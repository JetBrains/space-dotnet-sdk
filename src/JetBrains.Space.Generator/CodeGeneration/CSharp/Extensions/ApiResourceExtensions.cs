using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiResourceExtensions
    {
        public static string ToCSharpIdentifierSingular(this ApiResource subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.DisplaySingular);
        
        public static string ToCSharpIdentifierPlural(this ApiResource subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.DisplayPlural);
    }
}