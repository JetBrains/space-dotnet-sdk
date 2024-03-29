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

namespace JetBrains.Space.Client.CodeReviewLinkedExternalIssuesChangedPartialBuilder;

public static class CodeReviewLinkedExternalIssuesChangedPartialExtensions
{
    public static Partial<CodeReviewLinkedExternalIssuesChanged> WithReview(this Partial<CodeReviewLinkedExternalIssuesChanged> it)
        => it.AddFieldName("review");
    
    public static Partial<CodeReviewLinkedExternalIssuesChanged> WithReview(this Partial<CodeReviewLinkedExternalIssuesChanged> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
        => it.AddFieldName("review", partialBuilder(new Partial<CodeReviewRecord>(it)));
    
    public static Partial<CodeReviewLinkedExternalIssuesChanged> WithIssues(this Partial<CodeReviewLinkedExternalIssuesChanged> it)
        => it.AddFieldName("issues");
    
    public static Partial<CodeReviewLinkedExternalIssuesChanged> WithIssues(this Partial<CodeReviewLinkedExternalIssuesChanged> it, Func<Partial<ExternalIssueIdOut>, Partial<ExternalIssueIdOut>> partialBuilder)
        => it.AddFieldName("issues", partialBuilder(new Partial<ExternalIssueIdOut>(it)));
    
}

