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
    public class ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest() { }
        
        public ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest(string sourceBranch, string targetBranch, string title, List<ReviewerParam>? reviewers = null)
        {
            SourceBranch = sourceBranch;
            TargetBranch = targetBranch;
            Title = title;
            Reviewers = reviewers;
        }
        
        private PropertyValue<string> _sourceBranch = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest), nameof(SourceBranch));
        
        [Required]
        [JsonPropertyName("sourceBranch")]
        public string SourceBranch
        {
            get => _sourceBranch.GetValue();
            set => _sourceBranch.SetValue(value);
        }
    
        private PropertyValue<string> _targetBranch = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest), nameof(TargetBranch));
        
        [Required]
        [JsonPropertyName("targetBranch")]
        public string TargetBranch
        {
            get => _targetBranch.GetValue();
            set => _targetBranch.SetValue(value);
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        private PropertyValue<List<ReviewerParam>?> _reviewers = new PropertyValue<List<ReviewerParam>?>(nameof(ProjectsForProjectRepositoriesForRepositoryMergeRequestsPostRequest), nameof(Reviewers));
        
        [JsonPropertyName("reviewers")]
        public List<ReviewerParam>? Reviewers
        {
            get => _reviewers.GetValue();
            set => _reviewers.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _sourceBranch.SetAccessPath(path, validateHasBeenSet);
            _targetBranch.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _reviewers.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
