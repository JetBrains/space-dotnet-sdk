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

namespace SpaceDotNet.Client.ProjectsForProjectCodeReviewsForReviewIdStatePatchRequestPartialBuilder
{
    public static class ProjectsForProjectCodeReviewsForReviewIdStatePatchRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectCodeReviewsForReviewIdStatePatchRequest> WithState(this Partial<ProjectsForProjectCodeReviewsForReviewIdStatePatchRequest> it)
            => it.AddFieldName("state");
        
        public static Partial<ProjectsForProjectCodeReviewsForReviewIdStatePatchRequest> WithState(this Partial<ProjectsForProjectCodeReviewsForReviewIdStatePatchRequest> it, Func<Partial<CodeReviewState>, Partial<CodeReviewState>> partialBuilder)
            => it.AddFieldName("state", partialBuilder(new Partial<CodeReviewState>(it)));
        
    }
    
}
