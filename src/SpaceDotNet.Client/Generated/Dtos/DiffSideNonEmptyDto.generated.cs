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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class DiffSideNonEmptyDto
         : DiffSideDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "DiffSide.NonEmpty";
        
        public DiffSideNonEmptyDto() { }
        
        public DiffSideNonEmptyDto(string revision, string path)
        {
            Revision = revision;
            Path = path;
        }
        
        private PropertyValue<string> _revision = new PropertyValue<string>(nameof(DiffSideNonEmptyDto), nameof(Revision));
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision
        {
            get { return _revision.GetValue(); }
            set { _revision.SetValue(value); }
        }
    
        private PropertyValue<string> _path = new PropertyValue<string>(nameof(DiffSideNonEmptyDto), nameof(Path));
        
        [Required]
        [JsonPropertyName("path")]
        public string Path
        {
            get { return _path.GetValue(); }
            set { _path.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _revision.SetAccessPath(path, validateHasBeenSet);
            _path.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
