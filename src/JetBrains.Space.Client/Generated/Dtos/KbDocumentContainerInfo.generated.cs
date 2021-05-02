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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class KbDocumentContainerInfo
         : DocumentContainerInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "KbDocumentContainerInfo";
        
        public KbDocumentContainerInfo() { }
        
        public KbDocumentContainerInfo(KBBook book, KBArticle article)
        {
            Book = book;
            Article = article;
        }
        
        private PropertyValue<KBBook> _book = new PropertyValue<KBBook>(nameof(KbDocumentContainerInfo), nameof(Book));
        
        [Required]
        [JsonPropertyName("book")]
        public KBBook Book
        {
            get => _book.GetValue();
            set => _book.SetValue(value);
        }
    
        private PropertyValue<KBArticle> _article = new PropertyValue<KBArticle>(nameof(KbDocumentContainerInfo), nameof(Article));
        
        [Required]
        [JsonPropertyName("article")]
        public KBArticle Article
        {
            get => _article.GetValue();
            set => _article.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _book.SetAccessPath(path, validateHasBeenSet);
            _article.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}