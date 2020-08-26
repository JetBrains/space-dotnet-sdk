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

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class MessageStyle : Enumeration
    {
        private MessageStyle(string value) : base(value) { }
        
        public static readonly MessageStyle PRIMARY = new MessageStyle("PRIMARY");
        public static readonly MessageStyle SECONDARY = new MessageStyle("SECONDARY");
        public static readonly MessageStyle SUCCESS = new MessageStyle("SUCCESS");
        public static readonly MessageStyle ERROR = new MessageStyle("ERROR");
        public static readonly MessageStyle WARNING = new MessageStyle("WARNING");
    }
    
}
