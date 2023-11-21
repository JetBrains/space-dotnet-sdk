using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;

public class CSharpApiModelUrlParameterGenerator
{
    private readonly CodeGenerationContext _codeGenerationContext;
        
    public CSharpApiModelUrlParameterGenerator(CodeGenerationContext codeGenerationContext)
    {
        _codeGenerationContext = codeGenerationContext;
    }
        
    public string GenerateUrlParameterDefinition(ApiUrlParameter apiUrlParameter)
    {
        var indent = new Indent();
        var builder = new CSharpBuilder();
            
        var typeNameForUrlParameter = apiUrlParameter.ToCSharpClassName();
            
        if (apiUrlParameter.Deprecation != null)
        {
            builder.AppendLine($"{indent}{apiUrlParameter.Deprecation.ToCSharpDeprecation()}");
        }
        else if (apiUrlParameter.Experimental != null && FeatureFlags.GenerateExperimentalAnnotations)
        {
            builder.AppendLine($"{indent}{apiUrlParameter.Experimental.ToCSharpExperimental()}");
        }

        // Parameter type
        builder.AppendLine($"{indent}[JsonConverter(typeof(UrlParameterConverter))]");
        builder.AppendLine($"{indent}public abstract class {typeNameForUrlParameter} : IUrlParameter");
        builder.AppendLine($"{indent}{{");
        indent.Increment();
            
        foreach (var apiUrlParameterOption in apiUrlParameter.Options)
        {
            builder.Append(
                indent.Wrap(
                    GenerateUrlParameterOptionFactoryMethod(apiUrlParameter, apiUrlParameterOption, typeNameForUrlParameter)));
        }
            
        foreach (var apiUrlParameterOption in apiUrlParameter.Options)
        {
            builder.Append(
                indent.Wrap(
                    GenerateUrlParameterOptionClass(apiUrlParameterOption, typeNameForUrlParameter)));
        }
            
        indent.Decrement();
        builder.AppendLine($"{indent}}}");
        return builder.ToString();
    }

    private string GenerateUrlParameterOptionFactoryMethod(
        ApiUrlParameter apiUrlParameter,
        ApiUrlParameterOption apiUrlParameterOption,
        string typeNameForUrlParameter)
    {
        var indent = new Indent();
        var builder = new CSharpBuilder();

        var typeNameForUrlParameterOption = apiUrlParameterOption.ToCSharpClassName();
        var factoryMethodNameForUrlParameterOption = apiUrlParameterOption.ToCSharpFactoryMethodName(typeNameForUrlParameterOption, apiUrlParameter);
        
        // Option method documentation
        ApiDocumentationUtilities.RenderCSharpDocumentation(apiUrlParameterOption.Description, apiUrlParameterOption.Experimental, output =>
        {
            builder.Append(indent.Wrap(output));
        });
        
        // Option method deprecation
        if (apiUrlParameterOption.Deprecation != null)
        {
            builder.AppendLine($"{indent}{apiUrlParameterOption.Deprecation.ToCSharpDeprecation()}");
        }
        else if (apiUrlParameterOption.FeatureFlag != null && _codeGenerationContext.TryGetFeatureFlag(apiUrlParameterOption.FeatureFlag, out var featureFlag))
        {
            builder.AppendLine($"{indent}{featureFlag.ToCSharpFeatureFlag()}");
        }
        else if (apiUrlParameterOption.Experimental != null && FeatureFlags.GenerateExperimentalAnnotations)
        {
            builder.AppendLine($"{indent}{apiUrlParameterOption.Experimental.ToCSharpExperimental()}");
        }
            
        // Option method
        switch (apiUrlParameterOption)
        {
            case ApiUrlParameterOption.Const:
                builder.AppendLine($"{indent}public static {typeNameForUrlParameter} {factoryMethodNameForUrlParameterOption}");
                indent.Increment();
                builder.AppendLine($"{indent}=> new {typeNameForUrlParameterOption}();");
                indent.Decrement();
                break;
                
            case ApiUrlParameterOption.Var varParameter:
                var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                    .WithParametersForApiFields(varParameter.Parameters);
                    
                builder.AppendLine($"{indent}public static {typeNameForUrlParameter} {factoryMethodNameForUrlParameterOption}({methodParametersBuilder.BuildMethodParametersList()})");
                indent.Increment();
                builder.AppendLine($"{indent}=> new {typeNameForUrlParameterOption}({methodParametersBuilder.BuildMethodCallParameters(includePrefix: false)});");
                indent.Decrement();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(apiUrlParameterOption));
        }
        builder.AppendLine($"{indent}");
            
