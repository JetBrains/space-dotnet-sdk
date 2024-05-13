using JetBrains.Space.Common;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;

public class CSharpPartialExtensionsGenerator
{
    private readonly CodeGenerationContext _context;

    public CSharpPartialExtensionsGenerator(CodeGenerationContext context)
    {
        _context = context;
    }
        
    public string GeneratePartialClassFor(ApiDto apiDto)
    {
        var indent = new Indent();
        var builder = new CSharpBuilder();
            
        var typeNameForDto = apiDto.ToCSharpClassName();
        var typeNameForPartialDto = $"Partial<{typeNameForDto}>";
            
        builder.AppendLine($"{indent}public static class {typeNameForDto}PartialExtensions");
        builder.AppendLine($"{indent}{{");
        indent.Increment();
            
        foreach (var apiDtoField in apiDto.Fields)
        {
            builder.Append(indent.Wrap(GenerateExtensionMethodsFor(typeNameForDto, typeNameForPartialDto, apiDtoField.Field)));
        }

        indent.Decrement();
        builder.AppendLine($"{indent}}}");
        return builder.ToString();
    }

    private string GenerateExtensionMethodsFor(
        string currentDtoType, 
        string currentPartialType,
        ApiField apiField)
    {
        var indent = new Indent();
        var builder = new CSharpBuilder();
            
        var propertyName = apiField.ToCSharpPropertyName(currentDtoType);
        var apiFieldName = apiField.Name;
            
        // Field
        ApiDocumentationUtilities.RenderCSharpDocumentation(apiField.Description, apiField.Experimental, output =>
        {
            builder.Append(indent.Wrap(output));
        });
        if (apiField.Deprecation != null)
        {
            builder.AppendLine($"{indent}{apiField.Deprecation.ToCSharpDeprecation()}");
        }
        else if (apiField.Experimental != null && FeatureFlags.GenerateExperimentalAnnotations)
        {
            builder.AppendLine($"{indent}{apiField.Experimental.ToCSharpExperimental()}");
        }
        builder.AppendLine($"{indent}public static {currentPartialType} With{propertyName}(this {currentPartialType} it)");
        indent.Increment();
        builder.AppendLine($"{indent}=> it.AddFieldName(\"{apiFieldName}\");");
        indent.Decrement();
        builder.AppendLine($"{indent}");

        var currentFieldInnerType = GenerateCSharpTypeFrom(apiField.Type);
            
        var isPrimitiveOrObject = apiField.Type is ApiFieldType.Primitive or ApiFieldType.Object;
        var isArrayOfPrimitive = apiField.Type is ApiFieldType.Array { ElementType: ApiFieldType.Primitive };
        if (!isPrimitiveOrObject && !isArrayOfPrimitive && !string.IsNullOrEmpty(currentFieldInnerType))
        {
            // Recursive field?
            if (currentDtoType == currentFieldInnerType)
            {
                ApiDocumentationUtilities.RenderCSharpDocumentation(apiField.Description, apiField.Experimental, output =>
                {
                    builder.Append(indent.Wrap(output));
                });
                if (apiField.Deprecation != null)
                {
                    builder.AppendLine($"{indent}{apiField.Deprecation.ToCSharpDeprecation()}");
                }
                else if (apiField.Experimental != null && FeatureFlags.GenerateExperimentalAnnotations)
                {
                    builder.AppendLine($"{indent}{apiField.Experimental.ToCSharpExperimental()}");
                }
                builder.AppendLine($"{indent}public static {currentPartialType} With{propertyName}Recursive(this {currentPartialType} it)");
                indent.Increment();
                builder.AppendLine($"{indent}=> it.AddFieldName(\"{apiFieldName}!\");");
                indent.Decrement();
                builder.AppendLine($"{indent}");
            }

            // Field with partial builder
            ApiDocumentationUtilities.RenderCSharpDocumentation(apiField.Description, apiField.Experimental, output =>
            {
                builder.Append(indent.Wrap(output));
            });
            if (apiField.Deprecation != null)
            {
                builder.AppendLine($"{indent}{apiField.Deprecation.ToCSharpDeprecation()}");
            }
            else if (apiField.Experimental != null && FeatureFlags.GenerateExperimentalAnnotations)
            {
                builder.AppendLine($"{indent}{apiField.Experimental.ToCSharpExperimental()}");
            }
            builder.AppendLine($"{indent}public static {currentPartialType} With{propertyName}(this {currentPartialType} it, Func<Partial<{currentFieldInnerType}>, Partial<{currentFieldInnerType}>> partialBuilder)");
            indent.Increment();
            builder.AppendLine($"{indent}=> it.AddFieldName(\"{apiFieldName}\", partialBuilder(new Partial<{currentFieldInnerType}>(it)));");
            indent.Decrement();
            builder.AppendLine($"{indent}");
        }

        return builder.ToString();
    }

