using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;

public class CSharpApiModelEnumGenerator
{
    public string GenerateEnumDefinition(ApiEnum apiEnum)
    {
        var indent = new Indent();
        var builder = new CSharpBuilder();
            
        var typeNameForEnum = apiEnum.ToCSharpClassName();
            
        if (apiEnum.Deprecation != null)
        {
            builder.AppendLine($"{indent}{apiEnum.Deprecation.ToCSharpDeprecation()}");
        }
        else if (apiEnum.Experimental != null && FeatureFlags.GenerateExperimentalAnnotations)
        {
            builder.AppendLine($"{indent}{apiEnum.Experimental.ToCSharpExperimental()}");
        }
            
        builder.AppendLine($"{indent}[JsonConverter(typeof(EnumStringConverter))]");
        builder.AppendLine($"{indent}public enum {typeNameForEnum}");
        builder.AppendLine($"{indent}{{");
                
        indent.Increment();
            
        foreach (var value in apiEnum.Values)
        {
            var identifierForValue = CSharpIdentifier.ForClassOrNamespace(value);
            builder.AppendLine($"{indent}[EnumMember(Value = \"{value}\")]");
            builder.AppendLine($"{indent}{identifierForValue},");
            builder.AppendLine($"{indent}");
        }
            
        indent.Decrement();
                
        builder.AppendLine($"{indent}}}");
        return builder.ToString();
    }
}