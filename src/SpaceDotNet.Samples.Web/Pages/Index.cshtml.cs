using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SpaceDotNet.Client;
using SpaceDotNet.Client.CPrincipalExtensions;
using SpaceDotNet.Client.CUserPrincipalDetailsExtensions;
using SpaceDotNet.Client.CUserWithEmailPrincipalDetailsExtensions;
using SpaceDotNet.Client.DTOMeetingExtensions;
using SpaceDotNet.Client.IssueExtensions;
using SpaceDotNet.Client.M2ChannelRecordExtensions;
using SpaceDotNet.Client.MessageInfoExtensions;
using SpaceDotNet.Client.TDMemberProfileExtensions;
using SpaceDotNet.Client.TDMembershipExtensions;
using SpaceDotNet.Client.TDProfileLanguageExtensions;
using SpaceDotNet.Client.TDProfileNameExtensions;
using SpaceDotNet.Client.TDRoleExtensions;
using SpaceDotNet.Client.TDTeamExtensions;
using SpaceDotNet.Client.TodoItemRecordExtensions;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Samples.Web.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
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
            IConfiguration configuration, 
            ILogger<IndexModel> logger,
            ProjectClient projectClient,
            ToDoItemClient todoClient,
            TeamDirectoryClient teamDirectoryClient,
            CalendarClient calendarClient)
        {
            _configuration = configuration;
            _logger = logger;
            _projectClient = projectClient;
            _todoClient = todoClient;
            _teamDirectoryClient = teamDirectoryClient;
            _calendarClient = calendarClient;
        }

        public async Task OnGet()
        {
            #region Example with default fields (1 level)
            
            MemberProfile = await _teamDirectoryClient.Profiles.Me.GetMe();
            
            #endregion
            
            #region Example with full recursive (not recommended as it is too eager)
            
            MemberProfile = await _teamDirectoryClient.Profiles.Me.GetMe(partial => Partial<TDMemberProfileDto>.Recursive());
            
            #endregion
            
            #region Example with full field definitions
            
            MemberProfile = await _teamDirectoryClient.Profiles.Me.GetMe(partial => partial
                .AddAllFieldNames() // adds all fields for the current partial request (one level)
                .WithId()
                .WithName(name => name
                    .WithFirstName()
                    .WithLastName())
                .WithEmails(emails => emails.AddAllFieldNames())
                .WithMessengers()
                .WithPhones()
                .WithLinks()
                .WithBirthday()
                .WithLanguages(languages => languages
                    .AddAllFieldNames()
                    .WithLanguage(language => language.AddAllFieldNames()))
                .WithAbsences(absence => absence.AddAllFieldNames())
                .WithMemberships(membership => membership
                    .AddAllFieldNames()
                    .WithRole(role => role.WithName())
                    .WithTeam(team => team.WithName())));
            
            #endregion
            
            MemberProfile = await _teamDirectoryClient.Profiles.Me.GetMe();
            
            var weekStart = StartOfWeek(DateTime.UtcNow, DayOfWeek.Monday);
            var weekEnd = weekStart.AddDays(7).AddHours(23).AddMinutes(59).AddSeconds(59);

            var issuesCreatedThisWeek = 0;
            var issuesResolvedThisWeek = 0;
            var reviewsCreatedThisWeek = 0;
            var reviewsParticipatedThisWeek = 0;
            var todoClosedThisWeek = 0;
            var meetingsThisWeek = 0;
            
            await foreach (var projectDto in BatchEnumerator.AllItems(skip => _projectClient.GetAllProjectsByMember(MemberProfile.Id, skip: skip)))
            {
                try
                {
                    // Check # of issues resolved this week
                    var issueStatuses = await _projectClient.Planning.Issues.Statuses.GetAllIssueStatuses(projectDto.Id);
                
                    await foreach (var issueDto in BatchEnumerator.AllItems(skip => _projectClient.Planning.Issues.GetAllIssues(projectDto.Id, issueStatuses.Select(it => it.Id).ToList(), IssuesSorting.UPDATED, descending: true, skip: skip, partialBuilder: partial => partial
                        .WithNext()
                        .WithTotalCount()
                        .WithData(issue => issue
                            .AddAllFieldNames()
                            .WithCreationTime()
                            .WithCreatedBy(createdBy => createdBy
                                .WithDetails(details => details
                                    .WithInherited<CUserPrincipalDetailsDto>(detailsDto => detailsDto
                                        .WithUser(user => user
                                            .WithId()))
                                    .WithInherited<CUserWithEmailPrincipalDetailsDto>(detailsDto => detailsDto
                                        .WithName()
                                        .WithEmail())))
                            .WithStatus()
                            .WithAssignee(assignee => assignee
                                .WithId())
                            .WithChannel(channel => channel
                                .WithLastMessage(lastMessage => lastMessage
                                    .WithText()
                                    .WithTime()))))))
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
                    var reviews1 = await BatchEnumerator.AllItems(skip => _projectClient.CodeReviews.GetAllCodeReviews(projectDto.Key.Key, ReviewSorting.LastUpdatedDesc, state: CodeReviewStateFilter.Opened, from: weekStart.AsSpaceDate(), skip: skip)).ToListAsync();
                    var reviews2 = await BatchEnumerator.AllItems(skip => _projectClient.CodeReviews.GetAllCodeReviews(projectDto.Key.Key, ReviewSorting.LastUpdatedDesc, state: CodeReviewStateFilter.NeedsReview, from: weekStart.AsSpaceDate(), skip: skip)).ToListAsync();
                    var reviews3 = await BatchEnumerator.AllItems(skip => _projectClient.CodeReviews.GetAllCodeReviews(projectDto.Key.Key, ReviewSorting.LastUpdatedDesc, state: CodeReviewStateFilter.RequiresAuthorAttention, from: weekStart.AsSpaceDate(), skip: skip)).ToListAsync();
                    var reviews4 = await BatchEnumerator.AllItems(skip => _projectClient.CodeReviews.GetAllCodeReviews(projectDto.Key.Key, ReviewSorting.LastUpdatedDesc, state: CodeReviewStateFilter.Closed, from: weekStart.AsSpaceDate(), skip: skip)).ToListAsync();
                    
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
                // Check # of TODO items resolved
                await foreach (var todoDto in BatchEnumerator.AllItems(skip => _todoClient.GetAllToDoItems(from: weekStart.AsSpaceDate(), skip: skip, partialBuilder: partial => partial
                    .WithNext()
                    .WithTotalCount()
                    .WithData(todoItem => todoItem
                        .WithStatus()))))
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
                await foreach (var meetingDto in BatchEnumerator.AllItems(skip => _calendarClient.Meetings.GetAllMeetings("", new List<string>(), new List<string> { MemberProfile.Id }, new List<string>(), true, false, startingAfter: weekStart.AsSpaceTime(), endingBefore: weekEnd.AsSpaceTime(), skip: skip, partialBuilder: partial => partial
                    .WithNext()
                    .WithTotalCount()
                    .WithData(meeting => meeting
                        .AddAllFieldNames()
                        .WithId()
                        .WithSummary()
                        .WithDescription()
                        .WithConferenceLink()))))
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

        public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            var diff = (7 + (dt.Date.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}