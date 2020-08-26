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

namespace SpaceDotNet.Client
{
    public class ProjectsForProjectPlanningIssuesForIssueIdToggleResolvedPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPlanningIssuesForIssueIdToggleResolvedPostRequest() { }
        
        public ProjectsForProjectPlanningIssuesForIssueIdToggleResolvedPostRequest(bool resolved)
        {
            Resolved = resolved;
        }
        
        private PropertyValue<bool> _resolved = new PropertyValue<bool>(nameof(ProjectsForProjectPlanningIssuesForIssueIdToggleResolvedPostRequest), nameof(Resolved));
        
        [Required]
        [JsonPropertyName("resolved")]
        public bool Resolved
        {
            get { return _resolved.GetValue(); }
            set { _resolved.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _resolved.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
