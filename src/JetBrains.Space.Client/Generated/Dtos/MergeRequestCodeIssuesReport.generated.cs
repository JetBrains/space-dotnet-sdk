// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class MergeRequestCodeIssuesReport
     : IPropagatePropertyAccessPath
{
    public MergeRequestCodeIssuesReport() { }
    
    public MergeRequestCodeIssuesReport(string tool, DateTime createdAt, string commitId, bool runInProgress, List<MergeRequestCodeIssueStatsForLevel>? issuesCountByLevel = null)
    {
        Tool = tool;
        CreatedAt = createdAt;
        CommitId = commitId;
        IsRunInProgress = runInProgress;
        IssuesCountByLevel = issuesCountByLevel;
    }
    
    private PropertyValue<string> _tool = new PropertyValue<string>(nameof(MergeRequestCodeIssuesReport), nameof(Tool), "tool");
    
    [Required]
    [JsonPropertyName("tool")]
    public string Tool
    {
        get => _tool.GetValue(InlineErrors);
        set => _tool.SetValue(value);
    }

    private PropertyValue<DateTime> _createdAt = new PropertyValue<DateTime>(nameof(MergeRequestCodeIssuesReport), nameof(CreatedAt), "createdAt");
    
    [Required]
    [JsonPropertyName("createdAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime CreatedAt
    {
        get => _createdAt.GetValue(InlineErrors);
        set => _createdAt.SetValue(value);
    }

    private PropertyValue<string> _commitId = new PropertyValue<string>(nameof(MergeRequestCodeIssuesReport), nameof(CommitId), "commitId");
    
    [Required]
    [JsonPropertyName("commitId")]
    public string CommitId
    {
        get => _commitId.GetValue(InlineErrors);
        set => _commitId.SetValue(value);
    }

    private PropertyValue<bool> _runInProgress = new PropertyValue<bool>(nameof(MergeRequestCodeIssuesReport), nameof(IsRunInProgress), "runInProgress");
    
    [Required]
    [JsonPropertyName("runInProgress")]
    public bool IsRunInProgress
    {
        get => _runInProgress.GetValue(InlineErrors);
        set => _runInProgress.SetValue(value);
    }

    private PropertyValue<List<MergeRequestCodeIssueStatsForLevel>?> _issuesCountByLevel = new PropertyValue<List<MergeRequestCodeIssueStatsForLevel>?>(nameof(MergeRequestCodeIssuesReport), nameof(IssuesCountByLevel), "issuesCountByLevel");
    
    [JsonPropertyName("issuesCountByLevel")]
    public List<MergeRequestCodeIssueStatsForLevel>? IssuesCountByLevel
    {
        get => _issuesCountByLevel.GetValue(InlineErrors);
        set => _issuesCountByLevel.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _tool.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _runInProgress.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issuesCountByLevel.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

