using System.Collections.Generic;
using System.Text;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;
using JetBrains.Space.Generator.CodeGeneration.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators
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
                apiResource.ToCSharpIdentifierSingular() + "Client",
                apiResource.Path.Segments.ToPath(),
                apiResource.ToCSharpIdentifierSingular(),
                new HashSet<string>(),
                true);

        private string GenerateResourceDefinition(
            ApiResource apiResource,
            string typeNameForClient,
            string baseEndpointPath,
            string resourceBreadcrumbPath,
            HashSet<string> resourceBreadcrumbPaths,
            bool withConstructor)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            // Client class
            builder.AppendLine($"{indent}public partial class {typeNameForClient} : ISpaceClient");
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

                    var typeNameForNestedClient = apiNestedResource.ToCSharpIdentifierSingular() + "Client";
                    if (typeNameForNestedClient == typeNameForClient)
                    {
                        // Example: Team Directory > Profiles > Profiles > Deactivate -> ProfileProfileClient
                        typeNameForNestedClient = apiNestedResource.ToCSharpIdentifierSingular() + apiNestedResource.ToCSharpIdentifierSingular() + "Client";
                    }
                    
                    var isFirstWrite = resourceBreadcrumbPaths.Add(nestedResourceBreadcrumbPath);
                    if (isFirstResource && isFirstWrite)
                    {
                        var propertyNameForNestedClient = apiNestedResource.ToCSharpIdentifierPlural();
                        builder.AppendLine($"{indent}public {typeNameForNestedClient} {propertyNameForNestedClient} => new {typeNameForNestedClient}(_connection);");
                        builder.AppendLine($"{indent}");
                    }

                    builder.AppendLine(
                        indent.Wrap(
                            GenerateResourceDefinition(
                                apiNestedResource,
                                typeNameForNestedClient,
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
                builder.AppendLine(GenerateEnumerableMethodForBatchApiEndpoint(apiEndpoint, baseEndpointPath));
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
            
            var isResponsePrimitiveOrArrayOfPrimitive = apiEndpoint.ResponseBody is ApiFieldType.Primitive 
                                                        || (apiEndpoint.ResponseBody is ApiFieldType.Array arrayField && arrayField.ElementType is ApiFieldType.Primitive);
            
            if (apiEndpoint.ResponseBody == null)
            {
                var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                    .WithParametersForApiParameters(apiEndpoint.Parameters);
                
                if (apiEndpoint.RequestBody != null)
                {
                    if (FeatureFlags.DoNotExposeRequestObjects)
                    {
                        methodParametersBuilder = methodParametersBuilder
                            .WithParametersForApiFields(apiEndpoint.RequestBody.Fields);
                    }
                    else
                    {
                        methodParametersBuilder = methodParametersBuilder
                            .WithParameter(
                                apiEndpoint.ToCSharpRequestBodyClassName(endpointPath)!,
                                "data");
                    }
                }
                
                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(CSharpType.CancellationToken.Value,
                        "cancellationToken",
                        CSharpExpression.DefaultLiteral);
                
                builder.Append(
                    indent.Wrap(GenerateMethodDocumentationForEndpoint(apiEndpoint)));
                builder.Append($"{indent}public async Task {methodNameForEndpoint}Async(");
                builder.Append(methodParametersBuilder.BuildMethodParametersList());
                builder.AppendLine(")");
                builder.AppendLine($"{indent}{{");
                
                indent.Increment();
                
                // Generate query string
                var requestParametersBuilder = new QueryStringParameterConversionGenerator("queryParameters", _codeGenerationContext)
                    .WithQueryStringParametersForEndpoint(apiEndpoint);
                
                if (apiEndpoint.ResponseBody != null && !isResponsePrimitiveOrArrayOfPrimitive)
                {
                    var partialType = "Partial<" + apiEndpoint.ResponseBody.GetArrayElementTypeOrType().ToCSharpType(_codeGenerationContext) + ">";
                    
                    requestParametersBuilder = requestParametersBuilder
                        .WithQueryStringParameter("$fields", $"(partial != null ? partial(new {partialType}()) : {partialType}.Default()).ToString()");
                }
                
                builder.AppendLine($"{indent}var {requestParametersBuilder.TargetNameValueCollectionName} = new NameValueCollection();");
                requestParametersBuilder.WriteTo(builder, indent);
                builder.AppendLine($"{indent}");
                
                // Generate HTTP request
                builder.Append($"{indent}await _connection.RequestResourceAsync");
                builder.Append("(\"" + apiCallMethod + "\", ");
                builder.Append("$\"api/http/" + endpointPath + "{" + requestParametersBuilder.TargetNameValueCollectionName + ".ToQueryString()}");
                builder.Append("\"");

                if (apiEndpoint.RequestBody != null)
                {
                    if (FeatureFlags.DoNotExposeRequestObjects)
                    {
                        // TODO MAARTEN REFACTOR WITH PROPER NEWLINES
                        builder.Append(", " + ConstructNewRequestObject(indent, apiEndpoint, endpointPath));
                    }
                    else
                    {
                        builder.Append(", data");
                    }
                }
                
                builder.Append(", cancellationToken");
                builder.AppendLine(");");
                indent.Decrement();
                builder.AppendLine($"{indent}}}");
            }
            else if (apiEndpoint.ResponseBody != null)
            {
                var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                    .WithParametersForApiParameters(apiEndpoint.Parameters);
                
                if (apiEndpoint.RequestBody != null)
                {
                    if (FeatureFlags.DoNotExposeRequestObjects)
                    {
                        methodParametersBuilder = methodParametersBuilder
                            .WithParametersForApiFields(apiEndpoint.RequestBody.Fields);
                    }
                    else
                    {
                        methodParametersBuilder = methodParametersBuilder
                            .WithParameter(
                                apiEndpoint.ToCSharpRequestBodyClassName(endpointPath)!,
                                "data");
                    }
                }
        
                if (apiEndpoint.ResponseBody != null && !isResponsePrimitiveOrArrayOfPrimitive)
                {
                    var partialType = "Partial<" + apiEndpoint.ResponseBody.GetArrayElementTypeOrType().ToCSharpType(_codeGenerationContext) + ">";
                    var funcType = $"Func<{partialType}, {partialType}>?";
                    methodParametersBuilder = methodParametersBuilder
                        .WithParameter(
                            funcType,
                            "partial",
                            CSharpExpression.NullLiteral);
                }
                
                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(CSharpType.CancellationToken.Value,
                        "cancellationToken",
                        CSharpExpression.DefaultLiteral);
        
                builder.Append(
                    indent.Wrap(GenerateMethodDocumentationForEndpoint(apiEndpoint)));
                builder.Append($"{indent}public async Task<");
                builder.Append(apiEndpoint.ResponseBody!.ToCSharpType(_codeGenerationContext));
                builder.Append(">");
                builder.Append($" {methodNameForEndpoint}Async(");
                builder.Append(methodParametersBuilder.BuildMethodParametersList());
                builder.AppendLine(")");
                builder.AppendLine($"{indent}{{");
                
                indent.Increment();
                
                // Generate query string
                var requestParametersBuilder = new QueryStringParameterConversionGenerator("queryParameters", _codeGenerationContext)
                    .WithQueryStringParametersForEndpoint(apiEndpoint);
                
                if (apiEndpoint.ResponseBody != null && !isResponsePrimitiveOrArrayOfPrimitive)
                {
                    var partialType = "Partial<" + apiEndpoint.ResponseBody.GetArrayElementTypeOrType().ToCSharpType(_codeGenerationContext) + ">";
                    
                    requestParametersBuilder = requestParametersBuilder
                        .WithQueryStringParameter("$fields", $"(partial != null ? partial(new {partialType}()) : {partialType}.Default()).ToString()");
                }
                
                builder.AppendLine($"{indent}var {requestParametersBuilder.TargetNameValueCollectionName} = new NameValueCollection();");
                requestParametersBuilder.WriteTo(builder, indent);
                builder.AppendLine($"{indent}");

                // Generate HTTP request
                builder.Append($"{indent}return await _connection.RequestResourceAsync<");
                if (apiEndpoint.RequestBody != null)
                {
                    builder.Append(apiEndpoint.ToCSharpRequestBodyClassName(endpointPath)!);
                    builder.Append(", ");
                }
                builder.Append(apiEndpoint.ResponseBody!.ToCSharpType(_codeGenerationContext));
                builder.Append(">");
                builder.Append("(\"" + apiCallMethod + "\", ");
                builder.Append("$\"api/http/" + endpointPath + "{" + requestParametersBuilder.TargetNameValueCollectionName + ".ToQueryString()}");
                builder.Append("\"");
                
                if (apiEndpoint.RequestBody != null)
                {
                    if (FeatureFlags.DoNotExposeRequestObjects)
                    {
                        builder.Append(", " + ConstructNewRequestObject(indent, apiEndpoint, endpointPath));
                    }
                    else
                    {
                        builder.Append(", data");
                    }
                }
                
                builder.Append(", cancellationToken");
                builder.AppendLine(");");
                indent.Decrement();
                builder.AppendLine($"{indent}}}");
            }
            else
            {
                builder.AppendLine($"{indent}#warning UNSUPPORTED CASE - " + apiEndpoint.ToCSharpMethodName() + " - " + apiEndpoint.Method.ToHttpMethod() + " " + endpointPath);
            }
            
            return builder.ToString();
        }

        private string ConstructNewRequestObject(Indent indent, ApiEndpoint apiEndpoint, string endpointPath)
        {
            var builder = new StringBuilder();

            builder.AppendLine();
            indent.Increment();
            
            builder.AppendLine($"{indent}new {apiEndpoint.ToCSharpRequestBodyClassName(endpointPath)!}");
            builder.AppendLine($"{indent}{{ ");
            indent.Increment();
            
            var typeNameForDto = apiEndpoint.ToCSharpRequestBodyClassName(endpointPath);
            foreach (var field in apiEndpoint.RequestBody!.Fields)
            {
                if (FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes && !(field.Type is ApiFieldType.Enum))
                {
                    builder.AppendLine($"{indent}{field.ToCSharpPropertyName(typeNameForDto)} = {field.ToCSharpVariableInstanceOrDefaultValue(_codeGenerationContext)},");
                }
                else
                {
                    builder.AppendLine($"{indent}{field.ToCSharpPropertyName(typeNameForDto)} = {field.ToCSharpVariableName()},");
                }
            }
            
            indent.Decrement();   
            builder.Append($"{indent}}}");
            
            indent.Decrement();   
            return builder.ToString();
        }

        private string GenerateEnumerableMethodForBatchApiEndpoint(ApiEndpoint apiEndpoint, string baseEndpointPath)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            var endpointPath = (baseEndpointPath + "/" + apiEndpoint.Path.Segments.ToPath()).TrimEnd('/');

            var methodNameForEndpoint = apiEndpoint.ToCSharpMethodName();
            
            var batchDataType = ((ApiFieldType.Object)apiEndpoint.ResponseBody!).GetBatchDataType()!;
            
            if (apiEndpoint.ResponseBody != null)
            {
                var methodParametersBuilder = new MethodParametersBuilder(_codeGenerationContext)
                    .WithParametersForApiParameters(apiEndpoint.Parameters);
                
                if (apiEndpoint.RequestBody != null)
                {
                    if (FeatureFlags.DoNotExposeRequestObjects)
                    {
                        methodParametersBuilder = methodParametersBuilder
                            .WithParametersForApiFields(apiEndpoint.RequestBody.Fields);
                    }
                    else
                    {
                        methodParametersBuilder = methodParametersBuilder
                            .WithParameter(
                                apiEndpoint.ToCSharpRequestBodyClassName(endpointPath)!,
                                "data");
                    }
                }
        
                var partialType = "Partial<" + batchDataType.GetBatchElementTypeOrType().ToCSharpType(_codeGenerationContext) + ">";
                var funcType = $"Func<{partialType}, {partialType}>?";
                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(
                        funcType,
                        "partial",
                        CSharpExpression.NullLiteral);
                
                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(CSharpType.CancellationToken.Value,
                        "cancellationToken",
                        CSharpExpression.DefaultLiteral);

                builder.Append(
                    indent.Wrap(GenerateMethodDocumentationForEndpoint(apiEndpoint)));
                builder.Append($"{indent}public IAsyncEnumerable<");
                builder.Append(batchDataType.ElementType.ToCSharpType(_codeGenerationContext));
                builder.Append(">");
                builder.Append($" {methodNameForEndpoint}AsyncEnumerable(");
                builder.Append(methodParametersBuilder.BuildMethodParametersList());
                builder.AppendLine(")");
                
                indent.Increment();
                builder.Append($"{indent}=> BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => ");
                
                builder.Append($"{methodNameForEndpoint}Async(");

                var partialTypeForBatch = "Partial<Batch<" + batchDataType.GetBatchElementTypeOrType().ToCSharpType(_codeGenerationContext) + ">>";
                builder.Append(
                    methodParametersBuilder
                        .WithDefaultValueForAllParameters(null)
                        .WithDefaultValueForParameter("skip", "batchSkip")
                        .WithDefaultValueForParameter("partial", $"builder => {partialTypeForBatch}.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => {partialType}.Default())")
                        .WithDefaultValueForParameter(CSharpType.CancellationToken.Value, "batchCancellationToken")
                        .BuildMethodCallParameters());
                
                builder.Append("), skip, cancellationToken);");
                indent.Decrement();
            }
            else
            {
                builder.AppendLine($"{indent}#warning UNSUPPORTED CASE - " + apiEndpoint.ToCSharpMethodName() + " - " + apiEndpoint.Method.ToHttpMethod() + " " + endpointPath);
            }

            return builder.ToString();
        }

        private string GenerateMethodDocumentationForEndpoint(ApiEndpoint apiEndpoint)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            // Documentation for method
            if (!string.IsNullOrEmpty(apiEndpoint.Documentation))
            {
                builder.Append(
                    indent.Wrap(
                        apiEndpoint.Documentation.ToCSharpDocumentationComment()));
            }

            // Remarks (required permissions)
            if (apiEndpoint.Rights != null && apiEndpoint.Rights.Count > 0)
            {
                builder.AppendLine($"{indent}/// <remarks>");
                builder.AppendLine($"{indent}/// Required permissions:");
                builder.AppendLine($"{indent}/// <list type=\"bullet\">");
                foreach (var apiRight in apiEndpoint.Rights)
                {
                    builder.AppendLine($"{indent}/// <item>");
                    builder.AppendLine($"{indent}/// <term>{apiRight.Title}</term>");
                    if (!string.IsNullOrEmpty(apiRight.Description))
                    {
                        builder.AppendLine($"{indent}/// <description>{apiRight.Description}</description>");
                    }
                    builder.AppendLine($"{indent}/// </item>");
                }
                builder.AppendLine($"{indent}/// </list>");
                builder.AppendLine($"{indent}/// </remarks>");
            }
            
            // Attributes
            if (apiEndpoint.Deprecation != null)
            {
                builder.AppendLine(apiEndpoint.Deprecation.ToCSharpDeprecation());
            }

            return builder.ToString();
        }
    }
}