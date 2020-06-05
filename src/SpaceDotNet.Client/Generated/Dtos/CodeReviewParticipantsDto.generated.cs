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
    public sealed class CodeReviewParticipantsDto
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeReviewParticipantsDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id { get { return _id.GetValue(); } set { _id.SetValue(value); } }
    
        private PropertyValue<List<CodeReviewParticipantDto>?> _participants = new PropertyValue<List<CodeReviewParticipantDto>?>(nameof(CodeReviewParticipantsDto), nameof(Participants));
        
        [JsonPropertyName("participants")]
        public List<CodeReviewParticipantDto>? Participants { get { return _participants.GetValue(); } set { _participants.SetValue(value); } }
    
        private PropertyValue<List<CodeReviewParticipantRecordDto>> _reviewers = new PropertyValue<List<CodeReviewParticipantRecordDto>>(nameof(CodeReviewParticipantsDto), nameof(Reviewers));
        
        [Required]
        [JsonPropertyName("reviewers")]
        public List<CodeReviewParticipantRecordDto> Reviewers { get { return _reviewers.GetValue(); } set { _reviewers.SetValue(value); } }
    
        private PropertyValue<List<CodeReviewParticipantRecordDto>> _authors = new PropertyValue<List<CodeReviewParticipantRecordDto>>(nameof(CodeReviewParticipantsDto), nameof(Authors));
        
        [Required]
        [JsonPropertyName("authors")]
        public List<CodeReviewParticipantRecordDto> Authors { get { return _authors.GetValue(); } set { _authors.SetValue(value); } }
    
        private PropertyValue<List<CodeReviewParticipantRecordDto>> _watchers = new PropertyValue<List<CodeReviewParticipantRecordDto>>(nameof(CodeReviewParticipantsDto), nameof(Watchers));
        
        [Required]
        [JsonPropertyName("watchers")]
        public List<CodeReviewParticipantRecordDto> Watchers { get { return _watchers.GetValue(); } set { _watchers.SetValue(value); } }
    
    }
    
}
