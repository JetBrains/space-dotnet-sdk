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
    public sealed class Weekday : Enumeration
    {
        private Weekday(string value) : base(value) { }
        
        public static readonly Weekday SUNDAY = new Weekday("SUNDAY");
        public static readonly Weekday MONDAY = new Weekday("MONDAY");
        public static readonly Weekday TUESDAY = new Weekday("TUESDAY");
        public static readonly Weekday WEDNESDAY = new Weekday("WEDNESDAY");
        public static readonly Weekday THURSDAY = new Weekday("THURSDAY");
        public static readonly Weekday FRIDAY = new Weekday("FRIDAY");
        public static readonly Weekday SATURDAY = new Weekday("SATURDAY");
    }
    
}
