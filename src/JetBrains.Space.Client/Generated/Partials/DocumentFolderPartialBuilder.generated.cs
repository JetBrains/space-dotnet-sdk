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

namespace JetBrains.Space.Client.DocumentFolderPartialBuilder;

public static class DocumentFolderPartialExtensions
{
    public static Partial<DocumentFolder> WithId(this Partial<DocumentFolder> it)
        => it.AddFieldName("id");
    
    public static Partial<DocumentFolder> WithIsArchived(this Partial<DocumentFolder> it)
        => it.AddFieldName("archived");
    
    public static Partial<DocumentFolder> WithParent(this Partial<DocumentFolder> it)
        => it.AddFieldName("parent");
    
    public static Partial<DocumentFolder> WithParentRecursive(this Partial<DocumentFolder> it)
        => it.AddFieldName("parent!");
    
    public static Partial<DocumentFolder> WithParent(this Partial<DocumentFolder> it, Func<Partial<DocumentFolder>, Partial<DocumentFolder>> partialBuilder)
        => it.AddFieldName("parent", partialBuilder(new Partial<DocumentFolder>(it)));
    
    public static Partial<DocumentFolder> WithName(this Partial<DocumentFolder> it)
        => it.AddFieldName("name");
    
    public static Partial<DocumentFolder> WithCreated(this Partial<DocumentFolder> it)
        => it.AddFieldName("created");
    
    public static Partial<DocumentFolder> WithCreatedBy(this Partial<DocumentFolder> it)
        => it.AddFieldName("createdBy");
    
    public static Partial<DocumentFolder> WithCreatedBy(this Partial<DocumentFolder> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("createdBy", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<DocumentFolder> WithUpdated(this Partial<DocumentFolder> it)
        => it.AddFieldName("updated");
    
    public static Partial<DocumentFolder> WithUpdatedBy(this Partial<DocumentFolder> it)
        => it.AddFieldName("updatedBy");
    
    public static Partial<DocumentFolder> WithUpdatedBy(this Partial<DocumentFolder> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("updatedBy", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<DocumentFolder> WithCover(this Partial<DocumentFolder> it)
        => it.AddFieldName("cover");
    
    public static Partial<DocumentFolder> WithCover(this Partial<DocumentFolder> it, Func<Partial<Document>, Partial<Document>> partialBuilder)
        => it.AddFieldName("cover", partialBuilder(new Partial<Document>(it)));
    
}

