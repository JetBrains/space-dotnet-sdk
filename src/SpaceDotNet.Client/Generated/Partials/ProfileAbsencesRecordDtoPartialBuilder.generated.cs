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

namespace SpaceDotNet.Client.ProfileAbsencesRecordDtoPartialBuilder
{
    public static class ProfileAbsencesRecordDtoPartialExtensions
    {
        public static Partial<ProfileAbsencesRecordDto> WithId(this Partial<ProfileAbsencesRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ProfileAbsencesRecordDto> WithAbsences(this Partial<ProfileAbsencesRecordDto> it)
            => it.AddFieldName("absences");
        
        public static Partial<ProfileAbsencesRecordDto> WithAbsences(this Partial<ProfileAbsencesRecordDto> it, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>> partialBuilder)
            => it.AddFieldName("absences", partialBuilder(new Partial<AbsenceRecordDto>(it)));
        
    }
    
}
