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

public interface InlineUnfurlDetails
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static AutomationJobExecutionUnfurlDetails AutomationJobExecutionUnfurlDetails(string jobExecutionId, PRProject projectRef, string repoName)
        => new AutomationJobExecutionUnfurlDetails(jobExecutionId: jobExecutionId, projectRef: projectRef, repoName: repoName);
    
    public static AutomationJobUnfurlDetails AutomationJobUnfurlDetails(string jobId, string jobName, PRProject projectRef, string repoName, JobExecutionDisplayStatus? jobExecutionDisplayStatusFilter = null, JobTriggerType? jobTriggerFilter = null, Branch? branch = null)
        => new AutomationJobUnfurlDetails(jobId: jobId, jobName: jobName, projectRef: projectRef, repoName: repoName, jobExecutionDisplayStatusFilter: jobExecutionDisplayStatusFilter, jobTriggerFilter: jobTriggerFilter, branch: branch);
    
    public static CallSessionUnfurlDetails CallSessionUnfurlDetails(CallSession session)
        => new CallSessionUnfurlDetails(session: session);
    
    public static DocumentHistoryUnfurlDetails DocumentHistoryUnfurlDetails(string document, string title, DateTime? version = null, DateTime? @base = null, DateTime? preview = null, DateTime? version2 = null, DateTime? base2 = null, DateTime? preview2 = null)
        => new DocumentHistoryUnfurlDetails(document: document, title: title, version: version, @base: @base, preview: preview, version2: version2, base2: base2, preview2: preview2);
    
    public static UnfurlDeployTargetDetails UnfurlDeployTargetDetails(DeployTargetRecord targetRef, string? targetName = null, bool? showLinkIcon = null, bool? skipDetailsRender = null)
        => new UnfurlDeployTargetDetails(targetRef: targetRef, targetName: targetName, showLinkIcon: showLinkIcon, skipDetailsRender: skipDetailsRender);
    
    public static UnfurlDeploymentDetails UnfurlDeploymentDetails(DeploymentRecord deploymentRef, bool? showLinkIcon = null, bool? showDetails = null, bool? showStatus = null)
        => new UnfurlDeploymentDetails(deploymentRef: deploymentRef, showLinkIcon: showLinkIcon, showDetails: showDetails, showStatus: showStatus);
    
    public static UnfurlDetailsApplication UnfurlDetailsApplication(ESApp app)
        => new UnfurlDetailsApplication(app: app);
    
    public static UnfurlDetailsArticle UnfurlDetailsArticle(ArticleRecord article, ArticleContentRecord? content = null, ArticleChannelRecord? channel = null, ArticleDetailsRecord? details = null)
        => new UnfurlDetailsArticle(article: article, content: content, channel: channel, details: details);
    
    public static UnfurlDetailsChat UnfurlDetailsChat(string channel, string title)
        => new UnfurlDetailsChat(channel: channel, title: title);
    
    public static UnfurlDetailsChatLink UnfurlDetailsChatLink(string contactKey, string title)
        => new UnfurlDetailsChatLink(contactKey: contactKey, title: title);
    
    public static UnfurlDetailsChecklist UnfurlDetailsChecklist(Checklist checklist)
        => new UnfurlDetailsChecklist(checklist: checklist);
    
    public static UnfurlDetailsCodeReview UnfurlDetailsCodeReview(CodeReviewRecord review, bool withBranchPair, bool? withIcon = null, string? defaultBranchInRepo = null, bool? hideIfCannotResolve = null, CodeReviewState? reviewState = null, bool? isMerged = null)
        => new UnfurlDetailsCodeReview(review: review, withBranchPair: withBranchPair, withIcon: withIcon, defaultBranchInRepo: defaultBranchInRepo, hideIfCannotResolve: hideIfCannotResolve, reviewState: reviewState, isMerged: isMerged);
    
    public static UnfurlDetailsCommit UnfurlDetailsCommit(PRProject project, string repository, string commitId, string message, DateTime commitDate, GitAuthorInfo author, string? repositoryId = null, CommitMessageUnfurlsRecord? messageUnfurls = null, DateTime? authorDate = null, TDMemberProfile? authorProfile = null, bool? hideAuthorAndDate = null, bool? withBranchTags = null, string? reviewId = null)
        => new UnfurlDetailsCommit(project: project, repository: repository, commitId: commitId, message: message, commitDate: commitDate, author: author, repositoryId: repositoryId, messageUnfurls: messageUnfurls, authorDate: authorDate, authorProfile: authorProfile, hideAuthorAndDate: hideAuthorAndDate, withBranchTags: withBranchTags, reviewId: reviewId);
    
    public static UnfurlDetailsDateTime UnfurlDetailsDateTime(long utcMilliseconds, DateTimeViewParams? @params = null)
        => new UnfurlDetailsDateTime(utcMilliseconds: utcMilliseconds, @params: @params);
    
    public static UnfurlDetailsDateTimeRange UnfurlDetailsDateTimeRange(long since, long till, DateTimeViewParams? @params = null)
        => new UnfurlDetailsDateTimeRange(since: since, till: till, @params: @params);
    
    public static UnfurlDetailsDraft UnfurlDetailsDraft(string draft, string title, Document? document = null, bool? strikeThrough = null)
        => new UnfurlDetailsDraft(draft: draft, title: title, document: document, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsExternalIssue UnfurlDetailsExternalIssue(ExternalIssue issue)
        => new UnfurlDetailsExternalIssue(issue: issue);
    
    public static UnfurlDetailsFolder UnfurlDetailsFolder(string name, bool root, DocumentFolder? folder = null)
        => new UnfurlDetailsFolder(name: name, root: root, folder: folder);
    
    public static UnfurlDetailsIssue UnfurlDetailsIssue(Issue issue, bool? strikeThrough = null, bool? compact = null)
        => new UnfurlDetailsIssue(issue: issue, strikeThrough: strikeThrough, compact: compact);
    
    public static UnfurlDetailsIssueId UnfurlDetailsIssueId(string projectId, string issueId)
        => new UnfurlDetailsIssueId(projectId: projectId, issueId: issueId);
    
    public static UnfurlDetailsIssueImportTransaction UnfurlDetailsIssueImportTransaction(ImportTransactionRecord importTransaction)
        => new UnfurlDetailsIssueImportTransaction(importTransaction: importTransaction);
    
    public static UnfurlDetailsIssueStatus UnfurlDetailsIssueStatus(IssueStatus status)
        => new UnfurlDetailsIssueStatus(status: status);
    
    public static UnfurlDetailsIssueTag UnfurlDetailsIssueTag(PlanningTag tag, bool strikeThrough, MessageTextSize? textSize = null)
        => new UnfurlDetailsIssueTag(tag: tag, strikeThrough: strikeThrough, textSize: textSize);
    
    public static UnfurlDetailsIssueTopic UnfurlDetailsIssueTopic(Topic topic, bool strikeThrough)
        => new UnfurlDetailsIssueTopic(topic: topic, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsLocation UnfurlDetailsLocation(TDLocation location, bool? strikeThrough = null)
        => new UnfurlDetailsLocation(location: location, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsMeeting UnfurlDetailsMeeting(Meeting meeting, bool? compact = null)
        => new UnfurlDetailsMeeting(meeting: meeting, compact: compact);
    
    public static UnfurlDetailsPackageDetails UnfurlDetailsPackageDetails(ProjectPackageRepository repoRef, string? packageName = null, string? version = null)
        => new UnfurlDetailsPackageDetails(repoRef: repoRef, packageName: packageName, version: version);
    
    public static UnfurlDetailsProfile UnfurlDetailsProfile(TDMemberProfile profile, bool? strikeThrough = null)
        => new UnfurlDetailsProfile(profile: profile, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsProject UnfurlDetailsProject(PRProject project, bool? strikeThrough = null)
        => new UnfurlDetailsProject(project: project, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsRepositoryBranch UnfurlDetailsRepositoryBranch(PRProject project, string repository, string branchHead, bool deleted, bool? isDefault = null)
        => new UnfurlDetailsRepositoryBranch(project: project, repository: repository, branchHead: branchHead, deleted: deleted, isDefault: isDefault);
    
    public static UnfurlDetailsReviewDescriptionDiff UnfurlDetailsReviewDescriptionDiff(string snapshotId, string baseSnapshotId)
        => new UnfurlDetailsReviewDescriptionDiff(snapshotId: snapshotId, baseSnapshotId: baseSnapshotId);
    
    public static UnfurlDetailsRole UnfurlDetailsRole(TDRole role)
        => new UnfurlDetailsRole(role: role);
    
    public static UnfurlDetailsShortCommit UnfurlDetailsShortCommit(PRProject project, string repository, string commitId, string message, bool strikeThrough)
        => new UnfurlDetailsShortCommit(project: project, repository: repository, commitId: commitId, message: message, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsSnapshotDiff UnfurlDetailsSnapshotDiff(string snapshotId, string baseSnapshotId)
        => new UnfurlDetailsSnapshotDiff(snapshotId: snapshotId, baseSnapshotId: baseSnapshotId);
    
    public static UnfurlDetailsSprint UnfurlDetailsSprint(PRProject project, SprintRecord sprint, bool? removed = null)
        => new UnfurlDetailsSprint(project: project, sprint: sprint, removed: removed);
    
    public static UnfurlDetailsTeam UnfurlDetailsTeam(TDTeam team, bool? strikeThrough = null)
        => new UnfurlDetailsTeam(team: team, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsTextDiff UnfurlDetailsTextDiff(string textBefore, string textAfter)
        => new UnfurlDetailsTextDiff(textBefore: textBefore, textAfter: textAfter);
    
}

