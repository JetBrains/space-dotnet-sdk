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
    public sealed class M2BlogItemContentDto
         : M2ItemContentDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<ArticleRecordDto> _article = new PropertyValue<ArticleRecordDto>(nameof(M2BlogItemContentDto), nameof(Article));
        
        [Required]
        [JsonPropertyName("article")]
        public ArticleRecordDto Article
        {
            get { return _article.GetValue(); }
            set { _article.SetValue(value); }
        }
    
        private PropertyValue<ArticleContentRecordDto> _articleContent = new PropertyValue<ArticleContentRecordDto>(nameof(M2BlogItemContentDto), nameof(ArticleContent));
        
        [Required]
        [JsonPropertyName("articleContent")]
        public ArticleContentRecordDto ArticleContent
        {
            get { return _articleContent.GetValue(); }
            set { _articleContent.SetValue(value); }
        }
    
        private PropertyValue<ArticleDetailsRecordDto> _articleDetails = new PropertyValue<ArticleDetailsRecordDto>(nameof(M2BlogItemContentDto), nameof(ArticleDetails));
        
        [Required]
        [JsonPropertyName("articleDetails")]
        public ArticleDetailsRecordDto ArticleDetails
        {
            get { return _articleDetails.GetValue(); }
            set { _articleDetails.SetValue(value); }
        }
    
        private PropertyValue<ArticleChannelRecordDto> _articleChannel = new PropertyValue<ArticleChannelRecordDto>(nameof(M2BlogItemContentDto), nameof(ArticleChannel));
        
        [Required]
        [JsonPropertyName("articleChannel")]
        public ArticleChannelRecordDto ArticleChannel
        {
            get { return _articleChannel.GetValue(); }
            set { _articleChannel.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _article.SetAccessPath(path + "->WithArticle()", validateHasBeenSet);
            _articleContent.SetAccessPath(path + "->WithArticleContent()", validateHasBeenSet);
            _articleDetails.SetAccessPath(path + "->WithArticleDetails()", validateHasBeenSet);
            _articleChannel.SetAccessPath(path + "->WithArticleChannel()", validateHasBeenSet);
        }
    
    }
    
}
