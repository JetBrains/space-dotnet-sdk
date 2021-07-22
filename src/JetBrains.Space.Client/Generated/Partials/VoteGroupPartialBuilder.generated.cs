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

namespace JetBrains.Space.Client.VoteGroupPartialBuilder
{
    public static class VoteGroupPartialExtensions
    {
        public static Partial<VoteGroup> WithVariantName(this Partial<VoteGroup> it)
            => it.AddFieldName("variantName");
        
        public static Partial<VoteGroup> WithCount(this Partial<VoteGroup> it)
            => it.AddFieldName("count");
        
        public static Partial<VoteGroup> WithIsMeVote(this Partial<VoteGroup> it)
            => it.AddFieldName("meVote");
        
        public static Partial<VoteGroup> WithLastUsers(this Partial<VoteGroup> it)
            => it.AddFieldName("lastUsers");
        
        public static Partial<VoteGroup> WithLastUsers(this Partial<VoteGroup> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("lastUsers", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<VoteGroup> WithOwner(this Partial<VoteGroup> it)
            => it.AddFieldName("owner");
        
        public static Partial<VoteGroup> WithOwner(this Partial<VoteGroup> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("owner", partialBuilder(new Partial<TDMemberProfile>(it)));
        
    }
    
}
