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
    public sealed class TwoFactorAuthenticationSecretDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _secretKey = new PropertyValue<string>(nameof(TwoFactorAuthenticationSecretDto), nameof(SecretKey));
        
        [Required]
        [JsonPropertyName("secretKey")]
        public string SecretKey
        {
            get { return _secretKey.GetValue(); }
            set { _secretKey.SetValue(value); }
        }
    
        private PropertyValue<QRCodeDto> _qrCode = new PropertyValue<QRCodeDto>(nameof(TwoFactorAuthenticationSecretDto), nameof(QrCode));
        
        [Required]
        [JsonPropertyName("qrCode")]
        public QRCodeDto QrCode
        {
            get { return _qrCode.GetValue(); }
            set { _qrCode.SetValue(value); }
        }
    
        private PropertyValue<List<int>> _scratchCodes = new PropertyValue<List<int>>(nameof(TwoFactorAuthenticationSecretDto), nameof(ScratchCodes));
        
        [Required]
        [JsonPropertyName("scratchCodes")]
        public List<int> ScratchCodes
        {
            get { return _scratchCodes.GetValue(); }
            set { _scratchCodes.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _secretKey.SetAccessPath(path + "->WithSecretKey()", validateHasBeenSet);
            _qrCode.SetAccessPath(path + "->WithQrCode()", validateHasBeenSet);
            _scratchCodes.SetAccessPath(path + "->WithScratchCodes()", validateHasBeenSet);
        }
    
    }
    
}
