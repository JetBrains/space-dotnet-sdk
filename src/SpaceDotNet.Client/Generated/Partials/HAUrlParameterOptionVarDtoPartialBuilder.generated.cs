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

namespace SpaceDotNet.Client.HAUrlParameterOptionVarDtoPartialBuilder
{
    public static class HAUrlParameterOptionVarDtoPartialExtensions
    {
        public static Partial<HAUrlParameterOptionVarDto> WithParameter(this Partial<HAUrlParameterOptionVarDto> it)
            => it.AddFieldName("parameter");
        
        public static Partial<HAUrlParameterOptionVarDto> WithParameter(this Partial<HAUrlParameterOptionVarDto> it, Func<Partial<HAFieldDto>, Partial<HAFieldDto>> partialBuilder)
            => it.AddFieldName("parameter", partialBuilder(new Partial<HAFieldDto>(it)));
        
        public static Partial<HAUrlParameterOptionVarDto> WithPrefixRequired(this Partial<HAUrlParameterOptionVarDto> it)
            => it.AddFieldName("prefixRequired");
        
        public static Partial<HAUrlParameterOptionVarDto> WithOptionName(this Partial<HAUrlParameterOptionVarDto> it)
            => it.AddFieldName("optionName");
        
        public static Partial<HAUrlParameterOptionVarDto> WithDeprecation(this Partial<HAUrlParameterOptionVarDto> it)
            => it.AddFieldName("deprecation");
        
        public static Partial<HAUrlParameterOptionVarDto> WithDeprecation(this Partial<HAUrlParameterOptionVarDto> it, Func<Partial<HADeprecationDto>, Partial<HADeprecationDto>> partialBuilder)
            => it.AddFieldName("deprecation", partialBuilder(new Partial<HADeprecationDto>(it)));
        
    }
    
}
