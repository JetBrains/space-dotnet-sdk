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

internal class ApplicationsForApplicationWebhooksForWebhookIdSubscriptionsForSubscriptionIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public ApplicationsForApplicationWebhooksForWebhookIdSubscriptionsForSubscriptionIdPatchRequest() { }
    
    public ApplicationsForApplicationWebhooksForWebhookIdSubscriptionsForSubscriptionIdPatchRequest(CustomGenericSubscriptionIn subscription, string? name = null, bool? enabled = null)
    {
        Name = name;
        IsEnabled = enabled;
        Subscription = subscription;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ApplicationsForApplicationWebhooksForWebhookIdSubscriptionsForSubscriptionIdPatchRequest), nameof(Name), "name");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<bool?> _enabled = new PropertyValue<bool?>(nameof(ApplicationsForApplicationWebhooksForWebhookIdSubscriptionsForSubscriptionIdPatchRequest), nameof(IsEnabled), "enabled");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("enabled")]
    public bool? IsEnabled
    {
        get => _enabled.GetValue(InlineErrors);
        set => _enabled.SetValue(value);
    }

    private PropertyValue<CustomGenericSubscriptionIn> _subscription = new PropertyValue<CustomGenericSubscriptionIn>(nameof(ApplicationsForApplicationWebhooksForWebhookIdSubscriptionsForSubscriptionIdPatchRequest), nameof(Subscription), "subscription");
    
    [JsonPropertyName("subscription")]
    public CustomGenericSubscriptionIn Subscription
    {
        get => _subscription.GetValue(InlineErrors);
        set => _subscription.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _enabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _subscription.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

