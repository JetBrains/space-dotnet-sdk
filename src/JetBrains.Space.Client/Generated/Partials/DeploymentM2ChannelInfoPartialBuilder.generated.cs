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

namespace JetBrains.Space.Client.DeploymentM2ChannelInfoPartialBuilder;

public static class DeploymentM2ChannelInfoPartialExtensions
{
    public static Partial<DeploymentM2ChannelInfo> WithNotificationDefaults(this Partial<DeploymentM2ChannelInfo> it)
        => it.AddFieldName("notificationDefaults");
    
    public static Partial<DeploymentM2ChannelInfo> WithNotificationDefaults(this Partial<DeploymentM2ChannelInfo> it, Func<Partial<ChannelSpecificDefaults>, Partial<ChannelSpecificDefaults>> partialBuilder)
        => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaults>(it)));
    
    public static Partial<DeploymentM2ChannelInfo> WithDeployment(this Partial<DeploymentM2ChannelInfo> it)
        => it.AddFieldName("deployment");
    
    public static Partial<DeploymentM2ChannelInfo> WithDeployment(this Partial<DeploymentM2ChannelInfo> it, Func<Partial<DeploymentRecord>, Partial<DeploymentRecord>> partialBuilder)
        => it.AddFieldName("deployment", partialBuilder(new Partial<DeploymentRecord>(it)));
    
    public static Partial<DeploymentM2ChannelInfo> WithProject(this Partial<DeploymentM2ChannelInfo> it)
        => it.AddFieldName("project");
    
    public static Partial<DeploymentM2ChannelInfo> WithProject(this Partial<DeploymentM2ChannelInfo> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
    
}

