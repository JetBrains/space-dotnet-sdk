using System.Text;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Generators
{
    public class CSharpApiModelEnumGenerator
    {
        public string GenerateEnumDefinition(ApiEnum apiEnum)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            var typeNameForEnum = apiEnum.ToCSharpClassName();
            
            if (apiEnum.Deprecation != null)
            {
                builder.AppendLine(apiEnum.Deprecation.ToCSharpDeprecation());
            }
            
            builder.AppendLine($"{indent}[JsonConverter(typeof(EnumerationConverter))]");
            builder.AppendLine($"{indent}public sealed class {typeNameForEnum} : Enumeration");
            builder.AppendLine($"{indent}{{");
                
            indent.Increment();
            builder.AppendLine($"{indent}private {typeNameForEnum}(string value) : base(value) {{ }}");
            builder.AppendLine($"{indent}");
            
            foreach (var value in apiEnum.Values)
            {
                var identifierForValue = CSharpIdentifier.ForClassOrNamespace(value);
                builder.AppendLine($"{indent}public static readonly {typeNameForEnum} {identifierForValue} = new {typeNameForEnum}(\"{value}\");");
            }
            
            indent.Decrement();
                
            builder.AppendLine($"{indent}}}");
            return builder.ToString();
        }
    }
}