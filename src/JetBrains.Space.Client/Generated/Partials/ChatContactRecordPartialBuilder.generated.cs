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

namespace JetBrains.Space.Client.ChatContactRecordPartialBuilder;

public static class ChatContactRecordPartialExtensions
{
    public static Partial<ChatContactRecord> WithId(this Partial<ChatContactRecord> it)
        => it.AddFieldName("id");
    
    public static Partial<ChatContactRecord> WithIsArchived(this Partial<ChatContactRecord> it)
        => it.AddFieldName("archived");
    
    public static Partial<ChatContactRecord> WithKey(this Partial<ChatContactRecord> it)
        => it.AddFieldName("key");
    
    public static Partial<ChatContactRecord> WithDetails(this Partial<ChatContactRecord> it)
        => it.AddFieldName("details");
    
    public static Partial<ChatContactRecord> WithDetails(this Partial<ChatContactRecord> it, Func<Partial<ChatContactDetails>, Partial<ChatContactDetails>> partialBuilder)
        => it.AddFieldName("details", partialBuilder(new Partial<ChatContactDetails>(it)));
    
    public static Partial<ChatContactRecord> WithChannelType(this Partial<ChatContactRecord> it)
        => it.AddFieldName("channelType");
    
    public static Partial<ChatContactRecord> WithLastMessage(this Partial<ChatContactRecord> it)
        => it.AddFieldName("lastMessage");
    
    public static Partial<ChatContactRecord> WithLastMessage(this Partial<ChatContactRecord> it, Func<Partial<MessageInfo>, Partial<MessageInfo>> partialBuilder)
        => it.AddFieldName("lastMessage", partialBuilder(new Partial<MessageInfo>(it)));
    
    public static Partial<ChatContactRecord> WithUnreadStatus(this Partial<ChatContactRecord> it)
        => it.AddFieldName("unreadStatus");
    
    public static Partial<ChatContactRecord> WithUnreadStatus(this Partial<ChatContactRecord> it, Func<Partial<M2UnreadStatus>, Partial<M2UnreadStatus>> partialBuilder)
        => it.AddFieldName("unreadStatus", partialBuilder(new Partial<M2UnreadStatus>(it)));
    
    public static Partial<ChatContactRecord> WithReadTime(this Partial<ChatContactRecord> it)
        => it.AddFieldName("readTime");
    
    public static Partial<ChatContactRecord> WithSubscribedSince(this Partial<ChatContactRecord> it)
        => it.AddFieldName("subscribedSince");
    
    public static Partial<ChatContactRecord> WithIsPinned(this Partial<ChatContactRecord> it)
        => it.AddFieldName("pinned");
    
    public static Partial<ChatContactRecord> WithPinnedPrevId(this Partial<ChatContactRecord> it)
        => it.AddFieldName("pinnedPrevId");
    
    public static Partial<ChatContactRecord> WithDraft(this Partial<ChatContactRecord> it)
        => it.AddFieldName("draft");
    
    public static Partial<ChatContactRecord> WithDraftTime(this Partial<ChatContactRecord> it)
        => it.AddFieldName("draftTime");
    
    public static Partial<ChatContactRecord> WithLastChildMessageTime(this Partial<ChatContactRecord> it)
        => it.AddFieldName("lastChildMessageTime");
    
    public static Partial<ChatContactRecord> WithIsDeleted(this Partial<ChatContactRecord> it)
        => it.AddFieldName("deleted");
    
    public static Partial<ChatContactRecord> WithIsMuted(this Partial<ChatContactRecord> it)
        => it.AddFieldName("muted");
    
}

