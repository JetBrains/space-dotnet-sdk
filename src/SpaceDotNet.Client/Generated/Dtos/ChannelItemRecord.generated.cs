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
    public sealed class ChannelItemRecord
         : IPropagatePropertyAccessPath
    {
        public ChannelItemRecord() { }
        
        public ChannelItemRecord(string text, CPrincipal author, SpaceTime created, long time, string id, bool archived, M2ItemContentDetails? details = null, AllReactionsToItemRecord? reactions = null, M2ChannelRecord? thread = null, ChannelItemRecord? projectedItem = null, List<AttachmentInfo>? attachments = null, List<AttachmentInfo>? attachmentsInfos = null, bool? pending = null, SpaceTime? edited = null, bool? pinned = null, List<CPrincipal>? suggestedParticipants = null)
        {
            Text = text;
            Details = details;
            Author = author;
            Created = created;
            Time = time;
            Reactions = reactions;
            Thread = thread;
            ProjectedItem = projectedItem;
            Attachments = attachments;
            AttachmentsInfos = attachmentsInfos;
            IsPending = pending;
            Id = id;
            IsArchived = archived;
            Edited = edited;
            IsPinned = pinned;
            SuggestedParticipants = suggestedParticipants;
        }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(ChannelItemRecord), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<M2ItemContentDetails?> _details = new PropertyValue<M2ItemContentDetails?>(nameof(ChannelItemRecord), nameof(Details));
        
        [JsonPropertyName("details")]
        public M2ItemContentDetails? Details
        {
            get { return _details.GetValue(); }
            set { _details.SetValue(value); }
        }
    
        private PropertyValue<CPrincipal> _author = new PropertyValue<CPrincipal>(nameof(ChannelItemRecord), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public CPrincipal Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _created = new PropertyValue<SpaceTime>(nameof(ChannelItemRecord), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<long> _time = new PropertyValue<long>(nameof(ChannelItemRecord), nameof(Time));
        
        [Required]
        [JsonPropertyName("time")]
        public long Time
        {
            get { return _time.GetValue(); }
            set { _time.SetValue(value); }
        }
    
        private PropertyValue<AllReactionsToItemRecord?> _reactions = new PropertyValue<AllReactionsToItemRecord?>(nameof(ChannelItemRecord), nameof(Reactions));
        
        [JsonPropertyName("reactions")]
        public AllReactionsToItemRecord? Reactions
        {
            get { return _reactions.GetValue(); }
            set { _reactions.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelRecord?> _thread = new PropertyValue<M2ChannelRecord?>(nameof(ChannelItemRecord), nameof(Thread));
        
        [JsonPropertyName("thread")]
        public M2ChannelRecord? Thread
        {
            get { return _thread.GetValue(); }
            set { _thread.SetValue(value); }
        }
    
        private PropertyValue<ChannelItemRecord?> _projectedItem = new PropertyValue<ChannelItemRecord?>(nameof(ChannelItemRecord), nameof(ProjectedItem));
        
        [JsonPropertyName("projectedItem")]
        public ChannelItemRecord? ProjectedItem
        {
            get { return _projectedItem.GetValue(); }
            set { _projectedItem.SetValue(value); }
        }
    
        private PropertyValue<List<AttachmentInfo>?> _attachments = new PropertyValue<List<AttachmentInfo>?>(nameof(ChannelItemRecord), nameof(Attachments));
        
        [JsonPropertyName("attachments")]
        public List<AttachmentInfo>? Attachments
        {
            get { return _attachments.GetValue(); }
            set { _attachments.SetValue(value); }
        }
    
        private PropertyValue<List<AttachmentInfo>?> _attachmentsInfos = new PropertyValue<List<AttachmentInfo>?>(nameof(ChannelItemRecord), nameof(AttachmentsInfos));
        
        [JsonPropertyName("attachmentsInfos")]
        public List<AttachmentInfo>? AttachmentsInfos
        {
            get { return _attachmentsInfos.GetValue(); }
            set { _attachmentsInfos.SetValue(value); }
        }
    
        private PropertyValue<bool?> _pending = new PropertyValue<bool?>(nameof(ChannelItemRecord), nameof(IsPending));
        
        [JsonPropertyName("pending")]
        public bool? IsPending
        {
            get { return _pending.GetValue(); }
            set { _pending.SetValue(value); }
        }
    
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ChannelItemRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ChannelItemRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _edited = new PropertyValue<SpaceTime?>(nameof(ChannelItemRecord), nameof(Edited));
        
        [JsonPropertyName("edited")]
        public SpaceTime? Edited
        {
            get { return _edited.GetValue(); }
            set { _edited.SetValue(value); }
        }
    
        private PropertyValue<bool?> _pinned = new PropertyValue<bool?>(nameof(ChannelItemRecord), nameof(IsPinned));
        
        [JsonPropertyName("pinned")]
        public bool? IsPinned
        {
            get { return _pinned.GetValue(); }
            set { _pinned.SetValue(value); }
        }
    
        private PropertyValue<List<CPrincipal>?> _suggestedParticipants = new PropertyValue<List<CPrincipal>?>(nameof(ChannelItemRecord), nameof(SuggestedParticipants));
        
        [JsonPropertyName("suggestedParticipants")]
        public List<CPrincipal>? SuggestedParticipants
        {
            get { return _suggestedParticipants.GetValue(); }
            set { _suggestedParticipants.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _details.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _time.SetAccessPath(path, validateHasBeenSet);
            _reactions.SetAccessPath(path, validateHasBeenSet);
            _thread.SetAccessPath(path, validateHasBeenSet);
            _projectedItem.SetAccessPath(path, validateHasBeenSet);
            _attachments.SetAccessPath(path, validateHasBeenSet);
            _attachmentsInfos.SetAccessPath(path, validateHasBeenSet);
            _pending.SetAccessPath(path, validateHasBeenSet);
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _edited.SetAccessPath(path, validateHasBeenSet);
            _pinned.SetAccessPath(path, validateHasBeenSet);
            _suggestedParticipants.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}