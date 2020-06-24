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
    public sealed class CPrincipalDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(CPrincipalDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<CPrincipalDetailsDto?> _details = new PropertyValue<CPrincipalDetailsDto?>(nameof(CPrincipalDto), nameof(Details));
        
        [JsonPropertyName("details")]
        public CPrincipalDetailsDto? Details
        {
            get { return _details.GetValue(); }
            set { _details.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _details.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
