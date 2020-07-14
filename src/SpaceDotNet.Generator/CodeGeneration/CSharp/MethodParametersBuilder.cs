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

        public MethodParametersBuilder WithParametersForApiDtoFields(IEnumerable<ApiDtoField> apiDtoFields) 
            => WithParametersForApiFields(apiDtoFields.Select(it => it.Field));

        public MethodParametersBuilder WithParametersForApiFields(IEnumerable<ApiField> apiFields)
        {
            var methodParametersBuilder = this;
            var orderedFields = apiFields.OrderBy(it => !it.Type.Nullable ? 0 : 1).ToList();
            foreach (var field in orderedFields)
            {
                var parameterType = field.Type.ToCSharpType(_context);
                if (field.Type.Nullable)
                {
                    parameterType += "?";
                }
                
                var parameterName = field.ToCSharpVariableName();
                var parameterDefaultValue = field.ToCSharpDefaultValueForParameterList(_context);

                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(parameterType, parameterName, parameterDefaultValue);
            }

            return methodParametersBuilder;
        }

        public MethodParametersBuilder WithParametersForApiParameters(IEnumerable<ApiParameter> apiParameters)
        {
            var methodParametersBuilder = this;
            var orderedParameters = apiParameters.OrderBy(it => !it.Field.Type.Nullable ? 0 : 1).ToList();
            foreach (var parameter in orderedParameters)
            {
                var parameterType = parameter.Field.Type.ToCSharpType(_context);
                if (parameter.Field.Type.Nullable)
                {
                    parameterType += "?";
                }
                
                var parameterName = parameter.Field.ToCSharpVariableName();
                var parameterDefaultValue = parameter.Field.ToCSharpDefaultValueForParameterList(_context);
                
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

        public string BuildMethodParametersList() =>
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

        public string BuildMethodCallParameters() =>
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