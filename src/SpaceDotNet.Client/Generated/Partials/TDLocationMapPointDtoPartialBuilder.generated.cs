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

namespace SpaceDotNet.Client.TDLocationMapPointDtoPartialBuilder
{
    public static class TDLocationMapPointDtoPartialExtensions
    {
        public static Partial<TDLocationMapPointDto> WithId(this Partial<TDLocationMapPointDto> it)
            => it.AddFieldName("id");
        
        public static Partial<TDLocationMapPointDto> WithMapId(this Partial<TDLocationMapPointDto> it)
            => it.AddFieldName("mapId");
        
        public static Partial<TDLocationMapPointDto> WithX(this Partial<TDLocationMapPointDto> it)
            => it.AddFieldName("x");
        
        public static Partial<TDLocationMapPointDto> WithY(this Partial<TDLocationMapPointDto> it)
            => it.AddFieldName("y");
        
        public static Partial<TDLocationMapPointDto> WithCreated(this Partial<TDLocationMapPointDto> it)
            => it.AddFieldName("created");
        
        public static Partial<TDLocationMapPointDto> WithMemberLocation(this Partial<TDLocationMapPointDto> it)
            => it.AddFieldName("memberLocation");
        
        public static Partial<TDLocationMapPointDto> WithDeleted(this Partial<TDLocationMapPointDto> it)
            => it.AddFieldName("deleted");
        
    }
    
}
