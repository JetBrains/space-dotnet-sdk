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

namespace JetBrains.Space.Client
{
    public sealed class ArticleMarkdownImage
         : IPropagatePropertyAccessPath
    {
        public ArticleMarkdownImage() { }
        
        public ArticleMarkdownImage(string alt, string src)
        {
            Alt = alt;
            Src = src;
        }
        
        private PropertyValue<string> _alt = new PropertyValue<string>(nameof(ArticleMarkdownImage), nameof(Alt));
        
        [Required]
        [JsonPropertyName("alt")]
        public string Alt
        {
            get => _alt.GetValue();
            set => _alt.SetValue(value);
        }
    
        private PropertyValue<string> _src = new PropertyValue<string>(nameof(ArticleMarkdownImage), nameof(Src));
        
        [Required]
        [JsonPropertyName("src")]
        public string Src
        {
            get => _src.GetValue();
            set => _src.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _alt.SetAccessPath(path, validateHasBeenSet);
            _src.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
