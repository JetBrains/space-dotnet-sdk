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

namespace SpaceDotNet.Client.MergeRequestReviewerDtoPartialBuilder
{
    public static class MergeRequestReviewerDtoPartialExtensions
    {
        public static Partial<MergeRequestReviewerDto> WithProfileId(this Partial<MergeRequestReviewerDto> it)
            => it.AddFieldName("profileId");
        
        public static Partial<MergeRequestReviewerDto> WithQualityGateSlot(this Partial<MergeRequestReviewerDto> it)
            => it.AddFieldName("qualityGateSlot");
        
        public static Partial<MergeRequestReviewerDto> WithQualityGateSlot(this Partial<MergeRequestReviewerDto> it, Func<Partial<CodeReviewParticipantQualityGateSlotDto>, Partial<CodeReviewParticipantQualityGateSlotDto>> partialBuilder)
            => it.AddFieldName("qualityGateSlot", partialBuilder(new Partial<CodeReviewParticipantQualityGateSlotDto>(it)));
        
    }
    
}
