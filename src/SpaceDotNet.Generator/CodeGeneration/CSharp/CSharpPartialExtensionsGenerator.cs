using System.Linq;
using System.Text;
using System.Text.Json;
using SpaceDotNet.Common;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.CodeGeneration.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;
using SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp;
using SpaceDotNet.Generator.Utilities;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
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
            var builder = new StringBuilder();
            
            builder.AppendLine($"{indent}public static class " + apiDto.Name.ToSafeIdentifier() + "DtoPartialExtensions");
            builder.AppendLine($"{indent}{{");
            indent.Increment();
            
            var currentDtoType = apiDto.Name.ToSafeIdentifier() + "Dto";
            var currentPartialType = $"Partial<{currentDtoType}>";
            foreach (var apiDtoField in apiDto.Fields)
            {
                if (!_context.PropertiesToSkip.Contains(apiDto.Name.ToSafeIdentifier() + "Dto." + apiDtoField.Field.Name.ToSafeIdentifier().ToUppercaseFirst()))
                {
                    builder.Append(indent.Wrap(GenerateExtensionMethodsFor(currentDtoType, currentPartialType, apiDtoField.Field)));
                }
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
            var builder = new StringBuilder();
            
            var currentFieldName = apiField.Name;
            
            // Field
            builder.Append($"{indent}public static {currentPartialType} With");
            builder.Append(currentFieldName.ToSafeIdentifier().ToUppercaseFirst());
            builder.AppendLine($"(this {currentPartialType} it)");
            indent.Increment();
            builder.AppendLine($"{indent}=> it.AddFieldName(\"{currentFieldName}\");");
            indent.Decrement();
            builder.AppendLine($"{indent}");

            var currentFieldInnerType = GenerateCSharpTypeFrom(apiField.Type);
            
            var isPrimitiveOrObject = apiField.Type is ApiFieldType.Primitive || apiField.Type is ApiFieldType.Object;
            var isArrayOfPrimitive = apiField.Type is ApiFieldType.Array arrayField && arrayField.ElementType is ApiFieldType.Primitive;
            if (!isPrimitiveOrObject && !isArrayOfPrimitive && !string.IsNullOrEmpty(currentFieldInnerType))
            {
                // Recursive field?
                if (currentDtoType == currentFieldInnerType)
                {
                    builder.Append($"{indent}public static {currentPartialType} With");
                    builder.Append(currentFieldName.ToSafeIdentifier().ToUppercaseFirst());
                    builder.AppendLine($"Recursive(this {currentPartialType} it)");
                    indent.Increment();
                    builder.AppendLine($"{indent}=> it.AddFieldName(\"{currentFieldName}!\");");
                    indent.Decrement();
                    builder.AppendLine($"{indent}");
                }

                // Field with partial builder
                builder.Append($"{indent}public static {currentPartialType} With");
                builder.Append(currentFieldName.ToSafeIdentifier().ToUppercaseFirst());
                builder.AppendLine($"(this {currentPartialType} it, Func<Partial<{currentFieldInnerType}>, Partial<{currentFieldInnerType}>> partialBuilder)");
                indent.Increment();
                builder.AppendLine($"{indent}=> it.AddFieldName(\"{currentFieldName}\", partialBuilder(new Partial<{currentFieldInnerType}>()));");
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
                    if (apiFieldTypeDto.DtoRef?.Id != null && _context.IdToDtoMap.TryGetValue(apiFieldTypeDto.DtoRef.Id, out var apiDto))
                    {
                        return apiDto.Name.ToSafeIdentifier() + "Dto";
                    }
                    break;
                
                case ApiFieldType.Enum apiFieldTypeEnum:
                    if (apiFieldTypeEnum.EnumRef?.Id != null && _context.IdToEnumMap.TryGetValue(apiFieldTypeEnum.EnumRef.Id, out var apiEnum))
                    {
                        return apiEnum.Name.ToSafeIdentifier()!;
                    }
                    break;
                
                case ApiFieldType.Object apiFieldTypeObject:
                    if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.PAIR)
                    {
                        // Known anonymous type
                        var sb = new StringBuilder();
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
                        var sb = new StringBuilder();
                        sb.Append("Triple<");
                        sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[0].Type));
                        sb.Append(", ");
                        sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[1].Type));
                        sb.Append(", ");
                        sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[2].Type));
                        sb.Append(">");
                        return sb.ToString();
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MAP_ENTRY)
                    {
                        // Known anonymous type
                        var sb = new StringBuilder();
                        sb.Append("MapEntry<");
                        sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[0].Type));
                        sb.Append(", ");
                        sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[1].Type));
                        sb.Append(">");
                        return sb.ToString();
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.BATCH)
                    {
                        // Known anonymous type
                        var sb = new StringBuilder();
                        sb.Append("Batch<");
                        sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.GetBatchDataType()!));
                        sb.Append(">");
                        return sb.ToString();
                    }  
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MOD)
                    {
                        // Known anonymous type
                        var sb = new StringBuilder();
                        sb.Append("Modification<");
                        sb.Append(GenerateCSharpTypeFrom(apiFieldTypeObject.Fields[0].Type));
                        sb.Append(">");
                        return sb.ToString();
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.REQUEST_BODY)
                    {
                        // Request body/anonymous type? Should not be part of the Dto collection...
                        throw new ResourceException("Could not generate type name for object kind: " + apiFieldTypeObject.Kind + " - it is expected to have been mapped as a Dto instead.");
                    }
                    else
                    {
                        // Unknown object kind
                        throw new ResourceException("Could not generate type name for object kind: " + apiFieldTypeObject.Kind);
                    }
        
                    break;
                
                case ApiFieldType.Primitive apiFieldTypePrimitive:
                    return apiFieldTypePrimitive.ToCSharpPrimitiveType()!;
        
                case ApiFieldType.Ref apiFieldTypeReference:
                    if (apiFieldTypeReference.DtoRef?.Id != null && _context.IdToDtoMap.TryGetValue(apiFieldTypeReference.DtoRef.Id, out var apiReferenceDto))
                    {
                        return apiReferenceDto.Name.ToSafeIdentifier() + "Dto";
                    }
                    break;
            }
            
            throw new ResourceException("Could not generate type name for field type: " + apiFieldType.ClassName);
        }
    }
}