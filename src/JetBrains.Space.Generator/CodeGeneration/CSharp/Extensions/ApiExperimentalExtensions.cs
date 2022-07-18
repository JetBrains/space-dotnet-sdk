using System.IO;
using System.Text;
using JetBrains.Space.Common.Utilities;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

public static class ApiExperimentalExtensions 
{
    public static string ToCSharpExperimental(this ApiExperimental subject)
    {
        var builder = new StringBuilder();
        builder.AppendLine($"#if NET6_0_OR_GREATER");
        
        builder.Append("[Obsolete(\"");
        if (!string.IsNullOrEmpty(subject.Message))
        {
            builder.Append(subject.Message.ToUppercaseFirst());
        }
        else
        {
            builder.Append("Usage of an experimental API");
        }
        builder.AppendLine("\", DiagnosticId = \"SPC001\")]");
        
        builder.AppendLine($"#else");
        
        builder.Append("[Obsolete(\"");
        if (!string.IsNullOrEmpty(subject.Message))
        {
            builder.Append(subject.Message.ToUppercaseFirst());
        }
        else
        {
            builder.Append("Usage of an experimental API");
        }
        builder.AppendLine("\")]");
        
        builder.AppendLine($"#endif");
        
        return builder.ToString();
    }
    
    public static string ToCSharpDocumentation(this ApiExperimental subject)
    {
        return ToCSharpDocumentationElement(subject, "<remarks>", "</remarks>");
    }
    
    private static string ToCSharpDocumentationElement(this ApiExperimental subject, string startElement, string endElement)
    {
        var builder = new StringBuilder();
        builder.AppendLine($"/// {startElement}");
        
        var reader = new StringReader(subject.Message ?? "This is an experimental API.");
        var line = reader.ReadLine();
        while (line != null)
        {
            builder.AppendLine("/// " + line
                .Replace("<", "&lt;")
                .Replace(">", "&gt;"));
            
            line = reader.ReadLine();
        }
            
        builder.AppendLine($"/// {endElement}");
        return builder.ToString();
    }
}