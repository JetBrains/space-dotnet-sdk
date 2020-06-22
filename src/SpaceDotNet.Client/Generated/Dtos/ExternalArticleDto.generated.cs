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
    public sealed class ExternalArticleDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(ExternalArticleDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string> _content = new PropertyValue<string>(nameof(ExternalArticleDto), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public string Content
        {
            get { return _content.GetValue(); }
            set { _content.SetValue(value); }
        }
    
        private PropertyValue<string> _authorId = new PropertyValue<string>(nameof(ExternalArticleDto), nameof(AuthorId));
        
        [Required]
        [JsonPropertyName("authorId")]
        public string AuthorId
        {
            get { return _authorId.GetValue(); }
            set { _authorId.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _created = new PropertyValue<SpaceTime>(nameof(ExternalArticleDto), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _teams = new PropertyValue<List<string>?>(nameof(ExternalArticleDto), nameof(Teams));
        
        [JsonPropertyName("teams")]
        public List<string>? Teams
        {
            get { return _teams.GetValue(); }
            set { _teams.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _locations = new PropertyValue<List<string>?>(nameof(ExternalArticleDto), nameof(Locations));
        
        [JsonPropertyName("locations")]
        public List<string>? Locations
        {
            get { return _locations.GetValue(); }
            set { _locations.SetValue(value); }
        }
    
        private PropertyValue<string?> _externalId = new PropertyValue<string?>(nameof(ExternalArticleDto), nameof(ExternalId));
        
        [JsonPropertyName("externalId")]
        public string? ExternalId
        {
            get { return _externalId.GetValue(); }
            set { _externalId.SetValue(value); }
        }
    
        private PropertyValue<string?> _externalUrl = new PropertyValue<string?>(nameof(ExternalArticleDto), nameof(ExternalUrl));
        
        [JsonPropertyName("externalUrl")]
        public string? ExternalUrl
        {
            get { return _externalUrl.GetValue(); }
            set { _externalUrl.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _title.SetAccessPath(path + "->WithTitle()", validateHasBeenSet);
            _content.SetAccessPath(path + "->WithContent()", validateHasBeenSet);
            _authorId.SetAccessPath(path + "->WithAuthorId()", validateHasBeenSet);
            _created.SetAccessPath(path + "->WithCreated()", validateHasBeenSet);
            _teams.SetAccessPath(path + "->WithTeams()", validateHasBeenSet);
            _locations.SetAccessPath(path + "->WithLocations()", validateHasBeenSet);
            _externalId.SetAccessPath(path + "->WithExternalId()", validateHasBeenSet);
            _externalUrl.SetAccessPath(path + "->WithExternalUrl()", validateHasBeenSet);
        }
    
    }
    
}
