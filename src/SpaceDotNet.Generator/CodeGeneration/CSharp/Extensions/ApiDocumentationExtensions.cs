using System.Text;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiDocumentationExtensions
    {
        public static string ToCSharpDocumentationComment(this string subject)
        {
            var builder = new StringBuilder();
            builder.AppendLine("/// <summary>");
            builder.AppendLine("/// " + subject);
            builder.AppendLine("/// </summary>");
            return builder.ToString();
        }
    }
}