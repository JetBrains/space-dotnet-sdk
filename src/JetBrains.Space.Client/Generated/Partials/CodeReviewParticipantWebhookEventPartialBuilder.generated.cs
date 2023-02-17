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

namespace JetBrains.Space.Client.CodeReviewParticipantWebhookEventPartialBuilder;

public static class CodeReviewParticipantWebhookEventPartialExtensions
{
    public static Partial<CodeReviewParticipantWebhookEvent> WithMeta(this Partial<CodeReviewParticipantWebhookEvent> it)
        => it.AddFieldName("meta");
    
    public static Partial<CodeReviewParticipantWebhookEvent> WithMeta(this Partial<CodeReviewParticipantWebhookEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
        => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
    
    public static Partial<CodeReviewParticipantWebhookEvent> WithReview(this Partial<CodeReviewParticipantWebhookEvent> it)
        => it.AddFieldName("review");
    
    public static Partial<CodeReviewParticipantWebhookEvent> WithReview(this Partial<CodeReviewParticipantWebhookEvent> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
        => it.AddFieldName("review", partialBuilder(new Partial<CodeReviewRecord>(it)));
    
    public static Partial<CodeReviewParticipantWebhookEvent> WithIsMergeRequest(this Partial<CodeReviewParticipantWebhookEvent> it)
        => it.AddFieldName("isMergeRequest");
    
    public static Partial<CodeReviewParticipantWebhookEvent> WithParticipant(this Partial<CodeReviewParticipantWebhookEvent> it)
        => it.AddFieldName("participant");
    
    public static Partial<CodeReviewParticipantWebhookEvent> WithParticipant(this Partial<CodeReviewParticipantWebhookEvent> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("participant", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<CodeReviewParticipantWebhookEvent> WithReviewerState(this Partial<CodeReviewParticipantWebhookEvent> it)
        => it.AddFieldName("reviewerState");
    
    public static Partial<CodeReviewParticipantWebhookEvent> WithTheirTurn(this Partial<CodeReviewParticipantWebhookEvent> it)
        => it.AddFieldName("theirTurn");
    
}

