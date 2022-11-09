using System.Text;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;

public class CSharpApiModelJsonSerializationContextGenerator
{
    private readonly CodeGenerationContext _codeGenerationContext;

    public CSharpApiModelJsonSerializationContextGenerator(CodeGenerationContext codeGenerationContext)
    {
        _codeGenerationContext = codeGenerationContext;
    }

    public string GenerateJsonSerializationContextClass()
    {
        var indent = new Indent();
        var builder = new StringBuilder();

        foreach (var apiEnum in _codeGenerationContext.GetEnums())
        {
            builder.AppendLine($"{indent}[JsonSerializable(typeof({apiEnum.ToCSharpClassName()}))]");
        }

        foreach (var apiDto in _codeGenerationContext.GetDtos())
        {
            builder.AppendLine($"{indent}[JsonSerializable(typeof({apiDto.ToCSharpClassName()}))]");
        }

        foreach (var apiUrlParameter in _codeGenerationContext.GetUrlParameters())
        {
            builder.AppendLine($"{indent}[JsonSerializable(typeof({apiUrlParameter.ToCSharpClassName()}))]");
        }

        builder.AppendLine($"{indent}public partial class JsonContext : JsonSerializerContext");
        builder.AppendLine($"{indent}{{");
        builder.AppendLine($"{indent}}}");
        builder.AppendLine($"{indent}");
        return builder.ToString();
    }
}