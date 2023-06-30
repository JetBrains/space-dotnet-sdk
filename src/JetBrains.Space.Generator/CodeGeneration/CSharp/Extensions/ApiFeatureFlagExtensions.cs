using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

public static class ApiFeatureFlagExtensions 
{
    public static string ToCSharpFeatureFlag(this ApiFeatureFlag subject)
    {
        var builder = new CSharpBuilder();
        builder.AppendLine($"#if NET6_0_OR_GREATER");
        
        builder.Append("[Obsolete(\"");
        builder.Append($"This declaration is related to an experimental feature \\\"{subject.DisplayName}\\\". " +
                       "It may be disabled for your organization. Please contact JetBrains support if you " +
                       "would like to enable the feature for your organization.");
        builder.AppendLine("\", DiagnosticId = \"SPC002\")]");
        
        builder.AppendLine($"#else");
        
        builder.Append("[Obsolete(\"");
        builder.Append($"This declaration is related to an experimental feature \\\"{subject.DisplayName}\\\". " +
                       "It may be disabled for your organization. Please contact JetBrains support if you " +
                       "would like to enable the feature for your organization.");
        builder.AppendLine("\")]");
        
        builder.AppendLine($"#endif");
        
        return builder.ToString();
    }
}