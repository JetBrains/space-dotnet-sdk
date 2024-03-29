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

namespace JetBrains.Space.Client.BasicCRDiscussionContactsRecordPartialBuilder;

public static class BasicCRDiscussionContactsRecordPartialExtensions
{
    public static Partial<BasicCRDiscussionContactsRecord> WithDiscussions(this Partial<BasicCRDiscussionContactsRecord> it)
        => it.AddFieldName("discussions");
    
    public static Partial<BasicCRDiscussionContactsRecord> WithDiscussions(this Partial<BasicCRDiscussionContactsRecord> it, Func<Partial<BasicCRDiscussionContactRecord>, Partial<BasicCRDiscussionContactRecord>> partialBuilder)
        => it.AddFieldName("discussions", partialBuilder(new Partial<BasicCRDiscussionContactRecord>(it)));
    
    public static Partial<BasicCRDiscussionContactsRecord> WithIsArchived(this Partial<BasicCRDiscussionContactsRecord> it)
        => it.AddFieldName("archived");
    
    public static Partial<BasicCRDiscussionContactsRecord> WithId(this Partial<BasicCRDiscussionContactsRecord> it)
        => it.AddFieldName("id");
    
}

