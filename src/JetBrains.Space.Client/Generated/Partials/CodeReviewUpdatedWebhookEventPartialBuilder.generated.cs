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

namespace JetBrains.Space.Client.CodeReviewUpdatedWebhookEventPartialBuilder;

public static class CodeReviewUpdatedWebhookEventPartialExtensions
{
    public static Partial<CodeReviewUpdatedWebhookEvent> WithMeta(this Partial<CodeReviewUpdatedWebhookEvent> it)
        => it.AddFieldName("meta");
    
    public static Partial<CodeReviewUpdatedWebhookEvent> WithMeta(this Partial<CodeReviewUpdatedWebhookEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
        => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
    
    public static Partial<CodeReviewUpdatedWebhookEvent> WithReview(this Partial<CodeReviewUpdatedWebhookEvent> it)
        => it.AddFieldName("review");
    
    public static Partial<CodeReviewUpdatedWebhookEvent> WithReview(this Partial<CodeReviewUpdatedWebhookEvent> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
        => it.AddFieldName("review", partialBuilder(new Partial<CodeReviewRecord>(it)));
    
    public static Partial<CodeReviewUpdatedWebhookEvent> WithTitleMod(this Partial<CodeReviewUpdatedWebhookEvent> it)
        => it.AddFieldName("titleMod");
    
    public static Partial<CodeReviewUpdatedWebhookEvent> WithDescriptionMod(this Partial<CodeReviewUpdatedWebhookEvent> it)
        => it.AddFieldName("descriptionMod");
    
    public static Partial<CodeReviewUpdatedWebhookEvent> WithTargetBranchMod(this Partial<CodeReviewUpdatedWebhookEvent> it)
        => it.AddFieldName("targetBranchMod");
    
}

