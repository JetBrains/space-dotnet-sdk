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
    public sealed class M2ChannelContactThreadDto
         : M2ChannelContactInfoDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<M2ChannelRecordDto> _parent = new PropertyValue<M2ChannelRecordDto>(nameof(M2ChannelContactThreadDto), nameof(Parent));
        
        [Required]
        [JsonPropertyName("parent")]
        public M2ChannelRecordDto Parent { get { return _parent.GetValue(); } set { _parent.SetValue(value); } }
    
        private PropertyValue<string?> _text = new PropertyValue<string?>(nameof(M2ChannelContactThreadDto), nameof(Text));
        
        [JsonPropertyName("text")]
        public string? Text { get { return _text.GetValue(); } set { _text.SetValue(value); } }
    
        private PropertyValue<string?> _messageId = new PropertyValue<string?>(nameof(M2ChannelContactThreadDto), nameof(MessageId));
        
        [JsonPropertyName("messageId")]
        public string? MessageId { get { return _messageId.GetValue(); } set { _messageId.SetValue(value); } }
    
        private PropertyValue<TDMemberProfileDto?> _author = new PropertyValue<TDMemberProfileDto?>(nameof(M2ChannelContactThreadDto), nameof(Author));
        
        [JsonPropertyName("author")]
        public TDMemberProfileDto? Author { get { return _author.GetValue(); } set { _author.SetValue(value); } }
    
        private PropertyValue<CPrincipalDto?> _messageAuthor = new PropertyValue<CPrincipalDto?>(nameof(M2ChannelContactThreadDto), nameof(MessageAuthor));
        
        [JsonPropertyName("messageAuthor")]
        public CPrincipalDto? MessageAuthor { get { return _messageAuthor.GetValue(); } set { _messageAuthor.SetValue(value); } }
    
        private PropertyValue<string?> _attachments = new PropertyValue<string?>(nameof(M2ChannelContactThreadDto), nameof(Attachments));
        
        [JsonPropertyName("attachments")]
        public string? Attachments { get { return _attachments.GetValue(); } set { _attachments.SetValue(value); } }
    
    }
    
}
