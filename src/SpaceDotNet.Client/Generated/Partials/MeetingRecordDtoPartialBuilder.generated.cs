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

namespace SpaceDotNet.Client.MeetingRecordDtoPartialBuilder
{
    public static class MeetingRecordDtoPartialExtensions
    {
        public static Partial<MeetingRecordDto> WithId(this Partial<MeetingRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<MeetingRecordDto> WithArchived(this Partial<MeetingRecordDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<MeetingRecordDto> WithStarts(this Partial<MeetingRecordDto> it)
            => it.AddFieldName("starts");
        
        public static Partial<MeetingRecordDto> WithFinishes(this Partial<MeetingRecordDto> it)
            => it.AddFieldName("finishes");
        
        public static Partial<MeetingRecordDto> WithTimezone(this Partial<MeetingRecordDto> it)
            => it.AddFieldName("timezone");
        
        public static Partial<MeetingRecordDto> WithTimezone(this Partial<MeetingRecordDto> it, Func<Partial<ATimeZoneDto>, Partial<ATimeZoneDto>> partialBuilder)
            => it.AddFieldName("timezone", partialBuilder(new Partial<ATimeZoneDto>(it)));
        
        public static Partial<MeetingRecordDto> WithAllDay(this Partial<MeetingRecordDto> it)
            => it.AddFieldName("allDay");
        
        public static Partial<MeetingRecordDto> WithRooms(this Partial<MeetingRecordDto> it)
            => it.AddFieldName("rooms");
        
        public static Partial<MeetingRecordDto> WithRooms(this Partial<MeetingRecordDto> it, Func<Partial<TDLocationDto>, Partial<TDLocationDto>> partialBuilder)
            => it.AddFieldName("rooms", partialBuilder(new Partial<TDLocationDto>(it)));
        
        public static Partial<MeetingRecordDto> WithParticipants(this Partial<MeetingRecordDto> it)
            => it.AddFieldName("participants");
        
        public static Partial<MeetingRecordDto> WithParticipants(this Partial<MeetingRecordDto> it, Func<Partial<ParticipantDto>, Partial<ParticipantDto>> partialBuilder)
            => it.AddFieldName("participants", partialBuilder(new Partial<ParticipantDto>(it)));
        
        public static Partial<MeetingRecordDto> WithArticle(this Partial<MeetingRecordDto> it)
            => it.AddFieldName("article");
        
        public static Partial<MeetingRecordDto> WithArticle(this Partial<MeetingRecordDto> it, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>> partialBuilder)
            => it.AddFieldName("article", partialBuilder(new Partial<ArticleRecordDto>(it)));
        
    }
    
}
