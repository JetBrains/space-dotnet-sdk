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

namespace JetBrains.Space.Client.ExternalIssueTrackerProjectLinkPartialBuilder;

public static class ExternalIssueTrackerProjectLinkPartialExtensions
{
    public static Partial<ExternalIssueTrackerProjectLink> WithSpaceProject(this Partial<ExternalIssueTrackerProjectLink> it)
        => it.AddFieldName("spaceProject");
    
    public static Partial<ExternalIssueTrackerProjectLink> WithSpaceProject(this Partial<ExternalIssueTrackerProjectLink> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("spaceProject", partialBuilder(new Partial<PRProject>(it)));
    
    public static Partial<ExternalIssueTrackerProjectLink> WithTargetStatusForMergeRequestMerge(this Partial<ExternalIssueTrackerProjectLink> it)
        => it.AddFieldName("targetStatusForMergeRequestMerge");
    
    public static Partial<ExternalIssueTrackerProjectLink> WithTargetStatusForMergeRequestMerge(this Partial<ExternalIssueTrackerProjectLink> it, Func<Partial<IssueStatus>, Partial<IssueStatus>> partialBuilder)
        => it.AddFieldName("targetStatusForMergeRequestMerge", partialBuilder(new Partial<IssueStatus>(it)));
    
    public static Partial<ExternalIssueTrackerProjectLink> WithLinkedAt(this Partial<ExternalIssueTrackerProjectLink> it)
        => it.AddFieldName("linkedAt");
    
}
