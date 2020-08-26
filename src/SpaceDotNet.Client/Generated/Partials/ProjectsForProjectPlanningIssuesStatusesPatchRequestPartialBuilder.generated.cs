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

namespace SpaceDotNet.Client.ProjectsForProjectPlanningIssuesStatusesPatchRequestPartialBuilder
{
    public static class ProjectsForProjectPlanningIssuesStatusesPatchRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectPlanningIssuesStatusesPatchRequest> WithStatuses(this Partial<ProjectsForProjectPlanningIssuesStatusesPatchRequest> it)
            => it.AddFieldName("statuses");
        
        public static Partial<ProjectsForProjectPlanningIssuesStatusesPatchRequest> WithStatuses(this Partial<ProjectsForProjectPlanningIssuesStatusesPatchRequest> it, Func<Partial<IssueStatusDataDto>, Partial<IssueStatusDataDto>> partialBuilder)
            => it.AddFieldName("statuses", partialBuilder(new Partial<IssueStatusDataDto>(it)));
        
    }
    
}
