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
    public sealed class PermissionComparisonContent
         : IPropagatePropertyAccessPath
    {
        public PermissionComparisonContent() { }
        
        public PermissionComparisonContent(List<PermissionComparisonEntry> entries, List<PermissionSnapshotPrincipal> principals, List<PermissionSnapshotRight> rights, List<PermissionSnapshotTarget> targets)
        {
            Entries = entries;
            Principals = principals;
            Rights = rights;
            Targets = targets;
        }
        
        private PropertyValue<List<PermissionComparisonEntry>> _entries = new PropertyValue<List<PermissionComparisonEntry>>(nameof(PermissionComparisonContent), nameof(Entries));
        
        [Required]
        [JsonPropertyName("entries")]
        public List<PermissionComparisonEntry> Entries
        {
            get { return _entries.GetValue(); }
            set { _entries.SetValue(value); }
        }
    
        private PropertyValue<List<PermissionSnapshotPrincipal>> _principals = new PropertyValue<List<PermissionSnapshotPrincipal>>(nameof(PermissionComparisonContent), nameof(Principals));
        
        [Required]
        [JsonPropertyName("principals")]
        public List<PermissionSnapshotPrincipal> Principals
        {
            get { return _principals.GetValue(); }
            set { _principals.SetValue(value); }
        }
    
        private PropertyValue<List<PermissionSnapshotRight>> _rights = new PropertyValue<List<PermissionSnapshotRight>>(nameof(PermissionComparisonContent), nameof(Rights));
        
        [Required]
        [JsonPropertyName("rights")]
        public List<PermissionSnapshotRight> Rights
        {
            get { return _rights.GetValue(); }
            set { _rights.SetValue(value); }
        }
    
        private PropertyValue<List<PermissionSnapshotTarget>> _targets = new PropertyValue<List<PermissionSnapshotTarget>>(nameof(PermissionComparisonContent), nameof(Targets));
        
        [Required]
        [JsonPropertyName("targets")]
        public List<PermissionSnapshotTarget> Targets
        {
            get { return _targets.GetValue(); }
            set { _targets.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _entries.SetAccessPath(path, validateHasBeenSet);
            _principals.SetAccessPath(path, validateHasBeenSet);
            _rights.SetAccessPath(path, validateHasBeenSet);
            _targets.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
