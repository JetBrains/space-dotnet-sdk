// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class PermissionSnapshotTargetDTODto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PermissionSnapshotTargetDTODto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _type = new PropertyValue<string>(nameof(PermissionSnapshotTargetDTODto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public string Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PermissionSnapshotTargetDTODto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
