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

namespace SpaceDotNet.Client.AbsencesAbsenceReasonsForIdPostRequestPartialBuilder
{
    public static class AbsencesAbsenceReasonsForIdPostRequestPartialExtensions
    {
        public static Partial<AbsencesAbsenceReasonsForIdPostRequest> WithName(this Partial<AbsencesAbsenceReasonsForIdPostRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<AbsencesAbsenceReasonsForIdPostRequest> WithDescription(this Partial<AbsencesAbsenceReasonsForIdPostRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<AbsencesAbsenceReasonsForIdPostRequest> WithDefaultAvailability(this Partial<AbsencesAbsenceReasonsForIdPostRequest> it)
            => it.AddFieldName("defaultAvailability");
        
        public static Partial<AbsencesAbsenceReasonsForIdPostRequest> WithApprovalRequired(this Partial<AbsencesAbsenceReasonsForIdPostRequest> it)
            => it.AddFieldName("approvalRequired");
        
        public static Partial<AbsencesAbsenceReasonsForIdPostRequest> WithIcon(this Partial<AbsencesAbsenceReasonsForIdPostRequest> it)
            => it.AddFieldName("icon");
        
    }
    
}
