using System;
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
        
        private readonly List<MethodParameter> _parameters;

        public MethodParametersBuilder() 
            : this(new List<MethodParameter>())
        {
        }
        
        private MethodParametersBuilder(List<MethodParameter> parameters)
        {
            _parameters = parameters;
        }

        // TODO REFACTORING f() should disappear
        public MethodParametersBuilder WithParametersForEndpoint(ApiEndpoint apiEndpoint, Func<ApiFieldType, string> f)
        {
            var methodParametersBuilder = new MethodParametersBuilder();
            var orderedEndpointParameters = apiEndpoint.Parameters.OrderBy(it => !it.Field.Type.Nullable ? 0 : 1).ToList();
            foreach (var apiEndpointParameter in orderedEndpointParameters)
            {
                var parameterType = f(apiEndpointParameter.Field.Type);
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
            return new MethodParametersBuilder(futureParameters);
        }
        
        public MethodParametersBuilder WithDefaultValueForAllParameters(string? defaultValue)
        {
            var futureParameters = new List<MethodParameter>();
            foreach (var futureParameter in _parameters)
            {
                futureParameters.Add(new MethodParameter(futureParameter.Type, futureParameter.Name, defaultValue));
            }
            return new MethodParametersBuilder(futureParameters);
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
            return new MethodParametersBuilder(futureParameters);
        }

        public string BuildMethodParametersDefinition() =>
            string.Join(", ", _parameters
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
                .Select(it =>
                {
                    var parameterDefinition = it.Name;
                    if (!string.IsNullOrEmpty(it.DefaultValue))
                    {
                        parameterDefinition += ": " + it.DefaultValue;
                    }
                    return parameterDefinition;
                }));
    }
}