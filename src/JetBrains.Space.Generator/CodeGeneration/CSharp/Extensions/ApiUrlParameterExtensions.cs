using System;
using System.Linq;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiUrlParameterExtensions
    {
        public static string ToCSharpClassName(this ApiUrlParameter subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.Name);
    }
    
    public static class ApiUrlParameterOptionExtensions
    {
        public static string ToCSharpClassName(this ApiUrlParameterOption subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.OptionName);
        
        public static string ToCSharpClassNameShort(this ApiUrlParameterOption subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.OptionName.Split('.', StringSplitOptions.RemoveEmptyEntries).Last());
    }
}