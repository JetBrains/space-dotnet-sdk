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

public sealed class ExternalIssueTrackerUiExtensionIn
     : AppUiExtensionIn, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ExternalIssueTrackerUiExtensionIn";
    
    public ExternalIssueTrackerUiExtensionIn() { }
    
    public ExternalIssueTrackerUiExtensionIn(string domain, string trackerName, bool canCreateIssues)
    {
        Domain = domain;
        TrackerName = trackerName;
        CanCreateIssues = canCreateIssues;
    }
    
    private PropertyValue<string> _domain = new PropertyValue<string>(nameof(ExternalIssueTrackerUiExtensionIn), nameof(Domain), "domain");
    
    [Required]
    [JsonPropertyName("domain")]
    public string Domain
    {
        get => _domain.GetValue(InlineErrors);
        set => _domain.SetValue(value);
    }

    private PropertyValue<string> _trackerName = new PropertyValue<string>(nameof(ExternalIssueTrackerUiExtensionIn), nameof(TrackerName), "trackerName");
    
    [Required]
    [JsonPropertyName("trackerName")]
    public string TrackerName
    {
        get => _trackerName.GetValue(InlineErrors);
        set => _trackerName.SetValue(value);
    }

    private PropertyValue<bool> _canCreateIssues = new PropertyValue<bool>(nameof(ExternalIssueTrackerUiExtensionIn), nameof(CanCreateIssues), "canCreateIssues");
    
    [Required]
    [JsonPropertyName("canCreateIssues")]
    public bool CanCreateIssues
    {
        get => _canCreateIssues.GetValue(InlineErrors);
        set => _canCreateIssues.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _domain.SetAccessPath(parentChainPath, validateHasBeenSet);
        _trackerName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _canCreateIssues.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

