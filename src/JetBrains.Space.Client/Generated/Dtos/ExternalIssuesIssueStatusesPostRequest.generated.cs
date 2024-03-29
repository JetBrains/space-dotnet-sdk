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

internal class ExternalIssuesIssueStatusesPostRequest
     : IPropagatePropertyAccessPath
{
    public ExternalIssuesIssueStatusesPostRequest() { }
    
    public ExternalIssuesIssueStatusesPostRequest(string issuePrefix, List<ExternalIssueStatusIn> statuses)
    {
        IssuePrefix = issuePrefix;
        Statuses = statuses;
    }
    
    private PropertyValue<string> _issuePrefix = new PropertyValue<string>(nameof(ExternalIssuesIssueStatusesPostRequest), nameof(IssuePrefix), "issuePrefix");
    
    [Required]
    [JsonPropertyName("issuePrefix")]
    public string IssuePrefix
    {
        get => _issuePrefix.GetValue(InlineErrors);
        set => _issuePrefix.SetValue(value);
    }

    private PropertyValue<List<ExternalIssueStatusIn>> _statuses = new PropertyValue<List<ExternalIssueStatusIn>>(nameof(ExternalIssuesIssueStatusesPostRequest), nameof(Statuses), "statuses", new List<ExternalIssueStatusIn>());
    
    [Required]
    [JsonPropertyName("statuses")]
    public List<ExternalIssueStatusIn> Statuses
    {
        get => _statuses.GetValue(InlineErrors);
        set => _statuses.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _issuePrefix.SetAccessPath(parentChainPath, validateHasBeenSet);
        _statuses.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

