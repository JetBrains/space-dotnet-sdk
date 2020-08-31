// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.ArticleImportResultPartialBuilder
{
    public static class ArticleImportResultPartialExtensions
    {
        public static Partial<ArticleImportResult> WithExternalId(this Partial<ArticleImportResult> it)
            => it.AddFieldName("externalId");
        
        public static Partial<ArticleImportResult> WithArticle(this Partial<ArticleImportResult> it)
            => it.AddFieldName("article");
        
        public static Partial<ArticleImportResult> WithArticle(this Partial<ArticleImportResult> it, Func<Partial<ArticleRecord>, Partial<ArticleRecord>> partialBuilder)
            => it.AddFieldName("article", partialBuilder(new Partial<ArticleRecord>(it)));
        
        public static Partial<ArticleImportResult> WithError(this Partial<ArticleImportResult> it)
            => it.AddFieldName("error");
        
    }
    
}
