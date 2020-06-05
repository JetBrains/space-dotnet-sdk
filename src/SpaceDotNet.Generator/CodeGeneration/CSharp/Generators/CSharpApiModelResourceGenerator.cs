using System.Collections.Generic;
using System.Text;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.CodeGeneration.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Generators
{
    public class CSharpApiModelResourceGenerator
    {
        private readonly CodeGenerationContext _codeGenerationContext;
        
        public CSharpApiModelResourceGenerator(CodeGenerationContext codeGenerationContext)
        {
            _codeGenerationContext = codeGenerationContext;
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
            var pathToResourceMapper = new PathToResourceMapper();
            var mapOfPathToResources = pathToResourceMapper.CreateMapOfPathToResources(apiResource);
            foreach (var (_, apiNestedResources) in mapOfPathToResources)
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
                
                var requestParametersBuilder = new RequestParametersBuilder(_codeGenerationContext)
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
                
                var requestParametersBuilder = new RequestParametersBuilder(_codeGenerationContext)
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