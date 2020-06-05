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
    public sealed class BlogPublicationDetailsDto
         : PublicationDetailsDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<TDTeamDto?> _teamId = new PropertyValue<TDTeamDto?>(nameof(BlogPublicationDetailsDto), nameof(TeamId));
        
        [JsonPropertyName("teamId")]
        public TDTeamDto? TeamId { get { return _teamId.GetValue(); } set { _teamId.SetValue(value); } }
    
        private PropertyValue<List<TDTeamDto>?> _teams = new PropertyValue<List<TDTeamDto>?>(nameof(BlogPublicationDetailsDto), nameof(Teams));
        
        [JsonPropertyName("teams")]
        public List<TDTeamDto>? Teams { get { return _teams.GetValue(); } set { _teams.SetValue(value); } }
    
        private PropertyValue<TDLocationDto?> _locationId = new PropertyValue<TDLocationDto?>(nameof(BlogPublicationDetailsDto), nameof(LocationId));
        
        [JsonPropertyName("locationId")]
        public TDLocationDto? LocationId { get { return _locationId.GetValue(); } set { _locationId.SetValue(value); } }
    
        private PropertyValue<List<TDLocationDto>?> _locations = new PropertyValue<List<TDLocationDto>?>(nameof(BlogPublicationDetailsDto), nameof(Locations));
        
        [JsonPropertyName("locations")]
        public List<TDLocationDto>? Locations { get { return _locations.GetValue(); } set { _locations.SetValue(value); } }
    
        private PropertyValue<CalendarEventDto?> _event = new PropertyValue<CalendarEventDto?>(nameof(BlogPublicationDetailsDto), nameof(Event));
        
        [JsonPropertyName("event")]
        public CalendarEventDto? Event { get { return _event.GetValue(); } set { _event.SetValue(value); } }
    
        private PropertyValue<ArticleRecordDto?> _article = new PropertyValue<ArticleRecordDto?>(nameof(BlogPublicationDetailsDto), nameof(Article));
        
        [JsonPropertyName("article")]
        public ArticleRecordDto? Article { get { return _article.GetValue(); } set { _article.SetValue(value); } }
    
    }
    
}
