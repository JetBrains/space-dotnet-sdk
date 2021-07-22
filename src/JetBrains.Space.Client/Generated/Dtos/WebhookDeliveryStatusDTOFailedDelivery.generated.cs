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
    public sealed class WebhookDeliveryStatusDTOFailedDelivery
         : WebhookDeliveryStatus, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "WebhookDeliveryStatusDTO.FailedDelivery";
        
        public WebhookDeliveryStatusDTOFailedDelivery() { }
        
        public WebhookDeliveryStatusDTOFailedDelivery(string deliveryId, int responseCode, string message, DateTime sentTime)
        {
            DeliveryId = deliveryId;
            ResponseCode = responseCode;
            Message = message;
            SentTime = sentTime;
        }
        
        private PropertyValue<string> _deliveryId = new PropertyValue<string>(nameof(WebhookDeliveryStatusDTOFailedDelivery), nameof(DeliveryId));
        
        [Required]
        [JsonPropertyName("deliveryId")]
        public string DeliveryId
        {
            get => _deliveryId.GetValue();
            set => _deliveryId.SetValue(value);
        }
    
        private PropertyValue<int> _responseCode = new PropertyValue<int>(nameof(WebhookDeliveryStatusDTOFailedDelivery), nameof(ResponseCode));
        
        [Required]
        [JsonPropertyName("responseCode")]
        public int ResponseCode
        {
            get => _responseCode.GetValue();
            set => _responseCode.SetValue(value);
        }
    
        private PropertyValue<string> _message = new PropertyValue<string>(nameof(WebhookDeliveryStatusDTOFailedDelivery), nameof(Message));
        
        [Required]
        [JsonPropertyName("message")]
        public string Message
        {
            get => _message.GetValue();
            set => _message.SetValue(value);
        }
    
        private PropertyValue<DateTime> _sentTime = new PropertyValue<DateTime>(nameof(WebhookDeliveryStatusDTOFailedDelivery), nameof(SentTime));
        
        [Required]
        [JsonPropertyName("sentTime")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime SentTime
        {
            get => _sentTime.GetValue();
            set => _sentTime.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _deliveryId.SetAccessPath(path, validateHasBeenSet);
            _responseCode.SetAccessPath(path, validateHasBeenSet);
            _message.SetAccessPath(path, validateHasBeenSet);
            _sentTime.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
