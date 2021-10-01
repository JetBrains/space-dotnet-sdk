#nullable enable

using System;
using System.Text;

namespace JetBrains.Space.Generator;

internal class DeploymentInfo
{
    public string? Version { get; set; }
    public DateTimeOffset? BuildDate { get; set; }
    public string? CommitHash { get; set; }
    public string? Branch { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();

        if (Version != null) builder.AppendLine($"Version: {Version}");
        if (BuildDate != null) builder.AppendLine($"Build date: {BuildDate.Value:o}");
        if (CommitHash != null) builder.AppendLine($"Commit: {CommitHash}");
        if (Branch != null) builder.AppendLine($"Branch: {Branch}");

        return builder.ToString();
    }
}