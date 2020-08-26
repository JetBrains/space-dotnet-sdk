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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public interface M2ChannelContactInfoDto
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static BillingFeedChannelDto BillingFeedChannel(ChannelSpecificDefaultsDto? notificationDefaults = null)
            => new BillingFeedChannelDto(notificationDefaults: null);
        
        public static M2ChannelAutomationJobFeedInfoDto M2ChannelAutomationJobFeedInfo(JobSubscriptionDto jobSubscription, string jobName, ChannelSpecificDefaultsDto notificationDefaults, string? repoName = null)
            => new M2ChannelAutomationJobFeedInfoDto(jobSubscription: jobSubscription, jobName: jobName, notificationDefaults: notificationDefaults, repoName: null);
        
        public static M2ChannelContactArticleDto M2ChannelContactArticle(ArticleRecordDto article, ChannelSpecificDefaultsDto notificationDefaults)
            => new M2ChannelContactArticleDto(article: article, notificationDefaults: notificationDefaults);
        
        public static M2ChannelContactObsoleteDto M2ChannelContactObsolete(M2ObsoleteCause? cause = null)
            => new M2ChannelContactObsoleteDto(cause: null);
        
        public static M2ChannelContactQuickInfoDefaultDto M2ChannelContactQuickInfoDefault(string name, string key)
            => new M2ChannelContactQuickInfoDefaultDto(name: name, key: key);
        
        public static M2ChannelContactThreadDto M2ChannelContactThread(M2ChannelRecordDto parent, string? text = null, string? messageId = null, TDMemberProfileDto? author = null, CPrincipalDto? messageAuthor = null, string? attachments = null)
            => new M2ChannelContactThreadDto(parent: parent, text: null, messageId: null, author: null, messageAuthor: null, attachments: null);
        
        public static M2ChannelContentApplicationDto M2ChannelContentApplication(ESServiceDto service, ChannelSpecificDefaultsDto notificationDefaults)
            => new M2ChannelContentApplicationDto(service: service, notificationDefaults: notificationDefaults);
        
        public static M2ChannelContentCodeDiscussionDto M2ChannelContentCodeDiscussion(string codeDiscussionId, ChannelSpecificDefaultsDto notificationDefaults, CodeDiscussionRecordDto? codeDiscussion = null)
            => new M2ChannelContentCodeDiscussionDto(codeDiscussionId: codeDiscussionId, notificationDefaults: notificationDefaults, codeDiscussion: null);
        
        public static M2ChannelContentCodeReviewDiscussionDto M2ChannelContentCodeReviewDiscussion(string codeReviewDiscussion, ChannelSpecificDefaultsDto notificationDefaults)
            => new M2ChannelContentCodeReviewDiscussionDto(codeReviewDiscussion: codeReviewDiscussion, notificationDefaults: notificationDefaults);
        
        public static M2ChannelContentCodeReviewFeedDto M2ChannelContentCodeReviewFeed(string codeReviewId, ChannelSpecificDefaultsDto notificationDefaults, CodeReviewRecordDto? codeReview = null, CodeReviewParticipantsDto? participants = null, CodeReviewPendingMessageCounterDto? pendingMessageCounter = null, PRProjectDto? project = null)
            => new M2ChannelContentCodeReviewFeedDto(codeReviewId: codeReviewId, notificationDefaults: notificationDefaults, codeReview: null, participants: null, pendingMessageCounter: null, project: null);
        
        public static M2ChannelContentLocationDto M2ChannelContentLocation(TDLocationDto location, ChannelSpecificDefaultsDto notificationDefaults)
            => new M2ChannelContentLocationDto(location: location, notificationDefaults: notificationDefaults);
        
        public static M2ChannelContentMemberDto M2ChannelContentMember(TDMemberProfileDto member, ChannelSpecificDefaultsDto notificationDefaults, ProfileAbsencesRecordDto? memberAbsences = null, ProfileMembershipRecordDto? memberTeams = null)
            => new M2ChannelContentMemberDto(member: member, notificationDefaults: notificationDefaults, memberAbsences: null, memberTeams: null);
        
        public static M2ChannelContentMentionDto M2ChannelContentMention(ChannelItemRecordDto record, M2ChannelRecordDto parent)
            => new M2ChannelContentMentionDto(record: record, parent: parent);
        
        public static M2ChannelContentNamedPrivateChannelDto M2ChannelContentNamedPrivateChannel(string name, ChannelSpecificDefaultsDto? notificationDefaults = null)
            => new M2ChannelContentNamedPrivateChannelDto(name: name, notificationDefaults: null);
        
        public static M2ChannelContentTeamDto M2ChannelContentTeam(TDTeamDto team, ChannelSpecificDefaultsDto notificationDefaults)
            => new M2ChannelContentTeamDto(team: team, notificationDefaults: notificationDefaults);
        
        public static M2ChannelIssueInfoDto M2ChannelIssueInfo(IssueDto issue, ChannelSpecificDefaultsDto notificationDefaults, ProjectKeyDto? projectKey = null)
            => new M2ChannelIssueInfoDto(issue: issue, notificationDefaults: notificationDefaults, projectKey: null);
        
        public static M2PrivateConversationChannelContentDto M2PrivateConversationChannelContent(string channelId, List<TDMemberProfileDto> members, string? subject = null, ChannelSpecificDefaultsDto? notificationDefaults = null)
            => new M2PrivateConversationChannelContentDto(channelId: channelId, members: members, subject: null, notificationDefaults: null);
        
        public static M2SharedChannelContentDto M2SharedChannelContent(string name, string group, M2Access access, string description, ChannelSpecificDefaultsDto notificationDefaults, int? membersCounter = null, string? iconId = null, List<TDTeamDto>? teams = null, bool? canEdit = null)
            => new M2SharedChannelContentDto(name: name, group: group, access: access, description: description, notificationDefaults: notificationDefaults, membersCounter: null, iconId: null, teams: null, canEdit: null);
        
        public static SpaceNewsFeedChannelDto SpaceNewsFeedChannel(ChannelSpecificDefaultsDto? notificationDefaults = null)
            => new SpaceNewsFeedChannelDto(notificationDefaults: null);
        
    }
    
}
