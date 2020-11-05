using System.Text;
using JetBrains.Space.Common.Utilities;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiDeprecationExtensions 
    {
        public static string ToCSharpDeprecation(this ApiDeprecation subject)
        {
            var builder = new StringBuilder();
            builder.Append("[Obsolete(\"");
            if (!string.IsNullOrEmpty(subject.Message))
            {
                builder.Append(subject.Message.ToUppercaseFirst());
            }
            else
            {
                builder.Append("This is obsolete");
            }
            if (!string.IsNullOrEmpty(subject.Since))
            {
                builder.Append(" (since " + subject.Since + ")");
            }
            if (subject.ForRemoval)
            {
                builder.Append(" (marked for removal)");
            }
            builder.Append("\")]");
            return builder.ToString();
        }
    }
}