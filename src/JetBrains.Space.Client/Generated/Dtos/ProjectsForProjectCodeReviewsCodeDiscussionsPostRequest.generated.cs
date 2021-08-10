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
    public class ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest() { }
        
        public ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest(string text, string repository, string revision, bool pending = false, DiffContext? diffContext = null, string? filename = null, int? line = null, int? oldLine = null)
        {
            Text = text;
            DiffContext = diffContext;
            Repository = repository;
            Revision = revision;
            Filename = filename;
            Line = line;
            OldLine = oldLine;
            IsPending = pending;
        }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<DiffContext?> _diffContext = new PropertyValue<DiffContext?>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(DiffContext));
        
        [JsonPropertyName("diffContext")]
        public DiffContext? DiffContext
        {
            get => _diffContext.GetValue();
            set => _diffContext.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _revision = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(Revision));
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision
        {
            get => _revision.GetValue();
            set => _revision.SetValue(value);
        }
    
        private PropertyValue<string?> _filename = new PropertyValue<string?>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(Filename));
        
        [JsonPropertyName("filename")]
        public string? Filename
        {
            get => _filename.GetValue();
            set => _filename.SetValue(value);
        }
    
        private PropertyValue<int?> _line = new PropertyValue<int?>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(Line));
        
        [JsonPropertyName("line")]
        public int? Line
        {
            get => _line.GetValue();
            set => _line.SetValue(value);
        }
    
        private PropertyValue<int?> _oldLine = new PropertyValue<int?>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(OldLine));
        
        [JsonPropertyName("oldLine")]
        public int? OldLine
        {
            get => _oldLine.GetValue();
            set => _oldLine.SetValue(value);
        }
    
        private PropertyValue<bool> _pending = new PropertyValue<bool>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(IsPending));
        
        [JsonPropertyName("pending")]
        public bool IsPending
        {
            get => _pending.GetValue();
            set => _pending.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _diffContext.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _revision.SetAccessPath(path, validateHasBeenSet);
            _filename.SetAccessPath(path, validateHasBeenSet);
            _line.SetAccessPath(path, validateHasBeenSet);
            _oldLine.SetAccessPath(path, validateHasBeenSet);
            _pending.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}