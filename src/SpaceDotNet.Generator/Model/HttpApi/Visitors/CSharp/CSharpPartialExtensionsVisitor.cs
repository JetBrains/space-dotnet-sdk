using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.Json;
using SpaceDotNet.Common;
using SpaceDotNet.Generator.Utilities;

namespace SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp
{
    public class CSharpPartialExtensionsVisitor : ApiModelVisitor
    {
        protected readonly Indent Indent;
        protected readonly StringBuilder Builder;
        protected readonly HashSet<string> PropertiesToSkip;
        protected ImmutableSortedDictionary<string, ApiDto> IdToDtoMap { get; }
        protected SortedDictionary<string, ApiDto> IdToAnonymousClassMap { get; }

        public CSharpPartialExtensionsVisitor(
            StringBuilder builder, 
            Indent indent,
            HashSet<string> propertiesToSkip,
            ImmutableSortedDictionary<string, ApiDto> idToDtoMap,
            SortedDictionary<string, ApiDto> idToAnonymousClassMap)
        {
            IdToDtoMap = idToDtoMap;
            IdToAnonymousClassMap = idToAnonymousClassMap;
            Builder = builder;
            Indent = indent;
            PropertiesToSkip = propertiesToSkip;
        }

        private string _currentDtoType = string.Empty;
        private string _currentPartialType = string.Empty;
        private string _currentFieldName = string.Empty;
        private readonly StringBuilder _currentFieldInnerTypeBuilder = new StringBuilder();
        
        public override void Visit(ApiDto apiDto)
        {
            Builder.AppendLine($"{Indent}public static class " + apiDto.Name.ToSafeIdentifier() + "DtoPartialExtensions");
            Builder.AppendLine($"{Indent}{{");
            Indent.Increment();
            
            _currentDtoType = apiDto.Name.ToSafeIdentifier() + "Dto";
            _currentPartialType = $"Partial<{_currentDtoType}>";
            foreach (var apiDtoField in apiDto.Fields)
            {
                if (!PropertiesToSkip.Contains(apiDto.Name.ToSafeIdentifier() + "Dto." + apiDtoField.Field.Name.ToSafeIdentifier().ToUppercaseFirst()))
                {
                    Visit(apiDtoField);
                }
            }
            _currentPartialType = string.Empty;
            _currentDtoType = string.Empty;

            Indent.Decrement();
            Builder.AppendLine($"{Indent}}}");
            Builder.AppendLine($"{Indent}");
        }
        
        public override void Visit(ApiField apiField)
        {
            _currentFieldName = apiField.Name;
            
            // Field
            Builder.Append($"{Indent}public static {_currentPartialType} With");
            Builder.Append(_currentFieldName.ToSafeIdentifier().ToUppercaseFirst());
            Builder.AppendLine($"(this {_currentPartialType} it)");
            Indent.Increment();
            Builder.AppendLine($"{Indent}=> it.AddFieldName(\"{_currentFieldName}\");");
            Indent.Decrement();
            Builder.AppendLine($"{Indent}");
            
            _currentFieldInnerTypeBuilder.Clear();
            Visit(apiField.Type);
            var isPrimitiveOrObject = apiField.Type is ApiFieldType.Primitive || apiField.Type is ApiFieldType.Object;
            var isArrayOfPrimitive = apiField.Type is ApiFieldType.Array arrayField && arrayField.ElementType is ApiFieldType.Primitive;
            if (!isPrimitiveOrObject && !isArrayOfPrimitive && _currentFieldInnerTypeBuilder.Length > 0)
            {
                // Recursive field?
                if (_currentDtoType == _currentFieldInnerTypeBuilder.ToString())
                {
                    Builder.Append($"{Indent}public static {_currentPartialType} With");
                    Builder.Append(_currentFieldName.ToSafeIdentifier().ToUppercaseFirst());
                    Builder.AppendLine($"Recursive(this {_currentPartialType} it)");
                    Indent.Increment();
                    Builder.AppendLine($"{Indent}=> it.AddFieldName(\"{_currentFieldName}!\");");
                    Indent.Decrement();
                    Builder.AppendLine($"{Indent}");
                }

                // Field with partial builder
                Builder.Append($"{Indent}public static {_currentPartialType} With");
                Builder.Append(_currentFieldName.ToSafeIdentifier().ToUppercaseFirst());
                Builder.AppendLine($"(this {_currentPartialType} it, Func<Partial<{_currentFieldInnerTypeBuilder}>, Partial<{_currentFieldInnerTypeBuilder}>> partialBuilder)");
                Indent.Increment();
                Builder.AppendLine($"{Indent}=> it.AddFieldName(\"{_currentFieldName}\", partialBuilder(new Partial<{_currentFieldInnerTypeBuilder}>()));");
                Indent.Decrement();
                Builder.AppendLine($"{Indent}");
            }
            _currentFieldInnerTypeBuilder.Clear();
            _currentFieldName = string.Empty;
        }

