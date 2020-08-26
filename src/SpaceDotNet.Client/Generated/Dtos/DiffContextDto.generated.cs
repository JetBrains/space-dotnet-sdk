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
    public sealed class DiffContextDto
         : IPropagatePropertyAccessPath
    {
        public DiffContextDto() { }
        
        public DiffContextDto(DiffSideDto right, DiffSideDto? left = null)
        {
            Left = left;
            Right = right;
        }
        
        private PropertyValue<DiffSideDto?> _left = new PropertyValue<DiffSideDto?>(nameof(DiffContextDto), nameof(Left));
        
        [JsonPropertyName("left")]
        public DiffSideDto? Left
        {
            get { return _left.GetValue(); }
            set { _left.SetValue(value); }
        }
    
        private PropertyValue<DiffSideDto> _right = new PropertyValue<DiffSideDto>(nameof(DiffContextDto), nameof(Right));
        
        [Required]
        [JsonPropertyName("right")]
        public DiffSideDto Right
        {
            get { return _right.GetValue(); }
            set { _right.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _left.SetAccessPath(path, validateHasBeenSet);
            _right.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
