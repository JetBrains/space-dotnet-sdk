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
    public class ChatsMessagesSendMessageRequest
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<MessageRecipientDto> _recipient = new PropertyValue<MessageRecipientDto>(nameof(ChatsMessagesSendMessageRequest), nameof(Recipient));
        
        [Required]
        [JsonPropertyName("recipient")]
        public MessageRecipientDto Recipient
        {
            get { return _recipient.GetValue(); }
            set { _recipient.SetValue(value); }
        }
    
        private PropertyValue<ChatMessageDto> _content = new PropertyValue<ChatMessageDto>(nameof(ChatsMessagesSendMessageRequest), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public ChatMessageDto Content
        {
            get { return _content.GetValue(); }
            set { _content.SetValue(value); }
        }
    
        private PropertyValue<bool?> _unfurlLinks = new PropertyValue<bool?>(nameof(ChatsMessagesSendMessageRequest), nameof(UnfurlLinks));
        
        [JsonPropertyName("unfurlLinks")]
        public bool? UnfurlLinks
        {
            get { return _unfurlLinks.GetValue(); }
            set { _unfurlLinks.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _recipient.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            _unfurlLinks.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}