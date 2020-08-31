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

namespace SpaceDotNet.Client.KbPublicationDetailsPartialBuilder
{
    public static class KbPublicationDetailsPartialExtensions
    {
        public static Partial<KbPublicationDetails> WithBook(this Partial<KbPublicationDetails> it)
            => it.AddFieldName("book");
        
        public static Partial<KbPublicationDetails> WithBook(this Partial<KbPublicationDetails> it, Func<Partial<KBBook>, Partial<KBBook>> partialBuilder)
            => it.AddFieldName("book", partialBuilder(new Partial<KBBook>(it)));
        
        public static Partial<KbPublicationDetails> WithFolder(this Partial<KbPublicationDetails> it)
            => it.AddFieldName("folder");
        
        public static Partial<KbPublicationDetails> WithFolder(this Partial<KbPublicationDetails> it, Func<Partial<KBFolder>, Partial<KBFolder>> partialBuilder)
            => it.AddFieldName("folder", partialBuilder(new Partial<KBFolder>(it)));
        
        public static Partial<KbPublicationDetails> WithArticleId(this Partial<KbPublicationDetails> it)
            => it.AddFieldName("articleId");
        
        public static Partial<KbPublicationDetails> WithArticleId(this Partial<KbPublicationDetails> it, Func<Partial<KBArticle>, Partial<KBArticle>> partialBuilder)
            => it.AddFieldName("articleId", partialBuilder(new Partial<KBArticle>(it)));
        
    }
    
}
