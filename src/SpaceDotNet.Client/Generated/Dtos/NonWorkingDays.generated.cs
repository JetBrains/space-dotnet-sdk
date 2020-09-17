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
    public sealed class NonWorkingDays
         : IPropagatePropertyAccessPath
    {
        public NonWorkingDays() { }
        
        public NonWorkingDays(SpaceDate since, SpaceDate till, bool startsEarlier, bool endsLater)
        {
            Since = since;
            Till = till;
            IsStartsEarlier = startsEarlier;
            IsEndsLater = endsLater;
        }
        
        private PropertyValue<SpaceDate> _since = new PropertyValue<SpaceDate>(nameof(NonWorkingDays), nameof(Since));
        
        [Required]
        [JsonPropertyName("since")]
        public SpaceDate Since
        {
            get { return _since.GetValue(); }
            set { _since.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate> _till = new PropertyValue<SpaceDate>(nameof(NonWorkingDays), nameof(Till));
        
        [Required]
        [JsonPropertyName("till")]
        public SpaceDate Till
        {
            get { return _till.GetValue(); }
            set { _till.SetValue(value); }
        }
    
        private PropertyValue<bool> _startsEarlier = new PropertyValue<bool>(nameof(NonWorkingDays), nameof(IsStartsEarlier));
        
        [Required]
        [JsonPropertyName("startsEarlier")]
        public bool IsStartsEarlier
        {
            get { return _startsEarlier.GetValue(); }
            set { _startsEarlier.SetValue(value); }
        }
    
        private PropertyValue<bool> _endsLater = new PropertyValue<bool>(nameof(NonWorkingDays), nameof(IsEndsLater));
        
        [Required]
        [JsonPropertyName("endsLater")]
        public bool IsEndsLater
        {
            get { return _endsLater.GetValue(); }
            set { _endsLater.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _startsEarlier.SetAccessPath(path, validateHasBeenSet);
            _endsLater.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}