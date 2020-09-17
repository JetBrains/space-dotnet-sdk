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
    public sealed class FTSBlog
         : IPropagatePropertyAccessPath
    {
        public FTSBlog() { }
        
        public FTSBlog(string id, string title, TDMemberProfile author, SpaceTime date, List<FTSSnippet> snippets, List<FTSBlogComment>? comments = null)
        {
            Id = id;
            Title = title;
            Author = author;
            Date = date;
            Snippets = snippets;
            Comments = comments;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(FTSBlog), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(FTSBlog), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile> _author = new PropertyValue<TDMemberProfile>(nameof(FTSBlog), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public TDMemberProfile Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _date = new PropertyValue<SpaceTime>(nameof(FTSBlog), nameof(Date));
        
        [Required]
        [JsonPropertyName("date")]
        public SpaceTime Date
        {
            get { return _date.GetValue(); }
            set { _date.SetValue(value); }
        }
    
        private PropertyValue<List<FTSSnippet>> _snippets = new PropertyValue<List<FTSSnippet>>(nameof(FTSBlog), nameof(Snippets));
        
        [Required]
        [JsonPropertyName("snippets")]
        public List<FTSSnippet> Snippets
        {
            get { return _snippets.GetValue(); }
            set { _snippets.SetValue(value); }
        }
    
        private PropertyValue<List<FTSBlogComment>?> _comments = new PropertyValue<List<FTSBlogComment>?>(nameof(FTSBlog), nameof(Comments));
        
        [JsonPropertyName("comments")]
        public List<FTSBlogComment>? Comments
        {
            get { return _comments.GetValue(); }
            set { _comments.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _date.SetAccessPath(path, validateHasBeenSet);
            _snippets.SetAccessPath(path, validateHasBeenSet);
            _comments.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}