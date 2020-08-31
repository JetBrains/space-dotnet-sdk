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
    public sealed class CodeReviewParticipantRecord
         : IPropagatePropertyAccessPath
    {
        public CodeReviewParticipantRecord() { }
        
        public CodeReviewParticipantRecord(string id, string projectId, CodeReviewParticipantRole role, TDMemberProfile profile, bool archived, ReviewerState? reviewerState = null, bool? theirTurn = null)
        {
            Id = id;
            ProjectId = projectId;
            Role = role;
            Profile = profile;
            ReviewerState = reviewerState;
            IsTheirTurn = theirTurn;
            IsArchived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeReviewParticipantRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _projectId = new PropertyValue<string>(nameof(CodeReviewParticipantRecord), nameof(ProjectId));
        
        [Required]
        [JsonPropertyName("projectId")]
        public string ProjectId
        {
            get { return _projectId.GetValue(); }
            set { _projectId.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewParticipantRole> _role = new PropertyValue<CodeReviewParticipantRole>(nameof(CodeReviewParticipantRecord), nameof(Role));
        
        [Required]
        [JsonPropertyName("role")]
        public CodeReviewParticipantRole Role
        {
            get { return _role.GetValue(); }
            set { _role.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(CodeReviewParticipantRecord), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfile Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<ReviewerState?> _reviewerState = new PropertyValue<ReviewerState?>(nameof(CodeReviewParticipantRecord), nameof(ReviewerState));
        
        [JsonPropertyName("reviewerState")]
        public ReviewerState? ReviewerState
        {
            get { return _reviewerState.GetValue(); }
            set { _reviewerState.SetValue(value); }
        }
    
        private PropertyValue<bool?> _theirTurn = new PropertyValue<bool?>(nameof(CodeReviewParticipantRecord), nameof(IsTheirTurn));
        
        [JsonPropertyName("theirTurn")]
        public bool? IsTheirTurn
        {
            get { return _theirTurn.GetValue(); }
            set { _theirTurn.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(CodeReviewParticipantRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _projectId.SetAccessPath(path, validateHasBeenSet);
            _role.SetAccessPath(path, validateHasBeenSet);
            _profile.SetAccessPath(path, validateHasBeenSet);
            _reviewerState.SetAccessPath(path, validateHasBeenSet);
            _theirTurn.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
