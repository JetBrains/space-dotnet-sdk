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

namespace JetBrains.Space.Client
{
    public class ProjectsForProjectPlanningChecklistsForChecklistIdImportPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPlanningChecklistsForChecklistIdImportPostRequest() { }
        
        public ProjectsForProjectPlanningChecklistsForChecklistIdImportPostRequest(string targetParentId, string tabIndentedLines, string? afterItemId = null)
        {
            TargetParentId = targetParentId;
            AfterItemId = afterItemId;
            TabIndentedLines = tabIndentedLines;
        }
        
        private PropertyValue<string> _targetParentId = new PropertyValue<string>(nameof(ProjectsForProjectPlanningChecklistsForChecklistIdImportPostRequest), nameof(TargetParentId));
        
        [Required]
        [JsonPropertyName("targetParentId")]
        public string TargetParentId
        {
            get => _targetParentId.GetValue();
            set => _targetParentId.SetValue(value);
        }
    
        private PropertyValue<string?> _afterItemId = new PropertyValue<string?>(nameof(ProjectsForProjectPlanningChecklistsForChecklistIdImportPostRequest), nameof(AfterItemId));
        
        [JsonPropertyName("afterItemId")]
        public string? AfterItemId
        {
            get => _afterItemId.GetValue();
            set => _afterItemId.SetValue(value);
        }
    
        private PropertyValue<string> _tabIndentedLines = new PropertyValue<string>(nameof(ProjectsForProjectPlanningChecklistsForChecklistIdImportPostRequest), nameof(TabIndentedLines));
        
        [Required]
        [JsonPropertyName("tabIndentedLines")]
        public string TabIndentedLines
        {
            get => _tabIndentedLines.GetValue();
            set => _tabIndentedLines.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _targetParentId.SetAccessPath(path, validateHasBeenSet);
            _afterItemId.SetAccessPath(path, validateHasBeenSet);
            _tabIndentedLines.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
