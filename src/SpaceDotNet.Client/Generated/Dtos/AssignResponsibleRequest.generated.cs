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
    public class AssignResponsibleRequest
    {
        private PropertyValue<string?> _role = new PropertyValue<string?>(nameof(AssignResponsibleRequest), nameof(Role));
        
        [JsonPropertyName("role")]
        public string? Role { get { return _role.GetValue(); } set { _role.SetValue(value); } }
    
    }
    
}
