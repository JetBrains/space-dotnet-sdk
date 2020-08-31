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
    public sealed class CodeReviewDiscussionCounter
         : IPropagatePropertyAccessPath
    {
        public CodeReviewDiscussionCounter() { }
        
        public CodeReviewDiscussionCounter(string id, string projectId, Counter counter)
        {
            Id = id;
            ProjectId = projectId;
            Counter = counter;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeReviewDiscussionCounter), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _projectId = new PropertyValue<string>(nameof(CodeReviewDiscussionCounter), nameof(ProjectId));
        
        [Required]
        [JsonPropertyName("projectId")]
        public string ProjectId
        {
            get { return _projectId.GetValue(); }
            set { _projectId.SetValue(value); }
        }
    
        private PropertyValue<Counter> _counter = new PropertyValue<Counter>(nameof(CodeReviewDiscussionCounter), nameof(Counter));
        
        [Required]
        [JsonPropertyName("counter")]
        public Counter Counter
        {
            get { return _counter.GetValue(); }
            set { _counter.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _projectId.SetAccessPath(path, validateHasBeenSet);
            _counter.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
