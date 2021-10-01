using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

public static class ApiEnumExtensions
{
    public static string ToCSharpClassName(this ApiEnum subject)
        => CSharpIdentifier.ForClassOrNamespace(subject.Name);
}