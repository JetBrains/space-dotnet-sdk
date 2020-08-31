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
    public sealed class KotlinPlatform
         : IPropagatePropertyAccessPath
    {
        public KotlinPlatform() { }
        
        public KotlinPlatform(string name, List<string> targets)
        {
            Name = name;
            Targets = targets;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(KotlinPlatform), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _targets = new PropertyValue<List<string>>(nameof(KotlinPlatform), nameof(Targets));
        
        [Required]
        [JsonPropertyName("targets")]
        public List<string> Targets
        {
            get { return _targets.GetValue(); }
            set { _targets.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _targets.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
