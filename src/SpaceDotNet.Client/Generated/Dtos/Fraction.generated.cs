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
    public sealed class Fraction
         : IPropagatePropertyAccessPath
    {
        public Fraction() { }
        
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        
        private PropertyValue<int> _numerator = new PropertyValue<int>(nameof(Fraction), nameof(Numerator));
        
        [Required]
        [JsonPropertyName("numerator")]
        public int Numerator
        {
            get { return _numerator.GetValue(); }
            set { _numerator.SetValue(value); }
        }
    
        private PropertyValue<int> _denominator = new PropertyValue<int>(nameof(Fraction), nameof(Denominator));
        
        [Required]
        [JsonPropertyName("denominator")]
        public int Denominator
        {
            get { return _denominator.GetValue(); }
            set { _denominator.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _numerator.SetAccessPath(path, validateHasBeenSet);
            _denominator.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
