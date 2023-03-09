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

namespace JetBrains.Space.Client.UpdateDocumentAccessInPartialBuilder;

public static class UpdateDocumentAccessInPartialExtensions
{
    public static Partial<UpdateDocumentAccessIn> WithAddAccessTo(this Partial<UpdateDocumentAccessIn> it)
        => it.AddFieldName("addAccessTo");
    
    public static Partial<UpdateDocumentAccessIn> WithAddAccessTo(this Partial<UpdateDocumentAccessIn> it, Func<Partial<DocumentAccessRecipientIdentifier>, Partial<DocumentAccessRecipientIdentifier>> partialBuilder)
        => it.AddFieldName("addAccessTo", partialBuilder(new Partial<DocumentAccessRecipientIdentifier>(it)));
    
    public static Partial<UpdateDocumentAccessIn> WithRemoveAccessFrom(this Partial<UpdateDocumentAccessIn> it)
        => it.AddFieldName("removeAccessFrom");
    
    public static Partial<UpdateDocumentAccessIn> WithRemoveAccessFrom(this Partial<UpdateDocumentAccessIn> it, Func<Partial<PermissionsRecipientIdentifier>, Partial<PermissionsRecipientIdentifier>> partialBuilder)
        => it.AddFieldName("removeAccessFrom", partialBuilder(new Partial<PermissionsRecipientIdentifier>(it)));
    
}

