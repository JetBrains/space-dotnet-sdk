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

public interface AttachmentUnfurlDetails
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static AutomationJobExecutionUnfurlDetails AutomationJobExecutionUnfurlDetails(string jobExecutionId, PRProject projectRef, string repoName)
        => new AutomationJobExecutionUnfurlDetails(jobExecutionId: jobExecutionId, projectRef: projectRef, repoName: repoName);
    
    public static AutomationJobUnfurlDetails AutomationJobUnfurlDetails(string jobId, string jobName, PRProject projectRef, string repoName, JobExecutionDisplayStatus? jobExecutionDisplayStatusFilter = null, JobTriggerType? jobTriggerFilter = null, Branch? branch = null)
        => new AutomationJobUnfurlDetails(jobId: jobId, jobName: jobName, projectRef: projectRef, repoName: repoName, jobExecutionDisplayStatusFilter: jobExecutionDisplayStatusFilter, jobTriggerFilter: jobTriggerFilter, branch: branch);
    
    public static CallSessionUnfurlDetails CallSessionUnfurlDetails(CallSession session)
        => new CallSessionUnfurlDetails(session: session);
    
    public static ChannelItemSnapshot ChannelItemSnapshot(string id, string text, CPrincipal author, DateTime created, long time, string? channelId = null, M2ItemContentDetails? details = null, List<AttachmentInfo>? attachments = null, List<EntityMention>? mentions = null)
        => new ChannelItemSnapshot(id: id, text: text, author: author, created: created, time: time, channelId: channelId, details: details, attachments: attachments, mentions: mentions);
    
    public static UnfurlDeployTargetDetails UnfurlDeployTargetDetails(DeployTargetRecord targetRef, string? targetName = null, bool? showLinkIcon = null, bool? skipDetailsRender = null)
        => new UnfurlDeployTargetDetails(targetRef: targetRef, targetName: targetName, showLinkIcon: showLinkIcon, skipDetailsRender: skipDetailsRender);
    
    public static UnfurlDetailsArticle UnfurlDetailsArticle(ArticleRecord article, ArticleContentRecord? content = null, ArticleChannelRecord? channel = null, ArticleDetailsRecord? details = null)
        => new UnfurlDetailsArticle(article: article, content: content, channel: channel, details: details);
    
    public static UnfurlDetailsCodeDiffSnippet UnfurlDetailsCodeDiffSnippet(MCMessage header, List<AttachmentInfo> headerAttachments, List<InlineDiffLine> lines, int selectedLineIndex, int selectedLinesCount, string? sourceBranch = null, string? targetBranch = null)
        => new UnfurlDetailsCodeDiffSnippet(header: header, headerAttachments: headerAttachments, lines: lines, selectedLineIndex: selectedLineIndex, selectedLinesCount: selectedLinesCount, sourceBranch: sourceBranch, targetBranch: targetBranch);
    
    public static UnfurlDetailsCodeSnippet UnfurlDetailsCodeSnippet(CodeSnippetAnchor anchor, List<CodeLine> lines)
        => new UnfurlDetailsCodeSnippet(anchor: anchor, lines: lines);
    
    public static UnfurlDetailsImage UnfurlDetailsImage(string title, ImageAttachment image, string? icon = null)
        => new UnfurlDetailsImage(title: title, image: image, icon: icon);
    
    public static UnfurlDetailsMC UnfurlDetailsMC(MCMessage message, List<AttachmentInfo>? inlineUnfurls = null)
        => new UnfurlDetailsMC(message: message, inlineUnfurls: inlineUnfurls);
    
    public static UnfurlDetailsMeeting UnfurlDetailsMeeting(Meeting meeting, bool? compact = null)
        => new UnfurlDetailsMeeting(meeting: meeting, compact: compact);
    
}

