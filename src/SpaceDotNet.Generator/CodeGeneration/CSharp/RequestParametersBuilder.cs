using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.CodeGeneration.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    public class RequestParametersBuilder
    {
        private class RequestParameter
        {
            public string Name { get; set; }
            public string Value { get; set; }

            public RequestParameter(string name, string value)
            {
                Name = name;
                Value = value;
            }
        }
        
        private readonly CodeGenerationContext _context;
        private readonly List<RequestParameter> _parameters;

        public RequestParametersBuilder(CodeGenerationContext context) 
            : this(context, new List<RequestParameter>())
        {
        }
        
        private RequestParametersBuilder(CodeGenerationContext context, List<RequestParameter> parameters)
        {
            _context = context;
            _parameters = parameters;
        }

        public RequestParametersBuilder WithParametersForEndpoint(ApiEndpoint apiEndpoint)
        {
            var requestParametersBuilder = new RequestParametersBuilder(_context);
            var orderedEndpointParameters = apiEndpoint.Parameters.Where(it => !it.Path).ToList();
            foreach (var apiEndpointParameter in orderedEndpointParameters)
            {
                var parameterName = apiEndpointParameter.Field.Name;
                
                var parameterValueBuilder = new StringBuilder();
                parameterValueBuilder .Append("{");
                
                if (apiEndpointParameter.Field.DefaultValue is ApiDefaultValue.Const.EnumEntry enumEntry && FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                {
                    var apiEnumRef = apiEndpointParameter.Field.Type as ApiFieldType.Enum;
                    if (apiEnumRef == null || !_context.TryGetEnum(apiEnumRef.EnumRef!.Id, out var apiEnum))
                    {
                        throw new NotSupportedException("For " + nameof(ApiDefaultValue.Const.EnumEntry) + ", the field type should be of type" + nameof(ApiFieldType.Enum) + ".");
                    }

                    var typeNameForEnum = apiEnum.ToCSharpClassName();
                    var identifierForValue = CSharpIdentifier.ForClassOrNamespace(enumEntry.EntryName);

                    parameterValueBuilder.Append("(");
                    parameterValueBuilder.Append(apiEndpointParameter.Field.ToCSharpVariableName());
                    parameterValueBuilder.Append($" ?? {typeNameForEnum}.{identifierForValue}");
                    parameterValueBuilder.Append(")");
                }
                else if (apiEndpointParameter.Field.DefaultValue is ApiDefaultValue.Collection collection && FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                {
                    var typeNameForArrayElement = apiEndpointParameter.Field.Type.GetArrayElementTypeOrType().ToCSharpType(_context);

                    parameterValueBuilder.Append("(");
                    parameterValueBuilder.Append(apiEndpointParameter.Field.ToCSharpVariableName());
                    parameterValueBuilder.Append($" ?? new List<{typeNameForArrayElement}>()");
 
                    if (collection.Elements.Count > 0)
                    {
                        throw new NotSupportedException("Default values with populated collections are not supported yet.");
                    }
                    
                    parameterValueBuilder.Append(")");
                }
                else if (apiEndpointParameter.Field.DefaultValue is ApiDefaultValue.Map map && FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                {
                    var typeNameForMapValue = apiEndpointParameter.Field.Type.GetMapValueTypeOrType().ToCSharpType(_context);

                    parameterValueBuilder.Append("(");
                    parameterValueBuilder.Append(apiEndpointParameter.Field.ToCSharpVariableName());
                    parameterValueBuilder.Append($" ?? new Dictionary<string, {typeNameForMapValue}>()");
 
                    if (map.Elements.Count > 0)
                    {
                        throw new NotSupportedException("Default values with populated maps are not supported yet.");
                    }
                    
                    parameterValueBuilder.Append(")");
                }
                else if (apiEndpointParameter.Field.DefaultValue is ApiDefaultValue.Reference reference && FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                {
                    throw new NotSupportedException(nameof(ApiDefaultValue.Reference) + " is not supported yet.");
                }
                else
                {
                    parameterValueBuilder.Append(apiEndpointParameter.Field.ToCSharpVariableName());
                }
                
                if (apiEndpointParameter.Field.Type is ApiFieldType.Array arrayType)
                {
                    // For lists, we will need to repeat the parameter for each element
                    parameterValueBuilder.Append(!apiEndpointParameter.Field.Type.Nullable
                        ? ".JoinToString("
                        : "?.JoinToString(");
        
                    parameterValueBuilder.Append("\"");
                    parameterValueBuilder.Append(apiEndpointParameter.Field.Name);
                    parameterValueBuilder.Append("\", it => it");
        
                    parameterValueBuilder.Append(!arrayType.ElementType.Nullable
                        ? ".ToString()"
                        : "?.ToString()");
        
                    if (arrayType.ElementType is ApiFieldType.Primitive primitive && primitive.Type.Equals("Boolean", StringComparison.OrdinalIgnoreCase))
                    {
                        // Boolean needs lowercase value
                        parameterValueBuilder.Append(!arrayType.ElementType.Nullable
                            ? ".ToLowerInvariant()"
                            : "?.ToLowerInvariant()");
                    }
        
                    parameterValueBuilder.Append(")");
                }
                else
                {
                    // Anything else can be "ToString()"
                    parameterValueBuilder.Append(!apiEndpointParameter.Field.Type.Nullable
                        ? ".ToString()"
                        : "?.ToString()");
        
                    if (apiEndpointParameter.Field.Type is ApiFieldType.Primitive primitive && primitive.Type.Equals("Boolean", StringComparison.OrdinalIgnoreCase))
                    {
                        // Boolean needs lowercase value
                        parameterValueBuilder.Append(!apiEndpointParameter.Field.Type.Nullable
                            ? ".ToLowerInvariant()"
                            : "?.ToLowerInvariant()");
                    }
                }
        
                if (apiEndpointParameter.Field.Type.Nullable)
                {
                    // Used to be able to filter out nullable query string parameters in Connection.CleanNullableNullQueryStringParameters
                    parameterValueBuilder.Append(" ?? \"null\"");
                }
        
                parameterValueBuilder.Append("}");

                requestParametersBuilder = requestParametersBuilder
                    .WithParameter(parameterName, parameterValueBuilder.ToString());
            }

            return requestParametersBuilder;
        }

        public RequestParametersBuilder WithParameter(string name, string value)
        {
            var futureParameters = new List<RequestParameter>(_parameters);
            futureParameters.Add(new RequestParameter(name, value));
            return new RequestParametersBuilder(_context, futureParameters);
        }

        public string BuildQueryString()
        {
            if (_parameters.Count > 0)
            {
                return "?" + string.Join("&", _parameters
                    .Select(it => it.Name + "=" + it.Value));
            }

            return string.Empty;
        }
    }
}