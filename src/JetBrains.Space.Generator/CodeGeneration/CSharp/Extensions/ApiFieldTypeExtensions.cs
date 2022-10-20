using JetBrains.Space.Common;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

public static class ApiFieldTypeExtensions
{
    public static CSharpType ToCSharpPrimitiveType(this ApiFieldType.Primitive subject) =>
        subject.Type switch
        {
            "Byte" => CSharpType.Byte,
            "Short" => CSharpType.Short,
            "Int" => CSharpType.Int,
            "Long" => CSharpType.Long,
            "Float" => CSharpType.Float,
            "Double" => CSharpType.Double,
            "Boolean" => CSharpType.Bool,
            "String" => subject.Tags.Contains(Constants.Tags.PermissionScopeTag)
                ? CSharpType.PermissionScope
                : CSharpType.String,
            "Date" => CSharpType.SpaceDate,
            "DateTime" => CSharpType.SpaceTime,
            "Duration" => CSharpType.SpaceDuration,
            _ => CSharpType.Object
        };

    public static bool IsCSharpReferenceType(this ApiFieldType apiFieldType) =>
        apiFieldType switch
        {
            ApiFieldType.Enum => false,
            ApiFieldType.Primitive primitiveType when primitiveType.ToCSharpPrimitiveType() != CSharpType.String =>
                false,
            _ => true
        };

    public static string ToCSharpType(this ApiFieldType apiFieldType, CodeGenerationContext context)
    {
        switch (apiFieldType)
        {
            case ApiFieldType.Array apiFieldTypeArray:
            {
                var sb = new CSharpBuilder();
                sb.Append("List<");
                sb.Append(ToCSharpType(apiFieldTypeArray.ElementType, context));
                sb.Append(">");
                return sb.ToString();
            }

            case ApiFieldType.Dto apiFieldTypeDto:
                if (apiFieldTypeDto.DtoRef?.Id != null && context.TryGetDto(apiFieldTypeDto.DtoRef.Id, out var apiDto))
                {
                    return apiDto!.ToCSharpClassName();
                }
                else
                {
                    return "object";
                }
                
            case ApiFieldType.Enum apiFieldTypeEnum:
                if (apiFieldTypeEnum.EnumRef?.Id != null && context.TryGetEnum(apiFieldTypeEnum.EnumRef.Id, out var apiEnum))
                {
                    return apiEnum!.ToCSharpClassName();
                }
                else
                {
                    return "string";
                }
                
            case ApiFieldType.UrlParam apiFieldTypeUrlParam:
                if (apiFieldTypeUrlParam.UrlParamRef?.Id != null && context.TryGetUrlParameter(apiFieldTypeUrlParam.UrlParamRef.Id, out var apiUrlParam))
                {
                    return apiUrlParam!.ToCSharpClassName();
                }
                else
                {
                    throw new ResourceException("Could not generate type name for URL parameter with ref id: " + apiFieldTypeUrlParam.UrlParamRef?.Id);
                }
                
            case ApiFieldType.Map apiFieldTypeMap:
            {
                var sb = new CSharpBuilder();
                sb.Append("Dictionary<string, ");
                sb.Append(ToCSharpType(apiFieldTypeMap.ValueType, context));
                sb.Append(">");
                return sb.ToString();
            }

            case ApiFieldType.Object apiFieldTypeObject:
                if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.PAIR)
                {
                    // Known anonymous type
                    var sb = new CSharpBuilder();
                    sb.Append("Pair<");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[0].Type, context));
                    sb.Append(", ");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[1].Type, context));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.TRIPLE)
                {
                    // Known anonymous type
                    var sb = new CSharpBuilder();
                    sb.Append("Triple<");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[0].Type, context));
                    sb.Append(", ");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[1].Type, context));
                    sb.Append(", ");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[2].Type, context));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.BATCH)
                {
                    // Known anonymous type
                    var sb = new CSharpBuilder();
                    sb.Append("Batch<");
                    sb.Append(ToCSharpType(apiFieldTypeObject.GetBatchDataType()!.ElementType, context));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.SYNC_BATCH)
                {
                    // Known anonymous type
                    var sb = new CSharpBuilder();
                    sb.Append("SyncBatch<");
                    sb.Append(ToCSharpType(apiFieldTypeObject.GetBatchDataType()!.ElementType, context));
                    sb.Append(">");
                    return sb.ToString();
                }  
                else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MOD)
                {
                    // Known anonymous type
                    var sb = new CSharpBuilder();
                    sb.Append("Modification<");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[0].Type, context));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.REQUEST_BODY)
                {
                    // Request body/anonymous type?
                    throw new ResourceException($"The method {nameof(ToCSharpType)}() should not be called with object kind: " + apiFieldTypeObject.Kind 
                        + $". Ensure {nameof(CodeGenerationContextEnricher)} has run, and then invoke apiEndpoint.{nameof(ApiEndpointExtensions.ToCSharpRequestBodyClassName)}() to retrieve the proper type name.");
                }
                else
                {
                    // Unknown object kind
                    throw new ResourceException("Could not generate type for object kind: " + apiFieldTypeObject.ClassName);
                }
                
            case ApiFieldType.Primitive apiFieldTypePrimitive:
                return apiFieldTypePrimitive.ToCSharpPrimitiveType().Value;
        
            case ApiFieldType.Ref apiFieldTypeReference:
                if (apiFieldTypeReference.DtoRef?.Id != null && context.TryGetDto(apiFieldTypeReference.DtoRef.Id, out var apiReferenceDto))
                {
                    return apiReferenceDto!.ToCSharpClassName();
                }
                else
                {
                    return "object";
                }

            default:
                return "object";
        }
    }
}
