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

internal class ProjectsForProjectAutomationDeploymentTargetsPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectAutomationDeploymentTargetsPostRequest() { }
    
    public ProjectsForProjectAutomationDeploymentTargetsPostRequest(string key, string name, string description, List<DeployTargetRepositoryDTO>? repositories = null, bool? manualControl = null, bool? singleScheduled = null, int? hangTimeoutMinutes = null, int? failTimeoutMinutes = null, List<string>? responsibleUsers = null, List<string>? responsibleTeams = null, List<DeployTargetLink>? links = null, List<CustomFieldInputValue>? customFields = null)
    {
        Key = key;
        Name = name;
        Description = description;
        Repositories = (repositories ?? new List<DeployTargetRepositoryDTO>());
        IsManualControl = manualControl;
        IsSingleScheduled = singleScheduled;
        HangTimeoutMinutes = hangTimeoutMinutes;
        FailTimeoutMinutes = failTimeoutMinutes;
        ResponsibleUsers = responsibleUsers;
        ResponsibleTeams = responsibleTeams;
        Links = links;
        CustomFields = customFields;
    }
    
    private PropertyValue<string> _key = new PropertyValue<string>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(Key), "key");
    
    [Required]
    [JsonPropertyName("key")]
    public string Key
    {
        get => _key.GetValue(InlineErrors);
        set => _key.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _description = new PropertyValue<string>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(Description), "description");
    
    [Required]
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<List<DeployTargetRepositoryDTO>> _repositories = new PropertyValue<List<DeployTargetRepositoryDTO>>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(Repositories), "repositories", new List<DeployTargetRepositoryDTO>());
    
    [JsonPropertyName("repositories")]
    public List<DeployTargetRepositoryDTO> Repositories
    {
        get => _repositories.GetValue(InlineErrors);
        set => _repositories.SetValue(value);
    }

    private PropertyValue<bool?> _manualControl = new PropertyValue<bool?>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(IsManualControl), "manualControl");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("manualControl")]
    public bool? IsManualControl
    {
        get => _manualControl.GetValue(InlineErrors);
        set => _manualControl.SetValue(value);
    }

    private PropertyValue<bool?> _singleScheduled = new PropertyValue<bool?>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(IsSingleScheduled), "singleScheduled");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("singleScheduled")]
    public bool? IsSingleScheduled
    {
        get => _singleScheduled.GetValue(InlineErrors);
        set => _singleScheduled.SetValue(value);
    }

    private PropertyValue<int?> _hangTimeoutMinutes = new PropertyValue<int?>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(HangTimeoutMinutes), "hangTimeoutMinutes");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("hangTimeoutMinutes")]
    public int? HangTimeoutMinutes
    {
        get => _hangTimeoutMinutes.GetValue(InlineErrors);
        set => _hangTimeoutMinutes.SetValue(value);
    }

    private PropertyValue<int?> _failTimeoutMinutes = new PropertyValue<int?>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(FailTimeoutMinutes), "failTimeoutMinutes");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("failTimeoutMinutes")]
    public int? FailTimeoutMinutes
    {
        get => _failTimeoutMinutes.GetValue(InlineErrors);
        set => _failTimeoutMinutes.SetValue(value);
    }

    private PropertyValue<List<string>?> _responsibleUsers = new PropertyValue<List<string>?>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(ResponsibleUsers), "responsibleUsers");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("responsibleUsers")]
    public List<string>? ResponsibleUsers
    {
        get => _responsibleUsers.GetValue(InlineErrors);
        set => _responsibleUsers.SetValue(value);
    }

    private PropertyValue<List<string>?> _responsibleTeams = new PropertyValue<List<string>?>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(ResponsibleTeams), "responsibleTeams");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("responsibleTeams")]
    public List<string>? ResponsibleTeams
    {
        get => _responsibleTeams.GetValue(InlineErrors);
        set => _responsibleTeams.SetValue(value);
    }

    private PropertyValue<List<DeployTargetLink>?> _links = new PropertyValue<List<DeployTargetLink>?>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(Links), "links");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("links")]
    public List<DeployTargetLink>? Links
    {
        get => _links.GetValue(InlineErrors);
        set => _links.SetValue(value);
    }

    private PropertyValue<List<CustomFieldInputValue>?> _customFields = new PropertyValue<List<CustomFieldInputValue>?>(nameof(ProjectsForProjectAutomationDeploymentTargetsPostRequest), nameof(CustomFields), "customFields");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("customFields")]
    public List<CustomFieldInputValue>? CustomFields
    {
        get => _customFields.GetValue(InlineErrors);
        set => _customFields.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _key.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositories.SetAccessPath(parentChainPath, validateHasBeenSet);
        _manualControl.SetAccessPath(parentChainPath, validateHasBeenSet);
        _singleScheduled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hangTimeoutMinutes.SetAccessPath(parentChainPath, validateHasBeenSet);
        _failTimeoutMinutes.SetAccessPath(parentChainPath, validateHasBeenSet);
        _responsibleUsers.SetAccessPath(parentChainPath, validateHasBeenSet);
        _responsibleTeams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _links.SetAccessPath(parentChainPath, validateHasBeenSet);
        _customFields.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

