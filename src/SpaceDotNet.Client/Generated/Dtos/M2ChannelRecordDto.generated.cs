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
    public sealed class M2ChannelRecordDto
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(M2ChannelRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id { get { return _id.GetValue(); } set { _id.SetValue(value); } }
    
        private PropertyValue<M2ChannelContactDto> _contact = new PropertyValue<M2ChannelContactDto>(nameof(M2ChannelRecordDto), nameof(Contact));
        
        [Required]
        [JsonPropertyName("contact")]
        public M2ChannelContactDto Contact { get { return _contact.GetValue(); } set { _contact.SetValue(value); } }
    
        private PropertyValue<int> _totalMessages = new PropertyValue<int>(nameof(M2ChannelRecordDto), nameof(TotalMessages));
        
        [Required]
        [JsonPropertyName("totalMessages")]
        public int TotalMessages { get { return _totalMessages.GetValue(); } set { _totalMessages.SetValue(value); } }
    
        private PropertyValue<MessageInfoDto?> _lastMessage = new PropertyValue<MessageInfoDto?>(nameof(M2ChannelRecordDto), nameof(LastMessage));
        
        [JsonPropertyName("lastMessage")]
        public MessageInfoDto? LastMessage { get { return _lastMessage.GetValue(); } set { _lastMessage.SetValue(value); } }
    
        private PropertyValue<List<TDMemberProfileDto>?> _authors = new PropertyValue<List<TDMemberProfileDto>?>(nameof(M2ChannelRecordDto), nameof(Authors));
        
        [JsonPropertyName("authors")]
        public List<TDMemberProfileDto>? Authors { get { return _authors.GetValue(); } set { _authors.SetValue(value); } }
    
        private PropertyValue<List<CPrincipalDto>?> _commentAuthors = new PropertyValue<List<CPrincipalDto>?>(nameof(M2ChannelRecordDto), nameof(CommentAuthors));
        
        [JsonPropertyName("commentAuthors")]
        public List<CPrincipalDto>? CommentAuthors { get { return _commentAuthors.GetValue(); } set { _commentAuthors.SetValue(value); } }
    
        private PropertyValue<List<ChannelParticipantDto>?> _participants = new PropertyValue<List<ChannelParticipantDto>?>(nameof(M2ChannelRecordDto), nameof(Participants));
        
        [JsonPropertyName("participants")]
        public List<ChannelParticipantDto>? Participants { get { return _participants.GetValue(); } set { _participants.SetValue(value); } }
    
        private PropertyValue<bool?> _channelArchived = new PropertyValue<bool?>(nameof(M2ChannelRecordDto), nameof(ChannelArchived));
        
        [JsonPropertyName("channelArchived")]
        public bool? ChannelArchived { get { return _channelArchived.GetValue(); } set { _channelArchived.SetValue(value); } }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(M2ChannelRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get { return _archived.GetValue(); } set { _archived.SetValue(value); } }
    
        private PropertyValue<M2ChannelRecordDto> _channel = new PropertyValue<M2ChannelRecordDto>(nameof(M2ChannelRecordDto), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecordDto Channel { get { return _channel.GetValue(); } set { _channel.SetValue(value); } }
    
        private PropertyValue<List<ChannelItemRecordDto>?> _messages = new PropertyValue<List<ChannelItemRecordDto>?>(nameof(M2ChannelRecordDto), nameof(Messages));
        
        [JsonPropertyName("messages")]
        public List<ChannelItemRecordDto>? Messages { get { return _messages.GetValue(); } set { _messages.SetValue(value); } }
    
        private PropertyValue<M2ChannelContentInfoDto?> _content = new PropertyValue<M2ChannelContentInfoDto?>(nameof(M2ChannelRecordDto), nameof(Content));
        
        [JsonPropertyName("content")]
        public M2ChannelContentInfoDto? Content { get { return _content.GetValue(); } set { _content.SetValue(value); } }
    
    }
    
}
