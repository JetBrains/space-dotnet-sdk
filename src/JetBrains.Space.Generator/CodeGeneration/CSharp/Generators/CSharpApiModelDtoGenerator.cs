using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.Space.Common.Types;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;

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
            builder.AppendLine($"{indent}{apiDto.Deprecation.ToCSharpDeprecation()}");
        }
                
        if (apiDto.HierarchyRole2 != HierarchyRole2.INTERFACE && apiDto.HierarchyRole2 != HierarchyRole2.SEALED_INTERFACE && apiDto.Extends == null && apiDto.Inheritors.Count > 0)
        {
            // When extending another DTO, make sure to apply a converter
            builder.AppendLine($"{indent}[JsonConverter(typeof(ClassNameDtoTypeConverter))]");
        }

        var modifierForDto = apiDto.HierarchyRole2 switch
        {
            HierarchyRole2.INTERFACE => "interface",
            HierarchyRole2.SEALED_INTERFACE => "interface",
            HierarchyRole2.ABSTRACT_CLASS => "abstract class",
            HierarchyRole2.FINAL_CLASS => "sealed class",
            _ => "class"
        };
        
        var dtoHierarchy = new List<string>();
        if (apiDto.Extends != null && _codeGenerationContext.TryGetDto(apiDto.Extends.Id, out var apiDtoExtends))
        {
            dtoHierarchy.Add(apiDtoExtends!.ToCSharpClassName());
        }

        foreach (var dtoImplements in apiDto.Implements)
        {
            if (_codeGenerationContext.TryGetDto(dtoImplements.Id, out var apiDtoImplements))
            {
                dtoHierarchy.Add(apiDtoImplements!.ToCSharpClassName());
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
        if (dtoHierarchy.Contains(nameof(IClassNameConvertible)) && apiDto.HierarchyRole2 != HierarchyRole2.INTERFACE && apiDto.HierarchyRole2 != HierarchyRole2.SEALED_INTERFACE)
        {
            var modifierForClassNameProperty = apiDto.Extends == null
                ? apiDto.HierarchyRole2 != HierarchyRole2.FINAL_CLASS
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
        foreach (var apiDtoInheritorReference in apiDto.Inheritors)
        {
            if (_codeGenerationContext.TryGetDto(apiDtoInheritorReference.Id, out var apiDtoInheritor)
                && apiDtoInheritor!.HierarchyRole2 != HierarchyRole2.INTERFACE && apiDtoInheritor.HierarchyRole2 != HierarchyRole2.SEALED_INTERFACE && apiDtoInheritor.HierarchyRole2 != HierarchyRole2.ABSTRACT_CLASS)
            {
                var inheritorTypeName = apiDtoInheritor.ToCSharpClassName();
                var inheritorFactoryMethodName = apiDtoInheritor.ToCSharpFactoryMethodName(apiDto);
                    
                var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                    .WithParametersForApiDtoFields(DetermineFieldsToGenerateFor(apiDtoInheritor));
                    
                builder.AppendLine($"{indent}public static {inheritorTypeName} {inheritorFactoryMethodName}({methodParametersBuilder.BuildMethodParametersList()})");
                indent.Increment();
                builder.AppendLine($"{indent}=> new {inheritorTypeName}({methodParametersBuilder.WithDefaultValueForAllParameters(null).BuildMethodCallParameters()});");
                indent.Decrement();
                builder.AppendLine($"{indent}");
            }
        }
            
        // Generate constructor
        // ReSharper disable once RedundantLogicalConditionalExpressionOperand
        if (apiDto.HierarchyRole2 != HierarchyRole2.INTERFACE && apiDto.HierarchyRole2 != HierarchyRole2.SEALED_INTERFACE && apiDto.HierarchyRole2 != HierarchyRole2.ABSTRACT_CLASS)
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
                    if (apiDtoField.Field.Type.IsCSharpReferenceType())
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
            builder.AppendLine(indent.Wrap(GenerateDtoFieldDefinition(apiDto.Id, typeNameForDto, apiDtoField.Field)));
        }
            
        // Implement IPropagatePropertyAccessPath?
        if (dtoHierarchy.Contains(nameof(IPropagatePropertyAccessPath)) && apiDto.HierarchyRole2 != HierarchyRole2.INTERFACE && apiDto.HierarchyRole2 != HierarchyRole2.SEALED_INTERFACE)
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
        foreach (var dtoReference in apiDto.Implements)
        {
            if (_codeGenerationContext.TryGetDto(dtoReference.Id, out var apiDtoImplements))
            {
                apiDtoFields.AddRange(apiDtoImplements!.Fields);
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

    private string GenerateDtoFieldDefinition(string dtoId, string typeNameForDto, ApiField apiField)
    {
        var indent = new Indent();
        var builder = new StringBuilder();

        var propertyNameForField = apiField.ToCSharpPropertyName(typeNameForDto);
        var backingFieldNameForField = apiField.ToCSharpBackingFieldName();

        // Backing field
        builder.Append($"{indent}private PropertyValue<");
        builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
        if (apiField.Type.Nullable)
        {
            builder.Append('?');
        }
        
        if (!apiField.Type.Nullable && apiField.RequiresAddedNullability())
        {
            builder.Append('?');
        }

        builder.Append("> ");
        builder.Append($"{backingFieldNameForField} = new PropertyValue<");
        builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
        if (apiField.Type.Nullable)
        {
            builder.Append('?');
        }
        
        if (!apiField.Type.Nullable && apiField.RequiresAddedNullability())
        {
            builder.Append('?');
        }
            
        // For non-nullable List<> and Dictionary<>, make sure the field is initialized.
        // We do this by setting a temporary default value for this pass.
        var overrideDefaultValue = !apiField.Type.Nullable && apiField.DefaultValue == null;
        if (overrideDefaultValue)
        {
            // REVIEW: This is a mutation, might be good to consider making this immutable.
            apiField.DefaultValue = apiField.Type switch
            {
                ApiFieldType.Array => new ApiDefaultValue.Collection(),
                ApiFieldType.Map => new ApiDefaultValue.Map(),
                _ => apiField.DefaultValue
            };
        }

        var initialValueForAssignment = apiField.ToCSharpDefaultValueForAssignment(_codeGenerationContext);
        if (initialValueForAssignment != null)
        {
            builder.AppendLine($">(nameof({typeNameForDto}), nameof({propertyNameForField}), \"{apiField.Name}\", {initialValueForAssignment});");
        }
        else
        {
            builder.AppendLine($">(nameof({typeNameForDto}), nameof({propertyNameForField}), \"{apiField.Name}\");");
        }
        builder.AppendLine($"{indent}");

        // Restore null default value
        if (overrideDefaultValue)
        {
            apiField.DefaultValue = null;
        }

        // Property
        if (!apiField.Optional && !apiField.Type.Nullable)
        {
            builder.AppendLine($"{indent}[Required]");
        }
        if (apiField.Optional && (apiField.Type.Nullable || apiField.RequiresAddedNullability()) && _codeGenerationContext.IsRequestBodyDto(dtoId))
        {
            // REMARK: This only works well in .NET6+.
            // Since .NET3.1 will go out of support relatively soon (December 3, 2022 - https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core),
            // we decided to only add optional request body properties in supported .NET versions.
            builder.AppendLine($"#if NET6_0_OR_GREATER");
            builder.AppendLine($"{indent}[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]");
            builder.AppendLine($"#endif");
        }
        if (apiField.Deprecation != null)
        {
            builder.AppendLine($"{indent}{apiField.Deprecation.ToCSharpDeprecation()}");
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
            builder.Append('?');
        }
        
        if (!apiField.Type.Nullable && apiField.RequiresAddedNullability())
        {
            builder.Append('?');
        }
        
        builder.Append(" ");
        builder.AppendLine($"{indent}{propertyNameForField}");
            
        builder.AppendLine($"{indent}{{");
        indent.Increment();
            
        builder.AppendLine($"{indent}get => {backingFieldNameForField}.GetValue({nameof(IPropagatePropertyAccessPath.InlineErrors)});");
        builder.AppendLine($"{indent}set => {backingFieldNameForField}.SetValue(value);");

        indent.Decrement();
        builder.AppendLine($"{indent}}}");

        return builder.ToString();
    }

    private static string GenerateDtoPropagatePropertyAccessPath(ApiDto apiDto, List<ApiDtoField> apiDtoFields)
    {
        var indent = new Indent();
        var builder = new StringBuilder();
                
        var modifier = apiDto.Extends != null
            ? "override" 
            : apiDto.HierarchyRole2 != HierarchyRole2.FINAL_CLASS
                ? "virtual"
                : string.Empty;
                
        builder.AppendLine($"{indent}public {modifier} void {nameof(IPropagatePropertyAccessPath.SetAccessPath)}(string parentChainPath, bool validateHasBeenSet)");
        builder.AppendLine($"{indent}{{");
        indent.Increment();

        foreach (var apiDtoField in apiDtoFields)
        {
            var backingFieldNameForField = apiDtoField.Field.ToCSharpBackingFieldName();

            builder.AppendLine($"{indent}{backingFieldNameForField}.{nameof(IPropagatePropertyAccessPath.SetAccessPath)}(parentChainPath, validateHasBeenSet);");
        }

        indent.Decrement();
        builder.AppendLine($"{indent}}}");
        
        builder.AppendLine();
        
        builder.AppendLine($"{indent}/// <inheritdoc />");
        builder.AppendLine($"{indent}[JsonPropertyName(\"$errors\")]");
        builder.AppendLine($"{indent}public List<{nameof(ApiInlineError)}> {nameof(IPropagatePropertyAccessPath.InlineErrors)} {{ get; set; }} = new();");

        return builder.ToString();
    }
}