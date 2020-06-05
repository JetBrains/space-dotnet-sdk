using System.Collections.Generic;
using System.Linq;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    // TODO REFACTOR rename to proper use once context flows
    public class CSharpApiEndpointDtoEnricher
    {
        public void Enrich(CodeGenerationContext context)
        {
            foreach (var apiResource in context.ApiModel.Resources)
            {
                foreach (var apiEndpoint in apiResource.Endpoints)
                {
                    if (apiEndpoint.RequestBody != null && apiEndpoint.RequestBody.Kind == ApiFieldType.Object.ObjectKind.REQUEST_BODY)
                    {
                        // Expected class name
                        var typeNameForRequestBody = apiEndpoint.ToCSharpRequestBodyClassName()!;
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

                Enrich(context);
            }
        }
    }
}