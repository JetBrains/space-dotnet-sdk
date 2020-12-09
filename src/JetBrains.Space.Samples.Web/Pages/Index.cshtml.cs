using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using JetBrains.Space.Client;
using JetBrains.Space.Client.CodeReviewWithCountPartialBuilder;
using JetBrains.Space.Client.CPrincipalPartialBuilder;
using JetBrains.Space.Client.CUserPrincipalDetailsPartialBuilder;
using JetBrains.Space.Client.CUserWithEmailPrincipalDetailsPartialBuilder;
using JetBrains.Space.Client.MeetingPartialBuilder;
using JetBrains.Space.Client.IssuePartialBuilder;
using JetBrains.Space.Client.M2ChannelRecordPartialBuilder;
using JetBrains.Space.Client.MessageInfoPartialBuilder;
using JetBrains.Space.Client.TDMemberProfilePartialBuilder;
using JetBrains.Space.Client.TDMembershipPartialBuilder;
using JetBrains.Space.Client.TDMemberLocationPartialBuilder;
using JetBrains.Space.Client.TDLocationPartialBuilder;
using JetBrains.Space.Client.TDProfileLanguagePartialBuilder;
using JetBrains.Space.Client.TDProfileNamePartialBuilder;
using JetBrains.Space.Client.TDRolePartialBuilder;
using JetBrains.Space.Client.TDTeamPartialBuilder;
using JetBrains.Space.Client.TodoItemRecordPartialBuilder;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Samples.Web.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ProjectClient _projectClient;
        private readonly ToDoItemClient _todoClient;
        private readonly TeamDirectoryClient _teamDirectoryClient;
        private readonly CalendarClient _calendarClient;

        public TDMemberProfile? MemberProfile { get; set; }
        public List<Meeting> MeetingsToday { get; set; } = new List<Meeting>();
        public int IssuesCreatedThisWeek { get; set; }
        public int IssuesResolvedThisWeek { get; set; }
        public int ReviewsCreatedThisWeek { get; set; }
        public int ReviewsParticipatedThisWeek { get; set; }
        public int TodoClosedThisWeek { get; set; }
        public int MeetingsThisWeek { get; set; }
        
        public IndexModel(
            ILogger<IndexModel> logger,
            ProjectClient projectClient,
            ToDoItemClient todoClient,
            TeamDirectoryClient teamDirectoryClient,
            CalendarClient calendarClient)
        {
            _logger = logger;
            _projectClient = projectClient;
            _todoClient = todoClient;
            _teamDirectoryClient = teamDirectoryClient;
            _calendarClient = calendarClient;
        }

        public async Task OnGet()
        {
            #region Example with default fields (1 level)
            
            MemberProfile = await _teamDirectoryClient.Profiles.GetProfileAsync(ProfileIdentifier.Me);
            
            #endregion
            
            #region Example with full field definitions
            
            MemberProfile = await _teamDirectoryClient.Profiles.GetProfileAsync(ProfileIdentifier.Me, partial => partial
                .WithAllFieldsWildcard() // adds all fields for the current partial request (one level)
                .WithId()
                .WithName(name => name
                    .WithFirstName()
                    .WithLastName())
                .WithEmails(emails => emails.WithAllFieldsWildcard())
                .WithMessengers()
                .WithPhones()
                .WithLinks()
                .WithBirthday()
                .WithLanguages(languages => languages
                    .WithAllFieldsWildcard()
                    .WithLanguage(language => language.WithAllFieldsWildcard()))
                .WithAbsences(absence => absence.WithAllFieldsWildcard())
                .WithMemberships(membership => membership
                    .WithAllFieldsWildcard()
                    .WithRole(role => role.WithName())
                    .WithTeam(team => team.WithName()))
                .WithLocations(locations => locations
                    .WithId()
                    .WithLocation(location => location
                        .WithName())));
            
            #endregion
            
            var weekStart = StartOfWeek(DateTime.UtcNow, DayOfWeek.Monday);
            var weekEnd = weekStart.AddDays(7).AddHours(23).AddMinutes(59).AddSeconds(59);

            var issuesCreatedThisWeek = 0;
            var issuesResolvedThisWeek = 0;
            var reviewsCreatedThisWeek = 0;
            var reviewsParticipatedThisWeek = 0;
            var todoClosedThisWeek = 0;
            var meetingsThisWeek = 0;
            
            await foreach (var project in _projectClient.GetAllProjectsByMemberAsyncEnumerable(ProfileIdentifier.Id(MemberProfile.Id)))
            {
                try
                {
                    // Check # of issues resolved this week
                    var issueStatuses = await _projectClient.Planning.Issues.Statuses.GetAllIssueStatusesAsync(ProjectIdentifier.Id(project.Id));
                
                    await foreach (var issue in _projectClient.Planning.Issues.GetAllIssuesAsyncEnumerable(ProjectIdentifier.Id(project.Id), assigneeId: new List<ProfileIdentifier>(), statuses: issueStatuses.Select(it => it.Id).ToList(), sorting: IssuesSorting.UPDATED, descending: true, partial: _ => _
                        .WithAllFieldsWildcard()
                        .WithCreationTime()
                        .WithCreatedBy(createdBy => createdBy
                            .WithDetails(details => details
                                .ForInherited<CUserPrincipalDetails>(details => details
                                    .WithUser(user => user
                                        .WithId()))
                                .ForInherited<CUserWithEmailPrincipalDetails>(details => details
                                    .WithName()
                                    .WithEmail())))
                        .WithStatus()
                        .WithAssignee(assignee => assignee
                            .WithId())
                        .WithChannel(channel => channel
                            .WithLastMessage(lastMessage => lastMessage
                                .WithText()
                                .WithTime()))))
                    {
                        var created = issue.CreationTime;
                        var lastUpdated = issue.Channel.LastMessage?.Time.AsDateTime() ?? created;
                        if (lastUpdated < weekStart)
                        {
                            break;
                        }
                    
                        // Created
                        if (issue.CreatedBy.Details is CUserPrincipalDetails userPrincipal && userPrincipal.User?.Id == MemberProfile.Id)
                        {
                            if (created >= weekStart && created <= weekEnd)
                            {
                                issuesCreatedThisWeek++;
                            }
                        }
                        
                        // Resolved
                        if (issue.Assignee?.Id == MemberProfile.Id)
                        {
                            if (lastUpdated >= weekStart && lastUpdated <= weekEnd)
                            {
                                var wasStatusUpdate = issue.Channel.LastMessage?.Text == "changed status";
                                if (wasStatusUpdate && issue.Status.IsResolved)
                                {
                                    issuesResolvedThisWeek++;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError("An error occurred", ex);
                }
      
                try
                {
                    // Check # of reviews created and participated in
                    Partial<CodeReviewWithCount> codeReviewPartial(Partial<CodeReviewWithCount> _) => _
                        .WithAllFieldsWildcard()
                        .WithReview()
                        .WithAuthors()
                        .WithParticipants();

                    var reviews = await _projectClient.CodeReviews.GetAllCodeReviewsAsyncEnumerable(ProjectIdentifier.Id(project.Id), ReviewSorting.LastUpdatedDesc, state: null, from: weekStart, partial: codeReviewPartial).ToListAsync();
                    
                    foreach (var review in reviews)
                    {
                        var createdAt = review.Review switch
                        {
                            CommitSetReviewRecord commitSetReview => commitSetReview.CreatedAt.AsDateTime(),
                            MergeRequestRecord mergeRequest => mergeRequest.CreatedAt.AsDateTime(),
                            _ => DateTime.MinValue
                        };
                        
                        if (createdAt >= weekStart && createdAt <= weekEnd)
                        {
                            if (review.Participants.Participants.Any(it => it.User.Id == MemberProfile.Id && it.Role == CodeReviewParticipantRole.Author))
                            {
                                reviewsCreatedThisWeek++;
                            }
                        }
                        
                        if (review.Participants.Participants.Any(it => it.User.Id == MemberProfile.Id && it.Role == CodeReviewParticipantRole.Reviewer))
                        {
                            reviewsParticipatedThisWeek++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError("An error occurred", ex);
                }
            }

            try
            {
                // Check # of TO-DO items resolved
                await foreach (var todo in _todoClient.GetAllTodoItemsAsyncEnumerable(from: weekStart, partial: _ => _
                    .WithId()
                    .WithContent(content => content
                        .ForInherited<TodoItemContentMdText>(md => md
                            .WithAllFieldsWildcard()))
                    .WithStatus()))
                {
                    if (todo.Status == "Closed")
                    {
                        todoClosedThisWeek++;
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred", ex);
            }

            try
            {
                await foreach (var meeting in _calendarClient.Meetings.GetAllMeetingsAsyncEnumerable(profiles: new List<string> { MemberProfile.Id }, includePrivate: true, includeArchived: false, includeMeetingInstances: true, startingAfter: weekStart, endingBefore: weekEnd, partial: _ => _
                    .WithAllFieldsWildcard()
                    .WithId()
                    .WithSummary()
                    .WithDescription()
                    .WithConferenceLink()))
                {
                    meetingsThisWeek++;
            
                    if (meeting.OccurrenceRule.Start.Date == DateTime.UtcNow.Date)
                    {
                        MeetingsToday.Add(meeting);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred", ex);
            }
            
            IssuesCreatedThisWeek = issuesCreatedThisWeek;
            IssuesResolvedThisWeek = issuesResolvedThisWeek;
            ReviewsCreatedThisWeek = reviewsCreatedThisWeek;
            ReviewsParticipatedThisWeek = reviewsParticipatedThisWeek;
            TodoClosedThisWeek = todoClosedThisWeek;
            MeetingsThisWeek = meetingsThisWeek;
        }

        private static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            var diff = (7 + (dt.Date.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}