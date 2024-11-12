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

public sealed class MergeRequestQualityGateSettingsRule
     : IPropagatePropertyAccessPath
{
    public MergeRequestQualityGateSettingsRule() { }
    
    public MergeRequestQualityGateSettingsRule(List<QualityGateApproval> approvals, List<QualityGateCodeOwnersApproval> codeOwnersApproval, List<QualityGateExternalStatus> externalStatuses, List<QualityGateAutomationJob> automationJobs)
    {
        Approvals = approvals;
        CodeOwnersApproval = codeOwnersApproval;
        ExternalStatuses = externalStatuses;
        AutomationJobs = automationJobs;
    }
    
    private PropertyValue<List<QualityGateApproval>> _approvals = new PropertyValue<List<QualityGateApproval>>(nameof(MergeRequestQualityGateSettingsRule), nameof(Approvals), "approvals", new List<QualityGateApproval>());
    
    [Required]
    [JsonPropertyName("approvals")]
    public List<QualityGateApproval> Approvals
    {
        get => _approvals.GetValue(InlineErrors);
        set => _approvals.SetValue(value);
    }

    private PropertyValue<List<QualityGateCodeOwnersApproval>> _codeOwnersApproval = new PropertyValue<List<QualityGateCodeOwnersApproval>>(nameof(MergeRequestQualityGateSettingsRule), nameof(CodeOwnersApproval), "codeOwnersApproval", new List<QualityGateCodeOwnersApproval>());
    
    [Required]
    [JsonPropertyName("codeOwnersApproval")]
    public List<QualityGateCodeOwnersApproval> CodeOwnersApproval
    {
        get => _codeOwnersApproval.GetValue(InlineErrors);
        set => _codeOwnersApproval.SetValue(value);
    }

    private PropertyValue<List<QualityGateExternalStatus>> _externalStatuses = new PropertyValue<List<QualityGateExternalStatus>>(nameof(MergeRequestQualityGateSettingsRule), nameof(ExternalStatuses), "externalStatuses", new List<QualityGateExternalStatus>());
    
    [Required]
    [JsonPropertyName("externalStatuses")]
    public List<QualityGateExternalStatus> ExternalStatuses
    {
        get => _externalStatuses.GetValue(InlineErrors);
        set => _externalStatuses.SetValue(value);
    }

    private PropertyValue<List<QualityGateAutomationJob>> _automationJobs = new PropertyValue<List<QualityGateAutomationJob>>(nameof(MergeRequestQualityGateSettingsRule), nameof(AutomationJobs), "automationJobs", new List<QualityGateAutomationJob>());
    
    [Required]
    [JsonPropertyName("automationJobs")]
    public List<QualityGateAutomationJob> AutomationJobs
    {
        get => _automationJobs.GetValue(InlineErrors);
        set => _automationJobs.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _approvals.SetAccessPath(parentChainPath, validateHasBeenSet);
        _codeOwnersApproval.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalStatuses.SetAccessPath(parentChainPath, validateHasBeenSet);
        _automationJobs.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
