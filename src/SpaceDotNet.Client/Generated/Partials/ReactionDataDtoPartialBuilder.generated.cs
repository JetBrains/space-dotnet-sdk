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

namespace SpaceDotNet.Client.ReactionDataDtoPartialBuilder
{
    public static class ReactionDataDtoPartialExtensions
    {
        public static Partial<ReactionDataDto> WithName(this Partial<ReactionDataDto> it)
            => it.AddFieldName("name");
        
        public static Partial<ReactionDataDto> WithSymbol(this Partial<ReactionDataDto> it)
            => it.AddFieldName("symbol");
        
        public static Partial<ReactionDataDto> WithEmoji(this Partial<ReactionDataDto> it)
            => it.AddFieldName("emoji");
        
    }
    
}
