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

public interface SubscriptionFilter
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static AbsenceCommonSubscriptionFilter AbsenceCommon(List<AbsenceReasonRecord> reasons)
        => new AbsenceCommonSubscriptionFilter(reasons: reasons);
    
    public static ApplicationsSubscriptionFilter Applications(ESApp? application = null)
        => new ApplicationsSubscriptionFilter(application: application);
    
    public static AutomationJobSubscriptionFilter AutomationJob(List<PRProject> projects, string? repositoryName = null, List<string>? branchSpec = null, List<string>? jobs = null)
        => new AutomationJobSubscriptionFilter(projects: projects, repositoryName: repositoryName, branchSpec: branchSpec, jobs: jobs);
    
    public static BlogCommonSubscriptionFilter BlogCommon(List<TDTeam> teams, List<TDLocation> locations, List<TDMemberProfile> authors)
        => new BlogCommonSubscriptionFilter(teams: teams, locations: locations, authors: authors);
    
    public static ChatChannelSubscriptionFilter ChatChannel(string? channel = null, ChatContactRecord? contact = null)
        => new ChatChannelSubscriptionFilter(channel: channel, contact: contact);
    
    public static ChatMessageReactionSubscriptionFilter ChatMessageReaction(List<string> emojis)
        => new ChatMessageReactionSubscriptionFilter(emojis: emojis);
    
    public static CodeReviewSubscriptionFilter CodeReview(List<TDMemberProfile> authors, List<TDMemberProfile> participants, List<string> branchSpec, List<string> pathSpec, string titleRegex, PRProject? project = null, string? repository = null)
        => new CodeReviewSubscriptionFilter(authors: authors, participants: participants, branchSpec: branchSpec, pathSpec: pathSpec, titleRegex: titleRegex, project: project, repository: repository);
    
    public static DeploymentsSubscriptionFilter Deployments(PRProject? project = null, List<string>? repositories = null, List<string>? targetIdentifiers = null)
        => new DeploymentsSubscriptionFilter(project: project, repositories: repositories, targetIdentifiers: targetIdentifiers);
    
    public static DocumentCustomSubscriptionFilter DocumentCustom(List<Document> documents, PRProject? project = null, List<DocumentFolder>? folders = null)
        => new DocumentCustomSubscriptionFilter(documents: documents, project: project, folders: folders);
    
    public static DocumentFolderCustomSubscriptionFilter DocumentFolderCustom(PRProject? project = null, List<DocumentFolder>? folders = null)
        => new DocumentFolderCustomSubscriptionFilter(project: project, folders: folders);
    
    public static MeetingsCommonSubscriptionFilter MeetingsCommon(List<TDMemberProfile>? organizers = null, List<TDMemberProfile>? participants = null, List<TDTeam>? teams = null, List<TDLocation>? locations = null)
        => new MeetingsCommonSubscriptionFilter(organizers: organizers, participants: participants, teams: teams, locations: locations);
    
    public static MemberCommonSubscriptionFilter MemberCommon(List<TDTeam> teams, List<TDLocation> locations, List<TDMemberProfile>? profiles = null)
        => new MemberCommonSubscriptionFilter(teams: teams, locations: locations, profiles: profiles);
    
    public static PackagesSubscriptionFilter Packages(List<string> namePattern, PRProject? project = null, ProjectPackageRepository? repository = null, string? versionPattern = null)
        => new PackagesSubscriptionFilter(namePattern: namePattern, project: project, repository: repository, versionPattern: versionPattern);
    
    public static ProjectCommonSubscriptionFilter ProjectCommon(PRProject? project = null)
        => new ProjectCommonSubscriptionFilter(project: project);
    
    public static RdWarmupSubscriptionFilter RdWarmup(PRProject? project = null, string? repositoryName = null, List<string>? branchSpec = null, RdDevConfiguration? devConf = null)
        => new RdWarmupSubscriptionFilter(project: project, repositoryName: repositoryName, branchSpec: branchSpec, devConf: devConf);
    
    public static RepoCommitsSubscriptionFilter RepoCommits(string repository, RepoCommitsSubscriptionFilterSpec spec, PRProject? project = null)
        => new RepoCommitsSubscriptionFilter(repository: repository, spec: spec, project: project);
    
    public static RepoHeadsSubscriptionFilter RepoHeads(string repository, PRProject? project = null)
        => new RepoHeadsSubscriptionFilter(repository: repository, project: project);
    
    public static RepoPushSubscriptionFilter RepoPush(string repository, RepoCommitsSubscriptionFilterSpec spec, PRProject? project = null)
        => new RepoPushSubscriptionFilter(repository: repository, spec: spec, project: project);
    
}

