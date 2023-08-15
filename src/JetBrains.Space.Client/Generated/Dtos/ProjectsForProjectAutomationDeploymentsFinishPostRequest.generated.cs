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

internal class ProjectsForProjectAutomationDeploymentsFinishPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectAutomationDeploymentsFinishPostRequest() { }
    
    public ProjectsForProjectAutomationDeploymentsFinishPostRequest(TargetIdentifier targetIdentifier, DeploymentIdentifier? deploymentIdentifier = null, string? version = null, string? description = null, List<DeploymentCommitReference>? commitRefs = null, ExternalLink? externalLink = null)
    {
        TargetIdentifier = targetIdentifier;
        DeploymentIdentifier = deploymentIdentifier;
        Version = version;
        Description = description;
        CommitRefs = commitRefs;
        ExternalLink = externalLink;
    }
    
    private PropertyValue<TargetIdentifier> _targetIdentifier = new PropertyValue<TargetIdentifier>(nameof(ProjectsForProjectAutomationDeploymentsFinishPostRequest), nameof(TargetIdentifier), "targetIdentifier");
    
    [Required]
    [JsonPropertyName("targetIdentifier")]
    public TargetIdentifier TargetIdentifier
    {
        get => _targetIdentifier.GetValue(InlineErrors);
        set => _targetIdentifier.SetValue(value);
    }

    private PropertyValue<DeploymentIdentifier?> _deploymentIdentifier = new PropertyValue<DeploymentIdentifier?>(nameof(ProjectsForProjectAutomationDeploymentsFinishPostRequest), nameof(DeploymentIdentifier), "deploymentIdentifier");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("deploymentIdentifier")]
    public DeploymentIdentifier? DeploymentIdentifier
    {
        get => _deploymentIdentifier.GetValue(InlineErrors);
        set => _deploymentIdentifier.SetValue(value);
    }

    private PropertyValue<string?> _version = new PropertyValue<string?>(nameof(ProjectsForProjectAutomationDeploymentsFinishPostRequest), nameof(Version), "version");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("version")]
    public string? Version
    {
        get => _version.GetValue(InlineErrors);
        set => _version.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectAutomationDeploymentsFinishPostRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<List<DeploymentCommitReference>?> _commitRefs = new PropertyValue<List<DeploymentCommitReference>?>(nameof(ProjectsForProjectAutomationDeploymentsFinishPostRequest), nameof(CommitRefs), "commitRefs");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("commitRefs")]
    public List<DeploymentCommitReference>? CommitRefs
    {
        get => _commitRefs.GetValue(InlineErrors);
        set => _commitRefs.SetValue(value);
    }

    private PropertyValue<ExternalLink?> _externalLink = new PropertyValue<ExternalLink?>(nameof(ProjectsForProjectAutomationDeploymentsFinishPostRequest), nameof(ExternalLink), "externalLink");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("externalLink")]
    public ExternalLink? ExternalLink
    {
        get => _externalLink.GetValue(InlineErrors);
        set => _externalLink.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _targetIdentifier.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deploymentIdentifier.SetAccessPath(parentChainPath, validateHasBeenSet);
        _version.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitRefs.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalLink.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

