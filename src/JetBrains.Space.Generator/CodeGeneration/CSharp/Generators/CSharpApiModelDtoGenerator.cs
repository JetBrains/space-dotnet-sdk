using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.Space.Common.Types;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators
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
                    : apiDto.HierarchyRole == HierarchyRole.FINAL
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
                dtoHierarchy.Add(nameof(IClassNameConvertible));
            }
            
            dtoHierarchy.Add(nameof(IPropagatePropertyAccessPath));
            
            builder.AppendLine($"{indent}public {modifierForDto} {typeNameForDto}");
            indent.Increment();
            builder.AppendLine($"{indent} : " + string.Join(", ", dtoHierarchy));
            indent.Decrement();
            
            builder.AppendLine($"{indent}{{");
            indent.Increment();
            
            // When in a hierarchy with IClassNameConvertible, make sure we can capture the class name.
            if (dtoHierarchy.Contains(nameof(IClassNameConvertible)) && apiDto.HierarchyRole != HierarchyRole.INTERFACE)
            {
                var modifierForClassNameProperty = apiDto.Extends == null
                    ? apiDto.HierarchyRole != HierarchyRole.FINAL
                        ? "virtual" // Parent
                        : ""
                    : "override";   // Inheritor
                
                builder.AppendLine($"{indent}[JsonPropertyName(\"className\")]");
                builder.AppendLine($"{indent}public {modifierForClassNameProperty} string? ClassName => \"{apiDto.Name}\";");
                builder.AppendLine($"{indent}");
            }
            
            // Determine list of fields
            var apiDtoFields = DetermineFieldsToGenerateFor(apiDto);
            
            // Generate factories for inheritors
            // ReSharper disable once RedundantLogicalConditionalExpressionOperand
            if (FeatureFlags.GenerateInheritorFactoryMethods && FeatureFlags.GenerateDtoConstructor)
            {
                foreach (var apiDtoInheritorReference in apiDto.Inheritors)
                {
                    if (_codeGenerationContext.TryGetDto(apiDtoInheritorReference.Id, out var apiDtoInheritor)
                        && apiDtoInheritor!.HierarchyRole != HierarchyRole.INTERFACE && apiDtoInheritor.HierarchyRole != HierarchyRole.ABSTRACT)
                    {
                        var inheritorTypeName = apiDtoInheritor.ToCSharpClassName();
                        var inheritorFactoryMethodName = apiDtoInheritor.ToCSharpFactoryMethodName(apiDto);
                        
                        var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                            .WithParametersForApiDtoFields(DetermineFieldsToGenerateFor(apiDtoInheritor!));
                        
                        builder.AppendLine($"{indent}public static {inheritorTypeName} {inheritorFactoryMethodName}({methodParametersBuilder.BuildMethodParametersList()})");
                        indent.Increment();
                        builder.AppendLine($"{indent}=> new {inheritorTypeName}({methodParametersBuilder.WithDefaultValueForAllParameters(null).BuildMethodCallParameters()});");
                        indent.Decrement();
                        builder.AppendLine($"{indent}");
                    }
                }
            }
            
            // Generate constructor
            // ReSharper disable once RedundantLogicalConditionalExpressionOperand
            if (FeatureFlags.GenerateDtoConstructor && apiDto.HierarchyRole != HierarchyRole.INTERFACE && apiDto.HierarchyRole != HierarchyRole.ABSTRACT)
            {
                var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                    .WithParametersForApiDtoFields(apiDtoFields);
                        
                // Empty constructor
                builder.AppendLine($"{indent}public {typeNameForDto}() {{ }}");
                builder.AppendLine($"{indent}");
                
                // Parameterized constructor
                if (apiDtoFields.Count > 0)
                {
                    builder.AppendLine($"{indent}public {typeNameForDto}({methodParametersBuilder.BuildMethodParametersList()})");
                    builder.AppendLine($"{indent}{{");
                    indent.Increment();
                    foreach (var apiDtoField in apiDtoFields)
                    {
                        if (FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes && apiDtoField.Field.Type.IsCSharpReferenceType())
                        {
                            builder.AppendLine($"{indent}{apiDtoField.Field.ToCSharpPropertyName(typeNameForDto)} = {apiDtoField.Field.ToCSharpVariableInstanceOrDefaultValue(_codeGenerationContext)};");
                        }
                        else
                        {
                            builder.AppendLine($"{indent}{apiDtoField.Field.ToCSharpPropertyName(typeNameForDto)} = {apiDtoField.Field.ToCSharpVariableName()};");
                        }
                    }
                    indent.Decrement();
                    builder.AppendLine($"{indent}}}");
                    builder.AppendLine($"{indent}");
                }
            }
            
            // Generate properties for fields
            foreach (var apiDtoField in apiDtoFields)
            {
                builder.AppendLine(indent.Wrap(GenerateDtoFieldDefinition(typeNameForDto, apiDtoField.Field)));
            }
            
            // Implement IPropagatePropertyAccessPath?
            if (dtoHierarchy.Contains(nameof(IPropagatePropertyAccessPath)) && apiDto.HierarchyRole != HierarchyRole.INTERFACE)
            {
                builder.AppendLine(indent.Wrap(GenerateDtoPropagatePropertyAccessPath(apiDto, apiDtoFields)));
            }
        
            indent.Decrement();
            builder.AppendLine($"{indent}}}");
            return builder.ToString();
        }

        private List<ApiDtoField> DetermineFieldsToGenerateFor(ApiDto apiDto)
        {
            var dtoHierarchyFieldNames = new List<string>();
            if (apiDto.Extends != null && _codeGenerationContext.TryGetDto(apiDto.Extends.Id, out var apiDtoExtends))
            {
                dtoHierarchyFieldNames.AddRange(apiDtoExtends!.Fields.Select(it => it.Field.Name));
            }
                
            // For implements, add all referenced types' fields
            var apiDtoFields = new List<ApiDtoField>();
            if (apiDto.Implements != null)
            {
                foreach (var dtoReference in apiDto.Implements)
                {
                    if (_codeGenerationContext.TryGetDto(dtoReference.Id, out var apiDtoImplements))
                    {
                        apiDtoFields.AddRange(apiDtoImplements!.Fields);
                    }
                }
            }
        
            // Add own fields
            apiDtoFields.AddRange(apiDto.Fields);
            
            // Filter out properties that are already present in parent types
            apiDtoFields = apiDtoFields
                .Where(it => !dtoHierarchyFieldNames.Contains(it.Field.Name))
                .ToList();

            return apiDtoFields;
        }

        private string GenerateDtoFieldDefinition(string typeNameForDto, ApiField apiField)
        {
            var indent = new Indent();
            var builder = new StringBuilder();

            var propertyNameForField = apiField.ToCSharpPropertyName(typeNameForDto);
            var backingFieldNameForField = apiField.ToCSharpBackingFieldName();

            if (FeatureFlags.GenerateBackingFieldsForDtoProperties)
            {
                // Backing field
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

                // Property
                if (!apiField.Optional && !apiField.Type.Nullable)
                {
                    builder.AppendLine($"{indent}[Required]");
                }
                if (apiField.Deprecation != null)
                {
                    builder.AppendLine(apiField.Deprecation.ToCSharpDeprecation());
                }
                builder.AppendLine($"{indent}[JsonPropertyName(\"{apiField.Name}\")]");

                if (apiField.Type is ApiFieldType.Primitive apiFieldTypePrimitive)
                {
                    var csharpType = apiFieldTypePrimitive.ToCSharpPrimitiveType();
                    if (csharpType.JsonConverter != null)
                    {
                        builder.AppendLine($"{indent}[JsonConverter(typeof({csharpType.JsonConverter.Name}))]");
                    }
                }
                
                builder.Append($"{indent}public ");
                builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
                if (apiField.Type.Nullable)
                {
                    builder.Append("?");
                }
                builder.Append(" ");
                builder.AppendLine($"{indent}{propertyNameForField}");
                
                builder.AppendLine($"{indent}{{");
                indent.Increment();
                
                builder.AppendLine($"{indent}get => {backingFieldNameForField}.GetValue();");
                builder.AppendLine($"{indent}set => {backingFieldNameForField}.SetValue(value);");

                indent.Decrement();
                builder.AppendLine($"{indent}}}");
            }
            else 
            {
                // Property
                if (!apiField.Optional && !apiField.Type.Nullable)
                {
                    builder.AppendLine($"{indent}[Required]");
                }
                if (apiField.Deprecation != null)
                {
                    builder.AppendLine(apiField.Deprecation.ToCSharpDeprecation());
                }
                builder.AppendLine($"{indent}[JsonPropertyName(\"{apiField.Name}\")]");
                
                builder.Append($"{indent}public ");
                builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
                if (apiField.Type.Nullable)
                {
                    builder.Append("?");
                }
                builder.Append(" ");
                builder.AppendLine($"{indent}{propertyNameForField} {{ get; set; }}");
            }

            return builder.ToString();
        }

        private string GenerateDtoPropagatePropertyAccessPath(ApiDto apiDto, List<ApiDtoField> apiDtoFields)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
                
            var modifier = apiDto.Extends != null
                ? "override" 
                : apiDto.HierarchyRole != HierarchyRole.FINAL
                    ? "virtual"
                    : string.Empty;
                
            builder.AppendLine($"{indent}public {modifier} void {nameof(IPropagatePropertyAccessPath.SetAccessPath)}(string path, bool validateHasBeenSet)");
            builder.AppendLine($"{indent}{{");
            indent.Increment();

            if (FeatureFlags.GenerateBackingFieldsForDtoProperties) 
            {
                foreach (var apiDtoField in apiDtoFields)
                {
                    var backingFieldNameForField = apiDtoField.Field.ToCSharpBackingFieldName();

                    builder.AppendLine($"{indent}{backingFieldNameForField}.{nameof(IPropagatePropertyAccessPath.SetAccessPath)}(path, validateHasBeenSet);");
                }
            }

            indent.Decrement();
            builder.AppendLine($"{indent}}}");

            return builder.ToString();
        }
    }
}