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
    public sealed class GitGraphLayoutLineDto
    {
        private PropertyValue<List<GitGraphLayoutNodeDto>> _nodes = new PropertyValue<List<GitGraphLayoutNodeDto>>(nameof(GitGraphLayoutLineDto), nameof(Nodes));
        
        [Required]
        [JsonPropertyName("nodes")]
        public List<GitGraphLayoutNodeDto> Nodes { get { return _nodes.GetValue(); } set { _nodes.SetValue(value); } }
    
        private PropertyValue<List<GitGraphLayoutEdgeDto>> _edges = new PropertyValue<List<GitGraphLayoutEdgeDto>>(nameof(GitGraphLayoutLineDto), nameof(Edges));
        
        [Required]
        [JsonPropertyName("edges")]
        public List<GitGraphLayoutEdgeDto> Edges { get { return _edges.GetValue(); } set { _edges.SetValue(value); } }
    
    }
    
}
