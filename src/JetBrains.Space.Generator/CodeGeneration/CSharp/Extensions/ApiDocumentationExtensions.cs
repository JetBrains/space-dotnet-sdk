using System.IO;
using System.Text;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiDocumentationExtensions
    {
        public static string ToCSharpDocumentationComment(this string subject)
        {
            var builder = new StringBuilder();
            builder.AppendLine("/// <summary>");
            
            var reader = new StringReader(subject);
            var line = reader.ReadLine();
            while (line != null)
            {
                builder.AppendLine("/// " + line);
                line = reader.ReadLine();
            }
            
            builder.AppendLine("/// </summary>");
            return builder.ToString();
        }
    }
}