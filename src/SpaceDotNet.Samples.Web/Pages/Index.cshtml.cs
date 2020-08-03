using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SpaceDotNet.Client;
using SpaceDotNet.Client.CPrincipalDtoPartialBuilder;
using SpaceDotNet.Client.CUserPrincipalDetailsDtoPartialBuilder;
using SpaceDotNet.Client.CUserWithEmailPrincipalDetailsDtoPartialBuilder;
using SpaceDotNet.Client.DTOMeetingDtoPartialBuilder;
using SpaceDotNet.Client.IssueDtoPartialBuilder;
using SpaceDotNet.Client.M2ChannelRecordDtoPartialBuilder;
using SpaceDotNet.Client.MessageInfoDtoPartialBuilder;
using SpaceDotNet.Client.TDMemberProfileDtoPartialBuilder;
using SpaceDotNet.Client.TDMembershipDtoPartialBuilder;
using SpaceDotNet.Client.TDMemberLocationDtoPartialBuilder;
using SpaceDotNet.Client.TDLocationDtoPartialBuilder;
using SpaceDotNet.Client.TDProfileLanguageDtoPartialBuilder;
using SpaceDotNet.Client.TDProfileNameDtoPartialBuilder;
using SpaceDotNet.Client.TDRoleDtoPartialBuilder;
using SpaceDotNet.Client.TDTeamDtoPartialBuilder;
using SpaceDotNet.Client.TodoItemRecordDtoPartialBuilder;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Samples.Web.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ProjectClient _projectClient;
        private readonly ToDoItemClient _todoClient;
        private readonly TeamDirectoryClient _teamDirectoryClient;
        private readonly CalendarClient _calendarClient;

        public TDMemberProfileDto? MemberProfile { get; set; }
        public List<DTOMeetingDto> MeetingsToday { get; set; } = new List<DTOMeetingDto>();
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
            
            await foreach (var projectDto in _projectClient.GetAllProjectsByMemberAsyncEnumerable(ProfileIdentifier.Id(MemberProfile.Id)))
            {
                try
                {
                    // Check # of issues resolved this week
                    var issueStatuses = await _projectClient.Planning.Issues.Statuses.GetAllIssueStatusesAsync(ProjectIdentifier.Id(projectDto.Id));
                
                    await foreach (var issueDto in _projectClient.Planning.Issues.GetAllIssuesAsyncEnumerable(ProjectIdentifier.Id(projectDto.Id), assigneeId: null,  statuses: issueStatuses.Select(it => it.Id).ToList(), sorting: IssuesSorting.UPDATED, descending: true, partial: _ => _
                        .WithAllFieldsWildcard()
                        .WithCreationTime()
                        .WithCreatedBy(createdBy => createdBy
                            .WithDetails(details => details
                                .ForInherited<CUserPrincipalDetailsDto>(detailsDto => detailsDto
                                    .WithUser(user => user
                                        .WithId()))
                                .ForInherited<CUserWithEmailPrincipalDetailsDto>(detailsDto => detailsDto
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
                        var created = issueDto.CreationTime.AsDateTime();
                        var lastUpdated = issueDto.Channel.LastMessage?.Time.AsDateTime() ?? created;
                        if (lastUpdated < weekStart)
                        {
                            break;
                        }
                    
                        // Created
                        if (issueDto.CreatedBy.Details is CUserPrincipalDetailsDto userPrincipal && userPrincipal.User?.Id == MemberProfile.Id)
                        {
                            if (created >= weekStart && created <= weekEnd)
                            {
                                issuesCreatedThisWeek++;
                            }
                        }
                        
                        // Resolved
                        if (issueDto.Assignee?.Id == MemberProfile.Id)
                        {
                            if (lastUpdated >= weekStart && lastUpdated <= weekEnd)
                            {
                                var wasStatusUpdate = issueDto.Channel.LastMessage?.Text == "changed status";
                                if (wasStatusUpdate && issueDto.Status.Resolved)
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
                    var reviews1 = await _projectClient.CodeReviews.GetAllCodeReviewsAsyncEnumerable(ProjectIdentifier.Id(projectDto.Id), ReviewSorting.LastUpdatedDesc, state: CodeReviewStateFilter.Opened, @from: weekStart.AsSpaceDate()).ToListAsync();
                    var reviews2 = await _projectClient.CodeReviews.GetAllCodeReviewsAsyncEnumerable(ProjectIdentifier.Id(projectDto.Id), ReviewSorting.LastUpdatedDesc, state: CodeReviewStateFilter.NeedsReview, from: weekStart.AsSpaceDate()).ToListAsync();
                    var reviews3 = await _projectClient.CodeReviews.GetAllCodeReviewsAsyncEnumerable(ProjectIdentifier.Id(projectDto.Id), ReviewSorting.LastUpdatedDesc, state: CodeReviewStateFilter.RequiresAuthorAttention, from: weekStart.AsSpaceDate()).ToListAsync();
                    var reviews4 = await _projectClient.CodeReviews.GetAllCodeReviewsAsyncEnumerable(ProjectIdentifier.Id(projectDto.Id), ReviewSorting.LastUpdatedDesc, state: CodeReviewStateFilter.Closed, from: weekStart.AsSpaceDate()).ToListAsync();
                    
                    foreach (var reviewDto in reviews1.Union(reviews2).Union(reviews3).Union(reviews4))
                    {
                        if (reviewDto.Review is CommitSetReviewRecordDto commitSetReview)
                        {
                            var createdAt = commitSetReview.CreatedAt.AsDateTime();
                            if (createdAt >= weekStart && createdAt <= weekEnd)
                            {
                                if (reviewDto.Authors.Any(it => it.Profile != null && it.Profile.Id == MemberProfile.Id))
                                {
                                    reviewsCreatedThisWeek++;
                                }
                            }
                        
                            if (reviewDto.Participants.Participants.Any(it => it.User.Id == MemberProfile.Id))
                            {
                                reviewsParticipatedThisWeek++;
                            }
                        } 
                        else  if (reviewDto.Review is MergeRequestRecordDto mergeRequest)
                        {
                            var createdAt = mergeRequest.CreatedAt.AsDateTime();
                            if (createdAt >= weekStart && createdAt <= weekEnd)
                            {
                                if (reviewDto.Authors.Any(it => it.Profile != null && it.Profile.Id == MemberProfile.Id))
                                {
                                    reviewsCreatedThisWeek++;
                                }
                            }
                        
                            if (reviewDto.Participants.Participants.Any(it => it.User.Id == MemberProfile.Id))
                            {
                                reviewsParticipatedThisWeek++;
                            }
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
                await foreach (var todoDto in _todoClient.GetAllToDoItemsAsyncEnumerable(from: weekStart.AsSpaceDate(), partial: _ => _
                    .WithId()
                    .WithContent(content => content
                        .ForInherited<TodoItemContentMdTextDto>(md => md
                            .WithAllFieldsWildcard()))
                    .WithStatus()))
                {
                    if (todoDto.Status == "Closed")
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
                await foreach (var meetingDto in _calendarClient.Meetings.GetAllMeetingsAsyncEnumerable(profiles: new List<string> { MemberProfile.Id }, includePrivate: true, includeArchived: false, includeMeetingInstances: true, startingAfter: weekStart.AsSpaceTime(), endingBefore: weekEnd.AsSpaceTime(), partial: _ => _
                    .WithAllFieldsWildcard()
                    .WithId()
                    .WithSummary()
                    .WithDescription()
                    .WithConferenceLink()))
                {
                    meetingsThisWeek++;
            
                    if (meetingDto.OccurrenceRule.Start.AsDateTime().Date == DateTime.UtcNow.Date)
                    {
                        MeetingsToday.Add(meetingDto);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred", ex);
            }
            
            // Issues
            // Reviews created
            // Reviews participated
            // Meetings
            // Commits
            // Documents
            // Chats
            // + status (open, in progress, done)
            
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