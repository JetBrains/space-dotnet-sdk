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

namespace JetBrains.Space.Client.IssueCommitLinkRemovedPartialBuilder;

public static class IssueCommitLinkRemovedPartialExtensions
{
    public static Partial<IssueCommitLinkRemoved> WithProject(this Partial<IssueCommitLinkRemoved> it)
        => it.AddFieldName("project");
    
    public static Partial<IssueCommitLinkRemoved> WithProject(this Partial<IssueCommitLinkRemoved> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
    
    public static Partial<IssueCommitLinkRemoved> WithRepositoryId(this Partial<IssueCommitLinkRemoved> it)
        => it.AddFieldName("repositoryId");
    
    public static Partial<IssueCommitLinkRemoved> WithCommitId(this Partial<IssueCommitLinkRemoved> it)
        => it.AddFieldName("commitId");
    
    public static Partial<IssueCommitLinkRemoved> WithIssuePrefix(this Partial<IssueCommitLinkRemoved> it)
        => it.AddFieldName("issuePrefix");
    
    public static Partial<IssueCommitLinkRemoved> WithIssueId(this Partial<IssueCommitLinkRemoved> it)
        => it.AddFieldName("issueId");
    
}

