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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.InvitationDtoPartialBuilder
{
    public static class InvitationDtoPartialExtensions
    {
        public static Partial<InvitationDto> WithId(this Partial<InvitationDto> it)
            => it.AddFieldName("id");
        
        public static Partial<InvitationDto> WithExpiresAt(this Partial<InvitationDto> it)
            => it.AddFieldName("expiresAt");
        
        public static Partial<InvitationDto> WithInviteeEmail(this Partial<InvitationDto> it)
            => it.AddFieldName("inviteeEmail");
        
        public static Partial<InvitationDto> WithInviteeEmailBlocked(this Partial<InvitationDto> it)
            => it.AddFieldName("inviteeEmailBlocked");
        
        public static Partial<InvitationDto> WithInviteeEmailBlockedReason(this Partial<InvitationDto> it)
            => it.AddFieldName("inviteeEmailBlockedReason");
        
        public static Partial<InvitationDto> WithInviteeFirstName(this Partial<InvitationDto> it)
            => it.AddFieldName("inviteeFirstName");
        
        public static Partial<InvitationDto> WithInviteeLastName(this Partial<InvitationDto> it)
            => it.AddFieldName("inviteeLastName");
        
        public static Partial<InvitationDto> WithInvitee(this Partial<InvitationDto> it)
            => it.AddFieldName("invitee");
        
        public static Partial<InvitationDto> WithInvitee(this Partial<InvitationDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("invitee", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<InvitationDto> WithInviter(this Partial<InvitationDto> it)
            => it.AddFieldName("inviter");
        
        public static Partial<InvitationDto> WithInviter(this Partial<InvitationDto> it, Func<Partial<CPrincipalDto>, Partial<CPrincipalDto>> partialBuilder)
            => it.AddFieldName("inviter", partialBuilder(new Partial<CPrincipalDto>(it)));
        
        public static Partial<InvitationDto> WithTeam(this Partial<InvitationDto> it)
            => it.AddFieldName("team");
        
        public static Partial<InvitationDto> WithTeam(this Partial<InvitationDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("team", partialBuilder(new Partial<TDTeamDto>(it)));
        
        public static Partial<InvitationDto> WithRole(this Partial<InvitationDto> it)
            => it.AddFieldName("role");
        
        public static Partial<InvitationDto> WithRole(this Partial<InvitationDto> it, Func<Partial<TDRoleDto>, Partial<TDRoleDto>> partialBuilder)
            => it.AddFieldName("role", partialBuilder(new Partial<TDRoleDto>(it)));
        
        public static Partial<InvitationDto> WithRevoked(this Partial<InvitationDto> it)
            => it.AddFieldName("revoked");
        
    }
    
}
