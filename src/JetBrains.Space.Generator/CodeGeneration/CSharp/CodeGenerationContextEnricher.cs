using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp;

public static class CodeGenerationContextEnricher
{
    /// <summary>
    /// Add resource request body types to DTO collection, so they can be resolved as such.
    /// </summary>
    public static void AddRequestBodyTypesToDtos(CodeGenerationContext context) => 
        AddRequestBodyTypesToDtos(context, context.ApiModel.Resources, string.Empty);

    private static void AddRequestBodyTypesToDtos(CodeGenerationContext context, IEnumerable<ApiResource> resources, string parentResourcePath)
    {
        foreach (var apiResource in resources)
        {
            var resourcePath = (parentResourcePath.Length > 0 
                ? parentResourcePath + "/" + apiResource.Path.Segments.ToPath() 
                : apiResource.Path.Segments.ToPath()).TrimEnd('/');
                
            foreach (var apiEndpoint in apiResource.Endpoints)
            {
                if (apiEndpoint.RequestBody is { Kind: ApiFieldType.Object.ObjectKind.REQUEST_BODY })
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

            AddRequestBodyTypesToDtos(context, apiResource.NestedResources, resourcePath);
        }
    }
        
    /// <summary>
    /// Remove DTO fields that should be ignored.
    /// </summary>
    public static void RemoveDtoFieldsToIgnore(CodeGenerationContext context)
    {
        // ReSharper disable once CollectionNeverUpdated.Local
        var fieldsToIgnore = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase)
        {
            // Example:
            // { "TD_MemberProfile", 
            //    new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "logins" } }
        };
            
        // Remove fields to ignore
        foreach (var apiDto in context.GetDtos())
        {
            if (fieldsToIgnore.TryGetValue(apiDto.Name, out var ignoreFields))
            {
                apiDto.Fields.RemoveAll(it => ignoreFields.Contains(it.Field.Name));
            }
        }
    }
        
    /// <summary>
    /// Remove "DTO" from DTO names, e.g. DTO_Meeting, DTO_Right, ...
    /// </summary>
    public static void RemoveDtoPrefixFromDtoNames(CodeGenerationContext context)
    {
        foreach (var apiDto in context.GetDtos().Where(it => it.Name.Length > 3))
        {
            if (apiDto.Name.StartsWith("DTO", StringComparison.OrdinalIgnoreCase))
            {
                apiDto.Name = apiDto.Name[3..];
            }
        }
    }
}