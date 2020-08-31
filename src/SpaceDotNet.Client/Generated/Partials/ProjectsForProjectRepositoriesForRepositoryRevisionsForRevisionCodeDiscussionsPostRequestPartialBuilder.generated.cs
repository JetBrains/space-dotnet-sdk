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

namespace SpaceDotNet.Client.ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequestPartialBuilder
{
    public static class ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> WithText(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> it)
            => it.AddFieldName("text");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> WithDiffContext(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> it)
            => it.AddFieldName("diffContext");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> WithDiffContext(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> it, Func<Partial<DiffContext>, Partial<DiffContext>> partialBuilder)
            => it.AddFieldName("diffContext", partialBuilder(new Partial<DiffContext>(it)));
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> WithFilename(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> it)
            => it.AddFieldName("filename");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> WithLine(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> it)
            => it.AddFieldName("line");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> WithOldLine(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> it)
            => it.AddFieldName("oldLine");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> WithIsPending(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest> it)
            => it.AddFieldName("pending");
        
    }
    
}
