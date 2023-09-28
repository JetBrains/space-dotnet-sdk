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

public sealed class CodeAnalysisCompletedFeedEvent
     : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "CodeAnalysisCompletedFeedEvent";
    
    public CodeAnalysisCompletedFeedEvent() { }
    
    public CodeAnalysisCompletedFeedEvent(ProjectKey projectKey, int reviewNumber, string revision, string revisionLink, string toolName, List<MergeRequestCodeIssueStatsForLevel> issuesCountByLevel)
    {
        ProjectKey = projectKey;
        ReviewNumber = reviewNumber;
        Revision = revision;
        RevisionLink = revisionLink;
        ToolName = toolName;
        IssuesCountByLevel = issuesCountByLevel;
    }
    
    private PropertyValue<ProjectKey> _projectKey = new PropertyValue<ProjectKey>(nameof(CodeAnalysisCompletedFeedEvent), nameof(ProjectKey), "projectKey");
    
    [Required]
    [JsonPropertyName("projectKey")]
    public ProjectKey ProjectKey
    {
        get => _projectKey.GetValue(InlineErrors);
        set => _projectKey.SetValue(value);
    }

    private PropertyValue<int> _reviewNumber = new PropertyValue<int>(nameof(CodeAnalysisCompletedFeedEvent), nameof(ReviewNumber), "reviewNumber");
    
    [Required]
    [JsonPropertyName("reviewNumber")]
    public int ReviewNumber
    {
        get => _reviewNumber.GetValue(InlineErrors);
        set => _reviewNumber.SetValue(value);
    }

    private PropertyValue<string> _revision = new PropertyValue<string>(nameof(CodeAnalysisCompletedFeedEvent), nameof(Revision), "revision");
    
    [Required]
    [JsonPropertyName("revision")]
    public string Revision
    {
        get => _revision.GetValue(InlineErrors);
        set => _revision.SetValue(value);
    }

    private PropertyValue<string> _revisionLink = new PropertyValue<string>(nameof(CodeAnalysisCompletedFeedEvent), nameof(RevisionLink), "revisionLink");
    
    [Required]
    [JsonPropertyName("revisionLink")]
    public string RevisionLink
    {
        get => _revisionLink.GetValue(InlineErrors);
        set => _revisionLink.SetValue(value);
    }

    private PropertyValue<string> _toolName = new PropertyValue<string>(nameof(CodeAnalysisCompletedFeedEvent), nameof(ToolName), "toolName");
    
    [Required]
    [JsonPropertyName("toolName")]
    public string ToolName
    {
        get => _toolName.GetValue(InlineErrors);
        set => _toolName.SetValue(value);
    }

    private PropertyValue<List<MergeRequestCodeIssueStatsForLevel>> _issuesCountByLevel = new PropertyValue<List<MergeRequestCodeIssueStatsForLevel>>(nameof(CodeAnalysisCompletedFeedEvent), nameof(IssuesCountByLevel), "issuesCountByLevel", new List<MergeRequestCodeIssueStatsForLevel>());
    
    [Required]
    [JsonPropertyName("issuesCountByLevel")]
    public List<MergeRequestCodeIssueStatsForLevel> IssuesCountByLevel
    {
        get => _issuesCountByLevel.GetValue(InlineErrors);
        set => _issuesCountByLevel.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _projectKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviewNumber.SetAccessPath(parentChainPath, validateHasBeenSet);
        _revision.SetAccessPath(parentChainPath, validateHasBeenSet);
        _revisionLink.SetAccessPath(parentChainPath, validateHasBeenSet);
        _toolName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issuesCountByLevel.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
