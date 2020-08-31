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
    public sealed class ESAzureAuthModuleSettings
         : ESOAuth2AuthModuleSettings, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_AzureAuthModuleSettings";
        
        public ESAzureAuthModuleSettings() { }
        
        public ESAzureAuthModuleSettings(string tenantId, string clientId, string clientSecret, bool registerNewUsers, bool emailVerified)
        {
            TenantId = tenantId;
            ClientId = clientId;
            ClientSecret = clientSecret;
            IsRegisterNewUsers = registerNewUsers;
            IsEmailVerified = emailVerified;
        }
        
        private PropertyValue<string> _tenantId = new PropertyValue<string>(nameof(ESAzureAuthModuleSettings), nameof(TenantId));
        
        [Required]
        [JsonPropertyName("tenantId")]
        public string TenantId
        {
            get { return _tenantId.GetValue(); }
            set { _tenantId.SetValue(value); }
        }
    
        private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(ESAzureAuthModuleSettings), nameof(ClientId));
        
        [Required]
        [JsonPropertyName("clientId")]
        public string ClientId
        {
            get { return _clientId.GetValue(); }
            set { _clientId.SetValue(value); }
        }
    
        private PropertyValue<string> _clientSecret = new PropertyValue<string>(nameof(ESAzureAuthModuleSettings), nameof(ClientSecret));
        
        [Required]
        [JsonPropertyName("clientSecret")]
        public string ClientSecret
        {
            get { return _clientSecret.GetValue(); }
            set { _clientSecret.SetValue(value); }
        }
    
        private PropertyValue<bool> _registerNewUsers = new PropertyValue<bool>(nameof(ESAzureAuthModuleSettings), nameof(IsRegisterNewUsers));
        
        [Required]
        [JsonPropertyName("registerNewUsers")]
        public bool IsRegisterNewUsers
        {
            get { return _registerNewUsers.GetValue(); }
            set { _registerNewUsers.SetValue(value); }
        }
    
        private PropertyValue<bool> _emailVerified = new PropertyValue<bool>(nameof(ESAzureAuthModuleSettings), nameof(IsEmailVerified));
        
        [Required]
        [JsonPropertyName("emailVerified")]
        public bool IsEmailVerified
        {
            get { return _emailVerified.GetValue(); }
            set { _emailVerified.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _tenantId.SetAccessPath(path, validateHasBeenSet);
            _clientId.SetAccessPath(path, validateHasBeenSet);
            _clientSecret.SetAccessPath(path, validateHasBeenSet);
            _registerNewUsers.SetAccessPath(path, validateHasBeenSet);
            _emailVerified.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
