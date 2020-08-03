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

namespace SpaceDotNet.Client.AbsenceRecordDtoPartialBuilder
{
    public static class AbsenceRecordDtoPartialExtensions
    {
        public static Partial<AbsenceRecordDto> WithId(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<AbsenceRecordDto> WithArchived(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<AbsenceRecordDto> WithMember(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("member");
        
        public static Partial<AbsenceRecordDto> WithMember(this Partial<AbsenceRecordDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("member", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<AbsenceRecordDto> WithIcon(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("icon");
        
        public static Partial<AbsenceRecordDto> WithReason(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("reason");
        
        public static Partial<AbsenceRecordDto> WithReason(this Partial<AbsenceRecordDto> it, Func<Partial<AbsenceReasonRecordDto>, Partial<AbsenceReasonRecordDto>> partialBuilder)
            => it.AddFieldName("reason", partialBuilder(new Partial<AbsenceReasonRecordDto>(it)));
        
        public static Partial<AbsenceRecordDto> WithDescription(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("description");
        
        public static Partial<AbsenceRecordDto> WithSince(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("since");
        
        public static Partial<AbsenceRecordDto> WithTill(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("till");
        
        public static Partial<AbsenceRecordDto> WithLocation(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("location");
        
        public static Partial<AbsenceRecordDto> WithLocation(this Partial<AbsenceRecordDto> it, Func<Partial<TDLocationDto>, Partial<TDLocationDto>> partialBuilder)
            => it.AddFieldName("location", partialBuilder(new Partial<TDLocationDto>(it)));
        
        public static Partial<AbsenceRecordDto> WithAvailable(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("available");
        
        public static Partial<AbsenceRecordDto> WithApproval(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("approval");
        
        public static Partial<AbsenceRecordDto> WithApproval(this Partial<AbsenceRecordDto> it, Func<Partial<AbsenceApprovalDto>, Partial<AbsenceApprovalDto>> partialBuilder)
            => it.AddFieldName("approval", partialBuilder(new Partial<AbsenceApprovalDto>(it)));
        
        public static Partial<AbsenceRecordDto> WithCustomFields(this Partial<AbsenceRecordDto> it)
            => it.AddFieldName("customFields");
        
        public static Partial<AbsenceRecordDto> WithCustomFields(this Partial<AbsenceRecordDto> it, Func<Partial<CFValueDto>, Partial<CFValueDto>> partialBuilder)
            => it.AddFieldName("customFields", partialBuilder(new Partial<CFValueDto>(it)));
        
    }
    
}
