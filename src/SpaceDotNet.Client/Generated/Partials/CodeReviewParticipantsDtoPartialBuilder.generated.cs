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

namespace SpaceDotNet.Client.CodeReviewParticipantsDtoPartialBuilder
{
    public static class CodeReviewParticipantsDtoPartialExtensions
    {
        public static Partial<CodeReviewParticipantsDto> WithId(this Partial<CodeReviewParticipantsDto> it)
            => it.AddFieldName("id");
        
        public static Partial<CodeReviewParticipantsDto> WithParticipants(this Partial<CodeReviewParticipantsDto> it)
            => it.AddFieldName("participants");
        
        public static Partial<CodeReviewParticipantsDto> WithParticipants(this Partial<CodeReviewParticipantsDto> it, Func<Partial<CodeReviewParticipantDto>, Partial<CodeReviewParticipantDto>> partialBuilder)
            => it.AddFieldName("participants", partialBuilder(new Partial<CodeReviewParticipantDto>(it)));
        
        public static Partial<CodeReviewParticipantsDto> WithReviewers(this Partial<CodeReviewParticipantsDto> it)
            => it.AddFieldName("reviewers");
        
        public static Partial<CodeReviewParticipantsDto> WithReviewers(this Partial<CodeReviewParticipantsDto> it, Func<Partial<CodeReviewParticipantRecordDto>, Partial<CodeReviewParticipantRecordDto>> partialBuilder)
            => it.AddFieldName("reviewers", partialBuilder(new Partial<CodeReviewParticipantRecordDto>(it)));
        
        public static Partial<CodeReviewParticipantsDto> WithAuthors(this Partial<CodeReviewParticipantsDto> it)
            => it.AddFieldName("authors");
        
        public static Partial<CodeReviewParticipantsDto> WithAuthors(this Partial<CodeReviewParticipantsDto> it, Func<Partial<CodeReviewParticipantRecordDto>, Partial<CodeReviewParticipantRecordDto>> partialBuilder)
            => it.AddFieldName("authors", partialBuilder(new Partial<CodeReviewParticipantRecordDto>(it)));
        
        public static Partial<CodeReviewParticipantsDto> WithWatchers(this Partial<CodeReviewParticipantsDto> it)
            => it.AddFieldName("watchers");
        
        public static Partial<CodeReviewParticipantsDto> WithWatchers(this Partial<CodeReviewParticipantsDto> it, Func<Partial<CodeReviewParticipantRecordDto>, Partial<CodeReviewParticipantRecordDto>> partialBuilder)
            => it.AddFieldName("watchers", partialBuilder(new Partial<CodeReviewParticipantRecordDto>(it)));
        
    }
    
}
