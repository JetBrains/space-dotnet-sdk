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
    public sealed class MeCodeReviewParticipantRecordDto
         : IPropagatePropertyAccessPath
    {
        public MeCodeReviewParticipantRecordDto() { }
        
        public MeCodeReviewParticipantRecordDto(string id, CodeReviewRecordDto review, CodeReviewParticipantsDto participants, CodeReviewPendingMessageCounterDto pendingCounter, bool archived, CodeReviewParticipantRole? role = null, bool? theirTurn = null, ReviewerState? reviewerState = null)
        {
            Id = id;
            Role = role;
            TheirTurn = theirTurn;
            ReviewerState = reviewerState;
            Review = review;
            Participants = participants;
            PendingCounter = pendingCounter;
            Archived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(MeCodeReviewParticipantRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewParticipantRole?> _role = new PropertyValue<CodeReviewParticipantRole?>(nameof(MeCodeReviewParticipantRecordDto), nameof(Role));
        
        [JsonPropertyName("role")]
        public CodeReviewParticipantRole? Role
        {
            get { return _role.GetValue(); }
            set { _role.SetValue(value); }
        }
    
        private PropertyValue<bool?> _theirTurn = new PropertyValue<bool?>(nameof(MeCodeReviewParticipantRecordDto), nameof(TheirTurn));
        
        [JsonPropertyName("theirTurn")]
        public bool? TheirTurn
        {
            get { return _theirTurn.GetValue(); }
            set { _theirTurn.SetValue(value); }
        }
    
        private PropertyValue<ReviewerState?> _reviewerState = new PropertyValue<ReviewerState?>(nameof(MeCodeReviewParticipantRecordDto), nameof(ReviewerState));
        
        [JsonPropertyName("reviewerState")]
        public ReviewerState? ReviewerState
        {
            get { return _reviewerState.GetValue(); }
            set { _reviewerState.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewRecordDto> _review = new PropertyValue<CodeReviewRecordDto>(nameof(MeCodeReviewParticipantRecordDto), nameof(Review));
        
        [Required]
        [JsonPropertyName("review")]
        public CodeReviewRecordDto Review
        {
            get { return _review.GetValue(); }
            set { _review.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewParticipantsDto> _participants = new PropertyValue<CodeReviewParticipantsDto>(nameof(MeCodeReviewParticipantRecordDto), nameof(Participants));
        
        [Required]
        [JsonPropertyName("participants")]
        public CodeReviewParticipantsDto Participants
        {
            get { return _participants.GetValue(); }
            set { _participants.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewPendingMessageCounterDto> _pendingCounter = new PropertyValue<CodeReviewPendingMessageCounterDto>(nameof(MeCodeReviewParticipantRecordDto), nameof(PendingCounter));
        
        [Required]
        [JsonPropertyName("pendingCounter")]
        public CodeReviewPendingMessageCounterDto PendingCounter
        {
            get { return _pendingCounter.GetValue(); }
            set { _pendingCounter.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(MeCodeReviewParticipantRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _role.SetAccessPath(path, validateHasBeenSet);
            _theirTurn.SetAccessPath(path, validateHasBeenSet);
            _reviewerState.SetAccessPath(path, validateHasBeenSet);
            _review.SetAccessPath(path, validateHasBeenSet);
            _participants.SetAccessPath(path, validateHasBeenSet);
            _pendingCounter.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
