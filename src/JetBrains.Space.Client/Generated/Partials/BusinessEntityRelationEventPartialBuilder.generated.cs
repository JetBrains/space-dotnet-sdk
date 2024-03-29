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

namespace JetBrains.Space.Client.BusinessEntityRelationEventPartialBuilder;

public static class BusinessEntityRelationEventPartialExtensions
{
    public static Partial<BusinessEntityRelationEvent> WithMeta(this Partial<BusinessEntityRelationEvent> it)
        => it.AddFieldName("meta");
    
    public static Partial<BusinessEntityRelationEvent> WithMeta(this Partial<BusinessEntityRelationEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
        => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
    
    public static Partial<BusinessEntityRelationEvent> WithRelation(this Partial<BusinessEntityRelationEvent> it)
        => it.AddFieldName("relation");
    
    public static Partial<BusinessEntityRelationEvent> WithEntity(this Partial<BusinessEntityRelationEvent> it)
        => it.AddFieldName("entity");
    
    public static Partial<BusinessEntityRelationEvent> WithMember(this Partial<BusinessEntityRelationEvent> it)
        => it.AddFieldName("member");
    
    public static Partial<BusinessEntityRelationEvent> WithMember(this Partial<BusinessEntityRelationEvent> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("member", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<BusinessEntityRelationEvent> WithSince(this Partial<BusinessEntityRelationEvent> it)
        => it.AddFieldName("since");
    
    public static Partial<BusinessEntityRelationEvent> WithTill(this Partial<BusinessEntityRelationEvent> it)
        => it.AddFieldName("till");
    
    public static Partial<BusinessEntityRelationEvent> WithArchived(this Partial<BusinessEntityRelationEvent> it)
        => it.AddFieldName("archived");
    
}