        return builder.ToString();
    }

    private string GenerateUrlParameterOptionClass(
        ApiUrlParameterOption apiUrlParameterOption, 
        string typeNameForUrlParameter)
    {
        var indent = new Indent();
        var builder = new CSharpBuilder();
            
        var typeNameForUrlParameterOption = apiUrlParameterOption.ToCSharpClassName();
        
        // Option type documentation
        ApiDocumentationUtilities.RenderCSharpDocumentation(apiUrlParameterOption.Description, apiUrlParameterOption.Experimental, output =>
        {
            builder.Append(indent.Wrap(output));
        });
        
        // Option type deprecation
        if (apiUrlParameterOption.Deprecation != null)
        {
            builder.AppendLine($"{indent}{apiUrlParameterOption.Deprecation.ToCSharpDeprecation()}");
        }
        else if (apiUrlParameterOption.FeatureFlag != null && _codeGenerationContext.TryGetFeatureFlag(apiUrlParameterOption.FeatureFlag, out var featureFlag))
        {
            builder.AppendLine($"{indent}{featureFlag.ToCSharpFeatureFlag()}");
        }
        else if (apiUrlParameterOption.Experimental != null && FeatureFlags.GenerateExperimentalAnnotations)
        {
            builder.AppendLine($"{indent}{apiUrlParameterOption.Experimental.ToCSharpExperimental()}");
        }

        // Option type
        builder.AppendLine($"{indent}public class {typeNameForUrlParameterOption} : {typeNameForUrlParameter}");
        builder.AppendLine($"{indent}{{");
        indent.Increment();
            
        switch (apiUrlParameterOption)
        {
            case ApiUrlParameterOption.Const constParameter:
                // ToString() override
                builder.AppendLine($"{indent}public override string ToString()");
                indent.Increment();
                builder.AppendLine($"{indent}=> \"{constParameter.Value.Replace("\"", "\\\"")}\";");
                indent.Decrement();
                break;
                
            case ApiUrlParameterOption.Var varParameter:
                var orderedFields = varParameter.Parameters.OrderBy(it => !it.Type.Nullable ? 0 : 1).ToList();

                var isCompositeIdentifier = orderedFields.Count > 1;
                var toStringInterpolatedFields = new List<string>();
                    
                foreach (var field in orderedFields)
                {
                    var valueTypeName = field.Type.ToCSharpType(_codeGenerationContext);
                    var propertyName = field.ToCSharpPropertyName(typeNameForUrlParameterOption);
                    var urlParameterFieldName = field.Name;
                    
                    // Property
                    if (field is { Optional: false, Type.Nullable: false })
                    {
                        builder.AppendLine($"{indent}[Required]");
                    }
                    builder.AppendLine($"{indent}[JsonPropertyName(\"{field.Name}\")]");
                    builder.AppendLine($"#if NET6_0_OR_GREATER");
                    builder.AppendLine($"{indent}public {valueTypeName} {propertyName} {{ get; init; }}");
                    builder.AppendLine($"#else");
                    builder.AppendLine($"{indent}public {valueTypeName} {propertyName} {{ get; set; }}");
                    builder.AppendLine($"#endif");
                    builder.AppendLine($"{indent}");
                        
                    // ToString() override preparation
                    toStringInterpolatedFields.Add($"{urlParameterFieldName}:{{{propertyName}}}");
                }
                    
                // Parameterless constructor
                builder.AppendLine($"#if !NET6_0_OR_GREATER");
                builder.AppendLine($"#pragma warning disable CS8618"); // [CS8618] Non-nullable property must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
                builder.AppendLine($"{indent}public {typeNameForUrlParameterOption}() {{ }}");
                builder.AppendLine($"#pragma warning restore CS8618");
                builder.AppendLine($"#endif");
                builder.AppendLine($"{indent}");
                
                // Constructor
                var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                    .WithParametersForApiFields(orderedFields);
                
                builder.AppendLine($"{indent}public {typeNameForUrlParameterOption}({methodParametersBuilder.BuildMethodParametersList()})");
                builder.AppendLine($"{indent}{{");
                indent.Increment();

                foreach (var field in orderedFields)
                {
                    var propertyName = field.ToCSharpPropertyName(typeNameForUrlParameterOption);
                    var variableName = field.ToCSharpVariableName();
                    
                    builder.AppendLine($"{indent}{propertyName} = {variableName};");
                }
                    
                indent.Decrement();
                builder.AppendLine($"{indent}}}");
                builder.AppendLine($"{indent}");
                    
                // ToString() override, e.g.:
                //   => $"username:{_username}";
                // or
                //   => $"{{username:{_username},profile:{_profile}}}"; (composite)
                builder.AppendLine($"{indent}public override string ToString()");
                indent.Increment();
                    
                builder.Append($"{indent}=> $\"");
                if (isCompositeIdentifier)
                {
                    builder.Append("{{");
                }
                builder.Append($"{string.Join(",", toStringInterpolatedFields)}");
                if (isCompositeIdentifier)
                {
                    builder.Append("}}");
                }
                builder.AppendLine("\";");
                    
                indent.Decrement();
                    
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(apiUrlParameterOption));
        }
            
        indent.Decrement();
        builder.AppendLine($"{indent}}}");
        builder.AppendLine($"{indent}");
            
        return builder.ToString();
    }
}