// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public interface UnfurlDetails
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static ChannelItemSnapshot ChannelItemSnapshot(string id, string text, CPrincipal author, SpaceTime created, long time, string? channelId = null, M2ItemContentDetails? details = null, List<AttachmentInfo>? attachments = null)
            => new ChannelItemSnapshot(id: id, text: text, author: author, created: created, time: time, channelId: null, details: null, attachments: null);
        
        public static UnfurlDetailsArticle Article(ArticleRecord article, ArticleContentRecord content, ArticleChannelRecord channel, ArticleDetailsRecord? details = null)
            => new UnfurlDetailsArticle(article: article, content: content, channel: channel, details: null);
        
        public static UnfurlDetailsChecklist Checklist(Checklist checklist)
            => new UnfurlDetailsChecklist(checklist: checklist);
        
        public static UnfurlDetailsCodeSnippet CodeSnippet(CodeSnippetAnchor anchor, List<CodeLine> lines)
            => new UnfurlDetailsCodeSnippet(anchor: anchor, lines: lines);
        
        public static UnfurlDetailsDateTime DateTime(long utcMilliseconds, DateTimeViewParams? @params = null)
            => new UnfurlDetailsDateTime(utcMilliseconds: utcMilliseconds, @params: null);
        
        public static UnfurlDetailsDateTimeRange DateTimeRange(long since, long till, DateTimeViewParams? @params = null)
            => new UnfurlDetailsDateTimeRange(since: since, till: till, @params: null);
        
        public static UnfurlDetailsDraft Draft(string draft, string title)
            => new UnfurlDetailsDraft(draft: draft, title: title);
        
        public static UnfurlDetailsIssue Issue(Issue issue)
            => new UnfurlDetailsIssue(issue: issue);
        
        public static UnfurlDetailsIssueStatus IssueStatus(IssueStatus status)
            => new UnfurlDetailsIssueStatus(status: status);
        
        public static UnfurlDetailsIssueTag IssueTag(PlanningTag tag, bool strikeThrough)
            => new UnfurlDetailsIssueTag(tag: tag, strikeThrough: strikeThrough);
        
        public static UnfurlDetailsLocation Location(TDLocation location)
            => new UnfurlDetailsLocation(location: location);
        
        public static UnfurlDetailsMC MC(MCMessage message, List<AttachmentInfo>? inlineUnfurls = null)
            => new UnfurlDetailsMC(message: message, inlineUnfurls: null);
        
        public static UnfurlDetailsMeeting Meeting(Meeting meeting)
            => new UnfurlDetailsMeeting(meeting: meeting);
        
        public static UnfurlDetailsProfile Profile(TDMemberProfile profile)
            => new UnfurlDetailsProfile(profile: profile);
        
        public static UnfurlDetailsSprint Sprint(PRProject project, SprintRecord sprint)
            => new UnfurlDetailsSprint(project: project, sprint: sprint);
        
        public static UnfurlDetailsTeam Team(TDTeam team)
            => new UnfurlDetailsTeam(team: team);
        
    }
    
}