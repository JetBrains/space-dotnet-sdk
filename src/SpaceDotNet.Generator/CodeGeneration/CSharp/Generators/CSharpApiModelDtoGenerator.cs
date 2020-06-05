using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Generators
{
    public class CSharpApiModelDtoGenerator
    {
        private readonly CodeGenerationContext _codeGenerationContext;
        
        public CSharpApiModelDtoGenerator(CodeGenerationContext codeGenerationContext)
        {
            _codeGenerationContext = codeGenerationContext;
        }
        
        public string GenerateDtoDefinition(ApiDto apiDto)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            var typeNameForDto = apiDto.ToCSharpClassName();
            
            if (apiDto.Deprecation != null)
            {
                builder.AppendLine(apiDto.Deprecation.ToCSharpDeprecation());
            }
                
            if (apiDto.HierarchyRole != HierarchyRole.INTERFACE && apiDto.Extends == null && apiDto.Inheritors.Count > 0)
            {
                // When extending another DTO, make sure to apply a converter
                builder.AppendLine($"{indent}[JsonConverter(typeof(ClassNameDtoTypeConverter))]");
            }
        
            var modifierForDto = apiDto.HierarchyRole == HierarchyRole.INTERFACE
                ? "interface"
                : apiDto.HierarchyRole == HierarchyRole.ABSTRACT
                    ? "abstract class"
                    : apiDto.HierarchyRole == HierarchyRole.SEALED || apiDto.HierarchyRole == HierarchyRole.FINAL
                        ? "sealed class"
                        : "class";
        
            var dtoHierarchy = new List<string>();
            var dtoHierarchyFieldNames = new List<string>();
            if (apiDto.Extends != null && _codeGenerationContext.TryGetDto(apiDto.Extends.Id, out var apiDtoExtends))
            {
                dtoHierarchy.Add(apiDtoExtends!.ToCSharpClassName());
                dtoHierarchyFieldNames.AddRange(apiDtoExtends!.Fields.Select(it => it.Field.Name));
            }
            if (apiDto.Implements != null)
            {
                foreach (var dtoImplements in apiDto.Implements)
                {
                    if (_codeGenerationContext.TryGetDto(dtoImplements.Id, out var apiDtoImplements))
                    {
                        dtoHierarchy.Add(apiDtoImplements!.ToCSharpClassName());
                    }
                }
            }
            if (dtoHierarchy.Count > 0 || apiDto.Inheritors.Count > 0)
            {
                dtoHierarchy.Add("IClassNameConvertible");
            }
            
            builder.AppendLine($"{indent}public {modifierForDto} {typeNameForDto}");
            if (dtoHierarchy.Count > 0)
            {
                indent.Increment();
                builder.AppendLine($"{indent} : " + string.Join(", ", dtoHierarchy));
                indent.Decrement();
            }
            builder.AppendLine($"{indent}{{");
            indent.Increment();
            
            // When in a hierarchy, make sure we can capture the class name.
            if (dtoHierarchy.Count > 0 && apiDto.HierarchyRole != HierarchyRole.INTERFACE && apiDto.Extends == null)
            {
                builder.AppendLine($"{indent}[JsonPropertyName(\"className\")]");
                builder.AppendLine($"{indent}public string? ClassName {{ get; set; }}"); // TODO C# 9 make this init only
                builder.AppendLine($"{indent}");
            }
                
            // For implements, add all referenced types' fields
            if (apiDto.Implements != null)
            {
                foreach (var dtoReference in apiDto.Implements)
                {
                    if (_codeGenerationContext.TryGetDto(dtoReference.Id, out var apiDtoImplements))
                    {
                        foreach (var apiDtoField in apiDtoImplements!.Fields)
                        {
                            builder.AppendLine(indent.Wrap(GenerateDtoFieldDefinition(typeNameForDto, apiDtoField.Field)));
                        }
                    }
                }
            }
        
            // Add own fields
            foreach (var apiDtoField in apiDto.Fields)
            {
                var propertyName = apiDtoField.Field.ToCSharpPropertyName();
                if (!_codeGenerationContext.PropertiesToSkip.Contains($"{typeNameForDto}.{propertyName}")
                    && !dtoHierarchyFieldNames.Contains(apiDtoField.Field.Name))
                {
                    builder.AppendLine(indent.Wrap(GenerateDtoFieldDefinition(typeNameForDto, apiDtoField.Field)));
                }
            }
        
            indent.Decrement();
            builder.AppendLine($"{indent}}}");
            return builder.ToString();
        }

        private string GenerateDtoFieldDefinition(string typeNameForDto, ApiField apiField)
        {
            var indent = new Indent();
            var builder = new StringBuilder();

            var propertyNameForField = apiField.ToCSharpPropertyName();
            var backingFieldNameForField = apiField.ToCSharpBackingFieldName();

            // Backing field
            if (FeatureFlags.GenerateBackingFieldsForDtoProperties)
            {
                // Generate a backing field that throws an Exception when a field has not been
                // requested from the API.
                builder.Append($"{indent}private PropertyValue<");
                builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
                if (apiField.Type.Nullable)
                {
                    builder.Append("?");
                }

                builder.Append("> ");
                builder.Append($"{backingFieldNameForField} = new PropertyValue<");
                builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
                if (apiField.Type.Nullable)
                {
                    builder.Append("?");
                }

                builder.AppendLine($">(nameof({typeNameForDto}), nameof({propertyNameForField}));");
                builder.AppendLine($"{indent}");
            }

            // Property
            if (!apiField.Type.Optional && !apiField.Type.Nullable)
            {
                builder.AppendLine($"{indent}[Required]");
            }
            builder.AppendLine($"{indent}[JsonPropertyName(\"{apiField.Name}\")]");
            
            builder.Append($"{indent}public ");
            builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
            if (apiField.Type.Nullable)
            {
                builder.Append("?");
            }
            builder.Append(" ");

            if (FeatureFlags.GenerateBackingFieldsForDtoProperties)
            {
                builder.AppendLine($"{indent}{propertyNameForField}");
                builder.AppendLine($"{indent}{{");
                indent.Increment();
                
                builder.AppendLine($"{indent}get {{ return {backingFieldNameForField}.GetValue(); }}");
                builder.AppendLine($"{indent}set {{ {backingFieldNameForField}.SetValue(value); }}");

                indent.Decrement();
                builder.AppendLine($"{indent}}}");
            } 
            else {
                builder.Append($"{indent}{propertyNameForField} {{ get; set; }}");
            }

            return builder.ToString();
        }
    }
}