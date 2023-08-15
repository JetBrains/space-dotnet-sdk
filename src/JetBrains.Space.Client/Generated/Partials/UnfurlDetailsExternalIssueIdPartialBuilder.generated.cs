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

namespace JetBrains.Space.Client.UnfurlDetailsExternalIssueIdPartialBuilder;

public static class UnfurlDetailsExternalIssueIdPartialExtensions
{
    public static Partial<UnfurlDetailsExternalIssueId> WithId(this Partial<UnfurlDetailsExternalIssueId> it)
        => it.AddFieldName("id");
    
    public static Partial<UnfurlDetailsExternalIssueId> WithId(this Partial<UnfurlDetailsExternalIssueId> it, Func<Partial<ExternalIssueId>, Partial<ExternalIssueId>> partialBuilder)
        => it.AddFieldName("id", partialBuilder(new Partial<ExternalIssueId>(it)));
    
    public static Partial<UnfurlDetailsExternalIssueId> WithMarketplaceAppId(this Partial<UnfurlDetailsExternalIssueId> it)
        => it.AddFieldName("marketplaceAppId");
    
}

