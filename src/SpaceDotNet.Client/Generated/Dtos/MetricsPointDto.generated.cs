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
    public sealed class MetricsPointDto
    {
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(MetricsPointDto), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key { get { return _key.GetValue(); } set { _key.SetValue(value); } }
    
        private PropertyValue<long> _value = new PropertyValue<long>(nameof(MetricsPointDto), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public long Value { get { return _value.GetValue(); } set { _value.SetValue(value); } }
    
    }
    
}
