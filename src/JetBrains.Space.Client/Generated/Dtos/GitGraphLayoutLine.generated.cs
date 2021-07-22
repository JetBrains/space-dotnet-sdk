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
    public sealed class GitGraphLayoutLine
         : IPropagatePropertyAccessPath
    {
        public GitGraphLayoutLine() { }
        
        public GitGraphLayoutLine(List<GitGraphLayoutNode> nodes, List<GitGraphLayoutEdge> edges)
        {
            Nodes = nodes;
            Edges = edges;
        }
        
        private PropertyValue<List<GitGraphLayoutNode>> _nodes = new PropertyValue<List<GitGraphLayoutNode>>(nameof(GitGraphLayoutLine), nameof(Nodes), new List<GitGraphLayoutNode>());
        
        [Required]
        [JsonPropertyName("nodes")]
        public List<GitGraphLayoutNode> Nodes
        {
            get => _nodes.GetValue();
            set => _nodes.SetValue(value);
        }
    
        private PropertyValue<List<GitGraphLayoutEdge>> _edges = new PropertyValue<List<GitGraphLayoutEdge>>(nameof(GitGraphLayoutLine), nameof(Edges), new List<GitGraphLayoutEdge>());
        
        [Required]
        [JsonPropertyName("edges")]
        public List<GitGraphLayoutEdge> Edges
        {
            get => _edges.GetValue();
            set => _edges.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _nodes.SetAccessPath(path, validateHasBeenSet);
            _edges.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
