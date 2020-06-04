using System;
using System.Collections.Generic;
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
            foreach (var apiDto in _codeGenerationContext.IdToDtoMap.Values)
            {
                var document = new CSharpDocument();
                document.Write(
                    GenerateDtoDefinition(apiDto));
                
                documentWriter.WriteDocument(
                    "Dtos/" + apiDto.Name.ToSafeIdentifier() + "Dto.generated.cs",
                    document.Create());
            }
            
            // Partial extensions
            var partialExtensionsVisitor = new CSharpPartialExtensionsGenerator(_codeGenerationContext);
            foreach (var apiDto in _codeGenerationContext.IdToDtoMap.Values)
            {
                var document = new CSharpDocument();
                document.Write(
                    partialExtensionsVisitor.GeneratePartialClassFor(apiDto));
                
                documentWriter.WriteDocument(
                    "Partials/" + apiDto.Name.ToSafeIdentifier() + "Dto.generated.cs",
                    document.CreateWithNamespaceSuffix(apiDto.Name.ToSafeIdentifier() + "Extensions"));
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
                    : apiDto.HierarchyRole == HierarchyRole.SEALED || apiDto.HierarchyRole == HierarchyRole.FINAL
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
                        /* TODO REFACTORING only generate for interfaces && apiDtoImplements.HierarchyRole == HierarchyRole.INTERFACE*/)
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
        
        public string GenerateDtoFieldDefinitionType(ApiFieldType apiFieldType, string? clientMethodName = null)
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
                        var anonymousClass = _codeGenerationContext.IdToDtoMap.Values.FirstOrDefault(it => it.Name.EndsWith("Request") && anonymousClassSignature == JsonSerializer.Serialize(it.Fields));
                        if (anonymousClass == null)
                        {
                            var anonymousClassId = !string.IsNullOrEmpty(clientMethodName)
                                ? clientMethodName + "Request" // TODO REFACTORING
                                : throw new Exception("Request body class requires a _clientMethodName to be specified.");
                            anonymousClass = new ApiDto
                            {
                                Id = anonymousClassId.ToLowerInvariant(),
                                Name = anonymousClassId,
                                Fields = anonymousClassFields
                            };
        
                            _codeGenerationContext.IdToDtoMap[anonymousClassId] = anonymousClass;
                        }
        
                        return anonymousClass.Name + "Dto";
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

        private HashSet<string> _resourceBreadcrumbPaths = new HashSet<string>();
        
        public string GenerateResourceDefinition(ApiResource apiResource)
        {
            return GenerateResourceDefinition(
                apiResource, 
                apiResource.Path.Segments.ToPath(),
                apiResource.DisplaySingular.ToSafeIdentifier(),
                true);
        }
        
        public string GenerateResourceDefinition(
            ApiResource apiResource,
            string baseEndpointPath,
            string resourceBreadcrumbPath,
            bool withConstructor)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            // Client class
            builder.AppendLine($"{indent}public partial class " + apiResource.DisplaySingular.ToSafeIdentifier() + "Client");
            builder.AppendLine($"{indent}{{");
            indent.Increment();
        
            // Constructor needed?
            if (withConstructor)
            {
                builder.AppendLine($"{indent}private readonly Connection _connection;");
                builder.AppendLine($"{indent}");
                builder.AppendLine($"{indent}public " + apiResource.DisplaySingular.ToSafeIdentifier() + "Client(Connection connection)");
                builder.AppendLine($"{indent}{{");
                indent.Increment();
        
                builder.AppendLine($"{indent}_connection = connection;");
            
                indent.Decrement();
                builder.AppendLine($"{indent}}}");
                builder.AppendLine($"{indent}");
            }
        
            // Endpoint methods
            foreach (var apiEndpoint in apiResource.Endpoints)
            {
                builder.AppendLine(
                    indent.Wrap(
                        GenerateResourceApiEndpointDefinition(apiResource, apiEndpoint, baseEndpointPath)));
            }
        
            // Group nested resources by path
            var resourcePathBuildingVisitor = new PathToResourceMapper();
            foreach (var (_, apiNestedResources) in resourcePathBuildingVisitor.CreateMapOfPathToResources(apiResource))
            {
                var isFirstResource = true;
                foreach (var apiNestedResource in apiNestedResources)
                {
                    var nestedResourceBreadcrumbPath = (resourceBreadcrumbPath.Length > 0 ? resourceBreadcrumbPath + "." : resourceBreadcrumbPath) + apiNestedResource.DisplaySingular.ToSafeIdentifier();

                    var isFirstWrite = _resourceBreadcrumbPaths.Add(nestedResourceBreadcrumbPath);
                    if (isFirstResource && isFirstWrite)
                    {
                        builder.AppendLine($"{indent}public " + apiNestedResource.DisplaySingular.ToSafeIdentifier() + "Client " + apiNestedResource.DisplayPlural.ToSafeIdentifier() + " => new " + apiNestedResource.DisplaySingular.ToSafeIdentifier() + "Client(_connection);");
                        builder.AppendLine($"{indent}");
                    }

                    builder.AppendLine(
                        indent.Wrap(
                            GenerateResourceDefinition(
                                apiNestedResource, 
                                (baseEndpointPath.Length > 0 ? baseEndpointPath + "/" : baseEndpointPath) + apiNestedResource.Path.Segments.ToPath(),
                                nestedResourceBreadcrumbPath,
                                isFirstResource && isFirstWrite)));
        
                    isFirstResource = false;
                }
            }
        
            indent.Decrement();
            builder.AppendLine($"{indent}}}");
            return builder.ToString();
        }
        
        public string GenerateResourceApiEndpointDefinition(ApiResource apiResource, ApiEndpoint apiEndpoint, string baseEndpointPath)
        {
            var builder = new StringBuilder();
            builder.AppendLine(GenerateApiEndpointDefinition(apiEndpoint, baseEndpointPath));
            
            var isResponseBatch = apiEndpoint.ResponseBody is ApiFieldType.Object objectResponse
                && objectResponse.Kind == ApiFieldType.Object.ObjectKind.BATCH;
        
            if (isResponseBatch && apiEndpoint.ResponseBody != null)
            {
                builder.AppendLine();
                builder.AppendLine(WriteEndpointBatchEnumeratorOverload(apiEndpoint, baseEndpointPath));
            }

            return builder.ToString();
        }

        // TODO REFACTORING GenerateMethodFor.... is a better name
        private string GenerateApiEndpointDefinition(ApiEndpoint apiEndpoint, string baseEndpointPath)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            var endpointPath = (baseEndpointPath + "/" + apiEndpoint.Path.Segments.ToPath()).TrimEnd('/');
        
            var apiCallMethod = apiEndpoint.Method.ToHttpMethod();
            var clientMethodName = apiEndpoint.DisplayName.ToSafeIdentifier()!;
        
            if (!string.IsNullOrEmpty(apiEndpoint.Documentation))
            {
                builder.Append(
                    indent.Wrap(
                        apiEndpoint.Documentation.ToCSharpDocumentationComment()));
            }
            
            if (apiEndpoint.Deprecation != null)
            {
                builder.AppendLine(apiEndpoint.Deprecation.ToCSharpDeprecation());
            }
            
            var isResponsePrimitiveOrArrayOfPrimitive = apiEndpoint.ResponseBody is ApiFieldType.Primitive 
                || (apiEndpoint.ResponseBody is ApiFieldType.Array arrayField && arrayField.ElementType is ApiFieldType.Primitive);
            
            if (apiEndpoint.ResponseBody == null)
            {
                builder.Append($"{indent}public async Task " + clientMethodName + "Async(");

                var methodParametersBuilder = new MethodParametersBuilder()
                    .WithParametersForEndpoint(apiEndpoint, x => GenerateDtoFieldDefinitionType(x, clientMethodName));
                
                if (apiEndpoint.RequestBody != null)
                {
                    methodParametersBuilder = methodParametersBuilder
                        .WithParameter(
                            GenerateDtoFieldDefinitionType(apiEndpoint.RequestBody, clientMethodName),
                            "data");
                }

                builder.Append(methodParametersBuilder.BuildMethodParametersDefinition());
        
                builder.AppendLine(")");
                indent.Increment();
                builder.Append($"{indent}=> await _connection.RequestResourceAsync");
                builder.Append("(\"" + apiCallMethod + "\", ");
                builder.Append("$\"api/http/" + endpointPath);
                
                var requestParametersBuilder = new RequestParametersBuilder()
                    .WithParametersForEndpoint(apiEndpoint);
                
                if (apiEndpoint.ResponseBody != null && !isResponsePrimitiveOrArrayOfPrimitive)
                {
                    var partialType = "Partial<" + GenerateDtoFieldDefinitionType(apiEndpoint.ResponseBody.GetArrayElementTypeOrType(), clientMethodName) + ">";
                    
                    requestParametersBuilder = requestParametersBuilder
                        .WithParameter("$fields", $"{{(partial != null ? partial(new {partialType}()) : {partialType}.Default())}}");
                }
                
                builder.Append(requestParametersBuilder.ForHttpQueryString());
                builder.Append("\"");
                
                if (apiEndpoint.RequestBody != null)
                {
                    builder.Append(", data");
                }
                builder.Append(");");
                indent.Decrement();
            }
            else if (apiEndpoint.ResponseBody != null)
            {
                builder.Append($"{indent}public async Task<");
                builder.Append(GenerateDtoFieldDefinitionType(apiEndpoint.ResponseBody, clientMethodName));
                builder.Append(">");
                builder.Append(" " + clientMethodName + "Async(");
                
                var methodParametersBuilder = new MethodParametersBuilder()
                    .WithParametersForEndpoint(apiEndpoint, x => GenerateDtoFieldDefinitionType(x, clientMethodName));
                
                if (apiEndpoint.RequestBody != null)
                {
                    methodParametersBuilder = methodParametersBuilder
                        .WithParameter(
                            GenerateDtoFieldDefinitionType(apiEndpoint.RequestBody, clientMethodName),
                            "data");
                }
        
                if (apiEndpoint.ResponseBody != null && !isResponsePrimitiveOrArrayOfPrimitive)
                {
                    var partialType = "Partial<" + GenerateDtoFieldDefinitionType(apiEndpoint.ResponseBody.GetArrayElementTypeOrType(), clientMethodName) + ">";
                    var funcType = $"Func<{partialType}, {partialType}>";
                    methodParametersBuilder = methodParametersBuilder
                        .WithParameter(
                            funcType,
                            "partial",
                            "null");
                }
        
                builder.Append(methodParametersBuilder.BuildMethodParametersDefinition());
                builder.AppendLine(")");
                
                indent.Increment();
                builder.Append($"{indent}=> await _connection.RequestResourceAsync<");
                if (apiEndpoint.RequestBody != null)
                {
                    builder.Append(GenerateDtoFieldDefinitionType(apiEndpoint.RequestBody, clientMethodName));
                    builder.Append(", ");
                }
                builder.Append(GenerateDtoFieldDefinitionType(apiEndpoint.ResponseBody, clientMethodName));
                builder.Append(">");
                builder.Append("(\"" + apiCallMethod + "\", ");
                builder.Append("$\"api/http/" + endpointPath);
                
                var requestParametersBuilder = new RequestParametersBuilder()
                    .WithParametersForEndpoint(apiEndpoint);
                
                if (apiEndpoint.ResponseBody != null && !isResponsePrimitiveOrArrayOfPrimitive)
                {
                    var partialType = "Partial<" + GenerateDtoFieldDefinitionType(apiEndpoint.ResponseBody.GetArrayElementTypeOrType(), clientMethodName) + ">";
                    
                    requestParametersBuilder = requestParametersBuilder
                        .WithParameter("$fields", $"{{(partial != null ? partial(new {partialType}()) : {partialType}.Default())}}");
                }
                
                builder.Append(requestParametersBuilder.ForHttpQueryString());
                builder.Append("\"");
                
                if (apiEndpoint.RequestBody != null)
                {
                    builder.Append(", data");
                }
                builder.Append(");");
                indent.Decrement();
            }
            else
            {
                builder.AppendLine($"{indent}#warning UNSUPPORTED CASE - " + apiEndpoint.DisplayName.ToSafeIdentifier() + " - " + apiEndpoint.Method.ToHttpMethod() + " " + endpointPath);
            }
            
            return builder.ToString();
        }
        
        private string WriteEndpointBatchEnumeratorOverload(ApiEndpoint apiEndpoint, string baseEndpointPath)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            var endpointPath = (baseEndpointPath + "/" + apiEndpoint.Path.Segments.ToPath()).TrimEnd('/');
        
            var clientMethodName = apiEndpoint.DisplayName.ToSafeIdentifier()!;
        
            if (!string.IsNullOrEmpty(apiEndpoint.Documentation))
            {
                builder.Append(
                    indent.Wrap(
                        apiEndpoint.Documentation.ToCSharpDocumentationComment()));
            }
            
            if (apiEndpoint.Deprecation != null)
            {
                builder.AppendLine(apiEndpoint.Deprecation.ToCSharpDeprecation());
            }
            
            var batchDataType = ((ApiFieldType.Object)apiEndpoint.ResponseBody).GetBatchDataType();
            
            if (apiEndpoint.ResponseBody != null)
            {
                builder.Append($"{indent}public IAsyncEnumerable<");
                builder.Append(GenerateDtoFieldDefinitionType(batchDataType.ElementType, clientMethodName));
                builder.Append(">");
                builder.Append(" " + clientMethodName + "AsyncEnumerable(");
            
                var methodParametersBuilder = new MethodParametersBuilder()
                    .WithParametersForEndpoint(apiEndpoint, x => GenerateDtoFieldDefinitionType(x, clientMethodName));
                
                if (apiEndpoint.RequestBody != null)
                {
                    methodParametersBuilder = methodParametersBuilder
                        .WithParameter(
                            GenerateDtoFieldDefinitionType(apiEndpoint.RequestBody, clientMethodName),
                            "data");
                }
        
                var partialType = "Partial<" + GenerateDtoFieldDefinitionType(batchDataType.GetBatchElementTypeOrType(), clientMethodName) + ">";
                var funcType = $"Func<{partialType}, {partialType}>";
                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(
                        funcType,
                        "partial",
                        "null");
                
                builder.Append(methodParametersBuilder.BuildMethodParametersDefinition());
                builder.AppendLine(")");
                
                indent.Increment();
                builder.Append($"{indent}=> BatchEnumerator.AllItems(batchSkip => ");
                
                builder.Append(clientMethodName + "Async(");

                var partialTypeForBatch = "Partial<Batch<" + GenerateDtoFieldDefinitionType(batchDataType.GetBatchElementTypeOrType(), clientMethodName) + ">>";
                builder.Append(
                    methodParametersBuilder
                        .WithDefaultValueForAllParameters(null)
                        .WithDefaultValueForParameter("skip", "batchSkip")
                        .WithDefaultValueForParameter("partial", $"builder => {partialTypeForBatch}.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => {partialType}.Default())")
                        .BuildMethodCallParametersDefinition());
                
                builder.Append("), skip);");
                indent.Decrement();
            }
            else
            {
                builder.AppendLine($"{indent}#warning UNSUPPORTED CASE - " + apiEndpoint.DisplayName.ToSafeIdentifier() + " - " + apiEndpoint.Method.ToHttpMethod() + " " + endpointPath);
            }

            return builder.ToString();
        }
    }
}