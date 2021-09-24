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

namespace JetBrains.Space.Client.WebhookRecordPartialBuilder
{
    public static class WebhookRecordPartialExtensions
    {
        public static Partial<WebhookRecord> WithId(this Partial<WebhookRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<WebhookRecord> WithIsArchived(this Partial<WebhookRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<WebhookRecord> WithApp(this Partial<WebhookRecord> it)
            => it.AddFieldName("app");
        
        public static Partial<WebhookRecord> WithApp(this Partial<WebhookRecord> it, Func<Partial<ESApp>, Partial<ESApp>> partialBuilder)
            => it.AddFieldName("app", partialBuilder(new Partial<ESApp>(it)));
        
        public static Partial<WebhookRecord> WithSubscriptions(this Partial<WebhookRecord> it)
            => it.AddFieldName("subscriptions");
        
        public static Partial<WebhookRecord> WithSubscriptions(this Partial<WebhookRecord> it, Func<Partial<Subscription>, Partial<Subscription>> partialBuilder)
            => it.AddFieldName("subscriptions", partialBuilder(new Partial<Subscription>(it)));
        
        public static Partial<WebhookRecord> WithName(this Partial<WebhookRecord> it)
            => it.AddFieldName("name");
        
        public static Partial<WebhookRecord> WithDescription(this Partial<WebhookRecord> it)
            => it.AddFieldName("description");
        
        public static Partial<WebhookRecord> WithIsUseAppEndpoint(this Partial<WebhookRecord> it)
            => it.AddFieldName("useAppEndpoint");
        
        public static Partial<WebhookRecord> WithEndpoint(this Partial<WebhookRecord> it)
            => it.AddFieldName("endpoint");
        
        public static Partial<WebhookRecord> WithEndpoint(this Partial<WebhookRecord> it, Func<Partial<Endpoint>, Partial<Endpoint>> partialBuilder)
            => it.AddFieldName("endpoint", partialBuilder(new Partial<Endpoint>(it)));
        
        public static Partial<WebhookRecord> WithIsUseAppEndpointAuth(this Partial<WebhookRecord> it)
            => it.AddFieldName("useAppEndpointAuth");
        
        public static Partial<WebhookRecord> WithEndpointAuth(this Partial<WebhookRecord> it)
            => it.AddFieldName("endpointAuth");
        
        public static Partial<WebhookRecord> WithEndpointAuth(this Partial<WebhookRecord> it, Func<Partial<EndpointAuth>, Partial<EndpointAuth>> partialBuilder)
            => it.AddFieldName("endpointAuth", partialBuilder(new Partial<EndpointAuth>(it)));
        
        public static Partial<WebhookRecord> WithIsEnabled(this Partial<WebhookRecord> it)
            => it.AddFieldName("enabled");
        
        public static Partial<WebhookRecord> WithAcceptedHttpResponseCodes(this Partial<WebhookRecord> it)
            => it.AddFieldName("acceptedHttpResponseCodes");
        
        public static Partial<WebhookRecord> WithIsDoRetries(this Partial<WebhookRecord> it)
            => it.AddFieldName("doRetries");
        
        public static Partial<WebhookRecord> WithStatus(this Partial<WebhookRecord> it)
            => it.AddFieldName("status");
        
        public static Partial<WebhookRecord> WithStatus(this Partial<WebhookRecord> it, Func<Partial<WebhookDeliveryStatus>, Partial<WebhookDeliveryStatus>> partialBuilder)
            => it.AddFieldName("status", partialBuilder(new Partial<WebhookDeliveryStatus>(it)));
        
    }
    
}
