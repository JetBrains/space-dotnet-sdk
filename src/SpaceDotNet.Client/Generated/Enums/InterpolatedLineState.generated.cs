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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class InterpolatedLineState : Enumeration
    {
        private InterpolatedLineState(string value) : base(value) { }
        
        public static readonly InterpolatedLineState Normal = new InterpolatedLineState("Normal");
        public static readonly InterpolatedLineState Deleted = new InterpolatedLineState("Deleted");
        public static readonly InterpolatedLineState Modified = new InterpolatedLineState("Modified");
    }
    
}
