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

public sealed class MeetingsCommonSubscriptionFilter
     : SubscriptionFilter, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MeetingsCommonSubscriptionFilter";
    
    public MeetingsCommonSubscriptionFilter() { }
    
    public MeetingsCommonSubscriptionFilter(List<TDMemberProfile>? organizers = null, List<TDMemberProfile>? participants = null, List<TDTeam>? teams = null, List<TDLocation>? locations = null)
    {
        Organizers = organizers;
        Participants = participants;
        Teams = teams;
        Locations = locations;
    }
    
    private PropertyValue<List<TDMemberProfile>?> _organizers = new PropertyValue<List<TDMemberProfile>?>(nameof(MeetingsCommonSubscriptionFilter), nameof(Organizers), "organizers");
    
    [JsonPropertyName("organizers")]
    public List<TDMemberProfile>? Organizers
    {
        get => _organizers.GetValue(InlineErrors);
        set => _organizers.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>?> _participants = new PropertyValue<List<TDMemberProfile>?>(nameof(MeetingsCommonSubscriptionFilter), nameof(Participants), "participants");
    
    [JsonPropertyName("participants")]
    public List<TDMemberProfile>? Participants
    {
        get => _participants.GetValue(InlineErrors);
        set => _participants.SetValue(value);
    }

    private PropertyValue<List<TDTeam>?> _teams = new PropertyValue<List<TDTeam>?>(nameof(MeetingsCommonSubscriptionFilter), nameof(Teams), "teams");
    
    [JsonPropertyName("teams")]
    public List<TDTeam>? Teams
    {
        get => _teams.GetValue(InlineErrors);
        set => _teams.SetValue(value);
    }

    private PropertyValue<List<TDLocation>?> _locations = new PropertyValue<List<TDLocation>?>(nameof(MeetingsCommonSubscriptionFilter), nameof(Locations), "locations");
    
    [JsonPropertyName("locations")]
    public List<TDLocation>? Locations
    {
        get => _locations.GetValue(InlineErrors);
        set => _locations.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _organizers.SetAccessPath(parentChainPath, validateHasBeenSet);
        _participants.SetAccessPath(parentChainPath, validateHasBeenSet);
        _teams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _locations.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

