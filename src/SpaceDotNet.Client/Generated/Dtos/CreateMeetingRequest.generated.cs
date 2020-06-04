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
    public class CreateMeetingRequest
    {
        [Required]
        [JsonPropertyName("summary")]
        public string Summary { get; set; }
    
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    
        [Required]
        [JsonPropertyName("occurrenceRule")]
        public CalendarEventSpecDto OccurrenceRule { get; set; }
    
        [Required]
        [JsonPropertyName("locations")]
        public List<string> Locations { get; set; }
    
        [Required]
        [JsonPropertyName("profiles")]
        public List<string> Profiles { get; set; }
    
        [Required]
        [JsonPropertyName("externalParticipants")]
        public List<string> ExternalParticipants { get; set; }
    
        [Required]
        [JsonPropertyName("teams")]
        public List<string> Teams { get; set; }
    
        [Required]
        [JsonPropertyName("visibility")]
        public MeetingVisibility Visibility { get; set; }
    
        [Required]
        [JsonPropertyName("modificationPreference")]
        public MeetingModificationPreference ModificationPreference { get; set; }
    
        [Required]
        [JsonPropertyName("joiningPreference")]
        public MeetingJoiningPreference JoiningPreference { get; set; }
    
        [Required]
        [JsonPropertyName("notifyOnExport")]
        public bool NotifyOnExport { get; set; }
    
        [JsonPropertyName("organizer")]
        public string? Organizer { get; set; }
    
    }
    
}
