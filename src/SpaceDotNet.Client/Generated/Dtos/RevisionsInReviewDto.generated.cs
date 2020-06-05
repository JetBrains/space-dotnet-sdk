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
    public sealed class RevisionsInReviewDto
    {
        private PropertyValue<RepositoryInReviewDto> _repository = new PropertyValue<RepositoryInReviewDto>(nameof(RevisionsInReviewDto), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public RepositoryInReviewDto Repository { get { return _repository.GetValue(); } set { _repository.SetValue(value); } }
    
        private PropertyValue<List<GitCommitWithGraphDto>> _commits = new PropertyValue<List<GitCommitWithGraphDto>>(nameof(RevisionsInReviewDto), nameof(Commits));
        
        [Required]
        [JsonPropertyName("commits")]
        public List<GitCommitWithGraphDto> Commits { get { return _commits.GetValue(); } set { _commits.SetValue(value); } }
    
    }
    
}
