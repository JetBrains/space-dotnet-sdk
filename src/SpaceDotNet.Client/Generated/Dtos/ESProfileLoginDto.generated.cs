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
    public sealed class ESProfileLoginDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _identifier = new PropertyValue<string>(nameof(ESProfileLoginDto), nameof(Identifier));
        
        [Required]
        [JsonPropertyName("identifier")]
        public string Identifier
        {
            get { return _identifier.GetValue(); }
            set { _identifier.SetValue(value); }
        }
    
        private PropertyValue<ESAuthModuleDto> _authModule = new PropertyValue<ESAuthModuleDto>(nameof(ESProfileLoginDto), nameof(AuthModule));
        
        [Required]
        [JsonPropertyName("authModule")]
        public ESAuthModuleDto AuthModule
        {
            get { return _authModule.GetValue(); }
            set { _authModule.SetValue(value); }
        }
    
        private PropertyValue<ESProfileLoginDetailsDto> _details = new PropertyValue<ESProfileLoginDetailsDto>(nameof(ESProfileLoginDto), nameof(Details));
        
        [Required]
        [JsonPropertyName("details")]
        public ESProfileLoginDetailsDto Details
        {
            get { return _details.GetValue(); }
            set { _details.SetValue(value); }
        }
    
        private PropertyValue<AccessRecordDto?> _access = new PropertyValue<AccessRecordDto?>(nameof(ESProfileLoginDto), nameof(Access));
        
        [JsonPropertyName("access")]
        public AccessRecordDto? Access
        {
            get { return _access.GetValue(); }
            set { _access.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _identifier.SetAccessPath(path + "->WithIdentifier()", validateHasBeenSet);
            _authModule.SetAccessPath(path + "->WithAuthModule()", validateHasBeenSet);
            _details.SetAccessPath(path + "->WithDetails()", validateHasBeenSet);
            _access.SetAccessPath(path + "->WithAccess()", validateHasBeenSet);
        }
    
    }
    
}
