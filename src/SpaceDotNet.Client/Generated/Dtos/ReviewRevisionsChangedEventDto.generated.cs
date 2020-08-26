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
    public sealed class ReviewRevisionsChangedEventDto
         : FeedEventDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ReviewRevisionsChangedEvent";
        
        public ReviewRevisionsChangedEventDto() { }
        
        public ReviewRevisionsChangedEventDto(List<RepositoryCommitRecordDto> commits, ReviewRevisionsChangedType changeType, string? projectKey = null, CodeReviewRecordDto? review = null)
        {
            Commits = commits;
            ChangeType = changeType;
            ProjectKey = projectKey;
            Review = review;
        }
        
        private PropertyValue<List<RepositoryCommitRecordDto>> _commits = new PropertyValue<List<RepositoryCommitRecordDto>>(nameof(ReviewRevisionsChangedEventDto), nameof(Commits));
        
        [Required]
        [JsonPropertyName("commits")]
        public List<RepositoryCommitRecordDto> Commits
        {
            get { return _commits.GetValue(); }
            set { _commits.SetValue(value); }
        }
    
        private PropertyValue<ReviewRevisionsChangedType> _changeType = new PropertyValue<ReviewRevisionsChangedType>(nameof(ReviewRevisionsChangedEventDto), nameof(ChangeType));
        
        [Required]
        [JsonPropertyName("changeType")]
        public ReviewRevisionsChangedType ChangeType
        {
            get { return _changeType.GetValue(); }
            set { _changeType.SetValue(value); }
        }
    
        private PropertyValue<string?> _projectKey = new PropertyValue<string?>(nameof(ReviewRevisionsChangedEventDto), nameof(ProjectKey));
        
        [JsonPropertyName("projectKey")]
        public string? ProjectKey
        {
            get { return _projectKey.GetValue(); }
            set { _projectKey.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewRecordDto?> _review = new PropertyValue<CodeReviewRecordDto?>(nameof(ReviewRevisionsChangedEventDto), nameof(Review));
        
        [JsonPropertyName("review")]
        public CodeReviewRecordDto? Review
        {
            get { return _review.GetValue(); }
            set { _review.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _commits.SetAccessPath(path, validateHasBeenSet);
            _changeType.SetAccessPath(path, validateHasBeenSet);
            _projectKey.SetAccessPath(path, validateHasBeenSet);
            _review.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
