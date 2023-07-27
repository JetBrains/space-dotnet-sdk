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

namespace JetBrains.Space.Client.ExternalIssueLinkedCommitsForRepoPartialBuilder;

public static class ExternalIssueLinkedCommitsForRepoPartialExtensions
{
    public static Partial<ExternalIssueLinkedCommitsForRepo> WithProject(this Partial<ExternalIssueLinkedCommitsForRepo> it)
        => it.AddFieldName("project");
    
    public static Partial<ExternalIssueLinkedCommitsForRepo> WithProject(this Partial<ExternalIssueLinkedCommitsForRepo> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
    
    public static Partial<ExternalIssueLinkedCommitsForRepo> WithRepositoryId(this Partial<ExternalIssueLinkedCommitsForRepo> it)
        => it.AddFieldName("repositoryId");
    
    public static Partial<ExternalIssueLinkedCommitsForRepo> WithRepositoryName(this Partial<ExternalIssueLinkedCommitsForRepo> it)
        => it.AddFieldName("repositoryName");
    
    public static Partial<ExternalIssueLinkedCommitsForRepo> WithCommits(this Partial<ExternalIssueLinkedCommitsForRepo> it)
        => it.AddFieldName("commits");
    
    public static Partial<ExternalIssueLinkedCommitsForRepo> WithCommits(this Partial<ExternalIssueLinkedCommitsForRepo> it, Func<Partial<ExternalIssueLinkedCommit>, Partial<ExternalIssueLinkedCommit>> partialBuilder)
        => it.AddFieldName("commits", partialBuilder(new Partial<ExternalIssueLinkedCommit>(it)));
    
}

