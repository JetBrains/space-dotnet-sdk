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

namespace SpaceDotNet.Client.UpdateTeamRequestExtensions
{
    public static class UpdateTeamRequestDtoPartialExtensions
    {
        public static Partial<UpdateTeamRequestDto> WithTeamNameRaw(this Partial<UpdateTeamRequestDto> it)
            => it.AddFieldName("teamNameRaw");
        
        public static Partial<UpdateTeamRequestDto> WithTeamDescription(this Partial<UpdateTeamRequestDto> it)
            => it.AddFieldName("teamDescription");
        
        public static Partial<UpdateTeamRequestDto> WithTeamEmails(this Partial<UpdateTeamRequestDto> it)
            => it.AddFieldName("teamEmails");
        
        public static Partial<UpdateTeamRequestDto> WithTeamEmails(this Partial<UpdateTeamRequestDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("teamEmails", partialBuilder(new Partial<string>()));
        
        public static Partial<UpdateTeamRequestDto> WithParentId(this Partial<UpdateTeamRequestDto> it)
            => it.AddFieldName("parentId");
        
        public static Partial<UpdateTeamRequestDto> WithCustomFieldValues(this Partial<UpdateTeamRequestDto> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<UpdateTeamRequestDto> WithCustomFieldValues(this Partial<UpdateTeamRequestDto> it, Func<Partial<CustomFieldValueDto>, Partial<CustomFieldValueDto>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldValueDto>()));
        
    }
    
}