using System.Collections.Generic;
using System.Linq;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp;

public class MethodParametersBuilder
{
    private class MethodParameter
    {
        public string Type { get; }
        public string Name { get; }
        public string? DefaultValue { get; }
        public string? Documentation { get; }

        public MethodParameter(string type, string name, string? defaultValue, string? documentation)
        {
            Type = type;
            Name = name;
            DefaultValue = defaultValue;
            Documentation = documentation;
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

            if (!field.Type.Nullable)
            {
                if (field.RequiresAddedNullability())
                {
                    parameterType += "?";
                }
                    
                if (field.DefaultValue is ApiDefaultValue.Collection or ApiDefaultValue.Map)
                {
                    parameterType += "?";
                }
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

            if (!parameter.Field.Type.Nullable)
            {
                if (parameter.Field.RequiresAddedNullability())
                {
                    parameterType += "?";
                }
                    
                if (parameter.Field.DefaultValue is ApiDefaultValue.Collection or ApiDefaultValue.Map)
                {
                    parameterType += "?";
                }
            }
                
            var parameterName = parameter.Field.ToCSharpVariableName();
            var parameterDefaultValue = parameter.Field.ToCSharpDefaultValueForParameterList(_context);
            var parameterDescription = parameter.Field.ToCSharpDocumentationParameter(parameterName);

            methodParametersBuilder = methodParametersBuilder
                .WithParameter(parameterType, parameterName, parameterDefaultValue, parameterDescription);
        }

        return methodParametersBuilder;
    }

    public MethodParametersBuilder WithParameter(string type, string name, string? defaultValue = null, string? description = null)
    {
        var futureParameters = new List<MethodParameter>(_parameters);
        futureParameters.Add(new MethodParameter(type, name, defaultValue, description));
        return new MethodParametersBuilder(_context, futureParameters);
    }

    public MethodParametersBuilder WithDefaultValueForAllParameters(string? defaultValue)
    {
        var futureParameters = new List<MethodParameter>();
        foreach (var futureParameter in _parameters)
        {
            futureParameters.Add(new MethodParameter(futureParameter.Type, futureParameter.Name, defaultValue, futureParameter.Documentation));
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
                futureParameters.Add(new MethodParameter(futureParameter.Type, futureParameter.Name, defaultValue, futureParameter.Documentation));
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

    public string BuildMethodParametersDocumentation() =>
        string.Join("", _parameters
            .OrderBy(RequiredParametersFirstOrder)
            .Select(it => it.Documentation)
            .Where(it => it != null));

    public string BuildMethodCallParameters(bool includePrefix = true) =>
        string.Join(", ", _parameters
            .OrderBy(RequiredParametersFirstOrder)
            .Select(it =>
            {
                var parameterDefinition = includePrefix 
                    ? it.Name + ": " 
                    : string.Empty;
                    
                if (!string.IsNullOrEmpty(it.DefaultValue))
                {
                    parameterDefinition += it.DefaultValue;
                }
                else
                {
                    parameterDefinition += it.Name;
                }
                return parameterDefinition;
            }));

    private static int RequiredParametersFirstOrder(MethodParameter it) => string.IsNullOrEmpty(it.DefaultValue) ? 0 : 1;
}