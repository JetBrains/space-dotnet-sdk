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

public sealed class AbsenceReasonRecord
     : IPropagatePropertyAccessPath
{
    public AbsenceReasonRecord() { }
    
    public AbsenceReasonRecord(string id, bool archived, string name, string description, bool defaultAvailability, bool approvalRequired, string icon, long? etag = null)
    {
        Id = id;
        IsArchived = archived;
        Name = name;
        Description = description;
        IsDefaultAvailability = defaultAvailability;
        IsApprovalRequired = approvalRequired;
        Icon = icon;
        Etag = etag;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(AbsenceReasonRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(AbsenceReasonRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(AbsenceReasonRecord), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _description = new PropertyValue<string>(nameof(AbsenceReasonRecord), nameof(Description), "description");
    
    [Required]
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<bool> _defaultAvailability = new PropertyValue<bool>(nameof(AbsenceReasonRecord), nameof(IsDefaultAvailability), "defaultAvailability");
    
    [Required]
    [JsonPropertyName("defaultAvailability")]
    public bool IsDefaultAvailability
    {
        get => _defaultAvailability.GetValue(InlineErrors);
        set => _defaultAvailability.SetValue(value);
    }

    private PropertyValue<bool> _approvalRequired = new PropertyValue<bool>(nameof(AbsenceReasonRecord), nameof(IsApprovalRequired), "approvalRequired");
    
    [Required]
    [JsonPropertyName("approvalRequired")]
    public bool IsApprovalRequired
    {
        get => _approvalRequired.GetValue(InlineErrors);
        set => _approvalRequired.SetValue(value);
    }

    private PropertyValue<string> _icon = new PropertyValue<string>(nameof(AbsenceReasonRecord), nameof(Icon), "icon");
    
    [Required]
    [JsonPropertyName("icon")]
    public string Icon
    {
        get => _icon.GetValue(InlineErrors);
        set => _icon.SetValue(value);
    }

    private PropertyValue<long?> _etag = new PropertyValue<long?>(nameof(AbsenceReasonRecord), nameof(Etag), "etag");
    
    [JsonPropertyName("etag")]
    public long? Etag
    {
        get => _etag.GetValue(InlineErrors);
        set => _etag.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultAvailability.SetAccessPath(parentChainPath, validateHasBeenSet);
        _approvalRequired.SetAccessPath(parentChainPath, validateHasBeenSet);
        _icon.SetAccessPath(parentChainPath, validateHasBeenSet);
        _etag.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

