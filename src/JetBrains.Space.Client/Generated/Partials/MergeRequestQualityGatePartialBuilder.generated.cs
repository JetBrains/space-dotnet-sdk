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

namespace JetBrains.Space.Client.MergeRequestQualityGatePartialBuilder;

public static class MergeRequestQualityGatePartialExtensions
{
    public static Partial<MergeRequestQualityGate> WithPermission(this Partial<MergeRequestQualityGate> it)
        => it.AddFieldName("permission");
    
    public static Partial<MergeRequestQualityGate> WithPermission(this Partial<MergeRequestQualityGate> it, Func<Partial<QualityGatePermission>, Partial<QualityGatePermission>> partialBuilder)
        => it.AddFieldName("permission", partialBuilder(new Partial<QualityGatePermission>(it)));
    
    public static Partial<MergeRequestQualityGate> WithIsPassed(this Partial<MergeRequestQualityGate> it)
        => it.AddFieldName("passed");
    
    public static Partial<MergeRequestQualityGate> WithSettings(this Partial<MergeRequestQualityGate> it)
        => it.AddFieldName("settings");
    
    public static Partial<MergeRequestQualityGate> WithSettings(this Partial<MergeRequestQualityGate> it, Func<Partial<MergeRequestQualityGateSettings>, Partial<MergeRequestQualityGateSettings>> partialBuilder)
        => it.AddFieldName("settings", partialBuilder(new Partial<MergeRequestQualityGateSettings>(it)));
    
}

