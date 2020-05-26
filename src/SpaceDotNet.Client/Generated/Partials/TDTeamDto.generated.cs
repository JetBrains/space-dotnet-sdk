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

namespace SpaceDotNet.Client.TDTeamExtensions
{
    public static class TDTeamDtoPartialExtensions
    {
        public static Partial<TDTeamDto> WithId(this Partial<TDTeamDto> it)
            => it.AddFieldName("id");
        
        public static Partial<TDTeamDto> WithName(this Partial<TDTeamDto> it)
            => it.AddFieldName("name");
        
        public static Partial<TDTeamDto> WithDescription(this Partial<TDTeamDto> it)
            => it.AddFieldName("description");
        
        public static Partial<TDTeamDto> WithParent(this Partial<TDTeamDto> it)
            => it.AddFieldName("parent");
        
        public static Partial<TDTeamDto> WithParentRecursive(this Partial<TDTeamDto> it)
            => it.AddFieldName("parent!");
        
        public static Partial<TDTeamDto> WithParent(this Partial<TDTeamDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<TDTeamDto>()));
        
        public static Partial<TDTeamDto> WithEmails(this Partial<TDTeamDto> it)
            => it.AddFieldName("emails");
        
        public static Partial<TDTeamDto> WithChannelId(this Partial<TDTeamDto> it)
            => it.AddFieldName("channelId");
        
        public static Partial<TDTeamDto> WithArchived(this Partial<TDTeamDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<TDTeamDto> WithDisbanded(this Partial<TDTeamDto> it)
            => it.AddFieldName("disbanded");
        
        public static Partial<TDTeamDto> WithDisbandedAt(this Partial<TDTeamDto> it)
            => it.AddFieldName("disbandedAt");
        
        public static Partial<TDTeamDto> WithMemberships(this Partial<TDTeamDto> it)
            => it.AddFieldName("memberships");
        
        public static Partial<TDTeamDto> WithMemberships(this Partial<TDTeamDto> it, Func<Partial<TDMembershipDto>, Partial<TDMembershipDto>> partialBuilder)
            => it.AddFieldName("memberships", partialBuilder(new Partial<TDMembershipDto>()));
        
    }
    
}
