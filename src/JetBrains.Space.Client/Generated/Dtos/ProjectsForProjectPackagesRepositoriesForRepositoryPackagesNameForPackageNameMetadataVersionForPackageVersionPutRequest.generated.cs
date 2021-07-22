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
    public class ProjectsForProjectPackagesRepositoriesForRepositoryPackagesNameForPackageNameMetadataVersionForPackageVersionPutRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPackagesRepositoriesForRepositoryPackagesNameForPackageNameMetadataVersionForPackageVersionPutRequest() { }
        
        public ProjectsForProjectPackagesRepositoriesForRepositoryPackagesNameForPackageNameMetadataVersionForPackageVersionPutRequest(bool pin, string? comment = null)
        {
            IsPin = pin;
            Comment = comment;
        }
        
        private PropertyValue<bool> _pin = new PropertyValue<bool>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPackagesNameForPackageNameMetadataVersionForPackageVersionPutRequest), nameof(IsPin));
        
        [Required]
        [JsonPropertyName("pin")]
        public bool IsPin
        {
            get => _pin.GetValue();
            set => _pin.SetValue(value);
        }
    
        private PropertyValue<string?> _comment = new PropertyValue<string?>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPackagesNameForPackageNameMetadataVersionForPackageVersionPutRequest), nameof(Comment));
        
        [JsonPropertyName("comment")]
        public string? Comment
        {
            get => _comment.GetValue();
            set => _comment.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _pin.SetAccessPath(path, validateHasBeenSet);
            _comment.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
