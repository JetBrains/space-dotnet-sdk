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
    public sealed class IssueStatusWithUsages
         : IPropagatePropertyAccessPath
    {
        public IssueStatusWithUsages() { }
        
        public IssueStatusWithUsages(IssueStatus status, int usages)
        {
            Status = status;
            Usages = usages;
        }
        
        private PropertyValue<IssueStatus> _status = new PropertyValue<IssueStatus>(nameof(IssueStatusWithUsages), nameof(Status));
        
        [Required]
        [JsonPropertyName("status")]
        public IssueStatus Status
        {
            get => _status.GetValue();
            set => _status.SetValue(value);
        }
    
        private PropertyValue<int> _usages = new PropertyValue<int>(nameof(IssueStatusWithUsages), nameof(Usages));
        
        [Required]
        [JsonPropertyName("usages")]
        public int Usages
        {
            get => _usages.GetValue();
            set => _usages.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _status.SetAccessPath(path, validateHasBeenSet);
            _usages.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
