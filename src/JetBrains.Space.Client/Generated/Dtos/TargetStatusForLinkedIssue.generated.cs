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

public sealed class TargetStatusForLinkedIssue
     : IPropagatePropertyAccessPath
{
    public TargetStatusForLinkedIssue() { }
    
    public TargetStatusForLinkedIssue(string issueId, string? issueStatusId = null, bool? isExternalIssue = null)
    {
        IssueId = issueId;
        IssueStatusId = issueStatusId;
        IsExternalIssue = isExternalIssue;
    }
    
    private PropertyValue<string> _issueId = new PropertyValue<string>(nameof(TargetStatusForLinkedIssue), nameof(IssueId), "issueId");
    
    [Required]
    [JsonPropertyName("issueId")]
    public string IssueId
    {
        get => _issueId.GetValue(InlineErrors);
        set => _issueId.SetValue(value);
    }

    private PropertyValue<string?> _issueStatusId = new PropertyValue<string?>(nameof(TargetStatusForLinkedIssue), nameof(IssueStatusId), "issueStatusId");
    
    [JsonPropertyName("issueStatusId")]
    public string? IssueStatusId
    {
        get => _issueStatusId.GetValue(InlineErrors);
        set => _issueStatusId.SetValue(value);
    }

    private PropertyValue<bool?> _isExternalIssue = new PropertyValue<bool?>(nameof(TargetStatusForLinkedIssue), nameof(IsExternalIssue), "isExternalIssue");
    
    [JsonPropertyName("isExternalIssue")]
    public bool? IsExternalIssue
    {
        get => _isExternalIssue.GetValue(InlineErrors);
        set => _isExternalIssue.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _issueId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueStatusId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _isExternalIssue.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

