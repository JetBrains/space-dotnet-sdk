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

namespace SpaceDotNet.Client.InvitationLinkDtoPartialBuilder
{
    public static class InvitationLinkDtoPartialExtensions
    {
        public static Partial<InvitationLinkDto> WithId(this Partial<InvitationLinkDto> it)
            => it.AddFieldName("id");
        
        public static Partial<InvitationLinkDto> WithName(this Partial<InvitationLinkDto> it)
            => it.AddFieldName("name");
        
        public static Partial<InvitationLinkDto> WithCreatedBy(this Partial<InvitationLinkDto> it)
            => it.AddFieldName("createdBy");
        
        public static Partial<InvitationLinkDto> WithCreatedBy(this Partial<InvitationLinkDto> it, Func<Partial<CPrincipalDto>, Partial<CPrincipalDto>> partialBuilder)
            => it.AddFieldName("createdBy", partialBuilder(new Partial<CPrincipalDto>(it)));
        
        public static Partial<InvitationLinkDto> WithCreatedAt(this Partial<InvitationLinkDto> it)
            => it.AddFieldName("createdAt");
        
        public static Partial<InvitationLinkDto> WithExpiresAt(this Partial<InvitationLinkDto> it)
            => it.AddFieldName("expiresAt");
        
        public static Partial<InvitationLinkDto> WithInviteeLimit(this Partial<InvitationLinkDto> it)
            => it.AddFieldName("inviteeLimit");
        
        public static Partial<InvitationLinkDto> WithInviteeUsage(this Partial<InvitationLinkDto> it)
            => it.AddFieldName("inviteeUsage");
        
        public static Partial<InvitationLinkDto> WithDeleted(this Partial<InvitationLinkDto> it)
            => it.AddFieldName("deleted");
        
    }
    
}
