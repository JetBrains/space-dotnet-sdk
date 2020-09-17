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
    public sealed class FolderHit
         : EntityHit, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "FolderHit";
        
        public FolderHit() { }
        
        public FolderHit(string id, double score, string bookId, string name)
        {
            Id = id;
            Score = score;
            BookId = bookId;
            Name = name;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(FolderHit), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<double> _score = new PropertyValue<double>(nameof(FolderHit), nameof(Score));
        
        [Required]
        [JsonPropertyName("score")]
        public double Score
        {
            get { return _score.GetValue(); }
            set { _score.SetValue(value); }
        }
    
        private PropertyValue<string> _bookId = new PropertyValue<string>(nameof(FolderHit), nameof(BookId));
        
        [Required]
        [JsonPropertyName("bookId")]
        public string BookId
        {
            get { return _bookId.GetValue(); }
            set { _bookId.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(FolderHit), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _score.SetAccessPath(path, validateHasBeenSet);
            _bookId.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}