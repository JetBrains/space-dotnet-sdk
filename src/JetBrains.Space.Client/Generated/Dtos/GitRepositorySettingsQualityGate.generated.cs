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

public sealed class GitRepositorySettingsQualityGate
     : IPropagatePropertyAccessPath
{
    public GitRepositorySettingsQualityGate() { }
    
    public GitRepositorySettingsQualityGate(List<string>? allowMergeFor = null, List<string>? allowBypassFor = null, List<string>? externalStatus = null, List<string>? automationJobs = null, List<GitRepositorySettingsQualityGateApproval>? approvals = null, bool? codeOwnersApproval = null)
    {
        AllowMergeFor = allowMergeFor;
        AllowBypassFor = allowBypassFor;
        ExternalStatus = externalStatus;
        AutomationJobs = automationJobs;
        Approvals = approvals;
        IsCodeOwnersApproval = codeOwnersApproval;
    }
    
    private PropertyValue<List<string>?> _allowMergeFor = new PropertyValue<List<string>?>(nameof(GitRepositorySettingsQualityGate), nameof(AllowMergeFor), "allowMergeFor");
    
    [JsonPropertyName("allowMergeFor")]
    public List<string>? AllowMergeFor
    {
        get => _allowMergeFor.GetValue(InlineErrors);
        set => _allowMergeFor.SetValue(value);
    }

    private PropertyValue<List<string>?> _allowBypassFor = new PropertyValue<List<string>?>(nameof(GitRepositorySettingsQualityGate), nameof(AllowBypassFor), "allowBypassFor");
    
    [JsonPropertyName("allowBypassFor")]
    public List<string>? AllowBypassFor
    {
        get => _allowBypassFor.GetValue(InlineErrors);
        set => _allowBypassFor.SetValue(value);
    }

    private PropertyValue<List<string>?> _externalStatus = new PropertyValue<List<string>?>(nameof(GitRepositorySettingsQualityGate), nameof(ExternalStatus), "externalStatus");
    
    [JsonPropertyName("externalStatus")]
    public List<string>? ExternalStatus
    {
        get => _externalStatus.GetValue(InlineErrors);
        set => _externalStatus.SetValue(value);
    }

    private PropertyValue<List<string>?> _automationJobs = new PropertyValue<List<string>?>(nameof(GitRepositorySettingsQualityGate), nameof(AutomationJobs), "automationJobs");
    
    [JsonPropertyName("automationJobs")]
    public List<string>? AutomationJobs
    {
        get => _automationJobs.GetValue(InlineErrors);
        set => _automationJobs.SetValue(value);
    }

    private PropertyValue<List<GitRepositorySettingsQualityGateApproval>?> _approvals = new PropertyValue<List<GitRepositorySettingsQualityGateApproval>?>(nameof(GitRepositorySettingsQualityGate), nameof(Approvals), "approvals");
    
    [JsonPropertyName("approvals")]
    public List<GitRepositorySettingsQualityGateApproval>? Approvals
    {
        get => _approvals.GetValue(InlineErrors);
        set => _approvals.SetValue(value);
    }

    private PropertyValue<bool?> _codeOwnersApproval = new PropertyValue<bool?>(nameof(GitRepositorySettingsQualityGate), nameof(IsCodeOwnersApproval), "codeOwnersApproval");
    
    [JsonPropertyName("codeOwnersApproval")]
    public bool? IsCodeOwnersApproval
    {
        get => _codeOwnersApproval.GetValue(InlineErrors);
        set => _codeOwnersApproval.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _allowMergeFor.SetAccessPath(parentChainPath, validateHasBeenSet);
        _allowBypassFor.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalStatus.SetAccessPath(parentChainPath, validateHasBeenSet);
        _automationJobs.SetAccessPath(parentChainPath, validateHasBeenSet);
        _approvals.SetAccessPath(parentChainPath, validateHasBeenSet);
        _codeOwnersApproval.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
