using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiEndpointExtensions
    {
        public static string ToCSharpMethodName(this ApiEndpoint subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.DisplayName);
    }
}