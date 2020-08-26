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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.BlogsArticlesImportPostRequestPartialBuilder
{
    public static class BlogsArticlesImportPostRequestPartialExtensions
    {
        public static Partial<BlogsArticlesImportPostRequest> WithMetadata(this Partial<BlogsArticlesImportPostRequest> it)
            => it.AddFieldName("metadata");
        
        public static Partial<BlogsArticlesImportPostRequest> WithMetadata(this Partial<BlogsArticlesImportPostRequest> it, Func<Partial<ImportMetadataDto>, Partial<ImportMetadataDto>> partialBuilder)
            => it.AddFieldName("metadata", partialBuilder(new Partial<ImportMetadataDto>(it)));
        
        public static Partial<BlogsArticlesImportPostRequest> WithArticles(this Partial<BlogsArticlesImportPostRequest> it)
            => it.AddFieldName("articles");
        
        public static Partial<BlogsArticlesImportPostRequest> WithArticles(this Partial<BlogsArticlesImportPostRequest> it, Func<Partial<ExternalArticleDto>, Partial<ExternalArticleDto>> partialBuilder)
            => it.AddFieldName("articles", partialBuilder(new Partial<ExternalArticleDto>(it)));
        
    }
    
}
