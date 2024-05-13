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

public sealed class FeatureFlagWebhookEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "FeatureFlagWebhookEvent";
    
    public FeatureFlagWebhookEvent() { }
    
    public FeatureFlagWebhookEvent(KMetaMod meta, string name, int? issueNumber = null, Modification<bool?>? enabledForAll = null, Modification<bool?>? selfManageable = null, List<TDTeam>? addedTeams = null, List<TDTeam>? addedProfiles = null, List<TDMemberProfile>? removedTeams = null, List<TDMemberProfile>? removedProfiles = null)
    {
        Meta = meta;
        Name = name;
        IssueNumber = issueNumber;
        EnabledForAll = enabledForAll;
        SelfManageable = selfManageable;
        AddedTeams = addedTeams;
        AddedProfiles = addedProfiles;
        RemovedTeams = removedTeams;
        RemovedProfiles = removedProfiles;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(FeatureFlagWebhookEvent), nameof(Meta), "meta");
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue(InlineErrors);
        set => _meta.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(FeatureFlagWebhookEvent), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<int?> _issueNumber = new PropertyValue<int?>(nameof(FeatureFlagWebhookEvent), nameof(IssueNumber), "issueNumber");
    
    [JsonPropertyName("issueNumber")]
    public int? IssueNumber
    {
        get => _issueNumber.GetValue(InlineErrors);
        set => _issueNumber.SetValue(value);
    }

    private PropertyValue<Modification<bool?>?> _enabledForAll = new PropertyValue<Modification<bool?>?>(nameof(FeatureFlagWebhookEvent), nameof(EnabledForAll), "enabledForAll");
    
    [JsonPropertyName("enabledForAll")]
    public Modification<bool?>? EnabledForAll
    {
        get => _enabledForAll.GetValue(InlineErrors);
        set => _enabledForAll.SetValue(value);
    }

    private PropertyValue<Modification<bool?>?> _selfManageable = new PropertyValue<Modification<bool?>?>(nameof(FeatureFlagWebhookEvent), nameof(SelfManageable), "selfManageable");
    
    [JsonPropertyName("selfManageable")]
    public Modification<bool?>? SelfManageable
    {
        get => _selfManageable.GetValue(InlineErrors);
        set => _selfManageable.SetValue(value);
    }

    private PropertyValue<List<TDTeam>?> _addedTeams = new PropertyValue<List<TDTeam>?>(nameof(FeatureFlagWebhookEvent), nameof(AddedTeams), "addedTeams");
    
    [JsonPropertyName("addedTeams")]
    public List<TDTeam>? AddedTeams
    {
        get => _addedTeams.GetValue(InlineErrors);
        set => _addedTeams.SetValue(value);
    }

    private PropertyValue<List<TDTeam>?> _addedProfiles = new PropertyValue<List<TDTeam>?>(nameof(FeatureFlagWebhookEvent), nameof(AddedProfiles), "addedProfiles");
    
    [JsonPropertyName("addedProfiles")]
    public List<TDTeam>? AddedProfiles
    {
        get => _addedProfiles.GetValue(InlineErrors);
        set => _addedProfiles.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>?> _removedTeams = new PropertyValue<List<TDMemberProfile>?>(nameof(FeatureFlagWebhookEvent), nameof(RemovedTeams), "removedTeams");
    
    [JsonPropertyName("removedTeams")]
    public List<TDMemberProfile>? RemovedTeams
    {
        get => _removedTeams.GetValue(InlineErrors);
        set => _removedTeams.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>?> _removedProfiles = new PropertyValue<List<TDMemberProfile>?>(nameof(FeatureFlagWebhookEvent), nameof(RemovedProfiles), "removedProfiles");
    
    [JsonPropertyName("removedProfiles")]
    public List<TDMemberProfile>? RemovedProfiles
    {
        get => _removedProfiles.GetValue(InlineErrors);
        set => _removedProfiles.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueNumber.SetAccessPath(parentChainPath, validateHasBeenSet);
        _enabledForAll.SetAccessPath(parentChainPath, validateHasBeenSet);
        _selfManageable.SetAccessPath(parentChainPath, validateHasBeenSet);
        _addedTeams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _addedProfiles.SetAccessPath(parentChainPath, validateHasBeenSet);
        _removedTeams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _removedProfiles.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

