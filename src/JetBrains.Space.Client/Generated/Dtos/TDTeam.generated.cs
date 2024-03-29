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

public sealed class TDTeam
     : IPropagatePropertyAccessPath
{
    public TDTeam() { }
    
    public TDTeam(string id, string name, string description, bool archived, Dictionary<string, CFValue> customFields, List<TDMembership> memberships, TDTeam? parent = null, List<string>? emails = null, string? channelId = null, bool? disbanded = null, DateTime? disbandedAt = null, string? externalId = null, TDMemberProfile? defaultManager = null)
    {
        Id = id;
        Name = name;
        Description = description;
        Parent = parent;
        Emails = emails;
        ChannelId = channelId;
        IsArchived = archived;
        IsDisbanded = disbanded;
        DisbandedAt = disbandedAt;
        ExternalId = externalId;
        DefaultManager = defaultManager;
        CustomFields = customFields;
        Memberships = memberships;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDTeam), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(TDTeam), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _description = new PropertyValue<string>(nameof(TDTeam), nameof(Description), "description");
    
    [Required]
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<TDTeam?> _parent = new PropertyValue<TDTeam?>(nameof(TDTeam), nameof(Parent), "parent");
    
    [JsonPropertyName("parent")]
    public TDTeam? Parent
    {
        get => _parent.GetValue(InlineErrors);
        set => _parent.SetValue(value);
    }

    private PropertyValue<List<string>?> _emails = new PropertyValue<List<string>?>(nameof(TDTeam), nameof(Emails), "emails");
    
    [JsonPropertyName("emails")]
    public List<string>? Emails
    {
        get => _emails.GetValue(InlineErrors);
        set => _emails.SetValue(value);
    }

    private PropertyValue<string?> _channelId = new PropertyValue<string?>(nameof(TDTeam), nameof(ChannelId), "channelId");
    
    [JsonPropertyName("channelId")]
    public string? ChannelId
    {
        get => _channelId.GetValue(InlineErrors);
        set => _channelId.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TDTeam), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<bool?> _disbanded = new PropertyValue<bool?>(nameof(TDTeam), nameof(IsDisbanded), "disbanded");
    
    [JsonPropertyName("disbanded")]
    public bool? IsDisbanded
    {
        get => _disbanded.GetValue(InlineErrors);
        set => _disbanded.SetValue(value);
    }

    private PropertyValue<DateTime?> _disbandedAt = new PropertyValue<DateTime?>(nameof(TDTeam), nameof(DisbandedAt), "disbandedAt");
    
    [JsonPropertyName("disbandedAt")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? DisbandedAt
    {
        get => _disbandedAt.GetValue(InlineErrors);
        set => _disbandedAt.SetValue(value);
    }

    private PropertyValue<string?> _externalId = new PropertyValue<string?>(nameof(TDTeam), nameof(ExternalId), "externalId");
    
    [JsonPropertyName("externalId")]
    public string? ExternalId
    {
        get => _externalId.GetValue(InlineErrors);
        set => _externalId.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _defaultManager = new PropertyValue<TDMemberProfile?>(nameof(TDTeam), nameof(DefaultManager), "defaultManager");
    
    [JsonPropertyName("defaultManager")]
    public TDMemberProfile? DefaultManager
    {
        get => _defaultManager.GetValue(InlineErrors);
        set => _defaultManager.SetValue(value);
    }

    private PropertyValue<Dictionary<string, CFValue>> _customFields = new PropertyValue<Dictionary<string, CFValue>>(nameof(TDTeam), nameof(CustomFields), "customFields", new Dictionary<string, CFValue>());
    
    [Required]
    [JsonPropertyName("customFields")]
    public Dictionary<string, CFValue> CustomFields
    {
        get => _customFields.GetValue(InlineErrors);
        set => _customFields.SetValue(value);
    }

    private PropertyValue<List<TDMembership>> _memberships = new PropertyValue<List<TDMembership>>(nameof(TDTeam), nameof(Memberships), "memberships", new List<TDMembership>());
    
    [Required]
    [JsonPropertyName("memberships")]
    public List<TDMembership> Memberships
    {
        get => _memberships.GetValue(InlineErrors);
        set => _memberships.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parent.SetAccessPath(parentChainPath, validateHasBeenSet);
        _emails.SetAccessPath(parentChainPath, validateHasBeenSet);
        _channelId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _disbanded.SetAccessPath(parentChainPath, validateHasBeenSet);
        _disbandedAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultManager.SetAccessPath(parentChainPath, validateHasBeenSet);
        _customFields.SetAccessPath(parentChainPath, validateHasBeenSet);
        _memberships.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

