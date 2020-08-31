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

namespace SpaceDotNet.Client.TeamDirectoryProfilesForProfileSettingsPatchRequestPartialBuilder
{
    public static class TeamDirectoryProfilesForProfileSettingsPatchRequestPartialExtensions
    {
        public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithThemeName(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
            => it.AddFieldName("themeName");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithFirstDayOfWeek(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
            => it.AddFieldName("firstDayOfWeek");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithFirstDayOfWeek(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it, Func<Partial<Weekday>, Partial<Weekday>> partialBuilder)
            => it.AddFieldName("firstDayOfWeek", partialBuilder(new Partial<Weekday>(it)));
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithDraftType(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
            => it.AddFieldName("draftType");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithDraftType(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)
            => it.AddFieldName("draftType", partialBuilder(new Partial<DraftDocumentType>(it)));
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithIsTodoFilters(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
            => it.AddFieldName("todoFilters");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithCalendarView(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
            => it.AddFieldName("calendarView");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithIsEmailNotificationsEnabled(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
            => it.AddFieldName("emailNotificationsEnabled");
        
        public static Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> WithNotificationEmail(this Partial<TeamDirectoryProfilesForProfileSettingsPatchRequest> it)
            => it.AddFieldName("notificationEmail");
        
    }
    
}
