using System;
using System.Text;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Generators
{
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
            var builder = new StringBuilder();
            
            var typeNameForUrlParameter = apiUrlParameter.ToCSharpClassName();
            
            if (apiUrlParameter.Deprecation != null)
            {
                builder.AppendLine(apiUrlParameter.Deprecation.ToCSharpDeprecation());
            }

            // Parameter type
            builder.AppendLine($"{indent}public abstract class {typeNameForUrlParameter}");
            builder.AppendLine($"{indent}{{");
            indent.Increment();
            
            foreach (var apiUrlParameterOption in apiUrlParameter.Options)
            {
                builder.Append(
                    indent.Wrap(
                        GenerateUrlParameterOptionFactoryMethod(apiUrlParameterOption, typeNameForUrlParameter)));
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
            ApiUrlParameterOption apiUrlParameterOption, 
            string typeNameForUrlParameter)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            var typeNameForUrlParameterOption = apiUrlParameterOption.ToCSharpClassName();
            var shortTypeNameForUrlParameterOption = apiUrlParameterOption.ToCSharpClassNameShort();
            
            // Option method deprecation
            if (apiUrlParameterOption.Deprecation != null)
            {
                builder.AppendLine(apiUrlParameterOption.Deprecation.ToCSharpDeprecation());
            }
            
            // Option method
            switch (apiUrlParameterOption)
            {
                case ApiUrlParameterOption.Const constParameter:
                    builder.AppendLine($"{indent}public static {typeNameForUrlParameter} {shortTypeNameForUrlParameterOption}");
                    indent.Increment();
                    builder.AppendLine($"{indent}=> new {typeNameForUrlParameterOption}();");
                    indent.Decrement();
                    break;
                
                case ApiUrlParameterOption.Var varParameter:
                    var valueTypeName = varParameter.Parameter.Type.ToCSharpType(_codeGenerationContext);
                    var variableName = varParameter.Parameter.ToCSharpVariableName();
                    
                    builder.AppendLine($"{indent}public static {typeNameForUrlParameter} {shortTypeNameForUrlParameterOption}({valueTypeName} {variableName})");
                    indent.Increment();
                    builder.AppendLine($"{indent}=> new {typeNameForUrlParameterOption}({variableName});");
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
            var builder = new StringBuilder();
            
            var typeNameForUrlParameterOption = apiUrlParameterOption.ToCSharpClassName();
            
            // Option type deprecation
            if (apiUrlParameterOption.Deprecation != null)
            {
                builder.AppendLine(apiUrlParameterOption.Deprecation.ToCSharpDeprecation());
            }
            
            // Option type
            builder.AppendLine($"{indent}private class {typeNameForUrlParameterOption} : {typeNameForUrlParameter}");
            builder.AppendLine($"{indent}{{");
            indent.Increment();
            
            switch (apiUrlParameterOption)
            {
                case ApiUrlParameterOption.Const constParameter:
                    // ToString() override
                    builder.AppendLine($"{indent}public override string ToString()");
                    builder.AppendLine($"{indent}{{");
                    indent.Increment();
                    builder.AppendLine($"{indent}return \"{constParameter.Value.Replace("\"", "\\\"")}\";");
                    indent.Decrement();
                    builder.AppendLine($"{indent}}}");
                    break;
                
                case ApiUrlParameterOption.Var varParameter:
                    var valueTypeName = varParameter.Parameter.Type.ToCSharpType(_codeGenerationContext);
                    var backingFieldName = varParameter.Parameter.ToCSharpBackingFieldName();
                    var variableName = varParameter.Parameter.ToCSharpVariableName();
                    var urlParameterFieldName = varParameter.Parameter.Name;
                    
                    // Backing field
                    builder.AppendLine($"{indent}public readonly {valueTypeName} {backingFieldName};");
                    builder.AppendLine($"{indent}");
                    
                    // Constructor
                    builder.AppendLine($"{indent}public {typeNameForUrlParameterOption}({valueTypeName} {variableName})");
                    builder.AppendLine($"{indent}{{");
                    indent.Increment();
                    builder.AppendLine($"{indent}{backingFieldName} = {variableName};");
                    indent.Decrement();
                    builder.AppendLine($"{indent}}}");
                    builder.AppendLine($"{indent}");
                    
                    // ToString() override
                    builder.AppendLine($"{indent}public override string ToString()");
                    builder.AppendLine($"{indent}{{");
                    indent.Increment();
                    builder.AppendLine($"{indent}return $\"{urlParameterFieldName}:{{{backingFieldName}}}\";");
                    indent.Decrement();
                    builder.AppendLine($"{indent}}}");
                    
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
}