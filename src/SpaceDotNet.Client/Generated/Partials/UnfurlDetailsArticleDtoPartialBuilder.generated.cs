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

namespace SpaceDotNet.Client.UnfurlDetailsArticleDtoPartialBuilder
{
    public static class UnfurlDetailsArticleDtoPartialExtensions
    {
        public static Partial<UnfurlDetailsArticleDto> WithArticle(this Partial<UnfurlDetailsArticleDto> it)
            => it.AddFieldName("article");
        
        public static Partial<UnfurlDetailsArticleDto> WithArticle(this Partial<UnfurlDetailsArticleDto> it, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>> partialBuilder)
            => it.AddFieldName("article", partialBuilder(new Partial<ArticleRecordDto>(it)));
        
        public static Partial<UnfurlDetailsArticleDto> WithContent(this Partial<UnfurlDetailsArticleDto> it)
            => it.AddFieldName("content");
        
        public static Partial<UnfurlDetailsArticleDto> WithContent(this Partial<UnfurlDetailsArticleDto> it, Func<Partial<ArticleContentRecordDto>, Partial<ArticleContentRecordDto>> partialBuilder)
            => it.AddFieldName("content", partialBuilder(new Partial<ArticleContentRecordDto>(it)));
        
        public static Partial<UnfurlDetailsArticleDto> WithChannel(this Partial<UnfurlDetailsArticleDto> it)
            => it.AddFieldName("channel");
        
        public static Partial<UnfurlDetailsArticleDto> WithChannel(this Partial<UnfurlDetailsArticleDto> it, Func<Partial<ArticleChannelRecordDto>, Partial<ArticleChannelRecordDto>> partialBuilder)
            => it.AddFieldName("channel", partialBuilder(new Partial<ArticleChannelRecordDto>(it)));
        
        public static Partial<UnfurlDetailsArticleDto> WithDetails(this Partial<UnfurlDetailsArticleDto> it)
            => it.AddFieldName("details");
        
        public static Partial<UnfurlDetailsArticleDto> WithDetails(this Partial<UnfurlDetailsArticleDto> it, Func<Partial<ArticleDetailsRecordDto>, Partial<ArticleDetailsRecordDto>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<ArticleDetailsRecordDto>(it)));
        
    }
    
}
