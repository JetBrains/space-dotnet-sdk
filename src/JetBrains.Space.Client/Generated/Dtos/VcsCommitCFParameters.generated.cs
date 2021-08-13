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
    public sealed class VcsCommitCFParameters
         : CFParameters, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "VcsCommitCFParameters";
        
        public VcsCommitCFParameters() { }
        
        public VcsCommitCFParameters(VcsCFScope vcsCFScope)
        {
            VcsCFScope = vcsCFScope;
        }
        
        private PropertyValue<VcsCFScope> _vcsCFScope = new PropertyValue<VcsCFScope>(nameof(VcsCommitCFParameters), nameof(VcsCFScope));
        
        [Required]
        [JsonPropertyName("vcsCFScope")]
        public VcsCFScope VcsCFScope
        {
            get => _vcsCFScope.GetValue();
            set => _vcsCFScope.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _vcsCFScope.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
