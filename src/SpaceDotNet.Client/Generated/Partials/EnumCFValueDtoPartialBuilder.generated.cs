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

namespace SpaceDotNet.Client.EnumCFValueDtoPartialBuilder
{
    public static class EnumCFValueDtoPartialExtensions
    {
        public static Partial<EnumCFValueDto> WithValue(this Partial<EnumCFValueDto> it)
            => it.AddFieldName("value");
        
        public static Partial<EnumCFValueDto> WithValue(this Partial<EnumCFValueDto> it, Func<Partial<EnumValueDataDto>, Partial<EnumValueDataDto>> partialBuilder)
            => it.AddFieldName("value", partialBuilder(new Partial<EnumValueDataDto>(it)));
        
    }
    
}
