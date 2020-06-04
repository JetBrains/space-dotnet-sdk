using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiEnumExtensions
    {
        public static string ToCSharpClassName(this ApiEnum subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.Name);
    }
}