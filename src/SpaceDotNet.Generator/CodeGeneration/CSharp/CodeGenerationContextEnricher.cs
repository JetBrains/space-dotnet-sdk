using System.Collections.Generic;
using System.Linq;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    public static class CodeGenerationContextEnricher
    {
        public static void EnrichDtosWithRequestBodyTypes(CodeGenerationContext context) => 
            EnrichDtosWithRequestBodyTypes(context, context.ApiModel.Resources, string.Empty);

        private static void EnrichDtosWithRequestBodyTypes(CodeGenerationContext context, IEnumerable<ApiResource> resources, string parentResourcePath)
        {
            foreach (var apiResource in resources)
            {
                var resourcePath = (parentResourcePath.Length > 0 
                    ? parentResourcePath + "/" + apiResource.Path.Segments.ToPath() 
                    : apiResource.Path.Segments.ToPath()).TrimEnd('/');
                
                foreach (var apiEndpoint in apiResource.Endpoints)
                {
                    if (apiEndpoint.RequestBody != null && apiEndpoint.RequestBody.Kind == ApiFieldType.Object.ObjectKind.REQUEST_BODY)
                    {
                        // Endpoint path
                        var endpointPath = (resourcePath + "/" + apiEndpoint.Path.Segments.ToPath()).TrimEnd('/');
                        
                        // Expected class name
                        var typeNameForRequestBody = apiEndpoint.ToCSharpRequestBodyClassName(endpointPath)!;
                        var classIdForRequestBody = typeNameForRequestBody.ToLowerInvariant();
                        
                        // See if we have seen the anonymous class before (and if not, add it)
                        if (!context.TryGetDto(classIdForRequestBody, out var requestBodyClass))
                        {
                            requestBodyClass = new ApiDto
                            {
                                Id = classIdForRequestBody,
                                Name = typeNameForRequestBody,
                                Fields = apiEndpoint.RequestBody.Fields.Select(it => new ApiDtoField { Field = it }).ToList()
                            };
        
                            context.AddDto(classIdForRequestBody, requestBodyClass);
                        }
                    }
                }

                EnrichDtosWithRequestBodyTypes(context, apiResource.NestedResources, resourcePath);
            }
        }
    }
}