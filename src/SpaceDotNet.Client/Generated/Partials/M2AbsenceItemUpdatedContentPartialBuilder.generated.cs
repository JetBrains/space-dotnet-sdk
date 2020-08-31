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

namespace SpaceDotNet.Client.M2AbsenceItemUpdatedContentPartialBuilder
{
    public static class M2AbsenceItemUpdatedContentPartialExtensions
    {
        public static Partial<M2AbsenceItemUpdatedContent> WithAbsence(this Partial<M2AbsenceItemUpdatedContent> it)
            => it.AddFieldName("absence");
        
        public static Partial<M2AbsenceItemUpdatedContent> WithAbsence(this Partial<M2AbsenceItemUpdatedContent> it, Func<Partial<AbsenceRecord>, Partial<AbsenceRecord>> partialBuilder)
            => it.AddFieldName("absence", partialBuilder(new Partial<AbsenceRecord>(it)));
        
        public static Partial<M2AbsenceItemUpdatedContent> WithReason(this Partial<M2AbsenceItemUpdatedContent> it)
            => it.AddFieldName("reason");
        
        public static Partial<M2AbsenceItemUpdatedContent> WithDescription(this Partial<M2AbsenceItemUpdatedContent> it)
            => it.AddFieldName("description");
        
        public static Partial<M2AbsenceItemUpdatedContent> WithSince(this Partial<M2AbsenceItemUpdatedContent> it)
            => it.AddFieldName("since");
        
        public static Partial<M2AbsenceItemUpdatedContent> WithTill(this Partial<M2AbsenceItemUpdatedContent> it)
            => it.AddFieldName("till");
        
        public static Partial<M2AbsenceItemUpdatedContent> WithBy(this Partial<M2AbsenceItemUpdatedContent> it)
            => it.AddFieldName("by");
        
        public static Partial<M2AbsenceItemUpdatedContent> WithBy(this Partial<M2AbsenceItemUpdatedContent> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("by", partialBuilder(new Partial<TDMemberProfile>(it)));
        
    }
    
}
