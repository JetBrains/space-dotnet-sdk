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
    public sealed class NuGetDependencyGroup
         : IPropagatePropertyAccessPath
    {
        public NuGetDependencyGroup() { }
        
        public NuGetDependencyGroup(string? targetFramework = null, List<NuGetDependency>? dependencies = null)
        {
            TargetFramework = targetFramework;
            Dependencies = dependencies;
        }
        
        private PropertyValue<string?> _targetFramework = new PropertyValue<string?>(nameof(NuGetDependencyGroup), nameof(TargetFramework));
        
        [JsonPropertyName("targetFramework")]
        public string? TargetFramework
        {
            get { return _targetFramework.GetValue(); }
            set { _targetFramework.SetValue(value); }
        }
    
        private PropertyValue<List<NuGetDependency>?> _dependencies = new PropertyValue<List<NuGetDependency>?>(nameof(NuGetDependencyGroup), nameof(Dependencies));
        
        [JsonPropertyName("dependencies")]
        public List<NuGetDependency>? Dependencies
        {
            get { return _dependencies.GetValue(); }
            set { _dependencies.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _targetFramework.SetAccessPath(path, validateHasBeenSet);
            _dependencies.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
