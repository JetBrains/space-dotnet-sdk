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

public sealed class ArticleDetailsRecord
     : IPropagatePropertyAccessPath
{
    public ArticleDetailsRecord() { }
    
    public ArticleDetailsRecord(string id, bool archived, MeetingRecord? @event = null, List<TDTeam>? teams = null, List<TDLocation>? locations = null, ExternalEntityInfoRecord? externalEntityInfo = null)
    {
        Id = id;
        IsArchived = archived;
        Event = @event;
        Teams = teams;
        Locations = locations;
        ExternalEntityInfo = externalEntityInfo;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(ArticleDetailsRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ArticleDetailsRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<MeetingRecord?> _event = new PropertyValue<MeetingRecord?>(nameof(ArticleDetailsRecord), nameof(Event), "event");
    
    [JsonPropertyName("event")]
    public MeetingRecord? Event
    {
        get => _event.GetValue(InlineErrors);
        set => _event.SetValue(value);
    }

    private PropertyValue<List<TDTeam>?> _teams = new PropertyValue<List<TDTeam>?>(nameof(ArticleDetailsRecord), nameof(Teams), "teams");
    
    [JsonPropertyName("teams")]
    public List<TDTeam>? Teams
    {
        get => _teams.GetValue(InlineErrors);
        set => _teams.SetValue(value);
    }

    private PropertyValue<List<TDLocation>?> _locations = new PropertyValue<List<TDLocation>?>(nameof(ArticleDetailsRecord), nameof(Locations), "locations");
    
    [JsonPropertyName("locations")]
    public List<TDLocation>? Locations
    {
        get => _locations.GetValue(InlineErrors);
        set => _locations.SetValue(value);
    }

    private PropertyValue<ExternalEntityInfoRecord?> _externalEntityInfo = new PropertyValue<ExternalEntityInfoRecord?>(nameof(ArticleDetailsRecord), nameof(ExternalEntityInfo), "externalEntityInfo");
    
    [JsonPropertyName("externalEntityInfo")]
    public ExternalEntityInfoRecord? ExternalEntityInfo
    {
        get => _externalEntityInfo.GetValue(InlineErrors);
        set => _externalEntityInfo.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _event.SetAccessPath(parentChainPath, validateHasBeenSet);
        _teams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _locations.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalEntityInfo.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

