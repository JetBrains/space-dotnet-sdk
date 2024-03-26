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

namespace JetBrains.Space.Client.ReviewCompletionStateChangedPartialBuilder;

public static class ReviewCompletionStateChangedPartialExtensions
{
    public static Partial<ReviewCompletionStateChanged> WithState(this Partial<ReviewCompletionStateChanged> it)
        => it.AddFieldName("state");
    
    public static Partial<ReviewCompletionStateChanged> WithState(this Partial<ReviewCompletionStateChanged> it, Func<Partial<ReviewerState>, Partial<ReviewerState>> partialBuilder)
        => it.AddFieldName("state", partialBuilder(new Partial<ReviewerState>(it)));
    
    public static Partial<ReviewCompletionStateChanged> WithIsAccepted(this Partial<ReviewCompletionStateChanged> it)
        => it.AddFieldName("isAccepted");
    
    public static Partial<ReviewCompletionStateChanged> WithIsAcceptedBefore(this Partial<ReviewCompletionStateChanged> it)
        => it.AddFieldName("isAcceptedBefore");
    
    public static Partial<ReviewCompletionStateChanged> WithIsApproveSticky(this Partial<ReviewCompletionStateChanged> it)
        => it.AddFieldName("isApproveSticky");
    
    public static Partial<ReviewCompletionStateChanged> WithIsReviewOnlyOwnedFiles(this Partial<ReviewCompletionStateChanged> it)
        => it.AddFieldName("reviewOnlyOwnedFiles");
    
}
