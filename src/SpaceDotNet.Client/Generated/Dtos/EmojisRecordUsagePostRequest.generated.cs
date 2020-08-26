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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class EmojisRecordUsagePostRequest
         : IPropagatePropertyAccessPath
    {
        public EmojisRecordUsagePostRequest() { }
        
        public EmojisRecordUsagePostRequest(List<string> emojis)
        {
            Emojis = emojis;
        }
        
        private PropertyValue<List<string>> _emojis = new PropertyValue<List<string>>(nameof(EmojisRecordUsagePostRequest), nameof(Emojis));
        
        [Required]
        [JsonPropertyName("emojis")]
        public List<string> Emojis
        {
            get { return _emojis.GetValue(); }
            set { _emojis.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _emojis.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
