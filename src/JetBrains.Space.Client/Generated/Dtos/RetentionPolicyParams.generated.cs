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
    public sealed class RetentionPolicyParams
         : IPropagatePropertyAccessPath
    {
        public RetentionPolicyParams() { }
        
        public RetentionPolicyParams(bool retainDownloadedOnce, int? numberOfDaysToRetain = null, int? numberOfVersionsToRetain = null)
        {
            NumberOfDaysToRetain = numberOfDaysToRetain;
            NumberOfVersionsToRetain = numberOfVersionsToRetain;
            IsRetainDownloadedOnce = retainDownloadedOnce;
        }
        
        private PropertyValue<int?> _numberOfDaysToRetain = new PropertyValue<int?>(nameof(RetentionPolicyParams), nameof(NumberOfDaysToRetain));
        
        [JsonPropertyName("numberOfDaysToRetain")]
        public int? NumberOfDaysToRetain
        {
            get => _numberOfDaysToRetain.GetValue();
            set => _numberOfDaysToRetain.SetValue(value);
        }
    
        private PropertyValue<int?> _numberOfVersionsToRetain = new PropertyValue<int?>(nameof(RetentionPolicyParams), nameof(NumberOfVersionsToRetain));
        
        [JsonPropertyName("numberOfVersionsToRetain")]
        public int? NumberOfVersionsToRetain
        {
            get => _numberOfVersionsToRetain.GetValue();
            set => _numberOfVersionsToRetain.SetValue(value);
        }
    
        private PropertyValue<bool> _retainDownloadedOnce = new PropertyValue<bool>(nameof(RetentionPolicyParams), nameof(IsRetainDownloadedOnce));
        
        [Required]
        [JsonPropertyName("retainDownloadedOnce")]
        public bool IsRetainDownloadedOnce
        {
            get => _retainDownloadedOnce.GetValue();
            set => _retainDownloadedOnce.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _numberOfDaysToRetain.SetAccessPath(path, validateHasBeenSet);
            _numberOfVersionsToRetain.SetAccessPath(path, validateHasBeenSet);
            _retainDownloadedOnce.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
