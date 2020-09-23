using System.Text;
using SpaceDotNet.Common.Utilities;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions
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