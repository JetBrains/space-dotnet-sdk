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
    public class CreateCodeDiscussionRequest
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(CreateCodeDiscussionRequest), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<DiffContextDto?> _diffContext = new PropertyValue<DiffContextDto?>(nameof(CreateCodeDiscussionRequest), nameof(DiffContext));
        
        [JsonPropertyName("diffContext")]
        public DiffContextDto? DiffContext
        {
            get { return _diffContext.GetValue(); }
            set { _diffContext.SetValue(value); }
        }
    
        private PropertyValue<string?> _filename = new PropertyValue<string?>(nameof(CreateCodeDiscussionRequest), nameof(Filename));
        
        [JsonPropertyName("filename")]
        public string? Filename
        {
            get { return _filename.GetValue(); }
            set { _filename.SetValue(value); }
        }
    
        private PropertyValue<int?> _line = new PropertyValue<int?>(nameof(CreateCodeDiscussionRequest), nameof(Line));
        
        [JsonPropertyName("line")]
        public int? Line
        {
            get { return _line.GetValue(); }
            set { _line.SetValue(value); }
        }
    
        private PropertyValue<int?> _oldLine = new PropertyValue<int?>(nameof(CreateCodeDiscussionRequest), nameof(OldLine));
        
        [JsonPropertyName("oldLine")]
        public int? OldLine
        {
            get { return _oldLine.GetValue(); }
            set { _oldLine.SetValue(value); }
        }
    
        private PropertyValue<bool> _pending = new PropertyValue<bool>(nameof(CreateCodeDiscussionRequest), nameof(Pending));
        
        [Required]
        [JsonPropertyName("pending")]
        public bool Pending
        {
            get { return _pending.GetValue(); }
            set { _pending.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path + "->WithText()", validateHasBeenSet);
            _diffContext.SetAccessPath(path + "->WithDiffContext()", validateHasBeenSet);
            _filename.SetAccessPath(path + "->WithFilename()", validateHasBeenSet);
            _line.SetAccessPath(path + "->WithLine()", validateHasBeenSet);
            _oldLine.SetAccessPath(path + "->WithOldLine()", validateHasBeenSet);
            _pending.SetAccessPath(path + "->WithPending()", validateHasBeenSet);
        }
    
    }
    
}
