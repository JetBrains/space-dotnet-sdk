// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class ESServiceDto
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESServiceDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id { get { return _id.GetValue(); } set { _id.SetValue(value); } }
    
        private PropertyValue<TDMemberProfileDto?> _owner = new PropertyValue<TDMemberProfileDto?>(nameof(ESServiceDto), nameof(Owner));
        
        [JsonPropertyName("owner")]
        public TDMemberProfileDto? Owner { get { return _owner.GetValue(); } set { _owner.SetValue(value); } }
    
        private PropertyValue<OAuthServiceType> _type = new PropertyValue<OAuthServiceType>(nameof(ESServiceDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public OAuthServiceType Type { get { return _type.GetValue(); } set { _type.SetValue(value); } }
    
        private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(ESServiceDto), nameof(ClientId));
        
        [Required]
        [JsonPropertyName("clientId")]
        public string ClientId { get { return _clientId.GetValue(); } set { _clientId.SetValue(value); } }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ESServiceDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get { return _name.GetValue(); } set { _name.SetValue(value); } }
    
        private PropertyValue<string> _redirectURIs = new PropertyValue<string>(nameof(ESServiceDto), nameof(RedirectURIs));
        
        [Required]
        [JsonPropertyName("redirectURIs")]
        public string RedirectURIs { get { return _redirectURIs.GetValue(); } set { _redirectURIs.SetValue(value); } }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ESServiceDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get { return _archived.GetValue(); } set { _archived.SetValue(value); } }
    
        private PropertyValue<AccessRecordDto?> _lastClientCredentialsAccess = new PropertyValue<AccessRecordDto?>(nameof(ESServiceDto), nameof(LastClientCredentialsAccess));
        
        [JsonPropertyName("lastClientCredentialsAccess")]
        public AccessRecordDto? LastClientCredentialsAccess { get { return _lastClientCredentialsAccess.GetValue(); } set { _lastClientCredentialsAccess.SetValue(value); } }
    
    }
    
}
