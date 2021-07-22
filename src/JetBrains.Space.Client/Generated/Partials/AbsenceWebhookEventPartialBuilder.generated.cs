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

namespace JetBrains.Space.Client.AbsenceWebhookEventPartialBuilder
{
    public static class AbsenceWebhookEventPartialExtensions
    {
        public static Partial<AbsenceWebhookEvent> WithMeta(this Partial<AbsenceWebhookEvent> it)
            => it.AddFieldName("meta");
        
        public static Partial<AbsenceWebhookEvent> WithMeta(this Partial<AbsenceWebhookEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
            => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
        
        public static Partial<AbsenceWebhookEvent> WithAbsence(this Partial<AbsenceWebhookEvent> it)
            => it.AddFieldName("absence");
        
        public static Partial<AbsenceWebhookEvent> WithAbsence(this Partial<AbsenceWebhookEvent> it, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>> partialBuilder)
            => it.AddFieldName("absence", partialBuilder(new Partial<AbsenceRecord>(it)));
        
        public static Partial<AbsenceWebhookEvent> WithMember(this Partial<AbsenceWebhookEvent> it)
            => it.AddFieldName("member");
        
        public static Partial<AbsenceWebhookEvent> WithMember(this Partial<AbsenceWebhookEvent> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("member", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<AbsenceWebhookEvent> WithIcon(this Partial<AbsenceWebhookEvent> it)
            => it.AddFieldName("icon");
        
        public static Partial<AbsenceWebhookEvent> WithReason(this Partial<AbsenceWebhookEvent> it)
            => it.AddFieldName("reason");
        
        public static Partial<AbsenceWebhookEvent> WithDescription(this Partial<AbsenceWebhookEvent> it)
            => it.AddFieldName("description");
        
        public static Partial<AbsenceWebhookEvent> WithSince(this Partial<AbsenceWebhookEvent> it)
            => it.AddFieldName("since");
        
        public static Partial<AbsenceWebhookEvent> WithTill(this Partial<AbsenceWebhookEvent> it)
            => it.AddFieldName("till");
        
        public static Partial<AbsenceWebhookEvent> WithLocation(this Partial<AbsenceWebhookEvent> it)
            => it.AddFieldName("location");
        
        public static Partial<AbsenceWebhookEvent> WithAvailable(this Partial<AbsenceWebhookEvent> it)
            => it.AddFieldName("available");
        
    }
    
}
