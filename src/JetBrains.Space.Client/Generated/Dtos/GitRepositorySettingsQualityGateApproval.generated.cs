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

public sealed class GitRepositorySettingsQualityGateApproval
     : IPropagatePropertyAccessPath
{
    public GitRepositorySettingsQualityGateApproval() { }
    
    public GitRepositorySettingsQualityGateApproval(int minApprovals, List<string> approvedBy)
    {
        MinApprovals = minApprovals;
        ApprovedBy = approvedBy;
    }
    
    private PropertyValue<int> _minApprovals = new PropertyValue<int>(nameof(GitRepositorySettingsQualityGateApproval), nameof(MinApprovals), "minApprovals");
    
    [Required]
    [JsonPropertyName("minApprovals")]
    public int MinApprovals
    {
        get => _minApprovals.GetValue(InlineErrors);
        set => _minApprovals.SetValue(value);
    }

    private PropertyValue<List<string>> _approvedBy = new PropertyValue<List<string>>(nameof(GitRepositorySettingsQualityGateApproval), nameof(ApprovedBy), "approvedBy", new List<string>());
    
    [Required]
    [JsonPropertyName("approvedBy")]
    public List<string> ApprovedBy
    {
        get => _approvedBy.GetValue(InlineErrors);
        set => _approvedBy.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _minApprovals.SetAccessPath(parentChainPath, validateHasBeenSet);
        _approvedBy.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

