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
public abstract class PackageRepositoryIdentifier : IUrlParameter
{
    public static PackageRepositoryIdentifier Id(string id)
        => new PackageRepositoryIdentifierId(id);
    
    public static PackageRepositoryIdentifier Key(string key)
        => new PackageRepositoryIdentifierKey(key);
    
    public static PackageRepositoryIdentifier TypeAndName(string type, string name)
        => new PackageRepositoryIdentifierTypeAndName(type, name);
    
    public class PackageRepositoryIdentifierId : PackageRepositoryIdentifier
    {
        [Required]
        [JsonPropertyName("id")]
#if NET6_0_OR_GREATER
        public string Id { get; init; }
#else
        public string Id { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public PackageRepositoryIdentifierId() { }
#endif
        
        public PackageRepositoryIdentifierId(string id)
        {
            Id = id;
        }
        
        public override string ToString()
            => $"id:{Id}";
    }
    
    public class PackageRepositoryIdentifierKey : PackageRepositoryIdentifier
    {
        [Required]
        [JsonPropertyName("key")]
#if NET6_0_OR_GREATER
        public string Key { get; init; }
#else
        public string Key { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public PackageRepositoryIdentifierKey() { }
#endif
        
        public PackageRepositoryIdentifierKey(string key)
        {
            Key = key;
        }
        
        public override string ToString()
            => $"key:{Key}";
    }
    
    public class PackageRepositoryIdentifierTypeAndName : PackageRepositoryIdentifier
    {
        [Required]
        [JsonPropertyName("type")]
#if NET6_0_OR_GREATER
        public string Type { get; init; }
#else
        public string Type { get; set; }
#endif
        
        [Required]
        [JsonPropertyName("name")]
#if NET6_0_OR_GREATER
        public string Name { get; init; }
#else
        public string Name { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public PackageRepositoryIdentifierTypeAndName() { }
#endif
        
        public PackageRepositoryIdentifierTypeAndName(string type, string name)
        {
            Type = type;
            Name = name;
        }
        
        public override string ToString()
            => $"{{type:{Type},name:{Name}}}";
    }
    
}

