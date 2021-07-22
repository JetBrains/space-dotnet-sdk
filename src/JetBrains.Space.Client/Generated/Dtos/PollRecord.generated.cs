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
    public sealed class PollRecord
         : IPropagatePropertyAccessPath
    {
        public PollRecord() { }
        
        public PollRecord(string id, TDMemberProfile owner, string question, bool meVote, int countPeople, bool anonymous, bool closed, bool extendable, bool multiChoice, bool ended, List<VoteGroup> votes, DateTime? expirationTime = null)
        {
            Id = id;
            Owner = owner;
            Question = question;
            IsMeVote = meVote;
            CountPeople = countPeople;
            IsAnonymous = anonymous;
            IsClosed = closed;
            IsExtendable = extendable;
            IsMultiChoice = multiChoice;
            IsEnded = ended;
            ExpirationTime = expirationTime;
            Votes = votes;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PollRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile> _owner = new PropertyValue<TDMemberProfile>(nameof(PollRecord), nameof(Owner));
        
        [Required]
        [JsonPropertyName("owner")]
        public TDMemberProfile Owner
        {
            get => _owner.GetValue();
            set => _owner.SetValue(value);
        }
    
        private PropertyValue<string> _question = new PropertyValue<string>(nameof(PollRecord), nameof(Question));
        
        [Required]
        [JsonPropertyName("question")]
        public string Question
        {
            get => _question.GetValue();
            set => _question.SetValue(value);
        }
    
        private PropertyValue<bool> _meVote = new PropertyValue<bool>(nameof(PollRecord), nameof(IsMeVote));
        
        [Required]
        [JsonPropertyName("meVote")]
        public bool IsMeVote
        {
            get => _meVote.GetValue();
            set => _meVote.SetValue(value);
        }
    
        private PropertyValue<int> _countPeople = new PropertyValue<int>(nameof(PollRecord), nameof(CountPeople));
        
        [Required]
        [JsonPropertyName("countPeople")]
        public int CountPeople
        {
            get => _countPeople.GetValue();
            set => _countPeople.SetValue(value);
        }
    
        private PropertyValue<bool> _anonymous = new PropertyValue<bool>(nameof(PollRecord), nameof(IsAnonymous));
        
        [Required]
        [JsonPropertyName("anonymous")]
        public bool IsAnonymous
        {
            get => _anonymous.GetValue();
            set => _anonymous.SetValue(value);
        }
    
        private PropertyValue<bool> _closed = new PropertyValue<bool>(nameof(PollRecord), nameof(IsClosed));
        
        [Required]
        [JsonPropertyName("closed")]
        public bool IsClosed
        {
            get => _closed.GetValue();
            set => _closed.SetValue(value);
        }
    
        private PropertyValue<bool> _extendable = new PropertyValue<bool>(nameof(PollRecord), nameof(IsExtendable));
        
        [Required]
        [JsonPropertyName("extendable")]
        public bool IsExtendable
        {
            get => _extendable.GetValue();
            set => _extendable.SetValue(value);
        }
    
        private PropertyValue<bool> _multiChoice = new PropertyValue<bool>(nameof(PollRecord), nameof(IsMultiChoice));
        
        [Required]
        [JsonPropertyName("multiChoice")]
        public bool IsMultiChoice
        {
            get => _multiChoice.GetValue();
            set => _multiChoice.SetValue(value);
        }
    
        private PropertyValue<bool> _ended = new PropertyValue<bool>(nameof(PollRecord), nameof(IsEnded));
        
        [Required]
        [JsonPropertyName("ended")]
        public bool IsEnded
        {
            get => _ended.GetValue();
            set => _ended.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _expirationTime = new PropertyValue<DateTime?>(nameof(PollRecord), nameof(ExpirationTime));
        
        [JsonPropertyName("expirationTime")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? ExpirationTime
        {
            get => _expirationTime.GetValue();
            set => _expirationTime.SetValue(value);
        }
    
        private PropertyValue<List<VoteGroup>> _votes = new PropertyValue<List<VoteGroup>>(nameof(PollRecord), nameof(Votes), new List<VoteGroup>());
        
        [Required]
        [JsonPropertyName("votes")]
        public List<VoteGroup> Votes
        {
            get => _votes.GetValue();
            set => _votes.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _owner.SetAccessPath(path, validateHasBeenSet);
            _question.SetAccessPath(path, validateHasBeenSet);
            _meVote.SetAccessPath(path, validateHasBeenSet);
            _countPeople.SetAccessPath(path, validateHasBeenSet);
            _anonymous.SetAccessPath(path, validateHasBeenSet);
            _closed.SetAccessPath(path, validateHasBeenSet);
            _extendable.SetAccessPath(path, validateHasBeenSet);
            _multiChoice.SetAccessPath(path, validateHasBeenSet);
            _ended.SetAccessPath(path, validateHasBeenSet);
            _expirationTime.SetAccessPath(path, validateHasBeenSet);
            _votes.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
