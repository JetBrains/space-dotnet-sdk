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
    public partial class ChatClient
    {
        private readonly Connection _connection;
        
        public ChatClient(Connection connection)
        {
            _connection = connection;
        }
        
        public ChannelClient Channels => new ChannelClient(_connection);
        
        public partial class ChannelClient
        {
            private readonly Connection _connection;
            
            public ChannelClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<M2ChannelRecordDto> GetOrCreateDirectMessagesChannelAsync(string profile, Func<Partial<M2ChannelRecordDto>, Partial<M2ChannelRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<ChatsChannelsDmRequest, M2ChannelRecordDto>("POST", $"api/http/chats/channels/dm?$fields={(partial != null ? partial(new Partial<M2ChannelRecordDto>()) : Partial<M2ChannelRecordDto>.Default())}", new ChatsChannelsDmRequest{ Profile = profile });
        
            public async Task<bool> IsNameFreeAsync(string name)
                => await _connection.RequestResourceAsync<ChatsChannelsIsNameFreeRequest, bool>("POST", $"api/http/chats/channels/is-name-free", new ChatsChannelsIsNameFreeRequest{ Name = name });
        
            public async Task<List<string>> ImportMessageHistoryAsync(string channelId, List<MessageForImportDto> messages)
                => await _connection.RequestResourceAsync<ChatsChannelsForChannelIdImportRequest, List<string>>("POST", $"api/http/chats/channels/{channelId}/import", new ChatsChannelsForChannelIdImportRequest{ Messages = messages });
        
            public async Task RestoreArchivedChannelAsync(string channelId)
                => await _connection.RequestResourceAsync("POST", $"api/http/chats/channels/{channelId}/restore-archived");
        
            public async Task DeleteChannelAsync(string channelId)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/chats/channels/{channelId}");
        
            public async Task ArchiveChannelAsync(string channelId)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/chats/channels/{channelId}/archive");
        
            public MessageClient Messages => new MessageClient(_connection);
            
            public partial class MessageClient
            {
                private readonly Connection _connection;
                
                public MessageClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<ChannelItemRecordDto> SendTextMessageAsync(string channelId, string text, string? temporaryId = null, Func<Partial<ChannelItemRecordDto>, Partial<ChannelItemRecordDto>>? partial = null)
                    => await _connection.RequestResourceAsync<ChatsChannelsForChannelIdMessagesRequest, ChannelItemRecordDto>("POST", $"api/http/chats/channels/{channelId}/messages?$fields={(partial != null ? partial(new Partial<ChannelItemRecordDto>()) : Partial<ChannelItemRecordDto>.Default())}", new ChatsChannelsForChannelIdMessagesRequest{ Text = text, TemporaryId = temporaryId });
            
            }
        
        }
    
        public MessageClient Messages => new MessageClient(_connection);
        
        public partial class MessageClient
        {
            private readonly Connection _connection;
            
            public MessageClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task DeleteMessageAsync(string channel, string id)
                => await _connection.RequestResourceAsync("POST", $"api/http/chats/messages/delete-message", new ChatsMessagesDeleteMessageRequest{ Channel = channel, Id = id });
        
            public async Task EditMessageAsync(string channel, string message, ChatMessageDto content, bool? unfurlLinks = null)
                => await _connection.RequestResourceAsync("POST", $"api/http/chats/messages/edit-message", new ChatsMessagesEditMessageRequest{ Channel = channel, Message = message, Content = content, UnfurlLinks = unfurlLinks });
        
            [Obsolete("Use POST chats/messages/edit-message (since 2020-06-06) (marked for removal)")]
            public async Task EditTextMessageAsync(string channelId, string text, string messageId)
                => await _connection.RequestResourceAsync("POST", $"api/http/chats/messages/edit-text-message", new ChatsMessagesEditTextMessageRequest{ ChannelId = channelId, Text = text, MessageId = messageId });
        
            [Obsolete("Use POST chats/channels/{channelId}/messages (since 2020-01-17) (marked for removal)")]
            public async Task<ChannelItemRecordDto> SendTextMessageAsync(string channel, string text, bool pending, string? temporaryId = null, Func<Partial<ChannelItemRecordDto>, Partial<ChannelItemRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<ChatsMessagesSendRequest, ChannelItemRecordDto>("POST", $"api/http/chats/messages/send?$fields={(partial != null ? partial(new Partial<ChannelItemRecordDto>()) : Partial<ChannelItemRecordDto>.Default())}", new ChatsMessagesSendRequest{ Channel = channel, Text = text, Pending = pending, TemporaryId = temporaryId });
        
            public async Task<ChannelItemRecordDto> SendMessageAsync(MessageRecipientDto recipient, ChatMessageDto content, bool? unfurlLinks = null, Func<Partial<ChannelItemRecordDto>, Partial<ChannelItemRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<ChatsMessagesSendMessageRequest, ChannelItemRecordDto>("POST", $"api/http/chats/messages/send-message?$fields={(partial != null ? partial(new Partial<ChannelItemRecordDto>()) : Partial<ChannelItemRecordDto>.Default())}", new ChatsMessagesSendMessageRequest{ Recipient = recipient, Content = content, UnfurlLinks = unfurlLinks });
        
        }
    
    }
    
}
