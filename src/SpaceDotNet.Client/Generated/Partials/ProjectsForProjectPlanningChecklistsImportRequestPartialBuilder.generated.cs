// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.ProjectsForProjectPlanningChecklistsImportRequestPartialBuilder
{
    public static class ProjectsForProjectPlanningChecklistsImportRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectPlanningChecklistsImportRequest> WithName(this Partial<ProjectsForProjectPlanningChecklistsImportRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<ProjectsForProjectPlanningChecklistsImportRequest> WithTabIndentedLines(this Partial<ProjectsForProjectPlanningChecklistsImportRequest> it)
            => it.AddFieldName("tabIndentedLines");
        
    }
    
}
