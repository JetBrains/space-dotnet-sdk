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

public sealed class RdDevConfiguration
     : IPropagatePropertyAccessPath
{
    public RdDevConfiguration() { }
    
    public RdDevConfiguration(string id, string name, List<RepoConnectionWithBranch> repoConnections, RdDevContainer devContainer, RdDevConfigurationIde ide, string instanceTypeName, DevConfigurationInstanceType instanceType, PRProject project, DevConfigurationWarmup warmup, bool archived, DevConfigurationHotPool? hotPool = null, DevConfigurationHooks? hooks = null, DevConfigurationHibernation? hibernation = null, string? projectRoot = null, bool? sshEnabled = null, DevConfigurationAccessSettingsDTO? access = null)
    {
        Id = id;
        Name = name;
        RepoConnections = repoConnections;
        DevContainer = devContainer;
        Ide = ide;
        InstanceTypeName = instanceTypeName;
        InstanceType = instanceType;
        Project = project;
        HotPool = hotPool;
        Warmup = warmup;
        Hooks = hooks;
        Hibernation = hibernation;
        ProjectRoot = projectRoot;
        IsSshEnabled = sshEnabled;
        Access = access;
        IsArchived = archived;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(RdDevConfiguration), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(RdDevConfiguration), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<List<RepoConnectionWithBranch>> _repoConnections = new PropertyValue<List<RepoConnectionWithBranch>>(nameof(RdDevConfiguration), nameof(RepoConnections), "repoConnections", new List<RepoConnectionWithBranch>());
    
    [Required]
    [JsonPropertyName("repoConnections")]
    public List<RepoConnectionWithBranch> RepoConnections
    {
        get => _repoConnections.GetValue(InlineErrors);
        set => _repoConnections.SetValue(value);
    }

    private PropertyValue<RdDevContainer> _devContainer = new PropertyValue<RdDevContainer>(nameof(RdDevConfiguration), nameof(DevContainer), "devContainer");
    
    [Required]
    [JsonPropertyName("devContainer")]
    public RdDevContainer DevContainer
    {
        get => _devContainer.GetValue(InlineErrors);
        set => _devContainer.SetValue(value);
    }

    private PropertyValue<RdDevConfigurationIde> _ide = new PropertyValue<RdDevConfigurationIde>(nameof(RdDevConfiguration), nameof(Ide), "ide");
    
    [Required]
    [JsonPropertyName("ide")]
    public RdDevConfigurationIde Ide
    {
        get => _ide.GetValue(InlineErrors);
        set => _ide.SetValue(value);
    }

    private PropertyValue<string> _instanceTypeName = new PropertyValue<string>(nameof(RdDevConfiguration), nameof(InstanceTypeName), "instanceTypeName");
    
    [Required]
    [JsonPropertyName("instanceTypeName")]
    public string InstanceTypeName
    {
        get => _instanceTypeName.GetValue(InlineErrors);
        set => _instanceTypeName.SetValue(value);
    }

    private PropertyValue<DevConfigurationInstanceType> _instanceType = new PropertyValue<DevConfigurationInstanceType>(nameof(RdDevConfiguration), nameof(InstanceType), "instanceType");
    
    [Required]
    [JsonPropertyName("instanceType")]
    public DevConfigurationInstanceType InstanceType
    {
        get => _instanceType.GetValue(InlineErrors);
        set => _instanceType.SetValue(value);
    }

    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(RdDevConfiguration), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<DevConfigurationHotPool?> _hotPool = new PropertyValue<DevConfigurationHotPool?>(nameof(RdDevConfiguration), nameof(HotPool), "hotPool");
    
    [JsonPropertyName("hotPool")]
    public DevConfigurationHotPool? HotPool
    {
        get => _hotPool.GetValue(InlineErrors);
        set => _hotPool.SetValue(value);
    }

    private PropertyValue<DevConfigurationWarmup> _warmup = new PropertyValue<DevConfigurationWarmup>(nameof(RdDevConfiguration), nameof(Warmup), "warmup");
    
    [Required]
    [JsonPropertyName("warmup")]
    public DevConfigurationWarmup Warmup
    {
        get => _warmup.GetValue(InlineErrors);
        set => _warmup.SetValue(value);
    }

    private PropertyValue<DevConfigurationHooks?> _hooks = new PropertyValue<DevConfigurationHooks?>(nameof(RdDevConfiguration), nameof(Hooks), "hooks");
    
    [JsonPropertyName("hooks")]
    public DevConfigurationHooks? Hooks
    {
        get => _hooks.GetValue(InlineErrors);
        set => _hooks.SetValue(value);
    }

    private PropertyValue<DevConfigurationHibernation?> _hibernation = new PropertyValue<DevConfigurationHibernation?>(nameof(RdDevConfiguration), nameof(Hibernation), "hibernation");
    
    [JsonPropertyName("hibernation")]
    public DevConfigurationHibernation? Hibernation
    {
        get => _hibernation.GetValue(InlineErrors);
        set => _hibernation.SetValue(value);
    }

    private PropertyValue<string?> _projectRoot = new PropertyValue<string?>(nameof(RdDevConfiguration), nameof(ProjectRoot), "projectRoot");
    
    [JsonPropertyName("projectRoot")]
    public string? ProjectRoot
    {
        get => _projectRoot.GetValue(InlineErrors);
        set => _projectRoot.SetValue(value);
    }

    private PropertyValue<bool?> _sshEnabled = new PropertyValue<bool?>(nameof(RdDevConfiguration), nameof(IsSshEnabled), "sshEnabled");
    
    [JsonPropertyName("sshEnabled")]
    public bool? IsSshEnabled
    {
        get => _sshEnabled.GetValue(InlineErrors);
        set => _sshEnabled.SetValue(value);
    }

    private PropertyValue<DevConfigurationAccessSettingsDTO?> _access = new PropertyValue<DevConfigurationAccessSettingsDTO?>(nameof(RdDevConfiguration), nameof(Access), "access");
    
    [JsonPropertyName("access")]
    public DevConfigurationAccessSettingsDTO? Access
    {
        get => _access.GetValue(InlineErrors);
        set => _access.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(RdDevConfiguration), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repoConnections.SetAccessPath(parentChainPath, validateHasBeenSet);
        _devContainer.SetAccessPath(parentChainPath, validateHasBeenSet);
        _ide.SetAccessPath(parentChainPath, validateHasBeenSet);
        _instanceTypeName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _instanceType.SetAccessPath(parentChainPath, validateHasBeenSet);
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hotPool.SetAccessPath(parentChainPath, validateHasBeenSet);
        _warmup.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hooks.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hibernation.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectRoot.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sshEnabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _access.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

