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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
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
    public sealed class RepoCommitsSubscriptionFilterIn
         : SubscriptionFilterIn, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "RepoCommitsSubscriptionFilterIn";
        
        public RepoCommitsSubscriptionFilterIn() { }
        
        public RepoCommitsSubscriptionFilterIn(List<string> projects, string repository, RepoCommitsSubscriptionFilterSpec spec)
        {
            Projects = projects;
            Repository = repository;
            Spec = spec;
        }
        
        private PropertyValue<List<string>> _projects = new PropertyValue<List<string>>(nameof(RepoCommitsSubscriptionFilterIn), nameof(Projects), new List<string>());
        
        [Required]
        [JsonPropertyName("projects")]
        public List<string> Projects
        {
            get => _projects.GetValue();
            set => _projects.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(RepoCommitsSubscriptionFilterIn), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<RepoCommitsSubscriptionFilterSpec> _spec = new PropertyValue<RepoCommitsSubscriptionFilterSpec>(nameof(RepoCommitsSubscriptionFilterIn), nameof(Spec));
        
        [Required]
        [JsonPropertyName("spec")]
        public RepoCommitsSubscriptionFilterSpec Spec
        {
            get => _spec.GetValue();
            set => _spec.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _projects.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _spec.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}