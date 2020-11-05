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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.ChatsMessagesSendMessagePostRequestPartialBuilder
{
    public static class ChatsMessagesSendMessagePostRequestPartialExtensions
    {
        public static Partial<ChatsMessagesSendMessagePostRequest> WithRecipient(this Partial<ChatsMessagesSendMessagePostRequest> it)
            => it.AddFieldName("recipient");
        
        public static Partial<ChatsMessagesSendMessagePostRequest> WithRecipient(this Partial<ChatsMessagesSendMessagePostRequest> it, Func<Partial<MessageRecipient>, Partial<MessageRecipient>> partialBuilder)
            => it.AddFieldName("recipient", partialBuilder(new Partial<MessageRecipient>(it)));
        
        public static Partial<ChatsMessagesSendMessagePostRequest> WithContent(this Partial<ChatsMessagesSendMessagePostRequest> it)
            => it.AddFieldName("content");
        
        public static Partial<ChatsMessagesSendMessagePostRequest> WithContent(this Partial<ChatsMessagesSendMessagePostRequest> it, Func<Partial<ChatMessage>, Partial<ChatMessage>> partialBuilder)
            => it.AddFieldName("content", partialBuilder(new Partial<ChatMessage>(it)));
        
        public static Partial<ChatsMessagesSendMessagePostRequest> WithIsUnfurlLinks(this Partial<ChatsMessagesSendMessagePostRequest> it)
            => it.AddFieldName("unfurlLinks");
        
        public static Partial<ChatsMessagesSendMessagePostRequest> WithAttachments(this Partial<ChatsMessagesSendMessagePostRequest> it)
            => it.AddFieldName("attachments");
        
        public static Partial<ChatsMessagesSendMessagePostRequest> WithAttachments(this Partial<ChatsMessagesSendMessagePostRequest> it, Func<Partial<AttachmentIn>, Partial<AttachmentIn>> partialBuilder)
            => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentIn>(it)));
        
        public static Partial<ChatsMessagesSendMessagePostRequest> WithExternalId(this Partial<ChatsMessagesSendMessagePostRequest> it)
            => it.AddFieldName("externalId");
        
    }
    
}