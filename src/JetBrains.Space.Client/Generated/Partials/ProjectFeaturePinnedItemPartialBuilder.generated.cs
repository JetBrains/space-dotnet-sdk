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

namespace JetBrains.Space.Client.ProjectFeaturePinnedItemPartialBuilder;

public static class ProjectFeaturePinnedItemPartialExtensions
{
    public static Partial<ProjectFeaturePinnedItem> WithKind(this Partial<ProjectFeaturePinnedItem> it)
        => it.AddFieldName("kind");
    
    public static Partial<ProjectFeaturePinnedItem> WithKind(this Partial<ProjectFeaturePinnedItem> it, Func<Partial<ProjectPinnedItemKind>, Partial<ProjectPinnedItemKind>> partialBuilder)
        => it.AddFieldName("kind", partialBuilder(new Partial<ProjectPinnedItemKind>(it)));
    
    public static Partial<ProjectFeaturePinnedItem> WithId(this Partial<ProjectFeaturePinnedItem> it)
        => it.AddFieldName("id");
    
}
