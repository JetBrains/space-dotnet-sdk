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
    public sealed class GitDiffSizeDto
    {
        private PropertyValue<int> _added = new PropertyValue<int>(nameof(GitDiffSizeDto), nameof(Added));
        
        [Required]
        [JsonPropertyName("added")]
        public int Added { get { return _added.GetValue(); } set { _added.SetValue(value); } }
    
        private PropertyValue<int> _deleted = new PropertyValue<int>(nameof(GitDiffSizeDto), nameof(Deleted));
        
        [Required]
        [JsonPropertyName("deleted")]
        public int Deleted { get { return _deleted.GetValue(); } set { _deleted.SetValue(value); } }
    
    }
    
}
