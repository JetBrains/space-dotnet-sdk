using System.Collections.Generic;
using System.Linq;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    public class MethodParametersBuilder
    {
        private class MethodParameter
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string? DefaultValue { get; set; }

            public MethodParameter(string type, string name, string? defaultValue)
            {
                Type = type;
                Name = name;
                DefaultValue = defaultValue;
            }
        }

        private readonly CodeGenerationContext _context;
        private readonly List<MethodParameter> _parameters;

        public MethodParametersBuilder(CodeGenerationContext context) 
            : this(context, new List<MethodParameter>())
        {
        }
        
        private MethodParametersBuilder(CodeGenerationContext context, List<MethodParameter> parameters)
        {
            _context = context;
            _parameters = parameters;
        }

        public MethodParametersBuilder WithParametersForDtoFields(List<ApiDtoField> apiDtoFields)
        {
            var methodParametersBuilder = new MethodParametersBuilder(_context);
            var orderedDtoFieldsAsParameters = apiDtoFields.OrderBy(it => !it.Field.Type.Nullable ? 0 : 1).ToList();
            foreach (var apiDtoParameter in orderedDtoFieldsAsParameters)
            {
                var parameterType = apiDtoParameter.Field.Type.ToCSharpType(_context);
                if (apiDtoParameter.Field.Type.Nullable)
                {
                    parameterType += "?";
                }
                
                var parameterName = apiDtoParameter.Field.ToCSharpVariableName();

                string? parameterDefaultValue = null;
                if (apiDtoParameter.Field.Type.Nullable)
                {
                    parameterDefaultValue = "null";
                }

                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(parameterType, parameterName, parameterDefaultValue);
            }

            return methodParametersBuilder;
        }

        public MethodParametersBuilder WithParametersForEndpoint(ApiEndpoint apiEndpoint)
        {
            var methodParametersBuilder = new MethodParametersBuilder(_context);
            var orderedEndpointParameters = apiEndpoint.Parameters.OrderBy(it => !it.Field.Type.Nullable ? 0 : 1).ToList();
            foreach (var apiEndpointParameter in orderedEndpointParameters)
            {
                var parameterType = apiEndpointParameter.Field.Type.ToCSharpType(_context);
                if (apiEndpointParameter.Field.Type.Nullable)
                {
                    parameterType += "?";
                }
                
                var parameterName = apiEndpointParameter.Field.ToCSharpVariableName();

                string? parameterDefaultValue = null;
                if (apiEndpointParameter.Field.Type.Nullable)
                {
                    parameterDefaultValue = "null";
                }

                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(parameterType, parameterName, parameterDefaultValue);
            }

            return methodParametersBuilder;
        }

        public MethodParametersBuilder WithParameter(string type, string name, string? defaultValue = null)
        {
            var futureParameters = new List<MethodParameter>(_parameters);
            futureParameters.Add(new MethodParameter(type, name, defaultValue));
            return new MethodParametersBuilder(_context, futureParameters);
        }
        
        public MethodParametersBuilder WithDefaultValueForAllParameters(string? defaultValue)
        {
            var futureParameters = new List<MethodParameter>();
            foreach (var futureParameter in _parameters)
            {
                futureParameters.Add(new MethodParameter(futureParameter.Type, futureParameter.Name, defaultValue));
            }
            return new MethodParametersBuilder(_context, futureParameters);
        }

        public MethodParametersBuilder WithDefaultValueForParameter(string name, string? defaultValue = null)
        {
            var futureParameters = new List<MethodParameter>();
            foreach (var futureParameter in _parameters)
            {
                if (futureParameter.Name == name)
                {
                    futureParameters.Add(new MethodParameter(futureParameter.Type, futureParameter.Name, defaultValue));
                }
                else
                {
                    futureParameters.Add(futureParameter);
                }
            }
            return new MethodParametersBuilder(_context, futureParameters);
        }

        public string BuildMethodParametersDefinition() =>
            string.Join(", ", _parameters
                .OrderBy(RequiredParametersFirstOrder)
                .Select(it =>
                {
                    var parameterDefinition = it.Type + " " + it.Name;
                    if (!string.IsNullOrEmpty(it.DefaultValue))
                    {
                        parameterDefinition += " = " + it.DefaultValue;
                    }
                    return parameterDefinition;
                }));

        public string BuildMethodCallParametersDefinition() =>
            string.Join(", ", _parameters
                .OrderBy(RequiredParametersFirstOrder)
                .Select(it =>
                {
                    var parameterDefinition = it.Name;
                    if (!string.IsNullOrEmpty(it.DefaultValue))
                    {
                        parameterDefinition += ": " + it.DefaultValue;
                    }
                    else
                    {
                        parameterDefinition += ": " + parameterDefinition;
                    }
                    return parameterDefinition;
                }));

        private int RequiredParametersFirstOrder(MethodParameter it) => string.IsNullOrEmpty(it.DefaultValue) ? 0 : 1;
    }
}