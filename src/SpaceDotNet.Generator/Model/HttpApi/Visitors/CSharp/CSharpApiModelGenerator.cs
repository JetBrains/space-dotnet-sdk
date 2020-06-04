using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.Json;
using SpaceDotNet.Common;
using SpaceDotNet.Generator.CodeGeneration;
using SpaceDotNet.Generator.CodeGeneration.CSharp;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.CodeGeneration.Extensions;
using SpaceDotNet.Generator.Utilities;

namespace SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp
{
    public class CSharpApiModelGenerator
    {
        private readonly ApiModel _apiModel;
        private readonly CodeGenerationContext _codeGenerationContext;
        
        public CSharpApiModelGenerator(ApiModel apiModel)
        {
            _apiModel = apiModel;
            _codeGenerationContext = CodeGenerationContext.CreateFrom(_apiModel);
        }
        
        public void GenerateFiles(IDocumentWriter documentWriter)
        {
            // Enums
            foreach (var apiEnum in _apiModel.Enums)
            {
                var document = new CSharpDocument();
                document.Write(
                    GenerateEnumDefinition(apiEnum));
                
                documentWriter.WriteDocument(
                    "Enums/" + apiEnum.Name.ToSafeIdentifier() + ".generated.cs",
                    document.Create());
            }
            
            // Dtos
            foreach (var apiDto in _apiModel.Dto)
            {
                var document = new CSharpDocument();
                document.Write(
                    GenerateDtoDefinition(apiDto));
                
                documentWriter.WriteDocument(
                    "Dtos/" + apiDto.Name.ToSafeIdentifier() + "Dto.generated.cs",
                    document.Create());
            }
            
            // API clients/endpoints
            foreach (var apiResource in _apiModel.Resources)
            {
                var document = new CSharpDocument();
                document.Write(
                    GenerateResourceDefinition(apiResource));
                
                documentWriter.WriteDocument(
                    apiResource.DisplaySingular.ToSafeIdentifier() + "Client.generated.cs",
                    document.Create());
            }
            
            // Response bodies generated from API clients/endpoints
            var currentIdToAnonymousClassMap = _codeGenerationContext.IdToAnonymousClassMap.ToImmutableSortedDictionary();
            var writtenIdToAnonymousClassMap = new SortedDictionary<string, ApiDto>();
            do
            {
                // Write output
                foreach (var (anonymousDtoKey, anonymousDto) in currentIdToAnonymousClassMap)
                {
                    var document = new CSharpDocument();
                    document.Write(
                        GenerateDtoDefinition(anonymousDto));
                
                    documentWriter.WriteDocument(
                        "Dtos/" + anonymousDto.Name.ToSafeIdentifier() + "Dto.generated.cs",
                        document.Create());
                }
                
                // See if new classes have been generated?
                var temp = _codeGenerationContext.IdToAnonymousClassMap
                    .Where(it => !writtenIdToAnonymousClassMap.ContainsKey(it.Key))
                    .ToImmutableSortedDictionary();
            
                currentIdToAnonymousClassMap = temp;
            
            } while (currentIdToAnonymousClassMap.Count > 0);
            
            // Partial extensions
            var partialExtensionsVisitor = new CSharpPartialExtensionsGenerator(_codeGenerationContext);
            foreach (var apiDto in _apiModel.Dto)
            {
                var document = new CSharpDocument();
                document.Write(
                    partialExtensionsVisitor.GeneratePartialClassFor(apiDto));
                
                documentWriter.WriteDocument(
                    "Partials/" + apiDto.Name.ToSafeIdentifier() + "Dto.generated.cs",
                    document.CreateWithNamespaceSuffix(apiDto.Name.ToSafeIdentifier() + "Extensions"));
            }
            foreach (var (_, anonymousDto) in _codeGenerationContext.IdToAnonymousClassMap)
            {
                var document = new CSharpDocument();
                document.Write(
                    partialExtensionsVisitor.GeneratePartialClassFor(anonymousDto));
                
                documentWriter.WriteDocument(
                    "Partials/" + anonymousDto.Name.ToSafeIdentifier() + "Dto.generated.cs",
                    document.CreateWithNamespaceSuffix(anonymousDto.Name.ToSafeIdentifier() + "Extensions"));
            }
        }

