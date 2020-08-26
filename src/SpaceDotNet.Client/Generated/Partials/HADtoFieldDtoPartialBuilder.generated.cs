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

namespace SpaceDotNet.Client.HADtoFieldDtoPartialBuilder
{
    public static class HADtoFieldDtoPartialExtensions
    {
        public static Partial<HADtoFieldDto> WithField(this Partial<HADtoFieldDto> it)
            => it.AddFieldName("field");
        
        public static Partial<HADtoFieldDto> WithField(this Partial<HADtoFieldDto> it, Func<Partial<HAFieldDto>, Partial<HAFieldDto>> partialBuilder)
            => it.AddFieldName("field", partialBuilder(new Partial<HAFieldDto>(it)));
        
        public static Partial<HADtoFieldDto> WithExtension(this Partial<HADtoFieldDto> it)
            => it.AddFieldName("extension");
        
    }
    
}
