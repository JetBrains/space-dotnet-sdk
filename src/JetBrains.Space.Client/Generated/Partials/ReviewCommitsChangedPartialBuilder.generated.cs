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

namespace JetBrains.Space.Client.ReviewCommitsChangedPartialBuilder;

public static class ReviewCommitsChangedPartialExtensions
{
    public static Partial<ReviewCommitsChanged> WithChangeType(this Partial<ReviewCommitsChanged> it)
        => it.AddFieldName("changeType");
    
    public static Partial<ReviewCommitsChanged> WithChangeType(this Partial<ReviewCommitsChanged> it, Func<Partial<ReviewRevisionsChangedType>, Partial<ReviewRevisionsChangedType>> partialBuilder)
        => it.AddFieldName("changeType", partialBuilder(new Partial<ReviewRevisionsChangedType>(it)));
    
    public static Partial<ReviewCommitsChanged> WithIsInitial(this Partial<ReviewCommitsChanged> it)
        => it.AddFieldName("initial");
    
    public static Partial<ReviewCommitsChanged> WithIsForcePush(this Partial<ReviewCommitsChanged> it)
        => it.AddFieldName("forcePush");
    
    public static Partial<ReviewCommitsChanged> WithCommits(this Partial<ReviewCommitsChanged> it)
        => it.AddFieldName("commits");
    
    public static Partial<ReviewCommitsChanged> WithCommits(this Partial<ReviewCommitsChanged> it, Func<Partial<ReviewCommitsChangedCommit>, Partial<ReviewCommitsChangedCommit>> partialBuilder)
        => it.AddFieldName("commits", partialBuilder(new Partial<ReviewCommitsChangedCommit>(it)));
    
}

