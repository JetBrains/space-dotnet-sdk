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

public interface CompactFeedEvent
     : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static AuthorChanged AuthorChanged(TDMemberProfile profile, ReviewerChangedType changeType)
        => new AuthorChanged(profile: profile, changeType: changeType);
    
    public static AuthorResumedWork AuthorResumedWork()
        => new AuthorResumedWork();
    
    public static AuthorWaitsForReview AuthorWaitsForReview()
        => new AuthorWaitsForReview();
    
    public static BranchDeleted BranchDeleted(string branchName)
        => new BranchDeleted(branchName: branchName);
    
    public static MergeRequestClosed MergeRequestClosed(bool isMerged, string sourceBranch, bool sourceBranchDeleted, string targetBranch, bool targetBranchDeleted)
        => new MergeRequestClosed(isMerged: isMerged, sourceBranch: sourceBranch, sourceBranchDeleted: sourceBranchDeleted, targetBranch: targetBranch, targetBranchDeleted: targetBranchDeleted);
    
    public static MergeRequestDescriptionChanged MergeRequestDescriptionChanged(bool isUpdated)
        => new MergeRequestDescriptionChanged(isUpdated: isUpdated);
    
    public static MergeRequestMerged MergeRequestMerged(string sourceBranch, string targetBranch)
        => new MergeRequestMerged(sourceBranch: sourceBranch, targetBranch: targetBranch);
    
    public static MergeRequestStateChanged MergeRequestStateChanged(CodeReviewState state)
        => new MergeRequestStateChanged(state: state);
    
    public static MergeRequestTargetChanged MergeRequestTargetChanged(string prevBranch, string nextBranch)
        => new MergeRequestTargetChanged(prevBranch: prevBranch, nextBranch: nextBranch);
    
    public static MergeRequestTitleChanged MergeRequestTitleChanged(string oldTitle, string newTitle)
        => new MergeRequestTitleChanged(oldTitle: oldTitle, newTitle: newTitle);
    
    public static ReviewCommitsChanged ReviewCommitsChanged(ReviewRevisionsChangedType changeType, bool initial, bool forcePush, List<ReviewCommitsChangedCommit> commits)
        => new ReviewCommitsChanged(changeType: changeType, initial: initial, forcePush: forcePush, commits: commits);
    
    public static ReviewCompletionStateChanged ReviewCompletionStateChanged(ReviewerState state, bool isAccepted, bool isAcceptedBefore, bool isApproveSticky, bool reviewOnlyOwnedFiles)
        => new ReviewCompletionStateChanged(state: state, isAccepted: isAccepted, isAcceptedBefore: isAcceptedBefore, isApproveSticky: isApproveSticky, reviewOnlyOwnedFiles: reviewOnlyOwnedFiles);
    
    public static ReviewerChanged ReviewerChanged(TDMemberProfile profile, ReviewerChangedType changeType, bool personally)
        => new ReviewerChanged(profile: profile, changeType: changeType, personally: personally);
    
    public static ReviewerResumedReview ReviewerResumedReview()
        => new ReviewerResumedReview();
    
    public static ReviewerWaitsForUpdate ReviewerWaitsForUpdate()
        => new ReviewerWaitsForUpdate();
    
}

