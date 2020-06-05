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

namespace SpaceDotNet.Client
{
    public sealed class MergeRequestBranchPairDto
    {
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(MergeRequestBranchPairDto), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository { get { return _repository.GetValue(); } set { _repository.SetValue(value); } }
    
        private PropertyValue<string> _sourceBranch = new PropertyValue<string>(nameof(MergeRequestBranchPairDto), nameof(SourceBranch));
        
        [Required]
        [JsonPropertyName("sourceBranch")]
        public string SourceBranch { get { return _sourceBranch.GetValue(); } set { _sourceBranch.SetValue(value); } }
    
        private PropertyValue<string> _targetBranch = new PropertyValue<string>(nameof(MergeRequestBranchPairDto), nameof(TargetBranch));
        
        [Required]
        [JsonPropertyName("targetBranch")]
        public string TargetBranch { get { return _targetBranch.GetValue(); } set { _targetBranch.SetValue(value); } }
    
        private PropertyValue<string> _sourceBranchRef = new PropertyValue<string>(nameof(MergeRequestBranchPairDto), nameof(SourceBranchRef));
        
        [Required]
        [JsonPropertyName("sourceBranchRef")]
        public string SourceBranchRef { get { return _sourceBranchRef.GetValue(); } set { _sourceBranchRef.SetValue(value); } }
    
        private PropertyValue<MergeRequestBranchDto?> _sourceBranchInfo = new PropertyValue<MergeRequestBranchDto?>(nameof(MergeRequestBranchPairDto), nameof(SourceBranchInfo));
        
        [JsonPropertyName("sourceBranchInfo")]
        public MergeRequestBranchDto? SourceBranchInfo { get { return _sourceBranchInfo.GetValue(); } set { _sourceBranchInfo.SetValue(value); } }
    
        private PropertyValue<MergeRequestBranchDto?> _targetBranchInfo = new PropertyValue<MergeRequestBranchDto?>(nameof(MergeRequestBranchPairDto), nameof(TargetBranchInfo));
        
        [JsonPropertyName("targetBranchInfo")]
        public MergeRequestBranchDto? TargetBranchInfo { get { return _targetBranchInfo.GetValue(); } set { _targetBranchInfo.SetValue(value); } }
    
    }
    
}
