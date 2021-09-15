using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators
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
            var builder = new StringBuilder();
            
            var typeNameForUrlParameterOption = apiUrlParameterOption.ToCSharpClassName();
            var factoryMethodNameForUrlParameterOption = apiUrlParameterOption.ToCSharpFactoryMethodName(apiUrlParameter);
            
            // Option method deprecation
            if (apiUrlParameterOption.Deprecation != null)
            {
                builder.AppendLine(apiUrlParameterOption.Deprecation.ToCSharpDeprecation());
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
                        var backingFieldName = field.ToCSharpBackingFieldName();
                        var urlParameterFieldName = field.Name;
                    
                        // Backing field
                        builder.AppendLine($"{indent}private readonly {valueTypeName} {backingFieldName};");
                        builder.AppendLine($"{indent}");
                        
                        // ToString() override preparation
                        toStringInterpolatedFields.Add($"{urlParameterFieldName}:{{{backingFieldName}}}");
                    }

                    var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                        .WithParametersForApiFields(orderedFields);
                    
                    // Constructor
                    builder.AppendLine($"{indent}public {typeNameForUrlParameterOption}({methodParametersBuilder.BuildMethodParametersList()})");
                    builder.AppendLine($"{indent}{{");
                    indent.Increment();

                    foreach (var field in orderedFields)
                    {
                        var backingFieldName = field.ToCSharpBackingFieldName();
                        var variableName = field.ToCSharpVariableName();
                    
                        builder.AppendLine($"{indent}{backingFieldName} = {variableName};");
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
                    builder.AppendLine($"\";");
                    
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
}