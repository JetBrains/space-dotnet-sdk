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
    public partial class ChatClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public ChatClient(Connection connection)
        {
            _connection = connection;
        }
        
        public ChannelClient Channels => new ChannelClient(_connection);
        
        public partial class ChannelClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public ChannelClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create or get a direct messages channel with a profile.
            /// </summary>
            public async Task<M2ChannelRecord> GetOrCreateDirectMessagesChannelAsync(string profile, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<M2ChannelRecord>()) : Partial<M2ChannelRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<ChatsChannelsDmPostRequest, M2ChannelRecord>("POST", $"api/http/chats/channels/dm{queryParameters.ToQueryString()}", 
                    new ChatsChannelsDmPostRequest
                    { 
                        Profile = profile,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Check whether a channel name is available. Returns true when the channel name can be used to create a new channel, false otherwise.
            /// </summary>
            public async Task<bool> IsNameFreeAsync(string name, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                return await _connection.RequestResourceAsync<ChatsChannelsIsNameFreePostRequest, bool>("POST", $"api/http/chats/channels/is-name-free{queryParameters.ToQueryString()}", 
                    new ChatsChannelsIsNameFreePostRequest
                    { 
                        Name = name,
                    }, cancellationToken);
            }
            
        
            public async Task<List<string>> ImportMessageHistoryAsync(string channelId, List<MessageForImport> messages, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                return await _connection.RequestResourceAsync<ChatsChannelsForChannelIdImportPostRequest, List<string>>("POST", $"api/http/chats/channels/{channelId}/import{queryParameters.ToQueryString()}", 
                    new ChatsChannelsForChannelIdImportPostRequest
                    { 
                        Messages = messages,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Restore an archived channel, and allow new messages to be added.
            /// </summary>
            public async Task RestoreArchivedChannelAsync(string channelId, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/chats/channels/{channelId}/restore-archived{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            public async Task<Batch<AllChannelsListEntry>> ListAllChannelsAsync(string query, string? skip = null, int? top = 100, string? quickFilter = null, string? sortColumn = null, ColumnSortOrder? sortOrder = ColumnSortOrder.ASC, Func<Partial<Batch<AllChannelsListEntry>>, Partial<Batch<AllChannelsListEntry>>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("query", query);
                if (skip != null) queryParameters.Append("$skip", skip);
                if (top != null) queryParameters.Append("$top", top?.ToString());
                if (quickFilter != null) queryParameters.Append("quickFilter", quickFilter);
                if (sortColumn != null) queryParameters.Append("sortColumn", sortColumn);
                queryParameters.Append("sortOrder", sortOrder.ToEnumString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Batch<AllChannelsListEntry>>()) : Partial<Batch<AllChannelsListEntry>>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<Batch<AllChannelsListEntry>>("GET", $"api/http/chats/channels/all-channels{queryParameters.ToQueryString()}", cancellationToken);
            }
            
            
            public IAsyncEnumerable<AllChannelsListEntry> ListAllChannelsAsyncEnumerable(string query, string? skip = null, int? top = 100, string? quickFilter = null, string? sortColumn = null, ColumnSortOrder? sortOrder = ColumnSortOrder.ASC, Func<Partial<AllChannelsListEntry>, Partial<AllChannelsListEntry>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => ListAllChannelsAsync(query: query, top: top, quickFilter: quickFilter, sortColumn: sortColumn, sortOrder: sortOrder, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<AllChannelsListEntry>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<AllChannelsListEntry>.Default())), skip, cancellationToken);
        
            /// <summary>
            /// Delete a channel. No one will be able to view this channel or its threads. This action cannot be undone.
            /// </summary>
            public async Task DeleteChannelAsync(string channelId, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("DELETE", $"api/http/chats/channels/{channelId}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Archive a channel, and reject new messages being added. It is still possible to view messages from an archived channel. It is possible to restore the channel later.
            /// </summary>
            public async Task ArchiveChannelAsync(string channelId, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("DELETE", $"api/http/chats/channels/{channelId}/archive{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            public MessageClient Messages => new MessageClient(_connection);
            
            public partial class MessageClient : ISpaceClient
            {
                private readonly Connection _connection;
                
                public MessageClient(Connection connection)
                {
                    _connection = connection;
                }
                
                /// <summary>
                /// Send a message to a channel. Message text is a string.
                /// </summary>
                public async Task<ChannelItemRecord> SendTextMessageAsync(string channelId, string text, string? temporaryId = null, Func<Partial<ChannelItemRecord>, Partial<ChannelItemRecord>>? partial = null, CancellationToken cancellationToken = default)
                {
                    var queryParameters = new NameValueCollection();
                    queryParameters.Append("$fields", (partial != null ? partial(new Partial<ChannelItemRecord>()) : Partial<ChannelItemRecord>.Default()).ToString());
                    
                    return await _connection.RequestResourceAsync<ChatsChannelsForChannelIdMessagesPostRequest, ChannelItemRecord>("POST", $"api/http/chats/channels/{channelId}/messages{queryParameters.ToQueryString()}", 
                        new ChatsChannelsForChannelIdMessagesPostRequest
                        { 
                            Text = text,
                            TemporaryId = temporaryId,
                        }, cancellationToken);
                }
                
            
            }
        
        }
    
        public MessageClient Messages => new MessageClient(_connection);
        
        public partial class MessageClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public MessageClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Delete a message from a channel.
            /// </summary>
            public async Task DeleteMessageAsync(string channel, ChatMessageIdentifier id, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/chats/messages/delete-message{queryParameters.ToQueryString()}", 
                    new ChatsMessagesDeleteMessagePostRequest
                    { 
                        Channel = channel,
                        Id = id,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Edit an existing message. Message content can be a string, or a block with one or several sections of information.
            /// </summary>
            public async Task EditMessageAsync(string channel, ChatMessageIdentifier message, ChatMessage content, bool? unfurlLinks = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/chats/messages/edit-message{queryParameters.ToQueryString()}", 
                    new ChatsMessagesEditMessagePostRequest
                    { 
                        Channel = channel,
                        Message = message,
                        Content = content,
                        IsUnfurlLinks = unfurlLinks,
                    }, cancellationToken);
            }
            
        
            [Obsolete("Use POST chats/messages/edit-message (since 2020-06-06) (will be removed in a future version)")]
            public async Task EditTextMessageAsync(string channelId, string text, string messageId, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/chats/messages/edit-text-message{queryParameters.ToQueryString()}", 
                    new ChatsMessagesEditTextMessagePostRequest
                    { 
                        ChannelId = channelId,
                        Text = text,
                        MessageId = messageId,
                    }, cancellationToken);
            }
            
        
            [Obsolete("Use POST chats/channels/{channelId}/messages (since 2020-01-17) (will be removed in a future version)")]
            public async Task<ChannelItemRecord> SendTextMessageAsync(string channel, string text, bool pending = false, string? temporaryId = null, Func<Partial<ChannelItemRecord>, Partial<ChannelItemRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<ChannelItemRecord>()) : Partial<ChannelItemRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<ChatsMessagesSendPostRequest, ChannelItemRecord>("POST", $"api/http/chats/messages/send{queryParameters.ToQueryString()}", 
                    new ChatsMessagesSendPostRequest
                    { 
                        Channel = channel,
                        Text = text,
                        IsPending = pending,
                        TemporaryId = temporaryId,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Send a message to a recipient, such as a channel, member, issue, code review, ... Message content can be a string, or a block with one or several sections of information.
            /// </summary>
            public async Task<ChannelItemRecord> SendMessageAsync(MessageRecipient recipient, ChatMessage content, bool? unfurlLinks = null, List<AttachmentIn>? attachments = null, string? externalId = null, Func<Partial<ChannelItemRecord>, Partial<ChannelItemRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<ChannelItemRecord>()) : Partial<ChannelItemRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<ChatsMessagesSendMessagePostRequest, ChannelItemRecord>("POST", $"api/http/chats/messages/send-message{queryParameters.ToQueryString()}", 
                    new ChatsMessagesSendMessagePostRequest
                    { 
                        Recipient = recipient,
                        Content = content,
                        IsUnfurlLinks = unfurlLinks,
                        Attachments = attachments,
                        ExternalId = externalId,
                    }, cancellationToken);
            }
            
        
        }
    
    }
    
}
