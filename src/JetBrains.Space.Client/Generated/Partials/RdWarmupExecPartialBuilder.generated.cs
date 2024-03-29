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

namespace JetBrains.Space.Client.RdWarmupExecPartialBuilder;

public static class RdWarmupExecPartialExtensions
{
    public static Partial<RdWarmupExec> WithId(this Partial<RdWarmupExec> it)
        => it.AddFieldName("id");
    
    public static Partial<RdWarmupExec> WithProjectId(this Partial<RdWarmupExec> it)
        => it.AddFieldName("projectId");
    
    public static Partial<RdWarmupExec> WithVcsData(this Partial<RdWarmupExec> it)
        => it.AddFieldName("vcsData");
    
    public static Partial<RdWarmupExec> WithVcsData(this Partial<RdWarmupExec> it, Func<Partial<RdWarmupVcsData>, Partial<RdWarmupVcsData>> partialBuilder)
        => it.AddFieldName("vcsData", partialBuilder(new Partial<RdWarmupVcsData>(it)));
    
    public static Partial<RdWarmupExec> WithStatus(this Partial<RdWarmupExec> it)
        => it.AddFieldName("status");
    
    public static Partial<RdWarmupExec> WithStatus(this Partial<RdWarmupExec> it, Func<Partial<WarmupExecutionStatus>, Partial<WarmupExecutionStatus>> partialBuilder)
        => it.AddFieldName("status", partialBuilder(new Partial<WarmupExecutionStatus>(it)));
    
    public static Partial<RdWarmupExec> WithStartedAt(this Partial<RdWarmupExec> it)
        => it.AddFieldName("startedAt");
    
    public static Partial<RdWarmupExec> WithFinishedAt(this Partial<RdWarmupExec> it)
        => it.AddFieldName("finishedAt");
    
    public static Partial<RdWarmupExec> WithIdeType(this Partial<RdWarmupExec> it)
        => it.AddFieldName("ideType");
    
    public static Partial<RdWarmupExec> WithIdeType(this Partial<RdWarmupExec> it, Func<Partial<IdeType>, Partial<IdeType>> partialBuilder)
        => it.AddFieldName("ideType", partialBuilder(new Partial<IdeType>(it)));
    
    public static Partial<RdWarmupExec> WithIdeBuild(this Partial<RdWarmupExec> it)
        => it.AddFieldName("ideBuild");
    
    public static Partial<RdWarmupExec> WithIdeVersion(this Partial<RdWarmupExec> it)
        => it.AddFieldName("ideVersion");
    
    public static Partial<RdWarmupExec> WithIdeQuality(this Partial<RdWarmupExec> it)
        => it.AddFieldName("ideQuality");
    
    public static Partial<RdWarmupExec> WithComputeTaskId(this Partial<RdWarmupExec> it)
        => it.AddFieldName("computeTaskId");
    
    public static Partial<RdWarmupExec> WithTrigger(this Partial<RdWarmupExec> it)
        => it.AddFieldName("trigger");
    
    public static Partial<RdWarmupExec> WithTrigger(this Partial<RdWarmupExec> it, Func<Partial<WarmupExecutionTrigger>, Partial<WarmupExecutionTrigger>> partialBuilder)
        => it.AddFieldName("trigger", partialBuilder(new Partial<WarmupExecutionTrigger>(it)));
    
    public static Partial<RdWarmupExec> WithConfigurationSource(this Partial<RdWarmupExec> it)
        => it.AddFieldName("configurationSource");
    
    public static Partial<RdWarmupExec> WithConfigurationSource(this Partial<RdWarmupExec> it, Func<Partial<RdConfigurationSource>, Partial<RdConfigurationSource>> partialBuilder)
        => it.AddFieldName("configurationSource", partialBuilder(new Partial<RdConfigurationSource>(it)));
    
    public static Partial<RdWarmupExec> WithSizeData(this Partial<RdWarmupExec> it)
        => it.AddFieldName("sizeData");
    
    public static Partial<RdWarmupExec> WithSizeData(this Partial<RdWarmupExec> it, Func<Partial<RdWarmupSizeData>, Partial<RdWarmupSizeData>> partialBuilder)
        => it.AddFieldName("sizeData", partialBuilder(new Partial<RdWarmupSizeData>(it)));
    
    public static Partial<RdWarmupExec> WithIsArchived(this Partial<RdWarmupExec> it)
        => it.AddFieldName("archived");
    
}

