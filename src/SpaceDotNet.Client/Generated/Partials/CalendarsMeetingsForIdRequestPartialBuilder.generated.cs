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

namespace SpaceDotNet.Client.CalendarsMeetingsForIdRequestPartialBuilder
{
    public static class CalendarsMeetingsForIdRequestPartialExtensions
    {
        public static Partial<CalendarsMeetingsForIdRequest> WithSummary(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("summary");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithDescription(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithOccurrenceRule(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("occurrenceRule");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithOccurrenceRule(this Partial<CalendarsMeetingsForIdRequest> it, Func<Partial<CalendarEventSpecDto>, Partial<CalendarEventSpecDto>> partialBuilder)
            => it.AddFieldName("occurrenceRule", partialBuilder(new Partial<CalendarEventSpecDto>(it)));
        
        public static Partial<CalendarsMeetingsForIdRequest> WithLocationsDiff(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("locationsDiff");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithLocationsDiff(this Partial<CalendarsMeetingsForIdRequest> it, Func<Partial<DiffDto>, Partial<DiffDto>> partialBuilder)
            => it.AddFieldName("locationsDiff", partialBuilder(new Partial<DiffDto>(it)));
        
        public static Partial<CalendarsMeetingsForIdRequest> WithProfilesDiff(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("profilesDiff");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithProfilesDiff(this Partial<CalendarsMeetingsForIdRequest> it, Func<Partial<DiffDto>, Partial<DiffDto>> partialBuilder)
            => it.AddFieldName("profilesDiff", partialBuilder(new Partial<DiffDto>(it)));
        
        public static Partial<CalendarsMeetingsForIdRequest> WithExternalParticipantsDiff(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("externalParticipantsDiff");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithExternalParticipantsDiff(this Partial<CalendarsMeetingsForIdRequest> it, Func<Partial<DiffDto>, Partial<DiffDto>> partialBuilder)
            => it.AddFieldName("externalParticipantsDiff", partialBuilder(new Partial<DiffDto>(it)));
        
        public static Partial<CalendarsMeetingsForIdRequest> WithTeamsDiff(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("teamsDiff");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithTeamsDiff(this Partial<CalendarsMeetingsForIdRequest> it, Func<Partial<DiffDto>, Partial<DiffDto>> partialBuilder)
            => it.AddFieldName("teamsDiff", partialBuilder(new Partial<DiffDto>(it)));
        
        public static Partial<CalendarsMeetingsForIdRequest> WithVisibility(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("visibility");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithVisibility(this Partial<CalendarsMeetingsForIdRequest> it, Func<Partial<MeetingVisibility>, Partial<MeetingVisibility>> partialBuilder)
            => it.AddFieldName("visibility", partialBuilder(new Partial<MeetingVisibility>(it)));
        
        public static Partial<CalendarsMeetingsForIdRequest> WithModificationPreference(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("modificationPreference");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithModificationPreference(this Partial<CalendarsMeetingsForIdRequest> it, Func<Partial<MeetingModificationPreference>, Partial<MeetingModificationPreference>> partialBuilder)
            => it.AddFieldName("modificationPreference", partialBuilder(new Partial<MeetingModificationPreference>(it)));
        
        public static Partial<CalendarsMeetingsForIdRequest> WithJoiningPreference(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("joiningPreference");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithJoiningPreference(this Partial<CalendarsMeetingsForIdRequest> it, Func<Partial<MeetingJoiningPreference>, Partial<MeetingJoiningPreference>> partialBuilder)
            => it.AddFieldName("joiningPreference", partialBuilder(new Partial<MeetingJoiningPreference>(it)));
        
        public static Partial<CalendarsMeetingsForIdRequest> WithNotifyOnExport(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("notifyOnExport");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithOrganizer(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("organizer");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithTargetDate(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("targetDate");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithModificationKind(this Partial<CalendarsMeetingsForIdRequest> it)
            => it.AddFieldName("modificationKind");
        
        public static Partial<CalendarsMeetingsForIdRequest> WithModificationKind(this Partial<CalendarsMeetingsForIdRequest> it, Func<Partial<RecurrentModification>, Partial<RecurrentModification>> partialBuilder)
            => it.AddFieldName("modificationKind", partialBuilder(new Partial<RecurrentModification>(it)));
        
    }
    
}
