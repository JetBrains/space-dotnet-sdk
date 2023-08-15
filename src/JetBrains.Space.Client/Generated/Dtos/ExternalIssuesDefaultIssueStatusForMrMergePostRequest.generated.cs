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

internal class ExternalIssuesDefaultIssueStatusForMrMergePostRequest
     : IPropagatePropertyAccessPath
{
    public ExternalIssuesDefaultIssueStatusForMrMergePostRequest() { }
    
    public ExternalIssuesDefaultIssueStatusForMrMergePostRequest(ApplicationIdentifier application, ProjectIdentifier project, string issuePrefix, string? targetStatusForMergeRequestMerge = null)
    {
        Application = application;
        Project = project;
        IssuePrefix = issuePrefix;
        TargetStatusForMergeRequestMerge = targetStatusForMergeRequestMerge;
    }
    
    private PropertyValue<ApplicationIdentifier> _application = new PropertyValue<ApplicationIdentifier>(nameof(ExternalIssuesDefaultIssueStatusForMrMergePostRequest), nameof(Application), "application");
    
    [Required]
    [JsonPropertyName("application")]
    public ApplicationIdentifier Application
    {
        get => _application.GetValue(InlineErrors);
        set => _application.SetValue(value);
    }

    private PropertyValue<ProjectIdentifier> _project = new PropertyValue<ProjectIdentifier>(nameof(ExternalIssuesDefaultIssueStatusForMrMergePostRequest), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public ProjectIdentifier Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _issuePrefix = new PropertyValue<string>(nameof(ExternalIssuesDefaultIssueStatusForMrMergePostRequest), nameof(IssuePrefix), "issuePrefix");
    
    [Required]
    [JsonPropertyName("issuePrefix")]
    public string IssuePrefix
    {
        get => _issuePrefix.GetValue(InlineErrors);
        set => _issuePrefix.SetValue(value);
    }

    private PropertyValue<string?> _targetStatusForMergeRequestMerge = new PropertyValue<string?>(nameof(ExternalIssuesDefaultIssueStatusForMrMergePostRequest), nameof(TargetStatusForMergeRequestMerge), "targetStatusForMergeRequestMerge");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("targetStatusForMergeRequestMerge")]
    public string? TargetStatusForMergeRequestMerge
    {
        get => _targetStatusForMergeRequestMerge.GetValue(InlineErrors);
        set => _targetStatusForMergeRequestMerge.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _application.SetAccessPath(parentChainPath, validateHasBeenSet);
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issuePrefix.SetAccessPath(parentChainPath, validateHasBeenSet);
        _targetStatusForMergeRequestMerge.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
