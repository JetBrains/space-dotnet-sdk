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
    public class ProjectsForProjectPlanningChecklistsImportPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPlanningChecklistsImportPostRequest() { }
        
        public ProjectsForProjectPlanningChecklistsImportPostRequest(string name, string tabIndentedLines)
        {
            Name = name;
            TabIndentedLines = tabIndentedLines;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsForProjectPlanningChecklistsImportPostRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _tabIndentedLines = new PropertyValue<string>(nameof(ProjectsForProjectPlanningChecklistsImportPostRequest), nameof(TabIndentedLines));
        
        [Required]
        [JsonPropertyName("tabIndentedLines")]
        public string TabIndentedLines
        {
            get { return _tabIndentedLines.GetValue(); }
            set { _tabIndentedLines.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _tabIndentedLines.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
