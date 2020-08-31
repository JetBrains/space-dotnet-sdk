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

namespace SpaceDotNet.Client
{
    public sealed class BlogPublicationDetails
         : PublicationDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "BlogPublicationDetails";
        
        public BlogPublicationDetails() { }
        
        public BlogPublicationDetails(TDTeam? teamId = null, List<TDTeam>? teams = null, TDLocation? locationId = null, List<TDLocation>? locations = null, CalendarEvent? @event = null, ArticleRecord? article = null)
        {
            TeamId = teamId;
            Teams = teams;
            LocationId = locationId;
            Locations = locations;
            Event = @event;
            Article = article;
        }
        
        private PropertyValue<TDTeam?> _teamId = new PropertyValue<TDTeam?>(nameof(BlogPublicationDetails), nameof(TeamId));
        
        [JsonPropertyName("teamId")]
        public TDTeam? TeamId
        {
            get { return _teamId.GetValue(); }
            set { _teamId.SetValue(value); }
        }
    
        private PropertyValue<List<TDTeam>?> _teams = new PropertyValue<List<TDTeam>?>(nameof(BlogPublicationDetails), nameof(Teams));
        
        [JsonPropertyName("teams")]
        public List<TDTeam>? Teams
        {
            get { return _teams.GetValue(); }
            set { _teams.SetValue(value); }
        }
    
        private PropertyValue<TDLocation?> _locationId = new PropertyValue<TDLocation?>(nameof(BlogPublicationDetails), nameof(LocationId));
        
        [JsonPropertyName("locationId")]
        public TDLocation? LocationId
        {
            get { return _locationId.GetValue(); }
            set { _locationId.SetValue(value); }
        }
    
        private PropertyValue<List<TDLocation>?> _locations = new PropertyValue<List<TDLocation>?>(nameof(BlogPublicationDetails), nameof(Locations));
        
        [JsonPropertyName("locations")]
        public List<TDLocation>? Locations
        {
            get { return _locations.GetValue(); }
            set { _locations.SetValue(value); }
        }
    
        private PropertyValue<CalendarEvent?> _event = new PropertyValue<CalendarEvent?>(nameof(BlogPublicationDetails), nameof(Event));
        
        [JsonPropertyName("event")]
        public CalendarEvent? Event
        {
            get { return _event.GetValue(); }
            set { _event.SetValue(value); }
        }
    
        private PropertyValue<ArticleRecord?> _article = new PropertyValue<ArticleRecord?>(nameof(BlogPublicationDetails), nameof(Article));
        
        [JsonPropertyName("article")]
        public ArticleRecord? Article
        {
            get { return _article.GetValue(); }
            set { _article.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _teamId.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
            _locationId.SetAccessPath(path, validateHasBeenSet);
            _locations.SetAccessPath(path, validateHasBeenSet);
            _event.SetAccessPath(path, validateHasBeenSet);
            _article.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
