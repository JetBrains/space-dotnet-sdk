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
    public sealed class CodeSnippetAnchorDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<ProjectKeyDto> _projectKey = new PropertyValue<ProjectKeyDto>(nameof(CodeSnippetAnchorDto), nameof(ProjectKey));
        
        [Required]
        [JsonPropertyName("projectKey")]
        public ProjectKeyDto ProjectKey
        {
            get { return _projectKey.GetValue(); }
            set { _projectKey.SetValue(value); }
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(CodeSnippetAnchorDto), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<string> _revision = new PropertyValue<string>(nameof(CodeSnippetAnchorDto), nameof(Revision));
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision
        {
            get { return _revision.GetValue(); }
            set { _revision.SetValue(value); }
        }
    
        private PropertyValue<string> _filename = new PropertyValue<string>(nameof(CodeSnippetAnchorDto), nameof(Filename));
        
        [Required]
        [JsonPropertyName("filename")]
        public string Filename
        {
            get { return _filename.GetValue(); }
            set { _filename.SetValue(value); }
        }
    
        private PropertyValue<int?> _lineIndex = new PropertyValue<int?>(nameof(CodeSnippetAnchorDto), nameof(LineIndex));
        
        [JsonPropertyName("lineIndex")]
        public int? LineIndex
        {
            get { return _lineIndex.GetValue(); }
            set { _lineIndex.SetValue(value); }
        }
    
        private PropertyValue<int?> _lineStart = new PropertyValue<int?>(nameof(CodeSnippetAnchorDto), nameof(LineStart));
        
        [JsonPropertyName("lineStart")]
        public int? LineStart
        {
            get { return _lineStart.GetValue(); }
            set { _lineStart.SetValue(value); }
        }
    
        private PropertyValue<int?> _lineEnd = new PropertyValue<int?>(nameof(CodeSnippetAnchorDto), nameof(LineEnd));
        
        [JsonPropertyName("lineEnd")]
        public int? LineEnd
        {
            get { return _lineEnd.GetValue(); }
            set { _lineEnd.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _projectKey.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _revision.SetAccessPath(path, validateHasBeenSet);
            _filename.SetAccessPath(path, validateHasBeenSet);
            _lineIndex.SetAccessPath(path, validateHasBeenSet);
            _lineStart.SetAccessPath(path, validateHasBeenSet);
            _lineEnd.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
