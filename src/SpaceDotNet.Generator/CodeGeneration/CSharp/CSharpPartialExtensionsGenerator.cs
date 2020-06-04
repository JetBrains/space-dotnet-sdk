using System.Text;
using SpaceDotNet.Common;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.CodeGeneration.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

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
            
            var typeNameForDto = apiDto.ToCSharpClassName();
            var typeNameForPartialDto = $"Partial<{typeNameForDto}>";
            
            builder.AppendLine($"{indent}public static class {typeNameForDto}PartialExtensions");
            builder.AppendLine($"{indent}{{");
            indent.Increment();
            
            foreach (var apiDtoField in apiDto.Fields)
            {
                var propertyName = apiDtoField.Field.ToCSharpPropertyName();
                if (!_context.PropertiesToSkip.Contains($"{typeNameForDto}.{propertyName}"))
                {
                    builder.Append(indent.Wrap(GenerateExtensionMethodsFor(typeNameForDto, typeNameForPartialDto, apiDtoField.Field)));
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
            
            var propertyName = apiField.ToCSharpPropertyName();
            var apiFieldName = apiField.Name;
            
            // Field
            builder.Append($"{indent}public static {currentPartialType} With{propertyName}(this {currentPartialType} it)");
            indent.Increment();
            builder.AppendLine($"{indent}=> it.AddFieldName(\"{apiFieldName}\");");
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
                    builder.Append($"{indent}public static {currentPartialType} With{propertyName}Recursive(this {currentPartialType} it)");
                    indent.Increment();
                    builder.AppendLine($"{indent}=> it.AddFieldName(\"{apiFieldName}!\");");
                    indent.Decrement();
                    builder.AppendLine($"{indent}");
                }

                // Field with partial builder
                builder.Append($"{indent}public static {currentPartialType} With{propertyName}(this {currentPartialType} it, Func<Partial<{currentFieldInnerType}>, Partial<{currentFieldInnerType}>> partialBuilder)");
                indent.Increment();
                builder.AppendLine($"{indent}=> it.AddFieldName(\"{apiFieldName}\", partialBuilder(new Partial<{currentFieldInnerType}>()));");
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
                        return apiDto.ToCSharpClassName();
                    }
                    break;
                
                case ApiFieldType.Enum apiFieldTypeEnum:
                    if (apiFieldTypeEnum.EnumRef?.Id != null && _context.IdToEnumMap.TryGetValue(apiFieldTypeEnum.EnumRef.Id, out var apiEnum))
                    {
                        return apiEnum.ToCSharpClassName();
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
                
                case ApiFieldType.Primitive apiFieldTypePrimitive:
                    return apiFieldTypePrimitive.ToCSharpPrimitiveType()!;
        
                case ApiFieldType.Ref apiFieldTypeReference:
                    if (apiFieldTypeReference.DtoRef?.Id != null && _context.IdToDtoMap.TryGetValue(apiFieldTypeReference.DtoRef.Id, out var apiReferenceDto))
                    {
                        return apiReferenceDto.ToCSharpClassName();
                    }
                    break;
            }
            
            throw new ResourceException("Could not generate type name for field type: " + apiFieldType.ClassName);
        }
    }
}