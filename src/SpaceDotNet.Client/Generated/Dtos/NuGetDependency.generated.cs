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
    public sealed class NuGetDependency
         : IPropagatePropertyAccessPath
    {
        public NuGetDependency() { }
        
        public NuGetDependency(string id, string range)
        {
            Id = id;
            Range = range;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(NuGetDependency), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _range = new PropertyValue<string>(nameof(NuGetDependency), nameof(Range));
        
        [Required]
        [JsonPropertyName("range")]
        public string Range
        {
            get { return _range.GetValue(); }
            set { _range.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _range.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}