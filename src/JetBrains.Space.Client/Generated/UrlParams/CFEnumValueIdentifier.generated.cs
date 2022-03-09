// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

[JsonConverter(typeof(UrlParameterConverter))]
public abstract class CFEnumValueIdentifier : IUrlParameter
{
    public static CFEnumValueIdentifier Id(string id)
        => new CFEnumValueIdentifierId(id);
    
    public static CFEnumValueIdentifier Name(string name)
        => new CFEnumValueIdentifierName(name);
    
    public class CFEnumValueIdentifierId : CFEnumValueIdentifier
    {
        [Required]
        [JsonPropertyName("id")]
#if NET6_0_OR_GREATER
        public string Id { get; init; }
#else
        public string Id { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public CFEnumValueIdentifierId() { }
#endif
        
        public CFEnumValueIdentifierId(string id)
        {
            Id = id;
        }
        
        public override string ToString()
            => $"id:{Id}";
    }
    
    public class CFEnumValueIdentifierName : CFEnumValueIdentifier
    {
        [Required]
        [JsonPropertyName("name")]
#if NET6_0_OR_GREATER
        public string Name { get; init; }
#else
        public string Name { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public CFEnumValueIdentifierName() { }
#endif
        
        public CFEnumValueIdentifierName(string name)
        {
            Name = name;
        }
        
        public override string ToString()
            => $"name:{Name}";
    }
    
}

