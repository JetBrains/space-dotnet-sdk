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

namespace JetBrains.Space.Client.ChannelEventPartialBuilder
{
    public static class ChannelEventPartialExtensions
    {
        public static Partial<ChannelEvent> WithMeta(this Partial<ChannelEvent> it)
            => it.AddFieldName("meta");
        
        public static Partial<ChannelEvent> WithMeta(this Partial<ChannelEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
            => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
        
        public static Partial<ChannelEvent> WithChannel(this Partial<ChannelEvent> it)
            => it.AddFieldName("channel");
        
        public static Partial<ChannelEvent> WithChannel(this Partial<ChannelEvent> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
            => it.AddFieldName("channel", partialBuilder(new Partial<M2ChannelRecord>(it)));
        
        public static Partial<ChannelEvent> WithName(this Partial<ChannelEvent> it)
            => it.AddFieldName("name");
        
        public static Partial<ChannelEvent> WithDescription(this Partial<ChannelEvent> it)
            => it.AddFieldName("description");
        
        public static Partial<ChannelEvent> WithIcon(this Partial<ChannelEvent> it)
            => it.AddFieldName("icon");
        
        public static Partial<ChannelEvent> WithIsRestored(this Partial<ChannelEvent> it)
            => it.AddFieldName("restored");
        
        public static Partial<ChannelEvent> WithIsArchived(this Partial<ChannelEvent> it)
            => it.AddFieldName("archived");
        
    }
    
}
