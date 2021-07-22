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
    public sealed class IssueTagsChangedDetails
         : IssueChangedM2Details, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "IssueTagsChangedDetails";
        
        public IssueTagsChangedDetails() { }
        
        public IssueTagsChangedDetails(List<PlanningTag>? addedTags = null, List<PlanningTag>? removedTags = null)
        {
            AddedTags = addedTags;
            RemovedTags = removedTags;
        }
        
        private PropertyValue<List<PlanningTag>?> _addedTags = new PropertyValue<List<PlanningTag>?>(nameof(IssueTagsChangedDetails), nameof(AddedTags));
        
        [JsonPropertyName("addedTags")]
        public List<PlanningTag>? AddedTags
        {
            get => _addedTags.GetValue();
            set => _addedTags.SetValue(value);
        }
    
        private PropertyValue<List<PlanningTag>?> _removedTags = new PropertyValue<List<PlanningTag>?>(nameof(IssueTagsChangedDetails), nameof(RemovedTags));
        
        [JsonPropertyName("removedTags")]
        public List<PlanningTag>? RemovedTags
        {
            get => _removedTags.GetValue();
            set => _removedTags.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _addedTags.SetAccessPath(path, validateHasBeenSet);
            _removedTags.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