        public override void Visit(ApiFieldType apiFieldType)
        {
            switch (apiFieldType)
            {
                case ApiFieldType.Array apiFieldTypeArray:
                    Visit(apiFieldTypeArray.ElementType);
                    break;
                
                case ApiFieldType.Dto apiFieldTypeDto:
                    if (apiFieldTypeDto.DtoRef?.Id != null && IdToDtoMap.TryGetValue(apiFieldTypeDto.DtoRef.Id, out var apiDto))
                    {
                        _currentFieldInnerTypeBuilder.Append(apiDto.Name.ToSafeIdentifier() + "Dto");
                    }
                    break;
                
                case ApiFieldType.Object apiFieldTypeObject:
                    if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.PAIR)
                    {
                        // Known anonymous type
                        _currentFieldInnerTypeBuilder.Append("Pair<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        _currentFieldInnerTypeBuilder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[1].Type);
                        _currentFieldInnerTypeBuilder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.TRIPLE)
                    {
                        // Known anonymous type
                        _currentFieldInnerTypeBuilder.Append("Triple<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        _currentFieldInnerTypeBuilder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[1].Type);
                        _currentFieldInnerTypeBuilder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[2].Type);
                        _currentFieldInnerTypeBuilder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MAP_ENTRY)
                    {
                        // Known anonymous type
                        _currentFieldInnerTypeBuilder.Append("MapEntry<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        _currentFieldInnerTypeBuilder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[1].Type);
                        _currentFieldInnerTypeBuilder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.BATCH)
                    {
                        // Known anonymous type
                        _currentFieldInnerTypeBuilder.Append("Batch<");
                        var dataFieldType = apiFieldTypeObject.Fields.First(it => string.Equals(it.Name, "data", StringComparison.OrdinalIgnoreCase));
                        var dataFieldArrayType = (ApiFieldType.Array)dataFieldType.Type;
                        Visit(dataFieldArrayType.ElementType);
                        _currentFieldInnerTypeBuilder.Append(">");
                    }  
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MOD)
                    {
                        // Known anonymous type
                        _currentFieldInnerTypeBuilder.Append("Modification<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        _currentFieldInnerTypeBuilder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.REQUEST_BODY)
                    {
                        // Request body/anonymous type - check whether we generated it before?
                        var anonymousClassFields = apiFieldTypeObject.Fields.Select(it => new ApiDtoField { Field = it }).ToList();
        
                        // TODO: make this check less expensive, serializing N times is probably not the best idea
                        var anonymousClassSignature = JsonSerializer.Serialize(anonymousClassFields);
                        var anonymousClass = IdToAnonymousClassMap.Values.FirstOrDefault(it => anonymousClassSignature == JsonSerializer.Serialize(it.Fields));
                        if (anonymousClass != null)
                        {
                            _currentFieldInnerTypeBuilder.Append(anonymousClass.Id + "Dto");
                        }
                    }
                    else
                    {
                        // Unknown object kind
                        throw new ResourceException("Could not generate class for object kind: " + apiFieldTypeObject.Kind);
                    }
        
                    break;
                
                case ApiFieldType.Primitive apiFieldTypePrimitive:
                    _currentFieldInnerTypeBuilder.Append(apiFieldTypePrimitive.Type.ToCSharpPrimitiveType());
                    break;
        
                case ApiFieldType.Ref apiFieldTypeReference:
                    if (apiFieldTypeReference.DtoRef?.Id != null && IdToDtoMap.TryGetValue(apiFieldTypeReference.DtoRef.Id, out var apiReferenceDto))
                    {
                        _currentFieldInnerTypeBuilder.Append(apiReferenceDto.Name.ToSafeIdentifier() + "Dto");
                    }
                    break;
            }
        }
    }
}