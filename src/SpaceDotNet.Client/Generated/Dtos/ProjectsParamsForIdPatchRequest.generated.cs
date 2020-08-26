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
    public class ProjectsParamsForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsParamsForIdPatchRequest() { }
        
        public ProjectsParamsForIdPatchRequest(string value)
        {
            Value = value;
        }
        
        private PropertyValue<string> _value = new PropertyValue<string>(nameof(ProjectsParamsForIdPatchRequest), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public string Value
        {
            get { return _value.GetValue(); }
            set { _value.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _value.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
