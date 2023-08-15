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

public sealed class ContactExtraTag
     : IPropagatePropertyAccessPath
{
    public ContactExtraTag() { }
    
    public ContactExtraTag(string primary, string secondary, string? issueStatus = null, string? issueStatusColor = null, string? issueStatusId = null, int? issueNumber = null, string? issueTitle = null, ProjectKey? projectKey = null, string? projectName = null, string? projectId = null, CPrincipal? assignee = null)
    {
        Primary = primary;
        Secondary = secondary;
        IssueStatus = issueStatus;
        IssueStatusColor = issueStatusColor;
        IssueStatusId = issueStatusId;
        IssueNumber = issueNumber;
        IssueTitle = issueTitle;
        ProjectKey = projectKey;
        ProjectName = projectName;
        ProjectId = projectId;
        Assignee = assignee;
    }
    
    private PropertyValue<string> _primary = new PropertyValue<string>(nameof(ContactExtraTag), nameof(Primary), "primary");
    
    [Required]
    [JsonPropertyName("primary")]
    public string Primary
    {
        get => _primary.GetValue(InlineErrors);
        set => _primary.SetValue(value);
    }

    private PropertyValue<string> _secondary = new PropertyValue<string>(nameof(ContactExtraTag), nameof(Secondary), "secondary");
    
    [Required]
    [JsonPropertyName("secondary")]
    public string Secondary
    {
        get => _secondary.GetValue(InlineErrors);
        set => _secondary.SetValue(value);
    }

    private PropertyValue<string?> _issueStatus = new PropertyValue<string?>(nameof(ContactExtraTag), nameof(IssueStatus), "issueStatus");
    
    [JsonPropertyName("issueStatus")]
    public string? IssueStatus
    {
        get => _issueStatus.GetValue(InlineErrors);
        set => _issueStatus.SetValue(value);
    }

    private PropertyValue<string?> _issueStatusColor = new PropertyValue<string?>(nameof(ContactExtraTag), nameof(IssueStatusColor), "issueStatusColor");
    
    [JsonPropertyName("issueStatusColor")]
    public string? IssueStatusColor
    {
        get => _issueStatusColor.GetValue(InlineErrors);
        set => _issueStatusColor.SetValue(value);
    }

    private PropertyValue<string?> _issueStatusId = new PropertyValue<string?>(nameof(ContactExtraTag), nameof(IssueStatusId), "issueStatusId");
    
    [JsonPropertyName("issueStatusId")]
    public string? IssueStatusId
    {
        get => _issueStatusId.GetValue(InlineErrors);
        set => _issueStatusId.SetValue(value);
    }

    private PropertyValue<int?> _issueNumber = new PropertyValue<int?>(nameof(ContactExtraTag), nameof(IssueNumber), "issueNumber");
    
    [JsonPropertyName("issueNumber")]
    public int? IssueNumber
    {
        get => _issueNumber.GetValue(InlineErrors);
        set => _issueNumber.SetValue(value);
    }

    private PropertyValue<string?> _issueTitle = new PropertyValue<string?>(nameof(ContactExtraTag), nameof(IssueTitle), "issueTitle");
    
    [JsonPropertyName("issueTitle")]
    public string? IssueTitle
    {
        get => _issueTitle.GetValue(InlineErrors);
        set => _issueTitle.SetValue(value);
    }

    private PropertyValue<ProjectKey?> _projectKey = new PropertyValue<ProjectKey?>(nameof(ContactExtraTag), nameof(ProjectKey), "projectKey");
    
    [JsonPropertyName("projectKey")]
    public ProjectKey? ProjectKey
    {
        get => _projectKey.GetValue(InlineErrors);
        set => _projectKey.SetValue(value);
    }

    private PropertyValue<string?> _projectName = new PropertyValue<string?>(nameof(ContactExtraTag), nameof(ProjectName), "projectName");
    
    [JsonPropertyName("projectName")]
    public string? ProjectName
    {
        get => _projectName.GetValue(InlineErrors);
        set => _projectName.SetValue(value);
    }

    private PropertyValue<string?> _projectId = new PropertyValue<string?>(nameof(ContactExtraTag), nameof(ProjectId), "projectId");
    
    [JsonPropertyName("projectId")]
    public string? ProjectId
    {
        get => _projectId.GetValue(InlineErrors);
        set => _projectId.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _assignee = new PropertyValue<CPrincipal?>(nameof(ContactExtraTag), nameof(Assignee), "assignee");
    
    [JsonPropertyName("assignee")]
    public CPrincipal? Assignee
    {
        get => _assignee.GetValue(InlineErrors);
        set => _assignee.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _primary.SetAccessPath(parentChainPath, validateHasBeenSet);
        _secondary.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueStatus.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueStatusColor.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueStatusId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueNumber.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueTitle.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _assignee.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

