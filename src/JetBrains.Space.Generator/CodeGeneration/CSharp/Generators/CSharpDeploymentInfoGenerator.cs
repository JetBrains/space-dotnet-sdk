using System;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;

public class CSharpDeploymentInfoGenerator
{
    public string GenerateSdkInfo(DeploymentInfo deploymentInfo)
    {
        var indent = new Indent();
        var builder = new CSharpBuilder();

        var typeNameForSdkInfo = "SdkInfo";
        
        builder.AppendLine($"{indent}public static class {typeNameForSdkInfo}");
        builder.AppendLine($"{indent}{{");
        indent.Increment();

        if (string.IsNullOrEmpty(deploymentInfo.Version))
        {
            throw new NotSupportedException($"Deployment information does not contain a value for {nameof(DeploymentInfo.Version)}");
        }
        
        builder.AppendLine($"{indent}/// <summary>");
        builder.AppendLine($"{indent}/// Version of the JetBrains Space SDK for .NET.");
        builder.AppendLine($"{indent}/// </summary>");
        builder.AppendLine($"{indent}/// <remarks>");
        builder.AppendLine($"{indent}/// The version is derived from the deployed Space organization that was used to generate the SDK.");
        builder.AppendLine($"{indent}/// </remarks>");
        builder.AppendLine($"{indent}public const string Version = \"{deploymentInfo.Version.Trim()}\";");
            
        indent.Decrement();
        builder.AppendLine($"{indent}}}");
        return builder.ToString();
    }
}
