// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class MetricsRequest
         : IPropagatePropertyAccessPath
    {
        public MetricsRequest() { }
        
        public MetricsRequest(ClientInfo client, List<MetricsEvent> events)
        {
            Client = client;
            Events = events;
        }
        
        private PropertyValue<ClientInfo> _client = new PropertyValue<ClientInfo>(nameof(MetricsRequest), nameof(Client));
        
        [Required]
        [JsonPropertyName("client")]
        public ClientInfo Client
        {
            get { return _client.GetValue(); }
            set { _client.SetValue(value); }
        }
    
        private PropertyValue<List<MetricsEvent>> _events = new PropertyValue<List<MetricsEvent>>(nameof(MetricsRequest), nameof(Events));
        
        [Required]
        [JsonPropertyName("events")]
        public List<MetricsEvent> Events
        {
            get { return _events.GetValue(); }
            set { _events.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _client.SetAccessPath(path, validateHasBeenSet);
            _events.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
