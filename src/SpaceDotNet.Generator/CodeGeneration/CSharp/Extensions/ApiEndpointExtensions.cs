using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiEndpointExtensions
    {
        public static string ToCSharpMethodName(this ApiEndpoint subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.DisplayName);
        
        public static string? ToCSharpRequestBodyClassName(this ApiEndpoint subject, string endpointPath)
        {
            if (subject.RequestBody == null || 
                subject.RequestBody.Kind != ApiFieldType.Object.ObjectKind.REQUEST_BODY) return null;
            
            return CSharpIdentifier.ForClassOrNamespace(endpointPath) + "Request";
        }
    }
}