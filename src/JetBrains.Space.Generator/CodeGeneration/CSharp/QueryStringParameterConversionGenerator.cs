using System.Text;
using JetBrains.Space.Common;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp;

public class QueryStringParameterConversionGenerator
{
    private class QueryStringParameterConversion
    {
        public string Name { get; }
        public string ConversionCode { get; }
        public string? PredicateCode { get; }

        public QueryStringParameterConversion(string name, string conversionCode, string? predicateCode = null)
        {
            Name = name;
            ConversionCode = conversionCode;
            PredicateCode = predicateCode;
        }
    }

    public string TargetNameValueCollectionName { get; }
    private readonly CodeGenerationContext _context;
    private readonly List<QueryStringParameterConversion> _conversions;

    public QueryStringParameterConversionGenerator(string targetNameValueCollectionName, CodeGenerationContext context) 
        : this(targetNameValueCollectionName, context, new List<QueryStringParameterConversion>())
    {
    }
        
    private QueryStringParameterConversionGenerator(string targetNameValueCollectionName, CodeGenerationContext context, List<QueryStringParameterConversion> conversions)
    {
        TargetNameValueCollectionName = targetNameValueCollectionName;
        _context = context;
        _conversions = conversions;
    }

    public QueryStringParameterConversionGenerator WithQueryStringParametersForEndpoint(ApiEndpoint apiEndpoint)
    {
        var requestParametersBuilder = new QueryStringParameterConversionGenerator(TargetNameValueCollectionName, _context);
        var orderedEndpointParameters = apiEndpoint.Parameters.Where(it => !it.Path).ToList();
        foreach (var apiEndpointParameter in orderedEndpointParameters)
        {
            var parameterName = apiEndpointParameter.Field.Name;
            var csharpVariableName = apiEndpointParameter.Field.ToCSharpVariableName();
                
            var parameterValueBuilder = new StringBuilder();
            var parameterConditionBuilder = new StringBuilder();
                
            // Build condition (is it nullable?)
            if (apiEndpointParameter.Field.Type.Nullable && apiEndpointParameter.Field.Type is not ApiFieldType.Enum) // enums can be param="null", don't generate a null check
            {
                parameterConditionBuilder.Append($"{csharpVariableName} != null");
            }
                
            if (apiEndpointParameter.Field.RequiresAddedNullability())
            {
                parameterConditionBuilder.Append($"{csharpVariableName} != null");
            }
                
            // Build value generator
            if (apiEndpointParameter.Field.Type.IsCSharpReferenceType())
            {
                parameterValueBuilder.Append(apiEndpointParameter.Field.ToCSharpVariableInstanceOrDefaultValue(_context));
            }
            else
            {
                parameterValueBuilder.Append(apiEndpointParameter.Field.ToCSharpVariableName());
            }
                
            if (apiEndpointParameter.Field.Type is ApiFieldType.Array arrayType)
            {
                // For arrays, append all element values
                parameterValueBuilder.Append(".Select(it => it" + GenerateParameterTypeConversion(arrayType.ElementType) + ")");
            }
            else
            {
                // For other types, append the value
                parameterValueBuilder.Append(GenerateParameterTypeConversion(apiEndpointParameter.Field.Type));
            }

            requestParametersBuilder = requestParametersBuilder
                .WithQueryStringParameter(parameterName, parameterValueBuilder.ToString(), parameterConditionBuilder.ToString());
        }

        return requestParametersBuilder;
    }

    public QueryStringParameterConversionGenerator WithQueryStringParameter(string name, string conversionCode, string? predicateCode = null)
    {
        var futureParameters = new List<QueryStringParameterConversion>(_conversions);
        futureParameters.Add(new QueryStringParameterConversion(name, conversionCode, predicateCode));
        return new QueryStringParameterConversionGenerator(TargetNameValueCollectionName, _context, futureParameters);
    }

    public void WriteTo(CSharpBuilder builder, Indent indent)
    {
        foreach (var parameter in _conversions)
        {
            builder.Append(indent);
            if (!string.IsNullOrEmpty(parameter.PredicateCode))
            {
                builder.Append($"if ({parameter.PredicateCode}) ");
            }
                
            builder.AppendLine($"{TargetNameValueCollectionName}.Append(\"{parameter.Name}\", {parameter.ConversionCode});");
        }
    }

    private static string GenerateParameterTypeConversion(ApiFieldType apiFieldType)
    {
        switch (apiFieldType)
        {
            case ApiFieldType.Primitive primitiveType:
            {
                var csharpType = primitiveType.ToCSharpPrimitiveType();
                
                // String
                if (csharpType == CSharpType.String)
                {
                    return string.Empty;
                }
                
                // Duration
                if (csharpType == CSharpType.SpaceDuration)
                {
                    return !apiFieldType.Nullable
                        ? ".ToIsoString()"
                        : "?.ToIsoString()";
                }
                
                // Other primitives
                var formatString = "";
                if (csharpType.FormatString != null)
                {
                    formatString = $"\"{csharpType.FormatString}\"";

                    if (csharpType == CSharpType.SpaceDate || csharpType == CSharpType.SpaceTime)
                    {
                        formatString += ", CultureInfo.InvariantCulture";
                    }
                }

                return !apiFieldType.Nullable
                    ? $".ToString({formatString})"
                    : $"?.ToString({formatString})";
            }
                
            case ApiFieldType.UrlParam:
                return !apiFieldType.Nullable
                    ? ".ToString()"
                    : "?.ToString()";
                
            case ApiFieldType.Enum:
                return ".ToEnumString()";
                
            case ApiFieldType.Ref:
                return !apiFieldType.Nullable
                    ? ".Id"
                    : "?.Id";
                
            default:
                throw new ResourceException("Could not generate query string parameter type conversion for field type: " + apiFieldType.ClassName);
        }
    }
}
