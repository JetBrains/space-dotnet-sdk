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
    public sealed class FractionDto
    {
        private PropertyValue<int> _numerator = new PropertyValue<int>(nameof(FractionDto), nameof(Numerator));
        
        [Required]
        [JsonPropertyName("numerator")]
        public int Numerator { get { return _numerator.GetValue(); } set { _numerator.SetValue(value); } }
    
        private PropertyValue<int> _denominator = new PropertyValue<int>(nameof(FractionDto), nameof(Denominator));
        
        [Required]
        [JsonPropertyName("denominator")]
        public int Denominator { get { return _denominator.GetValue(); } set { _denominator.SetValue(value); } }
    
    }
    
}
