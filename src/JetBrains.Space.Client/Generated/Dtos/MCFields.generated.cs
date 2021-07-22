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
    public sealed class MCFields
         : MCElementDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MCFields";
        
        public MCFields() { }
        
        public MCFields(List<Pair<MCElement, MCElement>> fields)
        {
            Fields = fields;
        }
        
        private PropertyValue<List<Pair<MCElement, MCElement>>> _fields = new PropertyValue<List<Pair<MCElement, MCElement>>>(nameof(MCFields), nameof(Fields), new List<Pair<MCElement, MCElement>>());
        
        [Required]
        [JsonPropertyName("fields")]
        public List<Pair<MCElement, MCElement>> Fields
        {
            get => _fields.GetValue();
            set => _fields.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _fields.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