        public string GenerateEnumDefinition(ApiEnum apiEnum)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            if (apiEnum.Deprecation != null)
            {
                builder.AppendLine(apiEnum.Deprecation.ToCSharpDeprecation());
            }
            
            builder.AppendLine($"{indent}[JsonConverter(typeof(EnumerationConverter))]");
            builder.AppendLine($"{indent}public sealed class " + apiEnum.Name.ToSafeIdentifier() + " : Enumeration");
            builder.AppendLine($"{indent}{{");
                
            indent.Increment();
            builder.AppendLine($"{indent}private " + apiEnum.Name.ToSafeIdentifier() + "(string value) : base(value) { }");
            builder.AppendLine($"{indent}");
            
            foreach (var value in apiEnum.Values)
            {
                builder.AppendLine($"{indent}public static readonly " + apiEnum.Name.ToSafeIdentifier() + " " + value.ToSafeIdentifier() + " = new " + apiEnum.Name.ToSafeIdentifier() + "(\"" + value + "\");");
            }
            
            indent.Decrement();
                
            builder.AppendLine($"{indent}}}");
            return builder.ToString();
        }

        public string GenerateDtoDefinition(ApiDto apiDto)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            if (apiDto.Deprecation != null)
            {
                builder.AppendLine(apiDto.Deprecation.ToCSharpDeprecation());
            }
                
            if (apiDto.HierarchyRole != HierarchyRole.INTERFACE && apiDto.Extends == null && apiDto.Inheritors.Count > 0)
            {
                // When extending another DTO, make sure to apply a converter
                builder.AppendLine($"{indent}[JsonConverter(typeof(ClassNameDtoTypeConverter))]");
            }
        
            var dtoHierarchyType = apiDto.HierarchyRole == HierarchyRole.INTERFACE
                ? "interface"
                : apiDto.HierarchyRole == HierarchyRole.ABSTRACT
                    ? "abstract class"
                    : apiDto.HierarchyRole == HierarchyRole.SEALED
                        ? "sealed class"
                        : "class";
        
            var dtoHierarchy = new List<string>();
            if (apiDto.Extends != null && _codeGenerationContext.IdToDtoMap.TryGetValue(apiDto.Extends.Id, out var apiDtoExtends))
            {
                dtoHierarchy.Add(apiDtoExtends.Name.ToSafeIdentifier() + "Dto");
            }
            if (apiDto.Implements != null)
            {
                foreach (var dtoImplements in apiDto.Implements)
                {
                    if (_codeGenerationContext.IdToDtoMap.TryGetValue(dtoImplements.Id, out var apiDtoImplements))
                    {
                        dtoHierarchy.Add(apiDtoImplements.Name.ToSafeIdentifier() + "Dto");
                    }
                }
            }
            if (dtoHierarchy.Count > 0 || apiDto.Inheritors.Count > 0)
            {
                dtoHierarchy.Add("IClassNameConvertible");
            }
            
