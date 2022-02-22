using JetBrains.Space.Common.Utilities;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

public static class ApiEndpointExtensions
{
    private const string RequestBodyClassNameSuffix = "Request";
    
    public static string ToCSharpMethodName(this ApiEndpoint subject) => 
        CSharpIdentifier.ForClassOrNamespace(subject.FunctionName ?? subject.DisplayName);

    public static string? ToCSharpRequestBodyClassName(this ApiEndpoint subject, string endpointPath)
    {
        if (subject.RequestBody is not { Kind: ApiFieldType.Object.ObjectKind.REQUEST_BODY }) return null;
            
        return CSharpIdentifier.ForClassOrNamespace(endpointPath)
               + subject.Method.ToHttpMethod().ToLowerInvariant().ToUppercaseFirst()
               + RequestBodyClassNameSuffix;
    }
}