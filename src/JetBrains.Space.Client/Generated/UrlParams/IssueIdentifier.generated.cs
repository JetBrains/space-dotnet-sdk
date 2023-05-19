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
public abstract class IssueIdentifier : IUrlParameter
{
    /// <summary>
    /// Identifies issue in Space that was earlier imported from an external system by external id provided during the import.
    /// </summary>
    public static IssueIdentifier ExternalId(ProjectIdentifier project, string externalId)
        => new IssueIdentifierExternalId(project, externalId);
    
    public static IssueIdentifier Id(string id)
        => new IssueIdentifierId(id);
    
    public static IssueIdentifier Key(string key)
        => new IssueIdentifierKey(key);
    
    /// <summary>
    /// Identifies issue in Space that was earlier imported from an external system by external id provided during the import.
    /// </summary>
    public class IssueIdentifierExternalId : IssueIdentifier
    {
        [Required]
        [JsonPropertyName("project")]
#if NET6_0_OR_GREATER
        public ProjectIdentifier Project { get; init; }
#else
        public ProjectIdentifier Project { get; set; }
#endif
        
        [Required]
        [JsonPropertyName("externalId")]
#if NET6_0_OR_GREATER
        public string ExternalId { get; init; }
#else
        public string ExternalId { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public IssueIdentifierExternalId() { }
#pragma warning restore CS8618
#endif
        
        public IssueIdentifierExternalId(ProjectIdentifier project, string externalId)
        {
            Project = project;
            ExternalId = externalId;
        }
        
        public override string ToString()
            => $"{{project:{Project},externalId:{ExternalId}}}";
    }
    
    public class IssueIdentifierId : IssueIdentifier
    {
        [Required]
        [JsonPropertyName("id")]
#if NET6_0_OR_GREATER
        public string Id { get; init; }
#else
        public string Id { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public IssueIdentifierId() { }
#pragma warning restore CS8618
#endif
        
        public IssueIdentifierId(string id)
        {
            Id = id;
        }
        
        public override string ToString()
            => $"id:{Id}";
    }
    
    public class IssueIdentifierKey : IssueIdentifier
    {
        [Required]
        [JsonPropertyName("key")]
#if NET6_0_OR_GREATER
        public string Key { get; init; }
#else
        public string Key { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public IssueIdentifierKey() { }
#pragma warning restore CS8618
#endif
        
        public IssueIdentifierKey(string key)
        {
            Key = key;
        }
        
        public override string ToString()
            => $"key:{Key}";
    }
    
}

