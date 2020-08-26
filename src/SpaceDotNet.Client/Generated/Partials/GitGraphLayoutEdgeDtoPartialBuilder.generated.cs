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

namespace SpaceDotNet.Client.GitGraphLayoutEdgeDtoPartialBuilder
{
    public static class GitGraphLayoutEdgeDtoPartialExtensions
    {
        public static Partial<GitGraphLayoutEdgeDto> WithFrom(this Partial<GitGraphLayoutEdgeDto> it)
            => it.AddFieldName("from");
        
        public static Partial<GitGraphLayoutEdgeDto> WithTo(this Partial<GitGraphLayoutEdgeDto> it)
            => it.AddFieldName("to");
        
        public static Partial<GitGraphLayoutEdgeDto> WithType(this Partial<GitGraphLayoutEdgeDto> it)
            => it.AddFieldName("type");
        
        public static Partial<GitGraphLayoutEdgeDto> WithType(this Partial<GitGraphLayoutEdgeDto> it, Func<Partial<GitGraphEdgeType>, Partial<GitGraphEdgeType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<GitGraphEdgeType>(it)));
        
        public static Partial<GitGraphLayoutEdgeDto> WithStyle(this Partial<GitGraphLayoutEdgeDto> it)
            => it.AddFieldName("style");
        
        public static Partial<GitGraphLayoutEdgeDto> WithStyle(this Partial<GitGraphLayoutEdgeDto> it, Func<Partial<GitGraphEdgeLineStyle>, Partial<GitGraphEdgeLineStyle>> partialBuilder)
            => it.AddFieldName("style", partialBuilder(new Partial<GitGraphEdgeLineStyle>(it)));
        
        public static Partial<GitGraphLayoutEdgeDto> WithHasArrow(this Partial<GitGraphLayoutEdgeDto> it)
            => it.AddFieldName("hasArrow");
        
        public static Partial<GitGraphLayoutEdgeDto> WithColor(this Partial<GitGraphLayoutEdgeDto> it)
            => it.AddFieldName("color");
        
    }
    
}
