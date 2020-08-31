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

namespace SpaceDotNet.Client.TDTeamPartialBuilder
{
    public static class TDTeamPartialExtensions
    {
        public static Partial<TDTeam> WithId(this Partial<TDTeam> it)
            => it.AddFieldName("id");
        
        public static Partial<TDTeam> WithName(this Partial<TDTeam> it)
            => it.AddFieldName("name");
        
        public static Partial<TDTeam> WithDescription(this Partial<TDTeam> it)
            => it.AddFieldName("description");
        
        public static Partial<TDTeam> WithParent(this Partial<TDTeam> it)
            => it.AddFieldName("parent");
        
        public static Partial<TDTeam> WithParentRecursive(this Partial<TDTeam> it)
            => it.AddFieldName("parent!");
        
        public static Partial<TDTeam> WithParent(this Partial<TDTeam> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<TDTeam> WithEmails(this Partial<TDTeam> it)
            => it.AddFieldName("emails");
        
        public static Partial<TDTeam> WithChannelId(this Partial<TDTeam> it)
            => it.AddFieldName("channelId");
        
        public static Partial<TDTeam> WithIsArchived(this Partial<TDTeam> it)
            => it.AddFieldName("archived");
        
        public static Partial<TDTeam> WithIsDisbanded(this Partial<TDTeam> it)
            => it.AddFieldName("disbanded");
        
        public static Partial<TDTeam> WithDisbandedAt(this Partial<TDTeam> it)
            => it.AddFieldName("disbandedAt");
        
        public static Partial<TDTeam> WithMemberships(this Partial<TDTeam> it)
            => it.AddFieldName("memberships");
        
        public static Partial<TDTeam> WithMemberships(this Partial<TDTeam> it, Func<Partial<TDMembership>, Partial<TDMembership>> partialBuilder)
            => it.AddFieldName("memberships", partialBuilder(new Partial<TDMembership>(it)));
        
        public static Partial<TDTeam> WithCustomFields(this Partial<TDTeam> it)
            => it.AddFieldName("customFields");
        
        public static Partial<TDTeam> WithCustomFields(this Partial<TDTeam> it, Func<Partial<CFValue>, Partial<CFValue>> partialBuilder)
            => it.AddFieldName("customFields", partialBuilder(new Partial<CFValue>(it)));
        
    }
    
}
