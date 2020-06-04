using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiDtoExtensions
    {
        public static string ToCSharpClassName(this ApiDto subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.Name) + "Dto";
    }
}