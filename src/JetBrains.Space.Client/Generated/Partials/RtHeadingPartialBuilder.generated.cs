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

namespace JetBrains.Space.Client.RtHeadingPartialBuilder;

public static class RtHeadingPartialExtensions
{
    public static Partial<RtHeading> WithLevel(this Partial<RtHeading> it)
        => it.AddFieldName("level");
    
    public static Partial<RtHeading> WithChildren(this Partial<RtHeading> it)
        => it.AddFieldName("children");
    
    public static Partial<RtHeading> WithChildren(this Partial<RtHeading> it, Func<Partial<RtHeadingContentNode>, Partial<RtHeadingContentNode>> partialBuilder)
        => it.AddFieldName("children", partialBuilder(new Partial<RtHeadingContentNode>(it)));
    
    [Obsolete("RtTextAlign is deprecated, alignments are no longer supported (since 2023-10-17) (will be removed in a future version)")]
    public static Partial<RtHeading> WithTextAlign(this Partial<RtHeading> it)
        => it.AddFieldName("textAlign");
    
    [Obsolete("RtTextAlign is deprecated, alignments are no longer supported (since 2023-10-17) (will be removed in a future version)")]
    public static Partial<RtHeading> WithTextAlign(this Partial<RtHeading> it, Func<Partial<RtTextAlign>, Partial<RtTextAlign>> partialBuilder)
        => it.AddFieldName("textAlign", partialBuilder(new Partial<RtTextAlign>(it)));
    
}

