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

namespace SpaceDotNet.Client.ProfileHitPartialBuilder
{
    public static class ProfileHitPartialExtensions
    {
        public static Partial<ProfileHit> WithId(this Partial<ProfileHit> it)
            => it.AddFieldName("id");
        
        public static Partial<ProfileHit> WithScore(this Partial<ProfileHit> it)
            => it.AddFieldName("score");
        
        public static Partial<ProfileHit> WithFirstName(this Partial<ProfileHit> it)
            => it.AddFieldName("firstName");
        
        public static Partial<ProfileHit> WithLastName(this Partial<ProfileHit> it)
            => it.AddFieldName("lastName");
        
        public static Partial<ProfileHit> WithUserName(this Partial<ProfileHit> it)
            => it.AddFieldName("userName");
        
        public static Partial<ProfileHit> WithPhones(this Partial<ProfileHit> it)
            => it.AddFieldName("phones");
        
        public static Partial<ProfileHit> WithEmails(this Partial<ProfileHit> it)
            => it.AddFieldName("emails");
        
        public static Partial<ProfileHit> WithLinks(this Partial<ProfileHit> it)
            => it.AddFieldName("links");
        
        public static Partial<ProfileHit> WithMessengers(this Partial<ProfileHit> it)
            => it.AddFieldName("messengers");
        
        public static Partial<ProfileHit> WithIsNotAMember(this Partial<ProfileHit> it)
            => it.AddFieldName("notAMember");
        
        public static Partial<ProfileHit> WithRef(this Partial<ProfileHit> it)
            => it.AddFieldName("ref");
        
        public static Partial<ProfileHit> WithRef(this Partial<ProfileHit> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("ref", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<ProfileHit> WithCustomFields(this Partial<ProfileHit> it)
            => it.AddFieldName("customFields");
        
        public static Partial<ProfileHit> WithCustomFields(this Partial<ProfileHit> it, Func<Partial<CustomFieldHit>, Partial<CustomFieldHit>> partialBuilder)
            => it.AddFieldName("customFields", partialBuilder(new Partial<CustomFieldHit>(it)));
        
    }
    
}
