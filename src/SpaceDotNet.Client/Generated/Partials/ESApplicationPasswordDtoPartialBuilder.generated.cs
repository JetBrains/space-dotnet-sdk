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

namespace SpaceDotNet.Client.ESApplicationPasswordDtoPartialBuilder
{
    public static class ESApplicationPasswordDtoPartialExtensions
    {
        public static Partial<ESApplicationPasswordDto> WithId(this Partial<ESApplicationPasswordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ESApplicationPasswordDto> WithProfile(this Partial<ESApplicationPasswordDto> it)
            => it.AddFieldName("profile");
        
        public static Partial<ESApplicationPasswordDto> WithProfile(this Partial<ESApplicationPasswordDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<ESApplicationPasswordDto> WithName(this Partial<ESApplicationPasswordDto> it)
            => it.AddFieldName("name");
        
        public static Partial<ESApplicationPasswordDto> WithScope(this Partial<ESApplicationPasswordDto> it)
            => it.AddFieldName("scope");
        
        public static Partial<ESApplicationPasswordDto> WithCreated(this Partial<ESApplicationPasswordDto> it)
            => it.AddFieldName("created");
        
        public static Partial<ESApplicationPasswordDto> WithLastAccess(this Partial<ESApplicationPasswordDto> it)
            => it.AddFieldName("lastAccess");
        
        public static Partial<ESApplicationPasswordDto> WithLastAccess(this Partial<ESApplicationPasswordDto> it, Func<Partial<AccessRecordDto>, Partial<AccessRecordDto>> partialBuilder)
            => it.AddFieldName("lastAccess", partialBuilder(new Partial<AccessRecordDto>(it)));
        
    }
    
}
