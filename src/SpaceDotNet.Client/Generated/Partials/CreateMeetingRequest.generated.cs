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

namespace SpaceDotNet.Client.CreateMeetingRequestExtensions
{
    public static class CreateMeetingRequestPartialExtensions
    {
        public static Partial<CreateMeetingRequest> WithSummary(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("summary");
        
        public static Partial<CreateMeetingRequest> WithDescription(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("description");
        
        public static Partial<CreateMeetingRequest> WithOccurrenceRule(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("occurrenceRule");
        
        public static Partial<CreateMeetingRequest> WithOccurrenceRule(this Partial<CreateMeetingRequest> it, Func<Partial<CalendarEventSpecDto>, Partial<CalendarEventSpecDto>> partialBuilder)    => it.AddFieldName("occurrenceRule", partialBuilder(new Partial<CalendarEventSpecDto>()));
        
        public static Partial<CreateMeetingRequest> WithLocations(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("locations");
        
        public static Partial<CreateMeetingRequest> WithProfiles(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("profiles");
        
        public static Partial<CreateMeetingRequest> WithExternalParticipants(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("externalParticipants");
        
        public static Partial<CreateMeetingRequest> WithTeams(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("teams");
        
        public static Partial<CreateMeetingRequest> WithVisibility(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("visibility");
        
        public static Partial<CreateMeetingRequest> WithVisibility(this Partial<CreateMeetingRequest> it, Func<Partial<MeetingVisibility>, Partial<MeetingVisibility>> partialBuilder)    => it.AddFieldName("visibility", partialBuilder(new Partial<MeetingVisibility>()));
        
        public static Partial<CreateMeetingRequest> WithModificationPreference(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("modificationPreference");
        
        public static Partial<CreateMeetingRequest> WithModificationPreference(this Partial<CreateMeetingRequest> it, Func<Partial<MeetingModificationPreference>, Partial<MeetingModificationPreference>> partialBuilder)    => it.AddFieldName("modificationPreference", partialBuilder(new Partial<MeetingModificationPreference>()));
        
        public static Partial<CreateMeetingRequest> WithJoiningPreference(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("joiningPreference");
        
        public static Partial<CreateMeetingRequest> WithJoiningPreference(this Partial<CreateMeetingRequest> it, Func<Partial<MeetingJoiningPreference>, Partial<MeetingJoiningPreference>> partialBuilder)    => it.AddFieldName("joiningPreference", partialBuilder(new Partial<MeetingJoiningPreference>()));
        
        public static Partial<CreateMeetingRequest> WithNotifyOnExport(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("notifyOnExport");
        
        public static Partial<CreateMeetingRequest> WithOrganizer(this Partial<CreateMeetingRequest> it)    => it.AddFieldName("organizer");
        
    }
    
}
