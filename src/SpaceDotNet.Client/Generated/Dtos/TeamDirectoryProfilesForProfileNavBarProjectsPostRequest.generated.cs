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

namespace SpaceDotNet.Client
{
    public class TeamDirectoryProfilesForProfileNavBarProjectsPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryProfilesForProfileNavBarProjectsPostRequest() { }
        
        public TeamDirectoryProfilesForProfileNavBarProjectsPostRequest(ProjectIdentifier project)
        {
            Project = project;
        }
        
        private PropertyValue<ProjectIdentifier> _project = new PropertyValue<ProjectIdentifier>(nameof(TeamDirectoryProfilesForProfileNavBarProjectsPostRequest), nameof(Project));
        
        [Required]
        [JsonPropertyName("project")]
        public ProjectIdentifier Project
        {
            get { return _project.GetValue(); }
            set { _project.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _project.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
