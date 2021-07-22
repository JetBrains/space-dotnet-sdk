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
    public class ProjectsForProjectCodeReviewsForReviewIdMergePutRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectCodeReviewsForReviewIdMergePutRequest() { }
        
        public ProjectsForProjectCodeReviewsForReviewIdMergePutRequest(bool deleteSourceBranch, GitMergeMode mergeMode)
        {
            IsDeleteSourceBranch = deleteSourceBranch;
            MergeMode = mergeMode;
        }
        
        private PropertyValue<bool> _deleteSourceBranch = new PropertyValue<bool>(nameof(ProjectsForProjectCodeReviewsForReviewIdMergePutRequest), nameof(IsDeleteSourceBranch));
        
        [Required]
        [JsonPropertyName("deleteSourceBranch")]
        public bool IsDeleteSourceBranch
        {
            get => _deleteSourceBranch.GetValue();
            set => _deleteSourceBranch.SetValue(value);
        }
    
        private PropertyValue<GitMergeMode> _mergeMode = new PropertyValue<GitMergeMode>(nameof(ProjectsForProjectCodeReviewsForReviewIdMergePutRequest), nameof(MergeMode));
        
        [Required]
        [JsonPropertyName("mergeMode")]
        public GitMergeMode MergeMode
        {
            get => _mergeMode.GetValue();
            set => _mergeMode.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _deleteSourceBranch.SetAccessPath(path, validateHasBeenSet);
            _mergeMode.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
