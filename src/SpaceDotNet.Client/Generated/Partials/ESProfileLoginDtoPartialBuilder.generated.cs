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

namespace SpaceDotNet.Client.ESProfileLoginDtoPartialBuilder
{
    public static class ESProfileLoginDtoPartialExtensions
    {
        public static Partial<ESProfileLoginDto> WithIdentifier(this Partial<ESProfileLoginDto> it)
            => it.AddFieldName("identifier");
        
        public static Partial<ESProfileLoginDto> WithAuthModule(this Partial<ESProfileLoginDto> it)
            => it.AddFieldName("authModule");
        
        public static Partial<ESProfileLoginDto> WithAuthModule(this Partial<ESProfileLoginDto> it, Func<Partial<ESAuthModuleDto>, Partial<ESAuthModuleDto>> partialBuilder)
            => it.AddFieldName("authModule", partialBuilder(new Partial<ESAuthModuleDto>(it)));
        
        public static Partial<ESProfileLoginDto> WithDetails(this Partial<ESProfileLoginDto> it)
            => it.AddFieldName("details");
        
        public static Partial<ESProfileLoginDto> WithDetails(this Partial<ESProfileLoginDto> it, Func<Partial<ESProfileLoginDetailsDto>, Partial<ESProfileLoginDetailsDto>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<ESProfileLoginDetailsDto>(it)));
        
        public static Partial<ESProfileLoginDto> WithAccess(this Partial<ESProfileLoginDto> it)
            => it.AddFieldName("access");
        
        public static Partial<ESProfileLoginDto> WithAccess(this Partial<ESProfileLoginDto> it, Func<Partial<AccessRecordDto>, Partial<AccessRecordDto>> partialBuilder)
            => it.AddFieldName("access", partialBuilder(new Partial<AccessRecordDto>(it)));
        
    }
    
}