    private string GenerateCSharpTypeFrom(ApiFieldType apiFieldType)
    {
        switch (apiFieldType)
        {
            case ApiFieldType.Array apiFieldTypeArray:
                return GenerateCSharpTypeFrom(apiFieldTypeArray.ElementType);
                
            case ApiFieldType.Dto apiFieldTypeDto:
                if (apiFieldTypeDto.DtoRef?.Id != null && _context.TryGetDto(apiFieldTypeDto.DtoRef.Id, out var apiDto))
                {
                    return apiDto!.ToCSharpClassName();
                }
                break;
                
            case ApiFieldType.Enum apiFieldTypeEnum:
                if (apiFieldTypeEnum.EnumRef?.Id != null && _context.TryGetEnum(apiFieldTypeEnum.EnumRef.Id, out var apiEnum))
                {
                    return apiEnum!.ToCSharpClassName();
                }
                break;
                
            case ApiFieldType.Map apiFieldTypeMap:
                return GenerateCSharpTypeFrom(apiFieldTypeMap.ValueType);
                
            case ApiFieldType.UrlParam apiFieldTypeUrlParam:
                if (apiFieldTypeUrlParam.UrlParamRef?.Id != null && _context.TryGetUrlParameter(apiFieldTypeUrlParam.UrlParamRef.Id, out var apiUrlParam))
                {
                    return apiUrlParam!.ToCSharpClassName();
                }
                else
                {
                    throw new ResourceException("Could not generate type name for URL parameter with ref id: " + apiFieldTypeUrlParam.UrlParamRef?.Id);
                }
                
            case ApiFieldType.Object apiFieldTypeObject:
                if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.PAIR)
                {
                    // Known anonymous type
                    var sb = new CSharpBuilder();
                    sb.Append("Pair<");
                    sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[0].Type));
                    sb.Append(", ");
                    sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[1].Type));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.TRIPLE)
                {
                    // Known anonymous type
                    var sb = new CSharpBuilder();
                    sb.Append("Triple<");
                    sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[0].Type));
                    sb.Append(", ");
                    sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[1].Type));
                    sb.Append(", ");
                    sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[2].Type));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.BATCH)
                {
                    // Known anonymous type
                    var sb = new CSharpBuilder();
                    sb.Append("Batch<");
                    sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.GetBatchDataType()!));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.SYNC_BATCH)
                {
                    // Known anonymous type
                    var sb = new CSharpBuilder();
                    sb.Append("SyncBatch<");
                    sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.GetBatchDataType()!));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MOD)
                {
                    // Known anonymous type
                    var sb = new CSharpBuilder();
                    sb.Append("Modification<");
                    sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[0].Type));
                    if (apiFieldTypeObject.Nullable)
                    {
                        sb.Append("?");
                    }
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.REQUEST_BODY)
                {
                    // Request body/anonymous type?
                    throw new ResourceException($"The method {nameof(GenerateCSharpTypeFrom)}() should not be called with object kind: " + apiFieldTypeObject.Kind 
                        + $". Ensure {nameof(CodeGenerationContextEnricher)} has run, and then invoke apiEndpoint.{nameof(ApiEndpointExtensions.ToCSharpRequestBodyClassName)}() to retrieve the proper type name.");
                }
                else
                {
                    // Unknown object kind
                    throw new ResourceException("Could not generate type name for object kind: " + apiFieldTypeObject.Kind);
                }
                
            case ApiFieldType.Primitive apiFieldTypePrimitive:
                return apiFieldTypePrimitive.ToCSharpPrimitiveType().Value;
        
            case ApiFieldType.Ref apiFieldTypeReference:
                if (apiFieldTypeReference.DtoRef?.Id != null && _context.TryGetDto(apiFieldTypeReference.DtoRef.Id, out var apiReferenceDto))
                {
                    return apiReferenceDto!.ToCSharpClassName();
                }
                break;
        }
            
        throw new ResourceException("Could not generate type name for field type: " + apiFieldType.ClassName);
    }
}