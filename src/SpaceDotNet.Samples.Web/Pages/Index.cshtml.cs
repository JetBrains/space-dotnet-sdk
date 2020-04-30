using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SpaceDotNet.Client;
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

        public TDMemberProfileDto? MemberProfile { get; set; }
        public int IssuesResolvedThisWeek { get; set; }
        public int ReviewsCreatedThisWeek { get; set; }
        public int ReviewsParticipatedThisWeek { get; set; }
        public int TodoClosedThisWeek { get; set; }
        
        public IndexModel(
            IConfiguration configuration, 
            ILogger<IndexModel> logger,
            ProjectClient projectClient,
            ToDoItemClient todoClient,
            TeamDirectoryClient teamDirectoryClient)
        {
            _configuration = configuration;
            _logger = logger;
            _projectClient = projectClient;
            _todoClient = todoClient;
            _teamDirectoryClient = teamDirectoryClient;
        }

        public async Task OnGet()
        {
            MemberProfile = await _teamDirectoryClient.Profiles.Me.GetMe();
            
            var weekStart = StartOfWeek(DateTime.UtcNow, DayOfWeek.Monday);
            var weekEnd = weekStart.AddDays(7).AddHours(23).AddMinutes(59).AddSeconds(59);

            var issuesResolvedThisWeek = 0;
            var reviewsCreatedThisWeek = 0;
            var reviewsParticipatedThisWeek = 0;
            var todoClosedThisWeek = 0;

            await foreach (var projectDto in BatchEnumerator.AllItems(skip => _projectClient.GetAllProjectsByMember(MemberProfile.Id, skip: skip)))
            {
                try
                {
                    // Check # of issues resolved this week
                    var issueStatuses = await _projectClient.Planning.Issues.Statuses.GetAllIssueStatuses(projectDto.Id);
                
                    await foreach (var issueDto in BatchEnumerator.AllItems(skip => _projectClient.Planning.Issues.GetAllIssues(projectDto.Id, issueStatuses.Select(it => it.Id).ToList(), IssuesSorting.UPDATED, descending: true, skip: skip)))
                    {
                        var lastUpdated = issueDto.Channel.LastMessage?.Time.AsDateTime() ?? issueDto.CreationTime.AsDateTime();
                        if (lastUpdated < weekStart)
                        {
                            break;
                        }
                    
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
                await foreach (var todoDto in BatchEnumerator.AllItems(skip => _todoClient.GetAllToDoItems(from: weekStart.AsSpaceDate(), skip: skip)))
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


            // Issues
            // Reviews created
            // Reviews participated
            // Meetings
            // Commits
            // Documents
            // Chats
            // + status (open, in progress, done)
            
            IssuesResolvedThisWeek = issuesResolvedThisWeek;
            ReviewsCreatedThisWeek = reviewsCreatedThisWeek;
            ReviewsParticipatedThisWeek = reviewsParticipatedThisWeek;
            TodoClosedThisWeek = todoClosedThisWeek;
        }

        public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            var diff = (7 + (dt.Date.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}