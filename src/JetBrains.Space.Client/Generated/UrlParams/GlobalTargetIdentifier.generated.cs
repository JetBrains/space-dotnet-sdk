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
public abstract class GlobalTargetIdentifier : IUrlParameter
{
    public static GlobalTargetIdentifier Composite(ProjectIdentifier project, TargetIdentifier target)
        => new GlobalTargetIdentifierComposite(project, target);
    
    public static GlobalTargetIdentifier Number(string number)
        => new GlobalTargetIdentifierNumber(number);
    
    public class GlobalTargetIdentifierComposite : GlobalTargetIdentifier
    {
        [Required]
        [JsonPropertyName("project")]
#if NET6_0_OR_GREATER
        public ProjectIdentifier Project { get; init; }
#else
        public ProjectIdentifier Project { get; set; }
#endif
        
        [Required]
        [JsonPropertyName("target")]
#if NET6_0_OR_GREATER
        public TargetIdentifier Target { get; init; }
#else
        public TargetIdentifier Target { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public GlobalTargetIdentifierComposite() { }
#pragma warning restore CS8618
#endif
        
        public GlobalTargetIdentifierComposite(ProjectIdentifier project, TargetIdentifier target)
        {
            Project = project;
            Target = target;
        }
        
        public override string ToString()
            => $"{{project:{Project},target:{Target}}}";
    }
    
    public class GlobalTargetIdentifierNumber : GlobalTargetIdentifier
    {
        [Required]
        [JsonPropertyName("number")]
#if NET6_0_OR_GREATER
        public string Number { get; init; }
#else
        public string Number { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public GlobalTargetIdentifierNumber() { }
#pragma warning restore CS8618
#endif
        
        public GlobalTargetIdentifierNumber(string number)
        {
            Number = number;
        }
        
        public override string ToString()
            => $"number:{Number}";
    }
    
}

