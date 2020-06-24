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
    public sealed class ArticleRecordDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ArticleRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ArticleRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(ArticleRecordDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _created = new PropertyValue<SpaceTime>(nameof(ArticleRecordDto), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto> _author = new PropertyValue<TDMemberProfileDto>(nameof(ArticleRecordDto), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public TDMemberProfileDto Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        private PropertyValue<List<BGArticleAliasDto>> _aliases = new PropertyValue<List<BGArticleAliasDto>>(nameof(ArticleRecordDto), nameof(Aliases));
        
        [Required]
        [JsonPropertyName("aliases")]
        public List<BGArticleAliasDto> Aliases
        {
            get { return _aliases.GetValue(); }
            set { _aliases.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelRecordDto> _channel = new PropertyValue<M2ChannelRecordDto>(nameof(ArticleRecordDto), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecordDto Channel
        {
            get { return _channel.GetValue(); }
            set { _channel.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelContentRecordDto> _channelContent = new PropertyValue<M2ChannelContentRecordDto>(nameof(ArticleRecordDto), nameof(ChannelContent));
        
        [Required]
        [JsonPropertyName("channelContent")]
        public M2ChannelContentRecordDto ChannelContent
        {
            get { return _channelContent.GetValue(); }
            set { _channelContent.SetValue(value); }
        }
    
        private PropertyValue<AllReactionsToItemRecordDto> _reactions = new PropertyValue<AllReactionsToItemRecordDto>(nameof(ArticleRecordDto), nameof(Reactions));
        
        [Required]
        [JsonPropertyName("reactions")]
        public AllReactionsToItemRecordDto Reactions
        {
            get { return _reactions.GetValue(); }
            set { _reactions.SetValue(value); }
        }
    
        private PropertyValue<string> _content = new PropertyValue<string>(nameof(ArticleRecordDto), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public string Content
        {
            get { return _content.GetValue(); }
            set { _content.SetValue(value); }
        }
    
        private PropertyValue<MeetingRecordDto?> _event = new PropertyValue<MeetingRecordDto?>(nameof(ArticleRecordDto), nameof(Event));
        
        [JsonPropertyName("event")]
        public MeetingRecordDto? Event
        {
            get { return _event.GetValue(); }
            set { _event.SetValue(value); }
        }
    
        private PropertyValue<ExternalEntityInfoRecordDto?> _externalEntityInfo = new PropertyValue<ExternalEntityInfoRecordDto?>(nameof(ArticleRecordDto), nameof(ExternalEntityInfo));
        
        [JsonPropertyName("externalEntityInfo")]
        public ExternalEntityInfoRecordDto? ExternalEntityInfo
        {
            get { return _externalEntityInfo.GetValue(); }
            set { _externalEntityInfo.SetValue(value); }
        }
    
        private PropertyValue<TDLocationDto?> _location = new PropertyValue<TDLocationDto?>(nameof(ArticleRecordDto), nameof(Location));
        
        [JsonPropertyName("location")]
        public TDLocationDto? Location
        {
            get { return _location.GetValue(); }
            set { _location.SetValue(value); }
        }
    
        private PropertyValue<List<TDLocationDto>?> _locations = new PropertyValue<List<TDLocationDto>?>(nameof(ArticleRecordDto), nameof(Locations));
        
        [JsonPropertyName("locations")]
        public List<TDLocationDto>? Locations
        {
            get { return _locations.GetValue(); }
            set { _locations.SetValue(value); }
        }
    
        private PropertyValue<PRProjectDto?> _project = new PropertyValue<PRProjectDto?>(nameof(ArticleRecordDto), nameof(Project));
        
        [JsonPropertyName("project")]
        public PRProjectDto? Project
        {
            get { return _project.GetValue(); }
            set { _project.SetValue(value); }
        }
    
        private PropertyValue<TDTeamDto?> _team = new PropertyValue<TDTeamDto?>(nameof(ArticleRecordDto), nameof(Team));
        
        [JsonPropertyName("team")]
        public TDTeamDto? Team
        {
            get { return _team.GetValue(); }
            set { _team.SetValue(value); }
        }
    
        private PropertyValue<List<TDTeamDto>?> _teams = new PropertyValue<List<TDTeamDto>?>(nameof(ArticleRecordDto), nameof(Teams));
        
        [JsonPropertyName("teams")]
        public List<TDTeamDto>? Teams
        {
            get { return _teams.GetValue(); }
            set { _teams.SetValue(value); }
        }
    
        private PropertyValue<bool> _editable = new PropertyValue<bool>(nameof(ArticleRecordDto), nameof(Editable));
        
        [Required]
        [JsonPropertyName("editable")]
        public bool Editable
        {
            get { return _editable.GetValue(); }
            set { _editable.SetValue(value); }
        }
    
        private PropertyValue<string> _preview = new PropertyValue<string>(nameof(ArticleRecordDto), nameof(Preview));
        
        [Required]
        [JsonPropertyName("preview")]
        public string Preview
        {
            get { return _preview.GetValue(); }
            set { _preview.SetValue(value); }
        }
    
        private PropertyValue<List<ArticleMarkdownImageDto>> _previewImages = new PropertyValue<List<ArticleMarkdownImageDto>>(nameof(ArticleRecordDto), nameof(PreviewImages));
        
        [Required]
        [JsonPropertyName("previewImages")]
        public List<ArticleMarkdownImageDto> PreviewImages
        {
            get { return _previewImages.GetValue(); }
            set { _previewImages.SetValue(value); }
        }
    
        private PropertyValue<int?> _wordsNumber = new PropertyValue<int?>(nameof(ArticleRecordDto), nameof(WordsNumber));
        
        [JsonPropertyName("wordsNumber")]
        public int? WordsNumber
        {
            get { return _wordsNumber.GetValue(); }
            set { _wordsNumber.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _aliases.SetAccessPath(path, validateHasBeenSet);
            _channel.SetAccessPath(path, validateHasBeenSet);
            _channelContent.SetAccessPath(path, validateHasBeenSet);
            _reactions.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            _event.SetAccessPath(path, validateHasBeenSet);
            _externalEntityInfo.SetAccessPath(path, validateHasBeenSet);
            _location.SetAccessPath(path, validateHasBeenSet);
            _locations.SetAccessPath(path, validateHasBeenSet);
            _project.SetAccessPath(path, validateHasBeenSet);
            _team.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
            _editable.SetAccessPath(path, validateHasBeenSet);
            _preview.SetAccessPath(path, validateHasBeenSet);
            _previewImages.SetAccessPath(path, validateHasBeenSet);
            _wordsNumber.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
