// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.M2ChannelContentRecordPartialBuilder
{
    public static class M2ChannelContentRecordPartialExtensions
    {
        public static Partial<M2ChannelContentRecord> WithId(this Partial<M2ChannelContentRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<M2ChannelContentRecord> WithContent(this Partial<M2ChannelContentRecord> it)
            => it.AddFieldName("content");
        
        public static Partial<M2ChannelContentRecord> WithContent(this Partial<M2ChannelContentRecord> it, Func<Partial<M2ChannelContentInfo>, Partial<M2ChannelContentInfo>> partialBuilder)
            => it.AddFieldName("content", partialBuilder(new Partial<M2ChannelContentInfo>(it)));
        
    }
    
}
