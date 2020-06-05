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
    public class UpdateToDoItemRequest
    {
        private PropertyValue<string?> _text = new PropertyValue<string?>(nameof(UpdateToDoItemRequest), nameof(Text));
        
        [JsonPropertyName("text")]
        public string? Text { get { return _text.GetValue(); } set { _text.SetValue(value); } }
    
        private PropertyValue<SpaceDate?> _dueDate = new PropertyValue<SpaceDate?>(nameof(UpdateToDoItemRequest), nameof(DueDate));
        
        [JsonPropertyName("dueDate")]
        public SpaceDate? DueDate { get { return _dueDate.GetValue(); } set { _dueDate.SetValue(value); } }
    
        private PropertyValue<bool?> _open = new PropertyValue<bool?>(nameof(UpdateToDoItemRequest), nameof(Open));
        
        [JsonPropertyName("open")]
        public bool? Open { get { return _open.GetValue(); } set { _open.SetValue(value); } }
    
    }
    
}
