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
    public sealed class FTSDraft
         : IPropagatePropertyAccessPath
    {
        public FTSDraft() { }
        
        public FTSDraft(string id, string title, TDMemberProfile author, SpaceTime date, List<FTSSnippet> snippets)
        {
            Id = id;
            Title = title;
            Author = author;
            Date = date;
            Snippets = snippets;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(FTSDraft), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(FTSDraft), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile> _author = new PropertyValue<TDMemberProfile>(nameof(FTSDraft), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public TDMemberProfile Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _date = new PropertyValue<SpaceTime>(nameof(FTSDraft), nameof(Date));
        
        [Required]
        [JsonPropertyName("date")]
        public SpaceTime Date
        {
            get { return _date.GetValue(); }
            set { _date.SetValue(value); }
        }
    
        private PropertyValue<List<FTSSnippet>> _snippets = new PropertyValue<List<FTSSnippet>>(nameof(FTSDraft), nameof(Snippets));
        
        [Required]
        [JsonPropertyName("snippets")]
        public List<FTSSnippet> Snippets
        {
            get { return _snippets.GetValue(); }
            set { _snippets.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _date.SetAccessPath(path, validateHasBeenSet);
            _snippets.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
