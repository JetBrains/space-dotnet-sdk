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
    public sealed class WebhookRequestPayload
         : ApplicationPayload, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "WebhookRequestPayload";
        
        public WebhookRequestPayload() { }
        
        public WebhookRequestPayload(string clientId, string webhookId, WebhookEvent payload, string? verificationToken = null)
        {
            VerificationToken = verificationToken;
            ClientId = clientId;
            WebhookId = webhookId;
            Payload = payload;
        }
        
        private PropertyValue<string?> _verificationToken = new PropertyValue<string?>(nameof(WebhookRequestPayload), nameof(VerificationToken));
        
        [JsonPropertyName("verificationToken")]
        public string? VerificationToken
        {
            get => _verificationToken.GetValue();
            set => _verificationToken.SetValue(value);
        }
    
        private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(WebhookRequestPayload), nameof(ClientId));
        
        [Required]
        [JsonPropertyName("clientId")]
        public string ClientId
        {
            get => _clientId.GetValue();
            set => _clientId.SetValue(value);
        }
    
        private PropertyValue<string> _webhookId = new PropertyValue<string>(nameof(WebhookRequestPayload), nameof(WebhookId));
        
        [Required]
        [JsonPropertyName("webhookId")]
        public string WebhookId
        {
            get => _webhookId.GetValue();
            set => _webhookId.SetValue(value);
        }
    
        private PropertyValue<WebhookEvent> _payload = new PropertyValue<WebhookEvent>(nameof(WebhookRequestPayload), nameof(Payload));
        
        [Required]
        [JsonPropertyName("payload")]
        public WebhookEvent Payload
        {
            get => _payload.GetValue();
            set => _payload.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _verificationToken.SetAccessPath(path, validateHasBeenSet);
            _clientId.SetAccessPath(path, validateHasBeenSet);
            _webhookId.SetAccessPath(path, validateHasBeenSet);
            _payload.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
