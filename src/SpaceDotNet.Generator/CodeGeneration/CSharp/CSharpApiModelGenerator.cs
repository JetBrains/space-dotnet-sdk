using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.CodeGeneration.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    // TODO REFACTORING Split this into a couple classes (Dto/enum/api)
    public class CSharpApiModelGenerator
    {
        private readonly CodeGenerationContext _codeGenerationContext;
        
        public CSharpApiModelGenerator(CodeGenerationContext codeGenerationContext)
        {
            _codeGenerationContext = codeGenerationContext;
        }
        
        public void GenerateFiles(IDocumentWriter documentWriter)
        {
            // API clients/endpoints
            foreach (var apiResource in _codeGenerationContext.GetResources())
            {
                var document = new CSharpDocument();
                document.AppendLine(
                    GenerateResourceDefinition(apiResource));
                
                documentWriter.WriteDocument(
                    apiResource.ToCSharpIdentifierSingular() + "Client.generated.cs",
                    document.ToString());
            }
            
            // Enums
            foreach (var apiEnum in _codeGenerationContext.GetEnums())
            {
                var document = new CSharpDocument();
                document.AppendLine(
                    GenerateEnumDefinition(apiEnum));
                
                documentWriter.WriteDocument(
                    "Enums/" + apiEnum.ToCSharpClassName() + ".generated.cs",
                    document.ToString());
            }
            
            // Dtos
            foreach (var apiDto in _codeGenerationContext.GetDtos())
            {
                var document = new CSharpDocument();
                document.AppendLine(
                    GenerateDtoDefinition(apiDto));
                
                documentWriter.WriteDocument(
                    "Dtos/" + apiDto.ToCSharpClassName() + ".generated.cs",
                    document.ToString());
            }
            
            // Partial extensions
            var partialExtensionsVisitor = new CSharpPartialExtensionsGenerator(_codeGenerationContext);
            foreach (var apiDto in _codeGenerationContext.GetDtos())
            {
                var document = new CSharpDocument(apiDto.ToCSharpClassName() + "Extensions");
                document.AppendLine(
                    partialExtensionsVisitor.GeneratePartialClassFor(apiDto));
                
                documentWriter.WriteDocument(
                    "Partials/" + apiDto.ToCSharpClassName() + ".generated.cs",
                    document.ToString());
            }
        }

        public string GenerateEnumDefinition(ApiEnum apiEnum)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            var typeNameForEnum = apiEnum.ToCSharpClassName();
            
            if (apiEnum.Deprecation != null)
            {
                builder.AppendLine(apiEnum.Deprecation.ToCSharpDeprecation());
            }
            
            builder.AppendLine($"{indent}[JsonConverter(typeof(EnumerationConverter))]");
            builder.AppendLine($"{indent}public sealed class {typeNameForEnum} : Enumeration");
            builder.AppendLine($"{indent}{{");
                
            indent.Increment();
            builder.AppendLine($"{indent}private {typeNameForEnum}(string value) : base(value) {{ }}");
            builder.AppendLine($"{indent}");
            
            foreach (var value in apiEnum.Values)
            {
                var identifierForValue = CSharpIdentifier.ForClassOrNamespace(value);
                builder.AppendLine($"{indent}public static readonly {typeNameForEnum} {identifierForValue} = new {typeNameForEnum}(\"{value}\");");
            }
            
            indent.Decrement();
                
            builder.AppendLine($"{indent}}}");
            return builder.ToString();
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
                            builder.AppendLine(indent.Wrap(GenerateDtoFieldDefinition(apiDtoField.Field)));
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
                    builder.AppendLine(indent.Wrap(GenerateDtoFieldDefinition(apiDtoField.Field)));
                }
            }
        
            indent.Decrement();
            builder.AppendLine($"{indent}}}");
            return builder.ToString();
        }

        private string GenerateDtoFieldDefinition(ApiField apiField)
        {
            // TODO CONSIDER WRITING PARTIAL PATH ERRORS?
            var indent = new Indent();
            var builder = new StringBuilder();

            var propertyNameForField = apiField.ToCSharpPropertyName();
            
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
            builder.Append($"{propertyNameForField} {{ get; set; }}");
            return builder.ToString();
        }

        public string GenerateResourceDefinition(ApiResource apiResource) =>
            GenerateResourceDefinition(
                apiResource, 
                apiResource.Path.Segments.ToPath(),
                apiResource.ToCSharpIdentifierSingular(),
                new HashSet<string>(),
                true);

        private string GenerateResourceDefinition(
            ApiResource apiResource,
            string baseEndpointPath,
            string resourceBreadcrumbPath,
            HashSet<string> resourceBreadcrumbPaths,
            bool withConstructor)
        {
            var indent = new Indent();
            var builder = new StringBuilder();

            var typeNameForClient = apiResource.ToCSharpIdentifierSingular() + "Client";
            
            // Client class
            builder.AppendLine($"{indent}public partial class {typeNameForClient}");
            builder.AppendLine($"{indent}{{");
            indent.Increment();
        
            // Constructor needed?
            if (withConstructor)
            {
                builder.AppendLine($"{indent}private readonly Connection _connection;");
                builder.AppendLine($"{indent}");
                builder.AppendLine($"{indent}public {typeNameForClient}(Connection connection)");
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
                        GenerateMethodsForApiEndpoint(apiEndpoint, baseEndpointPath)));
            }
        
            // Group nested resources by path
            var resourcePathBuildingVisitor = new PathToResourceMapper();
            foreach (var (_, apiNestedResources) in resourcePathBuildingVisitor.CreateMapOfPathToResources(apiResource))
            {
                var isFirstResource = true;
                foreach (var apiNestedResource in apiNestedResources)
                {
                    var nestedResourceBreadcrumbPath = (resourceBreadcrumbPath.Length > 0 ? resourceBreadcrumbPath + "." : resourceBreadcrumbPath) + apiNestedResource.ToCSharpIdentifierSingular();

                    var isFirstWrite = resourceBreadcrumbPaths.Add(nestedResourceBreadcrumbPath);
                    if (isFirstResource && isFirstWrite)
                    {
                        var typeNameForNestedClient = apiNestedResource.ToCSharpIdentifierSingular() + "Client";
                        var propertyNameForNestedClient = apiNestedResource.ToCSharpIdentifierPlural();
                        builder.AppendLine($"{indent}public {typeNameForNestedClient} {propertyNameForNestedClient} => new {typeNameForNestedClient}(_connection);");
                        builder.AppendLine($"{indent}");
                    }

                    builder.AppendLine(
                        indent.Wrap(
                            GenerateResourceDefinition(
                                apiNestedResource, 
                                (baseEndpointPath.Length > 0 ? baseEndpointPath + "/" : baseEndpointPath) + apiNestedResource.Path.Segments.ToPath(),
                                nestedResourceBreadcrumbPath,
                                resourceBreadcrumbPaths,
                                isFirstResource && isFirstWrite)));
        
                    isFirstResource = false;
                }
            }
        
            indent.Decrement();
            builder.AppendLine($"{indent}}}");
            return builder.ToString();
        }

        private string GenerateMethodsForApiEndpoint(ApiEndpoint apiEndpoint, string baseEndpointPath)
        {
            var builder = new StringBuilder();
            builder.AppendLine(GenerateMethodForApiEndpoint(apiEndpoint, baseEndpointPath));
            
            var isResponseBatch = apiEndpoint.ResponseBody is ApiFieldType.Object objectResponse
                && objectResponse.Kind == ApiFieldType.Object.ObjectKind.BATCH;
        
            if (isResponseBatch && apiEndpoint.ResponseBody != null)
            {
                builder.AppendLine();
                builder.AppendLine(GenerateMethodForBatchApiEndpoint(apiEndpoint, baseEndpointPath));
            }

            return builder.ToString();
        }

        private string GenerateMethodForApiEndpoint(ApiEndpoint apiEndpoint, string baseEndpointPath)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            var endpointPath = (baseEndpointPath + "/" + apiEndpoint.Path.Segments.ToPath()).TrimEnd('/');
        
            var apiCallMethod = apiEndpoint.Method.ToHttpMethod();
            var methodNameForEndpoint = apiEndpoint.ToCSharpMethodName();
        
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
                builder.Append($"{indent}public async Task {methodNameForEndpoint}Async(");

                var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                    .WithParametersForEndpoint(apiEndpoint);
                
                if (apiEndpoint.RequestBody != null)
                {
                    methodParametersBuilder = methodParametersBuilder
                        .WithParameter(
                            apiEndpoint.ToCSharpRequestBodyClassName() ?? apiEndpoint.RequestBody.ToCSharpType(_codeGenerationContext),
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
                    var partialType = "Partial<" + apiEndpoint.ResponseBody.GetArrayElementTypeOrType().ToCSharpType(_codeGenerationContext) + ">";
                    
                    requestParametersBuilder = requestParametersBuilder
                        .WithParameter("$fields", $"{{(partial != null ? partial(new {partialType}()) : {partialType}.Default())}}");
                }
                
                builder.Append(requestParametersBuilder.BuildQueryString());
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
                builder.Append(apiEndpoint.ResponseBody.ToCSharpType(_codeGenerationContext));
                builder.Append(">");
                builder.Append($" {methodNameForEndpoint}Async(");
                
                var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                    .WithParametersForEndpoint(apiEndpoint);
                
                if (apiEndpoint.RequestBody != null)
                {
                    methodParametersBuilder = methodParametersBuilder
                        .WithParameter(
                            apiEndpoint.ToCSharpRequestBodyClassName() ?? apiEndpoint.RequestBody.ToCSharpType(_codeGenerationContext),
                            "data");
                }
        
                if (apiEndpoint.ResponseBody != null && !isResponsePrimitiveOrArrayOfPrimitive)
                {
                    var partialType = "Partial<" + apiEndpoint.ResponseBody.GetArrayElementTypeOrType().ToCSharpType(_codeGenerationContext) + ">";
                    var funcType = $"Func<{partialType}, {partialType}>?";
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
                    builder.Append(apiEndpoint.ToCSharpRequestBodyClassName() ?? apiEndpoint.RequestBody.ToCSharpType(_codeGenerationContext));
                    builder.Append(", ");
                }
                builder.Append(apiEndpoint.ResponseBody!.ToCSharpType(_codeGenerationContext));
                builder.Append(">");
                builder.Append("(\"" + apiCallMethod + "\", ");
                builder.Append("$\"api/http/" + endpointPath);
                
                var requestParametersBuilder = new RequestParametersBuilder()
                    .WithParametersForEndpoint(apiEndpoint);
                
                if (apiEndpoint.ResponseBody != null && !isResponsePrimitiveOrArrayOfPrimitive)
                {
                    var partialType = "Partial<" + apiEndpoint.ResponseBody.GetArrayElementTypeOrType().ToCSharpType(_codeGenerationContext) + ">";
                    
                    requestParametersBuilder = requestParametersBuilder
                        .WithParameter("$fields", $"{{(partial != null ? partial(new {partialType}()) : {partialType}.Default())}}");
                }
                
                builder.Append(requestParametersBuilder.BuildQueryString());
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
                builder.AppendLine($"{indent}#warning UNSUPPORTED CASE - " + apiEndpoint.ToCSharpMethodName() + " - " + apiEndpoint.Method.ToHttpMethod() + " " + endpointPath);
            }
            
            return builder.ToString();
        }
        
        private string GenerateMethodForBatchApiEndpoint(ApiEndpoint apiEndpoint, string baseEndpointPath)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            var endpointPath = (baseEndpointPath + "/" + apiEndpoint.Path.Segments.ToPath()).TrimEnd('/');

            var methodNameForEndpoint = apiEndpoint.ToCSharpMethodName();
        
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
            
            var batchDataType = ((ApiFieldType.Object)apiEndpoint.ResponseBody!).GetBatchDataType()!;
            
            if (apiEndpoint.ResponseBody != null)
            {
                builder.Append($"{indent}public IAsyncEnumerable<");
                builder.Append(batchDataType.ElementType.ToCSharpType(_codeGenerationContext));
                builder.Append(">");
                builder.Append($" {methodNameForEndpoint}AsyncEnumerable(");
            
                var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                    .WithParametersForEndpoint(apiEndpoint);
                
                if (apiEndpoint.RequestBody != null)
                {
                    methodParametersBuilder = methodParametersBuilder
                        .WithParameter(
                            apiEndpoint.ToCSharpRequestBodyClassName() ?? apiEndpoint.RequestBody.ToCSharpType(_codeGenerationContext),
                            "data");
                }
        
                var partialType = "Partial<" + batchDataType.GetBatchElementTypeOrType().ToCSharpType(_codeGenerationContext) + ">";
                var funcType = $"Func<{partialType}, {partialType}>?";
                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(
                        funcType,
                        "partial",
                        "null");
                
                builder.Append(methodParametersBuilder.BuildMethodParametersDefinition());
                builder.AppendLine(")");
                
                indent.Increment();
                builder.Append($"{indent}=> BatchEnumerator.AllItems(batchSkip => ");
                
                builder.Append($"{methodNameForEndpoint}Async(");

                var partialTypeForBatch = "Partial<Batch<" + batchDataType.GetBatchElementTypeOrType().ToCSharpType(_codeGenerationContext) + ">>";
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
                builder.AppendLine($"{indent}#warning UNSUPPORTED CASE - " + apiEndpoint.ToCSharpMethodName() + " - " + apiEndpoint.Method.ToHttpMethod() + " " + endpointPath);
            }

            return builder.ToString();
        }
    }
}