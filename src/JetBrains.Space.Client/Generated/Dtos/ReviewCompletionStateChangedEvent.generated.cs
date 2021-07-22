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
    public sealed class ReviewCompletionStateChangedEvent
         : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ReviewCompletionStateChangedEvent";
        
        public ReviewCompletionStateChangedEvent() { }
        
        public ReviewCompletionStateChangedEvent(ReviewerState state)
        {
            State = state;
        }
        
        private PropertyValue<ReviewerState> _state = new PropertyValue<ReviewerState>(nameof(ReviewCompletionStateChangedEvent), nameof(State));
        
        [Required]
        [JsonPropertyName("state")]
        public ReviewerState State
        {
            get => _state.GetValue();
            set => _state.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _state.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
