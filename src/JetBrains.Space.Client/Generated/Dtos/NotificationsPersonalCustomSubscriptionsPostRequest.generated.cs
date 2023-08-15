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

internal class NotificationsPersonalCustomSubscriptionsPostRequest
     : IPropagatePropertyAccessPath
{
    public NotificationsPersonalCustomSubscriptionsPostRequest() { }
    
    public NotificationsPersonalCustomSubscriptionsPostRequest(ProfileIdentifier profile, string name, string feed, CustomGenericSubscriptionIn subscription)
    {
        Profile = profile;
        Name = name;
        Feed = feed;
        Subscription = subscription;
    }
    
    private PropertyValue<ProfileIdentifier> _profile = new PropertyValue<ProfileIdentifier>(nameof(NotificationsPersonalCustomSubscriptionsPostRequest), nameof(Profile), "profile");
    
    [Required]
    [JsonPropertyName("profile")]
    public ProfileIdentifier Profile
    {
        get => _profile.GetValue(InlineErrors);
        set => _profile.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(NotificationsPersonalCustomSubscriptionsPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _feed = new PropertyValue<string>(nameof(NotificationsPersonalCustomSubscriptionsPostRequest), nameof(Feed), "feed");
    
    [Required]
    [JsonPropertyName("feed")]
    public string Feed
    {
        get => _feed.GetValue(InlineErrors);
        set => _feed.SetValue(value);
    }

    private PropertyValue<CustomGenericSubscriptionIn> _subscription = new PropertyValue<CustomGenericSubscriptionIn>(nameof(NotificationsPersonalCustomSubscriptionsPostRequest), nameof(Subscription), "subscription");
    
    [Required]
    [JsonPropertyName("subscription")]
    public CustomGenericSubscriptionIn Subscription
    {
        get => _subscription.GetValue(InlineErrors);
        set => _subscription.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _profile.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _feed.SetAccessPath(parentChainPath, validateHasBeenSet);
        _subscription.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

