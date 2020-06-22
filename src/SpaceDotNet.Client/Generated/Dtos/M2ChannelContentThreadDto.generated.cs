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
    public sealed class M2ChannelContentThreadDto
         : M2ChannelContentInfoDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<ChannelItemRecordDto> _record = new PropertyValue<ChannelItemRecordDto>(nameof(M2ChannelContentThreadDto), nameof(Record));
        
        [Required]
        [JsonPropertyName("record")]
        public ChannelItemRecordDto Record
        {
            get { return _record.GetValue(); }
            set { _record.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelRecordDto> _parent = new PropertyValue<M2ChannelRecordDto>(nameof(M2ChannelContentThreadDto), nameof(Parent));
        
        [Required]
        [JsonPropertyName("parent")]
        public M2ChannelRecordDto Parent
        {
            get { return _parent.GetValue(); }
            set { _parent.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _record.SetAccessPath(path + "->WithRecord()", validateHasBeenSet);
            _parent.SetAccessPath(path + "->WithParent()", validateHasBeenSet);
        }
    
    }
    
}
