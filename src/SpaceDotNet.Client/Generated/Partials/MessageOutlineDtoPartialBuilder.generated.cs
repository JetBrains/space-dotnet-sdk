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

namespace SpaceDotNet.Client.MessageOutlineDtoPartialBuilder
{
    public static class MessageOutlineDtoPartialExtensions
    {
        public static Partial<MessageOutlineDto> WithIcon(this Partial<MessageOutlineDto> it)
            => it.AddFieldName("icon");
        
        public static Partial<MessageOutlineDto> WithIcon(this Partial<MessageOutlineDto> it, Func<Partial<ApiIconDto>, Partial<ApiIconDto>> partialBuilder)
            => it.AddFieldName("icon", partialBuilder(new Partial<ApiIconDto>(it)));
        
        public static Partial<MessageOutlineDto> WithText(this Partial<MessageOutlineDto> it)
            => it.AddFieldName("text");
        
    }
    
}
