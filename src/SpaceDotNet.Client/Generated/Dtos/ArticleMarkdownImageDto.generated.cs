// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class ArticleMarkdownImageDto
    {
        private PropertyValue<string> _alt = new PropertyValue<string>(nameof(ArticleMarkdownImageDto), nameof(Alt));
        
        [Required]
        [JsonPropertyName("alt")]
        public string Alt { get { return _alt.GetValue(); } set { _alt.SetValue(value); } }
    
        private PropertyValue<string> _src = new PropertyValue<string>(nameof(ArticleMarkdownImageDto), nameof(Src));
        
        [Required]
        [JsonPropertyName("src")]
        public string Src { get { return _src.GetValue(); } set { _src.SetValue(value); } }
    
    }
    
}
