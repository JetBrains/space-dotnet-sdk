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

namespace JetBrains.Space.Client
{
    public sealed class WebhookRecord
         : IPropagatePropertyAccessPath
    {
        public WebhookRecord() { }
        
        public WebhookRecord(string id, bool archived, ESApp app, List<Subscription> subscriptions, string name, bool useAppEndpoint, Endpoint endpoint, bool useAppEndpointAuth, EndpointAuth endpointAuth, bool enabled, List<int> acceptedHttpResponseCodes, bool doRetries, string? description = null, WebhookDeliveryStatus? status = null)
        {
            Id = id;
            IsArchived = archived;
            App = app;
            Subscriptions = subscriptions;
            Name = name;
            Description = description;
            IsUseAppEndpoint = useAppEndpoint;
            Endpoint = endpoint;
            IsUseAppEndpointAuth = useAppEndpointAuth;
            EndpointAuth = endpointAuth;
            IsEnabled = enabled;
            AcceptedHttpResponseCodes = acceptedHttpResponseCodes;
            IsDoRetries = doRetries;
            Status = status;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(WebhookRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(WebhookRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<ESApp> _app = new PropertyValue<ESApp>(nameof(WebhookRecord), nameof(App));
        
        [Required]
        [JsonPropertyName("app")]
        public ESApp App
        {
            get => _app.GetValue();
            set => _app.SetValue(value);
        }
    
        private PropertyValue<List<Subscription>> _subscriptions = new PropertyValue<List<Subscription>>(nameof(WebhookRecord), nameof(Subscriptions), new List<Subscription>());
        
        [Required]
        [JsonPropertyName("subscriptions")]
        public List<Subscription> Subscriptions
        {
            get => _subscriptions.GetValue();
            set => _subscriptions.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(WebhookRecord), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(WebhookRecord), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<bool> _useAppEndpoint = new PropertyValue<bool>(nameof(WebhookRecord), nameof(IsUseAppEndpoint));
        
        [Required]
        [JsonPropertyName("useAppEndpoint")]
        public bool IsUseAppEndpoint
        {
            get => _useAppEndpoint.GetValue();
            set => _useAppEndpoint.SetValue(value);
        }
    
        private PropertyValue<Endpoint> _endpoint = new PropertyValue<Endpoint>(nameof(WebhookRecord), nameof(Endpoint));
        
        [Required]
        [JsonPropertyName("endpoint")]
        public Endpoint Endpoint
        {
            get => _endpoint.GetValue();
            set => _endpoint.SetValue(value);
        }
    
        private PropertyValue<bool> _useAppEndpointAuth = new PropertyValue<bool>(nameof(WebhookRecord), nameof(IsUseAppEndpointAuth));
        
        [Required]
        [JsonPropertyName("useAppEndpointAuth")]
        public bool IsUseAppEndpointAuth
        {
            get => _useAppEndpointAuth.GetValue();
            set => _useAppEndpointAuth.SetValue(value);
        }
    
        private PropertyValue<EndpointAuth> _endpointAuth = new PropertyValue<EndpointAuth>(nameof(WebhookRecord), nameof(EndpointAuth));
        
        [Required]
        [JsonPropertyName("endpointAuth")]
        public EndpointAuth EndpointAuth
        {
            get => _endpointAuth.GetValue();
            set => _endpointAuth.SetValue(value);
        }
    
        private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(WebhookRecord), nameof(IsEnabled));
        
        [Required]
        [JsonPropertyName("enabled")]
        public bool IsEnabled
        {
            get => _enabled.GetValue();
            set => _enabled.SetValue(value);
        }
    
        private PropertyValue<List<int>> _acceptedHttpResponseCodes = new PropertyValue<List<int>>(nameof(WebhookRecord), nameof(AcceptedHttpResponseCodes), new List<int>());
        
        [Required]
        [JsonPropertyName("acceptedHttpResponseCodes")]
        public List<int> AcceptedHttpResponseCodes
        {
            get => _acceptedHttpResponseCodes.GetValue();
            set => _acceptedHttpResponseCodes.SetValue(value);
        }
    
        private PropertyValue<bool> _doRetries = new PropertyValue<bool>(nameof(WebhookRecord), nameof(IsDoRetries));
        
        [Required]
        [JsonPropertyName("doRetries")]
        public bool IsDoRetries
        {
            get => _doRetries.GetValue();
            set => _doRetries.SetValue(value);
        }
    
        private PropertyValue<WebhookDeliveryStatus?> _status = new PropertyValue<WebhookDeliveryStatus?>(nameof(WebhookRecord), nameof(Status));
        
        [JsonPropertyName("status")]
        public WebhookDeliveryStatus? Status
        {
            get => _status.GetValue();
            set => _status.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _app.SetAccessPath(path, validateHasBeenSet);
            _subscriptions.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _useAppEndpoint.SetAccessPath(path, validateHasBeenSet);
            _endpoint.SetAccessPath(path, validateHasBeenSet);
            _useAppEndpointAuth.SetAccessPath(path, validateHasBeenSet);
            _endpointAuth.SetAccessPath(path, validateHasBeenSet);
            _enabled.SetAccessPath(path, validateHasBeenSet);
            _acceptedHttpResponseCodes.SetAccessPath(path, validateHasBeenSet);
            _doRetries.SetAccessPath(path, validateHasBeenSet);
            _status.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
