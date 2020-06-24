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
    public sealed class DiffDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<List<string>> _added = new PropertyValue<List<string>>(nameof(DiffDto), nameof(Added));
        
        [Required]
        [JsonPropertyName("added")]
        public List<string> Added
        {
            get { return _added.GetValue(); }
            set { _added.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _removed = new PropertyValue<List<string>>(nameof(DiffDto), nameof(Removed));
        
        [Required]
        [JsonPropertyName("removed")]
        public List<string> Removed
        {
            get { return _removed.GetValue(); }
            set { _removed.SetValue(value); }
        }
    
        private PropertyValue<bool> _removeAll = new PropertyValue<bool>(nameof(DiffDto), nameof(RemoveAll));
        
        [Required]
        [JsonPropertyName("removeAll")]
        public bool RemoveAll
        {
            get { return _removeAll.GetValue(); }
            set { _removeAll.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _added.SetAccessPath(path, validateHasBeenSet);
            _removed.SetAccessPath(path, validateHasBeenSet);
            _removeAll.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
