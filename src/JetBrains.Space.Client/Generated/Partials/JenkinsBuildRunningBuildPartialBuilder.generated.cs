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

namespace JetBrains.Space.Client.JenkinsBuildRunningBuildPartialBuilder;

public static class JenkinsBuildRunningBuildPartialExtensions
{
    public static Partial<JenkinsBuildRunningBuild> WithId(this Partial<JenkinsBuildRunningBuild> it)
        => it.AddFieldName("id");
    
    public static Partial<JenkinsBuildRunningBuild> WithUrl(this Partial<JenkinsBuildRunningBuild> it)
        => it.AddFieldName("url");
    
    public static Partial<JenkinsBuildRunningBuild> WithFullDisplayName(this Partial<JenkinsBuildRunningBuild> it)
        => it.AddFieldName("fullDisplayName");
    
    public static Partial<JenkinsBuildRunningBuild> WithIsInProgress(this Partial<JenkinsBuildRunningBuild> it)
        => it.AddFieldName("inProgress");
    
    public static Partial<JenkinsBuildRunningBuild> WithDuration(this Partial<JenkinsBuildRunningBuild> it)
        => it.AddFieldName("duration");
    
    public static Partial<JenkinsBuildRunningBuild> WithResult(this Partial<JenkinsBuildRunningBuild> it)
        => it.AddFieldName("result");
    
    public static Partial<JenkinsBuildRunningBuild> WithInitialQueueItemId(this Partial<JenkinsBuildRunningBuild> it)
        => it.AddFieldName("initialQueueItemId");
    
}

