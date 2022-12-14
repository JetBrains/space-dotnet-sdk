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
public abstract class PermissionContextIdentifier : IUrlParameter
{
    public static PermissionContextIdentifier Channel(string channel)
        => new ChannelPermissionContextIdentifier(channel);
    
    public static PermissionContextIdentifier Global
        => new GlobalPermissionContextIdentifier();
    
    public static PermissionContextIdentifier Project(ProjectIdentifier project)
        => new ProjectPermissionContextIdentifier(project);
    
    public class ChannelPermissionContextIdentifier : PermissionContextIdentifier
    {
        [Required]
        [JsonPropertyName("channel")]
#if NET6_0_OR_GREATER
        public string Channel { get; init; }
#else
        public string Channel { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public ChannelPermissionContextIdentifier() { }
#pragma warning restore CS8618
#endif
        
        public ChannelPermissionContextIdentifier(string channel)
        {
            Channel = channel;
        }
        
        public override string ToString()
            => $"channel:{Channel}";
    }
    
    public class GlobalPermissionContextIdentifier : PermissionContextIdentifier
    {
        public override string ToString()
            => "global";
    }
    
    public class ProjectPermissionContextIdentifier : PermissionContextIdentifier
    {
        [Required]
        [JsonPropertyName("project")]
#if NET6_0_OR_GREATER
        public ProjectIdentifier Project { get; init; }
#else
        public ProjectIdentifier Project { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public ProjectPermissionContextIdentifier() { }
#pragma warning restore CS8618
#endif
        
        public ProjectPermissionContextIdentifier(ProjectIdentifier project)
        {
            Project = project;
        }
        
        public override string ToString()
            => $"project:{Project}";
    }
    
}