            builder.AppendLine($"{indent}public {dtoHierarchyType} " + apiDto.Name.ToSafeIdentifier() + "Dto");
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
                    if (_codeGenerationContext.IdToDtoMap.TryGetValue(dtoReference.Id, out var apiDtoImplements)
                        /* TODO only generate for interfaces && apiDtoImplements.HierarchyRole == HierarchyRole.INTERFACE*/)
                    {
                        foreach (var apiDtoField in apiDtoImplements.Fields)
                        {
                            builder.AppendLine(indent.Wrap(GenerateDtoFieldDefinition(apiDtoField.Field)));
                        }
                    }
                }
            }
        
            // Add own fields
            foreach (var apiDtoField in apiDto.Fields)
            {
                if (!_codeGenerationContext.PropertiesToSkip.Contains(apiDto.Name.ToSafeIdentifier() + "Dto." + apiDtoField.Field.Name.ToSafeIdentifier().ToUppercaseFirst()))
                {
                    builder.AppendLine(indent.Wrap(GenerateDtoFieldDefinition(apiDtoField.Field)));
                }
            }
        
            indent.Decrement();
            builder.AppendLine($"{indent}}}");
            return builder.ToString();
        }

        public string GenerateDtoFieldDefinition(ApiField apiField)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            if (!apiField.Type.Optional && !apiField.Type.Nullable)
            {
                builder.AppendLine($"{indent}[Required]");
            }
            builder.AppendLine($"{indent}[JsonPropertyName(\"{apiField.Name}\")]");
            
            builder.Append($"{indent}public ");
            builder.Append(GenerateDtoFieldDefinitionType(apiField.Type));
            if (apiField.Type.Nullable)
            {
                builder.Append("?");
            }
            builder.Append(" ");
            builder.Append(apiField.Name.ToSafeIdentifier().ToUppercaseFirst());
            builder.AppendLine(" { get; set; }");
            return builder.ToString();
        }
        
        public string GenerateDtoFieldDefinitionType(ApiFieldType apiFieldType, string? _clientMethodName = null)
        {
            switch (apiFieldType)
            {
                case ApiFieldType.Array apiFieldTypeArray:
                {
                    var sb = new StringBuilder();
                    sb.Append("List<");
                    sb.Append(GenerateDtoFieldDefinitionType(apiFieldTypeArray.ElementType));
                    sb.Append(">");
                    return sb.ToString();
                }

                case ApiFieldType.Dto apiFieldTypeDto:
                    if (apiFieldTypeDto.DtoRef?.Id != null && _codeGenerationContext.IdToDtoMap.TryGetValue(apiFieldTypeDto.DtoRef.Id, out var apiDto))
                    {
                        return apiDto.Name.ToSafeIdentifier() + "Dto";
                    }
                    else
                    {
                        return "object";
                    }
                
                case ApiFieldType.Enum apiFieldTypeEnum:
                    if (apiFieldTypeEnum.EnumRef?.Id != null && _codeGenerationContext.IdToEnumMap.TryGetValue(apiFieldTypeEnum.EnumRef.Id, out var apiEnum))
                    {
                        return apiEnum.Name.ToSafeIdentifier()!;
                    }
                    else
                    {
                        return "string";
                    }
                
                case ApiFieldType.Object apiFieldTypeObject:
                    if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.PAIR)
                    {
                        // Known anonymous type
                        var sb = new StringBuilder();
                        sb.Append("Pair<");
                        sb.Append(GenerateDtoFieldDefinitionType(apiFieldTypeObject.Fields[0].Type));
                        sb.Append(", ");
                        sb.Append(GenerateDtoFieldDefinitionType(apiFieldTypeObject.Fields[1].Type));
                        sb.Append(">");
                        return sb.ToString();
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.TRIPLE)
                    {
                        // Known anonymous type
                        var sb = new StringBuilder();
                        sb.Append("Triple<");
                        sb.Append(GenerateDtoFieldDefinitionType(apiFieldTypeObject.Fields[0].Type));
                        sb.Append(", ");
                        sb.Append(GenerateDtoFieldDefinitionType(apiFieldTypeObject.Fields[1].Type));
                        sb.Append(", ");
                        sb.Append(GenerateDtoFieldDefinitionType(apiFieldTypeObject.Fields[2].Type));
                        sb.Append(">");
                        return sb.ToString();
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MAP_ENTRY)
                    {
                        // Known anonymous type
                        var sb = new StringBuilder();
                        sb.Append("MapEntry<");
                        sb.Append(GenerateDtoFieldDefinitionType(apiFieldTypeObject.Fields[0].Type));
                        sb.Append(", ");
                        sb.Append(GenerateDtoFieldDefinitionType(apiFieldTypeObject.Fields[1].Type));
                        sb.Append(">");
                        return sb.ToString();
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.BATCH)
                    {
                        // Known anonymous type
                        var sb = new StringBuilder();
                        sb.Append("Batch<");
                        sb.Append(GenerateDtoFieldDefinitionType(apiFieldTypeObject.GetBatchDataType()!.ElementType));
                        sb.Append(">");
                        return sb.ToString();
                    }  
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MOD)
                    {
                        // Known anonymous type
                        var sb = new StringBuilder();
                        sb.Append("Modification<");
                        sb.Append(GenerateDtoFieldDefinitionType(apiFieldTypeObject.Fields[0].Type));
                        sb.Append(">");
                        return sb.ToString();
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.REQUEST_BODY)
                    {
                        // Request body/anonymous type - check whether we generated it before?
                        var anonymousClassFields = apiFieldTypeObject.Fields.Select(it => new ApiDtoField { Field = it }).ToList();
        
                        // TODO: make this check less expensive, serializing N times is probably not the best idea
                        var anonymousClassSignature = JsonSerializer.Serialize(anonymousClassFields);
                        var anonymousClass = _codeGenerationContext.IdToAnonymousClassMap.Values.FirstOrDefault(it => anonymousClassSignature == JsonSerializer.Serialize(it.Fields));
                        if (anonymousClass == null)
                        {
                            var anonymousClassId = !string.IsNullOrEmpty(_clientMethodName)
                                ? _clientMethodName + "Request" // TODO REFACTORING
                                : "Object" + _codeGenerationContext.IdToAnonymousClassMap.Count;
                            anonymousClass = new ApiDto
                            {
                                Id = anonymousClassId,
                                Name = anonymousClassId,
                                Fields = anonymousClassFields
                            };
        
                            _codeGenerationContext.IdToAnonymousClassMap[anonymousClassId] = anonymousClass;
                        }
        
                        return anonymousClass.Id + "Dto";
                    }
                    else
                    {
                        // Unknown object kind
                        throw new ResourceException("Could not generate class for object kind: " + apiFieldTypeObject.Kind);
                    }
                
                case ApiFieldType.Primitive apiFieldTypePrimitive:
                    return apiFieldTypePrimitive.ToCSharpPrimitiveType()!;
        
                case ApiFieldType.Ref apiFieldTypeReference:
                    if (apiFieldTypeReference.DtoRef?.Id != null && _codeGenerationContext.IdToDtoMap.TryGetValue(apiFieldTypeReference.DtoRef.Id, out var apiReferenceDto))
                    {
                        return apiReferenceDto.Name.ToSafeIdentifier() + "Dto";
                    }
                    else
                    {
                        return "object";
                    }

                default:
                    return "object";
            }
        }

        // private string _baseEndpointPath = string.Empty;
        // private string _resourceBreadcrumbPath = string.Empty;
        // private HashSet<string> _resourceBreadcrumbPaths = new HashSet<string>();
        //
        // public void GenerateResourceDefinition(ApiResource apiResource)
        // {
        //     var originalBaseEndpointPath = _baseEndpointPath;
        //     _baseEndpointPath = (_baseEndpointPath.Length > 0 ? _baseEndpointPath + "/" : _baseEndpointPath) +  apiResource.Path.Segments.ToPath();
        //
        //     var originalResourceBreadcrumbPath = _resourceBreadcrumbPath;
        //     _resourceBreadcrumbPath = (_resourceBreadcrumbPath.Length > 0 ? _resourceBreadcrumbPath + "." : _resourceBreadcrumbPath) +  apiResource.DisplaySingular.ToSafeIdentifier();
        //
        //     GenerateResourceDefinition(apiResource, true);
        //
        //     _resourceBreadcrumbPath = originalResourceBreadcrumbPath;
        //     _baseEndpointPath = originalBaseEndpointPath;
        // }
        //
        // public void GenerateResourceDefinition(ApiResource apiResource, bool withConstructor)
        // {
        //     // Client class
        //     Builder.AppendLine($"{Indent}public partial class " + apiResource.DisplaySingular.ToSafeIdentifier() + "Client");
        //     Builder.AppendLine($"{Indent}{{");
        //     Indent.Increment();
        //
        //     // Constructor needed?
        //     if (withConstructor)
        //     {
        //         Builder.AppendLine($"{Indent}private readonly Connection _connection;");
        //         Builder.AppendLine($"{Indent}");
        //         Builder.AppendLine($"{Indent}public " + apiResource.DisplaySingular.ToSafeIdentifier() + "Client(Connection connection)");
        //         Builder.AppendLine($"{Indent}{{");
        //         Indent.Increment();
        //
        //         Builder.AppendLine($"{Indent}_connection = connection;");
        //     
        //         Indent.Decrement();
        //         Builder.AppendLine($"{Indent}}}");
        //         Builder.AppendLine($"{Indent}");
        //     }
        //
        //     // Endpoint methods
        //     foreach (var apiEndpoint in apiResource.Endpoints)
        //     {
        //         Visit(apiResource, apiEndpoint);
        //     }
        //
        //     // Group nested resources by path
        //     var resourcePathBuildingVisitor = new PathToResourceMapper();
        //     foreach (var (_, apiNestedResources) in resourcePathBuildingVisitor.CreateMapOfPathToResources(apiResource))
        //     {
        //         var isFirstResource = true;
        //         foreach (var apiNestedResource in apiNestedResources)
        //         {
        //             var originalBaseEndpointPath = _baseEndpointPath;
        //             _baseEndpointPath = (_baseEndpointPath.Length > 0 ? _baseEndpointPath + "/" : _baseEndpointPath) +  apiNestedResource.Path.Segments.ToPath();
        //
        //             var originalResourceBreadcrumbPath = _resourceBreadcrumbPath;
        //             _resourceBreadcrumbPath = (_resourceBreadcrumbPath.Length > 0 ? _resourceBreadcrumbPath + "." : _resourceBreadcrumbPath) +  apiNestedResource.DisplaySingular.ToSafeIdentifier();
        //
        //             var isFirstWrite = _resourceBreadcrumbPaths.Add(_resourceBreadcrumbPath);
        //             if (isFirstResource && isFirstWrite)
        //             {
        //                 Builder.AppendLine($"{Indent}public " + apiNestedResource.DisplaySingular.ToSafeIdentifier() + "Client " + apiNestedResource.DisplayPlural.ToSafeIdentifier() + " => new " + apiNestedResource.DisplaySingular.ToSafeIdentifier() + "Client(_connection);");
        //                 Builder.AppendLine($"{Indent}");
        //             }
        //             Visit(apiNestedResource, isFirstResource && isFirstWrite);
        //
        //             _resourceBreadcrumbPath = originalResourceBreadcrumbPath;
        //             _baseEndpointPath = originalBaseEndpointPath;
        //
        //             isFirstResource = false;
        //         }
        //     }
        //
        //     Indent.Decrement();
        //     Builder.AppendLine($"{Indent}}}");
        //     Builder.AppendLine($"{Indent}");
        // }
        //
        // private string _clientMethodName = string.Empty;
        //
        // public void GenerateResourceApiEndpointDefinition(ApiResource apiResource, ApiEndpoint apiEndpoint)
        // {
        //     GenerateApiEndpointDefinition(apiEndpoint);
        //     
        //     var isResponseBatch = apiEndpoint.ResponseBody is ApiFieldType.Object objectResponse
        //         && objectResponse.Kind == ApiFieldType.Object.ObjectKind.BATCH;
        //
        //     if (isResponseBatch && apiEndpoint.ResponseBody != null)
        //     {
        //         WriteEndpointBatchEnumeratorOverload(apiEndpoint);
        //     }
        // }
        //
        // private void GenerateApiEndpointDefinition(ApiEndpoint apiEndpoint)
        // {
        //     var endpointPath = (_baseEndpointPath + "/" + apiEndpoint.Path.Segments.ToPath()).TrimEnd('/');
        //
        //     var apiCallMethod = apiEndpoint.Method.ToHttpMethod();
        //     _clientMethodName = apiEndpoint.DisplayName.ToSafeIdentifier()!;
        //
        //     if (!string.IsNullOrEmpty(apiEndpoint.Documentation))
        //     {
        //         Builder.AppendLine($"{Indent}/// <summary>");
        //         Builder.AppendLine($"{Indent}/// {apiEndpoint.Documentation}");
        //         Builder.AppendLine($"{Indent}/// </summary>");
        //     }
        //     
        //     if (apiEndpoint.Deprecation != null)
        //     {
        //         Visit(apiEndpoint.Deprecation);
        //     }
        //     
        //     var isResponsePrimitiveOrArrayOfPrimitive = apiEndpoint.ResponseBody is ApiFieldType.Primitive 
        //         || (apiEndpoint.ResponseBody is ApiFieldType.Array arrayField && arrayField.ElementType is ApiFieldType.Primitive);
        //     
        //     if (apiEndpoint.ResponseBody == null)
        //     {
        //         Builder.Append($"{Indent}public async Task " + _clientMethodName + "Async(");
        //
        //         if (WriteMethodParameterList(apiEndpoint) && apiEndpoint.RequestBody != null)
        //         {
        //             Builder.Append(", ");
        //         }
        //         
        //         if (apiEndpoint.RequestBody != null)
        //         {
        //             Visit(apiEndpoint.RequestBody);
        //             Builder.Append(" data");
        //         }
        //
        //         Builder.AppendLine(")");
        //         Indent.Increment();
        //         Builder.Append($"{Indent}=> await _connection.RequestResourceAsync");
        //         Builder.Append("(\"" + apiCallMethod + "\", ");
        //         Builder.Append("$\"api/http/" + endpointPath);
        //         WriteRequestParameterList(apiEndpoint);
        //         Builder.Append("\"");
        //         if (apiEndpoint.RequestBody != null)
        //         {
        //             Builder.Append(", data");
        //         }
        //         Builder.Append(");");
        //         Indent.Decrement();
        //         Builder.AppendLine($"{Indent}");
        //     }
        //     else if (apiEndpoint.ResponseBody != null)
        //     {
        //         Builder.Append($"{Indent}public async Task<");
        //         Visit(apiEndpoint.ResponseBody);
        //         Builder.Append(">");
        //         Builder.Append(" " + _clientMethodName + "Async(");
        //
        //         if (WriteMethodParameterList(apiEndpoint) && (apiEndpoint.RequestBody != null || !isResponsePrimitiveOrArrayOfPrimitive))
        //         {
        //             Builder.Append(", ");
        //         }
        //
        //         if (apiEndpoint.RequestBody != null)
        //         {
        //             Visit(apiEndpoint.RequestBody);
        //             Builder.Append(" data");
        //             
        //             if (!isResponsePrimitiveOrArrayOfPrimitive)
        //             {
        //                 Builder.Append(", ");
        //             }
        //         }
        //
        //         if (!isResponsePrimitiveOrArrayOfPrimitive)
        //         {
        //             Builder.Append("Func<Partial<");
        //             Visit(apiEndpoint.ResponseBody.GetArrayElementTypeOrType());
        //             Builder.Append(">, Partial<");
        //             Visit(apiEndpoint.ResponseBody.GetArrayElementTypeOrType());
        //             Builder.Append(">> partialBuilder = null");
        //         }
        //
        //         Builder.AppendLine(")");
        //         
        //         Indent.Increment();
        //         Builder.Append($"{Indent}=> await _connection.RequestResourceAsync<");
        //         if (apiEndpoint.RequestBody != null)
        //         {
        //             Visit(apiEndpoint.RequestBody);
        //             Builder.Append(", ");
        //         }
        //         Visit(apiEndpoint.ResponseBody);
        //         Builder.Append(">");
        //         Builder.Append("(\"" + apiCallMethod + "\", ");
        //         Builder.Append("$\"api/http/" + endpointPath);
        //         Builder.Append(WriteRequestParameterList(apiEndpoint) ? "&" : "?");
        //         if (!isResponsePrimitiveOrArrayOfPrimitive)
        //         {
        //             Builder.Append("$fields=\" + (partialBuilder != null ? partialBuilder(new Partial<");
        //             Visit(apiEndpoint.ResponseBody.GetArrayElementTypeOrType());
        //             Builder.Append(">()) : Partial<");
        //             Visit(apiEndpoint.ResponseBody.GetArrayElementTypeOrType());
        //             Builder.Append(">.Default())");
        //         }
        //         else
        //         {
        //             Builder.Append("\"");
        //         }
        //         if (apiEndpoint.RequestBody != null)
        //         {
        //             Builder.Append(", data");
        //         }
        //         Builder.Append(");");
        //         Indent.Decrement();
        //         Builder.AppendLine($"{Indent}");
        //     }
        //     else
        //     {
        //         Builder.AppendLine($"{Indent}#warning UNSUPPORTED CASE - " + apiEndpoint.DisplayName.ToSafeIdentifier() + " - " + apiEndpoint.Method.ToHttpMethod() + " " + endpointPath);
        //     }
        //     
        //     Builder.AppendLine($"{Indent}");
        //
        //     _clientMethodName = string.Empty;
        // }
        //
        // private void WriteEndpointBatchEnumeratorOverload(ApiEndpoint apiEndpoint)
        // {
        //     void WriteMethodCallParameterList(ApiEndpoint apiEndpoint1)
        //     {
        //         var methodParameters = apiEndpoint1.Parameters.OrderBy(it => !it.Field.Type.Nullable ? 0 : 1).ToList();
        //         foreach (var apiEndpointParameter in methodParameters)
        //         {
        //             Builder.Append(apiEndpointParameter.Field.Name.ToSafeVariableIdentifier());
        //             if (apiEndpointParameter.Field.Name.ToSafeVariableIdentifier() == "skip")
        //             {
        //                 Builder.Append(": batchSkip");
        //             }
        //
        //             if (apiEndpointParameter != methodParameters.Last())
        //             {
        //                 Builder.Append(", ");
        //             }
        //         }
        //     }
        //     
        //     var endpointPath = (_baseEndpointPath + "/" + apiEndpoint.Path.Segments.ToPath()).TrimEnd('/');
        //
        //     _clientMethodName = apiEndpoint.DisplayName.ToSafeIdentifier()!;
        //
        //     if (!string.IsNullOrEmpty(apiEndpoint.Documentation))
        //     {
        //         Builder.AppendLine($"{Indent}/// <summary>");
        //         Builder.AppendLine($"{Indent}/// {apiEndpoint.Documentation}");
        //         Builder.AppendLine($"{Indent}/// </summary>");
        //     }
        //     
        //     if (apiEndpoint.Deprecation != null)
        //     {
        //         Visit(apiEndpoint.Deprecation);
        //     }
        //     
        //     var batchDataType = ((ApiFieldType.Object)apiEndpoint.ResponseBody).GetBatchDataType();
        //     
        //     if (apiEndpoint.ResponseBody != null)
        //     {
        //         Builder.Append($"{Indent}public IAsyncEnumerable<");
        //         Visit(batchDataType.ElementType);
        //         Builder.Append(">");
        //         Builder.Append(" " + _clientMethodName + "AsyncEnumerable(");
        //     
        //         if (WriteMethodParameterList(apiEndpoint))
        //         {
        //             Builder.Append(", ");
        //         }
        //
        //         if (apiEndpoint.RequestBody != null)
        //         {
        //             Visit(apiEndpoint.RequestBody);
        //             Builder.Append(" data");
        //
        //             Builder.Append(", ");
        //         }
        //
        //         Builder.Append("Func<Partial<");
        //         Visit(batchDataType.GetBatchElementTypeOrType());
        //         Builder.Append(">, Partial<");
        //         Visit(batchDataType.GetBatchElementTypeOrType());
        //         Builder.Append(">> partialBuilder = null");
        //
        //         Builder.AppendLine(")");
        //         
        //         Indent.Increment();
        //         Builder.Append($"{Indent}=> BatchEnumerator.AllItems(batchSkip => ");
        //         
        //         Builder.Append(_clientMethodName + "Async(");
        //         WriteMethodCallParameterList(apiEndpoint);
        //         Builder.Append(", ");
        //         
        //         if (apiEndpoint.RequestBody != null)
        //         {
        //             Builder.Append("data, ");
        //         }
        //         
        //         Builder.Append("builder => Partial<Batch<");
        //         Visit(batchDataType.GetBatchElementTypeOrType());
        //         Builder.Append(">>.Default().WithNext().WithTotalCount().WithData(partialBuilder != null ? partialBuilder : _ => Partial<");
        //         Visit(batchDataType.GetBatchElementTypeOrType());
        //         Builder.Append(">.Default()))");
        //         
        //         Builder.Append(", skip);");
        //         Indent.Decrement();
        //         Builder.AppendLine($"{Indent}");
        //     }
        //     else
        //     {
        //         Builder.AppendLine($"{Indent}#warning UNSUPPORTED CASE - " + apiEndpoint.DisplayName.ToSafeIdentifier() + " - " + apiEndpoint.Method.ToHttpMethod() + " " + endpointPath);
        //     }
        //     
        //     Builder.AppendLine($"{Indent}");
        //
        //     _clientMethodName = string.Empty;
        // }
        //
        // private bool WriteMethodParameterList(ApiEndpoint apiEndpoint)
        // {
        //     var methodParameters = apiEndpoint.Parameters.OrderBy(it => !it.Field.Type.Nullable ? 0 : 1).ToList();
        //     foreach (var apiEndpointParameter in methodParameters)
        //     {
        //         Visit(apiEndpointParameter.Field.Type);
        //         if (apiEndpointParameter.Field.Type.Nullable)
        //         {
        //             Builder.Append("?");
        //         }
        //
        //         Builder.Append(" ");
        //         Builder.Append(apiEndpointParameter.Field.Name.ToSafeVariableIdentifier());
        //         if (apiEndpointParameter.Field.Type.Nullable)
        //         {
        //             Builder.Append(" = null");
        //         }
        //
        //         if (apiEndpointParameter != methodParameters.Last())
        //         {
        //             Builder.Append(", ");
        //         }
        //     }
        //
        //     return methodParameters.Count > 0;
        // }
        //
        // private bool WriteRequestParameterList(ApiEndpoint apiEndpoint)
        // {
        //     var methodParameters = apiEndpoint.Parameters.Where(it => !it.Path).ToList();
        //     if (methodParameters.Count > 0)
        //     {
        //         Builder.Append("?");
        //     }
        //
        //     foreach (var apiEndpointParameter in methodParameters)
        //     {
        //         Builder.Append(apiEndpointParameter.Field.Name);
        //         Builder.Append("=");
        //         Builder.Append("{");
        //         Builder.Append(apiEndpointParameter.Field.Name.ToSafeVariableIdentifier());
        //
        //         if (apiEndpointParameter.Field.Type is ApiFieldType.Array arrayType)
        //         {
        //             // For lists, we will need to repeat the parameter for each element
        //             Builder.Append(!apiEndpointParameter.Field.Type.Nullable
        //                 ? ".JoinToString("
        //                 : "?.JoinToString(");
        //
        //             Builder.Append("\"");
        //             Builder.Append(apiEndpointParameter.Field.Name);
        //             Builder.Append("\", it => it");
        //
        //             Builder.Append(!arrayType.ElementType.Nullable
        //                 ? ".ToString()"
        //                 : "?.ToString()");
        //
        //             if (arrayType.ElementType is ApiFieldType.Primitive primitive && primitive.Type.Equals("Boolean", StringComparison.OrdinalIgnoreCase))
        //             {
        //                 // Boolean needs lowercase value
        //                 Builder.Append(!arrayType.ElementType.Nullable
        //                     ? ".ToLowerInvariant()"
        //                     : "?.ToLowerInvariant()");
        //             }
        //
        //             Builder.Append(")");
        //         }
        //         else
        //         {
        //             // Anything else can be "ToString()"
        //             Builder.Append(!apiEndpointParameter.Field.Type.Nullable
        //                 ? ".ToString()"
        //                 : "?.ToString()");
        //
        //             if (apiEndpointParameter.Field.Type is ApiFieldType.Primitive primitive && primitive.Type.Equals("Boolean", StringComparison.OrdinalIgnoreCase))
        //             {
        //                 // Boolean needs lowercase value
        //                 Builder.Append(!apiEndpointParameter.Field.Type.Nullable
        //                     ? ".ToLowerInvariant()"
        //                     : "?.ToLowerInvariant()");
        //             }
        //         }
        //
        //         if (apiEndpointParameter.Field.Type.Nullable)
        //         {
        //             // Used to be able to filter out nullable query string parameters in Connection.CleanNullableNullQueryStringParameters
        //             Builder.Append(" ?? \"null\"");
        //         }
        //
        //         Builder.Append("}");
        //
        //         if (apiEndpointParameter != methodParameters.Last())
        //         {
        //             Builder.Append("&");
        //         }
        //     }
        //
        //     return methodParameters.Count > 0;
        // }
        //
    }
}