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
    public sealed class TrackedBranchesInReview
         : IPropagatePropertyAccessPath
    {
        public TrackedBranchesInReview() { }
        
        public TrackedBranchesInReview(string repository, List<BranchInfo> branches)
        {
            Repository = repository;
            Branches = branches;
        }
        
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(TrackedBranchesInReview), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<List<BranchInfo>> _branches = new PropertyValue<List<BranchInfo>>(nameof(TrackedBranchesInReview), nameof(Branches));
        
        [Required]
        [JsonPropertyName("branches")]
        public List<BranchInfo> Branches
        {
            get { return _branches.GetValue(); }
            set { _branches.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _repository.SetAccessPath(path, validateHasBeenSet);
            _branches.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
