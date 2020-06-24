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
    public class UpdateMeetingRequest
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string?> _summary = new PropertyValue<string?>(nameof(UpdateMeetingRequest), nameof(Summary));
        
        [JsonPropertyName("summary")]
        public string? Summary
        {
            get { return _summary.GetValue(); }
            set { _summary.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(UpdateMeetingRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<CalendarEventSpecDto?> _occurrenceRule = new PropertyValue<CalendarEventSpecDto?>(nameof(UpdateMeetingRequest), nameof(OccurrenceRule));
        
        [JsonPropertyName("occurrenceRule")]
        public CalendarEventSpecDto? OccurrenceRule
        {
            get { return _occurrenceRule.GetValue(); }
            set { _occurrenceRule.SetValue(value); }
        }
    
        private PropertyValue<DiffDto> _locationsDiff = new PropertyValue<DiffDto>(nameof(UpdateMeetingRequest), nameof(LocationsDiff));
        
        [Required]
        [JsonPropertyName("locationsDiff")]
        public DiffDto LocationsDiff
        {
            get { return _locationsDiff.GetValue(); }
            set { _locationsDiff.SetValue(value); }
        }
    
        private PropertyValue<DiffDto> _profilesDiff = new PropertyValue<DiffDto>(nameof(UpdateMeetingRequest), nameof(ProfilesDiff));
        
        [Required]
        [JsonPropertyName("profilesDiff")]
        public DiffDto ProfilesDiff
        {
            get { return _profilesDiff.GetValue(); }
            set { _profilesDiff.SetValue(value); }
        }
    
        private PropertyValue<DiffDto> _externalParticipantsDiff = new PropertyValue<DiffDto>(nameof(UpdateMeetingRequest), nameof(ExternalParticipantsDiff));
        
        [Required]
        [JsonPropertyName("externalParticipantsDiff")]
        public DiffDto ExternalParticipantsDiff
        {
            get { return _externalParticipantsDiff.GetValue(); }
            set { _externalParticipantsDiff.SetValue(value); }
        }
    
        private PropertyValue<DiffDto> _teamsDiff = new PropertyValue<DiffDto>(nameof(UpdateMeetingRequest), nameof(TeamsDiff));
        
        [Required]
        [JsonPropertyName("teamsDiff")]
        public DiffDto TeamsDiff
        {
            get { return _teamsDiff.GetValue(); }
            set { _teamsDiff.SetValue(value); }
        }
    
        private PropertyValue<MeetingVisibility?> _visibility = new PropertyValue<MeetingVisibility?>(nameof(UpdateMeetingRequest), nameof(Visibility));
        
        [JsonPropertyName("visibility")]
        public MeetingVisibility? Visibility
        {
            get { return _visibility.GetValue(); }
            set { _visibility.SetValue(value); }
        }
    
        private PropertyValue<MeetingModificationPreference?> _modificationPreference = new PropertyValue<MeetingModificationPreference?>(nameof(UpdateMeetingRequest), nameof(ModificationPreference));
        
        [JsonPropertyName("modificationPreference")]
        public MeetingModificationPreference? ModificationPreference
        {
            get { return _modificationPreference.GetValue(); }
            set { _modificationPreference.SetValue(value); }
        }
    
        private PropertyValue<MeetingJoiningPreference?> _joiningPreference = new PropertyValue<MeetingJoiningPreference?>(nameof(UpdateMeetingRequest), nameof(JoiningPreference));
        
        [JsonPropertyName("joiningPreference")]
        public MeetingJoiningPreference? JoiningPreference
        {
            get { return _joiningPreference.GetValue(); }
            set { _joiningPreference.SetValue(value); }
        }
    
        private PropertyValue<bool> _notifyOnExport = new PropertyValue<bool>(nameof(UpdateMeetingRequest), nameof(NotifyOnExport));
        
        [Required]
        [JsonPropertyName("notifyOnExport")]
        public bool NotifyOnExport
        {
            get { return _notifyOnExport.GetValue(); }
            set { _notifyOnExport.SetValue(value); }
        }
    
        private PropertyValue<string?> _organizer = new PropertyValue<string?>(nameof(UpdateMeetingRequest), nameof(Organizer));
        
        [JsonPropertyName("organizer")]
        public string? Organizer
        {
            get { return _organizer.GetValue(); }
            set { _organizer.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _targetDate = new PropertyValue<SpaceTime?>(nameof(UpdateMeetingRequest), nameof(TargetDate));
        
        [JsonPropertyName("targetDate")]
        public SpaceTime? TargetDate
        {
            get { return _targetDate.GetValue(); }
            set { _targetDate.SetValue(value); }
        }
    
        private PropertyValue<RecurrentModification> _modificationKind = new PropertyValue<RecurrentModification>(nameof(UpdateMeetingRequest), nameof(ModificationKind));
        
        [Required]
        [JsonPropertyName("modificationKind")]
        public RecurrentModification ModificationKind
        {
            get { return _modificationKind.GetValue(); }
            set { _modificationKind.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _summary.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _occurrenceRule.SetAccessPath(path, validateHasBeenSet);
            _locationsDiff.SetAccessPath(path, validateHasBeenSet);
            _profilesDiff.SetAccessPath(path, validateHasBeenSet);
            _externalParticipantsDiff.SetAccessPath(path, validateHasBeenSet);
            _teamsDiff.SetAccessPath(path, validateHasBeenSet);
            _visibility.SetAccessPath(path, validateHasBeenSet);
            _modificationPreference.SetAccessPath(path, validateHasBeenSet);
            _joiningPreference.SetAccessPath(path, validateHasBeenSet);
            _notifyOnExport.SetAccessPath(path, validateHasBeenSet);
            _organizer.SetAccessPath(path, validateHasBeenSet);
            _targetDate.SetAccessPath(path, validateHasBeenSet);
            _modificationKind.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
