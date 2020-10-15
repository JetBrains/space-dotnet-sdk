using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
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
                parameterValueBuilder.Append("{");

                if (FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                {
                    parameterValueBuilder.Append(apiEndpointParameter.Field.ToCSharpVariableInstanceOrDefaultValue(_context));
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

                    var formatString = "";
                    if (arrayType.ElementType is ApiFieldType.Primitive primitive)
                    {
                        var csharpType = primitive.ToCSharpPrimitiveType();
                        if (csharpType.FormatString != null)
                        {
                            formatString = $"\"{csharpType.FormatString}\"";
                        }
                    }
                    
                    parameterValueBuilder.Append(!arrayType.ElementType.Nullable
                        ? $".ToString({formatString})"
                        : $"?.ToString({formatString})");
        
                    parameterValueBuilder.Append(")");
                }
                else
                {
                    // Anything else can be "ToString()"
                    var formatString = "";
                    if (apiEndpointParameter.Field.Type is ApiFieldType.Primitive primitive)
                    {
                        var csharpType = primitive.ToCSharpPrimitiveType();
                        if (csharpType.FormatString != null)
                        {
                            formatString = $"\"{csharpType.FormatString}\"";
                        }
                    }
                    
                    parameterValueBuilder.Append(!apiEndpointParameter.Field.Type.Nullable
                        ? $".ToString({formatString})"
                        : $"?.ToString({formatString})");
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