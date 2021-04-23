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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
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
    public sealed class IssueListCFValue
         : CFValue, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "IssueListCFValue";
        
        public IssueListCFValue() { }
        
        public IssueListCFValue(List<Issue> issues)
        {
            Issues = issues;
        }
        
        private PropertyValue<List<Issue>> _issues = new PropertyValue<List<Issue>>(nameof(IssueListCFValue), nameof(Issues), new List<Issue>());
        
        [Required]
        [JsonPropertyName("issues")]
        public List<Issue> Issues
        {
            get => _issues.GetValue();
            set => _issues.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _issues.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
