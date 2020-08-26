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
    public sealed class MdMarkupDto
         : IPropagatePropertyAccessPath
    {
        public MdMarkupDto() { }
        
        public MdMarkupDto(List<UnfurlDto> unfurl)
        {
            Unfurl = unfurl;
        }
        
        private PropertyValue<List<UnfurlDto>> _unfurl = new PropertyValue<List<UnfurlDto>>(nameof(MdMarkupDto), nameof(Unfurl));
        
        [Required]
        [JsonPropertyName("unfurl")]
        public List<UnfurlDto> Unfurl
        {
            get { return _unfurl.GetValue(); }
            set { _unfurl.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _unfurl.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
