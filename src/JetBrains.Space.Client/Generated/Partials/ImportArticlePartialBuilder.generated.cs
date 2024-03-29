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

namespace JetBrains.Space.Client.ImportArticlePartialBuilder;

public static class ImportArticlePartialExtensions
{
    public static Partial<ImportArticle> WithTitle(this Partial<ImportArticle> it)
        => it.AddFieldName("title");
    
    public static Partial<ImportArticle> WithContent(this Partial<ImportArticle> it)
        => it.AddFieldName("content");
    
    public static Partial<ImportArticle> WithAuthorId(this Partial<ImportArticle> it)
        => it.AddFieldName("authorId");
    
    public static Partial<ImportArticle> WithCreated(this Partial<ImportArticle> it)
        => it.AddFieldName("created");
    
    public static Partial<ImportArticle> WithTeams(this Partial<ImportArticle> it)
        => it.AddFieldName("teams");
    
    public static Partial<ImportArticle> WithLocations(this Partial<ImportArticle> it)
        => it.AddFieldName("locations");
    
    public static Partial<ImportArticle> WithExternalId(this Partial<ImportArticle> it)
        => it.AddFieldName("externalId");
    
    public static Partial<ImportArticle> WithExternalUrl(this Partial<ImportArticle> it)
        => it.AddFieldName("externalUrl");
    
}

