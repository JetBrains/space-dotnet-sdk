using System.Collections.Generic;
using System.Linq;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    // TODO REFACTOR rename to proper use once context flows
    public class CSharpApiEndpointDtoEnricher
    {
        public void Enrich(CodeGenerationContext context, IEnumerable<ApiResource> apiResources)
        {
            foreach (var apiResource in apiResources)
            {
                foreach (var apiEndpoint in apiResource.Endpoints)
                {
                    if (apiEndpoint.RequestBody != null && apiEndpoint.RequestBody.Kind == ApiFieldType.Object.ObjectKind.REQUEST_BODY)
                    {
                        // Expected class name
                        var typeNameForRequestBody = apiEndpoint.ToCSharpRequestBodyClassName()!;
                        var classIdForRequestBody = typeNameForRequestBody.ToLowerInvariant();
                        
                        // See if we have seen the anonymous class before (and if not, add it)
                        if (!context.IdToDtoMap.TryGetValue(classIdForRequestBody, out var requestBodyClass))
                        {
                            requestBodyClass = new ApiDto
                            {
                                Id = typeNameForRequestBody.ToLowerInvariant(),
                                Name = typeNameForRequestBody,
                                Fields = apiEndpoint.RequestBody.Fields.Select(it => new ApiDtoField { Field = it }).ToList()
                            };
        
                            context.IdToDtoMap[classIdForRequestBody] = requestBodyClass;
                        }
                    }
                }

                Enrich(context, apiResource.NestedResources);
            }
        }
    }
}