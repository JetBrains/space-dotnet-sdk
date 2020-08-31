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
    public sealed class IssueDescriptionChangedDetails
         : IssueChangedM2Details, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "IssueDescriptionChangedDetails";
        
        public IssueDescriptionChangedDetails() { }
        
        public IssueDescriptionChangedDetails(string? oldDescription = null, string? newDescription = null)
        {
            OldDescription = oldDescription;
            NewDescription = newDescription;
        }
        
        private PropertyValue<string?> _oldDescription = new PropertyValue<string?>(nameof(IssueDescriptionChangedDetails), nameof(OldDescription));
        
        [JsonPropertyName("oldDescription")]
        public string? OldDescription
        {
            get { return _oldDescription.GetValue(); }
            set { _oldDescription.SetValue(value); }
        }
    
        private PropertyValue<string?> _newDescription = new PropertyValue<string?>(nameof(IssueDescriptionChangedDetails), nameof(NewDescription));
        
        [JsonPropertyName("newDescription")]
        public string? NewDescription
        {
            get { return _newDescription.GetValue(); }
            set { _newDescription.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _oldDescription.SetAccessPath(path, validateHasBeenSet);
            _newDescription.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
