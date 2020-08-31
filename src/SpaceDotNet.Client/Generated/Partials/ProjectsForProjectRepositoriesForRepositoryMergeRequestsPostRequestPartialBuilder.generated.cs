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

namespace SpaceDotNet.Client.ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequestPartialBuilder
{
    public static class ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest> WithSourceBranch(this Partial<ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest> it)
            => it.AddFieldName("sourceBranch");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest> WithTargetBranch(this Partial<ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest> it)
            => it.AddFieldName("targetBranch");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest> WithTitle(this Partial<ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest> it)
            => it.AddFieldName("title");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest> WithReviewers(this Partial<ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest> it)
            => it.AddFieldName("reviewers");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest> WithReviewers(this Partial<ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest> it, Func<Partial<MergeRequestReviewer>, Partial<MergeRequestReviewer>> partialBuilder)
            => it.AddFieldName("reviewers", partialBuilder(new Partial<MergeRequestReviewer>(it)));
        
    }
    
}
