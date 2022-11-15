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

public interface SubscriptionFilterIn
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static AbsenceCommonSubscriptionFilterIn AbsenceCommon(List<string> reasons)
        => new AbsenceCommonSubscriptionFilterIn(reasons: reasons);
    
    public static ApplicationsSubscriptionFilterIn Applications(string? application = null)
        => new ApplicationsSubscriptionFilterIn(application: application);
    
    public static AutomationJobSubscriptionFilterIn AutomationJob(List<string>? projects = null, string? repositoryName = null, List<string>? branchSpec = null, List<string>? jobs = null)
        => new AutomationJobSubscriptionFilterIn(projects: projects, repositoryName: repositoryName, branchSpec: branchSpec, jobs: jobs);
    
    public static BlogCommonSubscriptionFilterIn BlogCommon(List<string> teams, List<string> locations, List<string> authors)
        => new BlogCommonSubscriptionFilterIn(teams: teams, locations: locations, authors: authors);
    
    public static CodeReviewSubscriptionFilterIn CodeReview(List<string> authors, List<string> participants, List<string> branchSpec, List<string> pathSpec, string titleRegex, string? project = null, string? repository = null)
        => new CodeReviewSubscriptionFilterIn(authors: authors, participants: participants, branchSpec: branchSpec, pathSpec: pathSpec, titleRegex: titleRegex, project: project, repository: repository);
    
    public static DeploymentsSubscriptionFilterIn Deployments(string project, List<string>? repositories = null, List<string>? targetIdentifiers = null)
        => new DeploymentsSubscriptionFilterIn(project: project, repositories: repositories, targetIdentifiers: targetIdentifiers);
    
    public static DocumentCustomSubscriptionFilterIn DocumentCustom(List<string> documents, string? project = null, List<string>? folders = null)
        => new DocumentCustomSubscriptionFilterIn(documents: documents, project: project, folders: folders);
    
    public static MemberCommonSubscriptionFilterIn MemberCommon(List<string> teams, List<string> locations, List<ProfileIdentifier>? profiles = null)
        => new MemberCommonSubscriptionFilterIn(teams: teams, locations: locations, profiles: profiles);
    
    public static PackagesSubscriptionFilterIn Packages(List<string> namePattern, string? project = null, string? repository = null, string? versionPattern = null)
        => new PackagesSubscriptionFilterIn(namePattern: namePattern, project: project, repository: repository, versionPattern: versionPattern);
    
    public static ProjectCommonSubscriptionFilterIn ProjectCommon(string? project = null)
        => new ProjectCommonSubscriptionFilterIn(project: project);
    
    public static RdWarmupSubscriptionFilterIn RdWarmup(string project, string? repositoryName = null, List<string>? branchSpec = null)
        => new RdWarmupSubscriptionFilterIn(project: project, repositoryName: repositoryName, branchSpec: branchSpec);
    
    public static RepoCommitsSubscriptionFilterIn RepoCommits(string repository, RepoCommitsSubscriptionFilterSpec spec, string? project = null)
        => new RepoCommitsSubscriptionFilterIn(repository: repository, spec: spec, project: project);
    
    public static RepoHeadsSubscriptionFilterIn RepoHeads(string repository, string? project = null)
        => new RepoHeadsSubscriptionFilterIn(repository: repository, project: project);
    
}

