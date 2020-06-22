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
    public sealed class CommitSetReviewRecordDto
         : CodeReviewRecordDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        private PropertyValue<ProjectKeyDto> _project = new PropertyValue<ProjectKeyDto>(nameof(CommitSetReviewRecordDto), nameof(Project));
        
        [Required]
        [JsonPropertyName("project")]
        public ProjectKeyDto Project
        {
            get { return _project.GetValue(); }
            set { _project.SetValue(value); }
        }
    
        private PropertyValue<int> _number = new PropertyValue<int>(nameof(CommitSetReviewRecordDto), nameof(Number));
        
        [Required]
        [JsonPropertyName("number")]
        public int Number
        {
            get { return _number.GetValue(); }
            set { _number.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(CommitSetReviewRecordDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewState> _state = new PropertyValue<CodeReviewState>(nameof(CommitSetReviewRecordDto), nameof(State));
        
        [Required]
        [JsonPropertyName("state")]
        public CodeReviewState State
        {
            get { return _state.GetValue(); }
            set { _state.SetValue(value); }
        }
    
        private PropertyValue<bool?> _canBeReopened = new PropertyValue<bool?>(nameof(CommitSetReviewRecordDto), nameof(CanBeReopened));
        
        [JsonPropertyName("canBeReopened")]
        public bool? CanBeReopened
        {
            get { return _canBeReopened.GetValue(); }
            set { _canBeReopened.SetValue(value); }
        }
    
        private PropertyValue<long> _createdAt = new PropertyValue<long>(nameof(CommitSetReviewRecordDto), nameof(CreatedAt));
        
        [Required]
        [JsonPropertyName("createdAt")]
        public long CreatedAt
        {
            get { return _createdAt.GetValue(); }
            set { _createdAt.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto> _createdBy = new PropertyValue<TDMemberProfileDto>(nameof(CommitSetReviewRecordDto), nameof(CreatedBy));
        
        [Required]
        [JsonPropertyName("createdBy")]
        public TDMemberProfileDto CreatedBy
        {
            get { return _createdBy.GetValue(); }
            set { _createdBy.SetValue(value); }
        }
    
        private PropertyValue<bool?> _turnBased = new PropertyValue<bool?>(nameof(CommitSetReviewRecordDto), nameof(TurnBased));
        
        [JsonPropertyName("turnBased")]
        public bool? TurnBased
        {
            get { return _turnBased.GetValue(); }
            set { _turnBased.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelRecordDto?> _feedChannel = new PropertyValue<M2ChannelRecordDto?>(nameof(CommitSetReviewRecordDto), nameof(FeedChannel));
        
        [JsonPropertyName("feedChannel")]
        public M2ChannelRecordDto? FeedChannel
        {
            get { return _feedChannel.GetValue(); }
            set { _feedChannel.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _project.SetAccessPath(path + "->WithProject()", validateHasBeenSet);
            _number.SetAccessPath(path + "->WithNumber()", validateHasBeenSet);
            _title.SetAccessPath(path + "->WithTitle()", validateHasBeenSet);
            _state.SetAccessPath(path + "->WithState()", validateHasBeenSet);
            _canBeReopened.SetAccessPath(path + "->WithCanBeReopened()", validateHasBeenSet);
            _createdAt.SetAccessPath(path + "->WithCreatedAt()", validateHasBeenSet);
            _createdBy.SetAccessPath(path + "->WithCreatedBy()", validateHasBeenSet);
            _turnBased.SetAccessPath(path + "->WithTurnBased()", validateHasBeenSet);
            _feedChannel.SetAccessPath(path + "->WithFeedChannel()", validateHasBeenSet);
        }
    
    }
    
}
