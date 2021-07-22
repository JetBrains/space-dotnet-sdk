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

namespace JetBrains.Space.Client.M2ChannelContentCodeDiscussionPartialBuilder
{
    public static class M2ChannelContentCodeDiscussionPartialExtensions
    {
        public static Partial<M2ChannelContentCodeDiscussion> WithCodeDiscussionId(this Partial<M2ChannelContentCodeDiscussion> it)
            => it.AddFieldName("codeDiscussionId");
        
        public static Partial<M2ChannelContentCodeDiscussion> WithNotificationDefaults(this Partial<M2ChannelContentCodeDiscussion> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelContentCodeDiscussion> WithNotificationDefaults(this Partial<M2ChannelContentCodeDiscussion> it, Func<Partial<ChannelSpecificDefaults>, Partial<ChannelSpecificDefaults>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaults>(it)));
        
        public static Partial<M2ChannelContentCodeDiscussion> WithCodeDiscussion(this Partial<M2ChannelContentCodeDiscussion> it)
            => it.AddFieldName("codeDiscussion");
        
        public static Partial<M2ChannelContentCodeDiscussion> WithCodeDiscussion(this Partial<M2ChannelContentCodeDiscussion> it, Func<Partial<CodeDiscussionRecord>, Partial<CodeDiscussionRecord>> partialBuilder)
            => it.AddFieldName("codeDiscussion", partialBuilder(new Partial<CodeDiscussionRecord>(it)));
        
    }
    
}
