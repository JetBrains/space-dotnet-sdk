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

internal class NotificationsPersonalSubscriptionsUpdatePersonalSubscriptionTargetPostRequest
     : IPropagatePropertyAccessPath
{
    public NotificationsPersonalSubscriptionsUpdatePersonalSubscriptionTargetPostRequest() { }
    
    public NotificationsPersonalSubscriptionsUpdatePersonalSubscriptionTargetPostRequest(ProfileIdentifier profile, string targetCode, string feed, List<string> eventCodes)
    {
        Profile = profile;
        TargetCode = targetCode;
        Feed = feed;
        EventCodes = eventCodes;
    }
    
    private PropertyValue<ProfileIdentifier> _profile = new PropertyValue<ProfileIdentifier>(nameof(NotificationsPersonalSubscriptionsUpdatePersonalSubscriptionTargetPostRequest), nameof(Profile), "profile");
    
    [Required]
    [JsonPropertyName("profile")]
    public ProfileIdentifier Profile
    {
        get => _profile.GetValue(InlineErrors);
        set => _profile.SetValue(value);
    }

    private PropertyValue<string> _targetCode = new PropertyValue<string>(nameof(NotificationsPersonalSubscriptionsUpdatePersonalSubscriptionTargetPostRequest), nameof(TargetCode), "targetCode");
    
    [Required]
    [JsonPropertyName("targetCode")]
    public string TargetCode
    {
        get => _targetCode.GetValue(InlineErrors);
        set => _targetCode.SetValue(value);
    }

    private PropertyValue<string> _feed = new PropertyValue<string>(nameof(NotificationsPersonalSubscriptionsUpdatePersonalSubscriptionTargetPostRequest), nameof(Feed), "feed");
    
    [Required]
    [JsonPropertyName("feed")]
    public string Feed
    {
        get => _feed.GetValue(InlineErrors);
        set => _feed.SetValue(value);
    }

    private PropertyValue<List<string>> _eventCodes = new PropertyValue<List<string>>(nameof(NotificationsPersonalSubscriptionsUpdatePersonalSubscriptionTargetPostRequest), nameof(EventCodes), "eventCodes", new List<string>());
    
    [Required]
    [JsonPropertyName("eventCodes")]
    public List<string> EventCodes
    {
        get => _eventCodes.GetValue(InlineErrors);
        set => _eventCodes.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _profile.SetAccessPath(parentChainPath, validateHasBeenSet);
        _targetCode.SetAccessPath(parentChainPath, validateHasBeenSet);
        _feed.SetAccessPath(parentChainPath, validateHasBeenSet);
        _eventCodes.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

