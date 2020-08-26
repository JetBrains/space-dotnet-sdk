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
    public sealed class DTORightsGroupDto
         : IPropagatePropertyAccessPath
    {
        public DTORightsGroupDto() { }
        
        public DTORightsGroupDto(string title, int priority, List<DTORightDto> rights)
        {
            Title = title;
            Priority = priority;
            Rights = rights;
        }
        
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(DTORightsGroupDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<int> _priority = new PropertyValue<int>(nameof(DTORightsGroupDto), nameof(Priority));
        
        [Required]
        [JsonPropertyName("priority")]
        public int Priority
        {
            get { return _priority.GetValue(); }
            set { _priority.SetValue(value); }
        }
    
        private PropertyValue<List<DTORightDto>> _rights = new PropertyValue<List<DTORightDto>>(nameof(DTORightsGroupDto), nameof(Rights));
        
        [Required]
        [JsonPropertyName("rights")]
        public List<DTORightDto> Rights
        {
            get { return _rights.GetValue(); }
            set { _rights.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _title.SetAccessPath(path, validateHasBeenSet);
            _priority.SetAccessPath(path, validateHasBeenSet);
            _rights.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
