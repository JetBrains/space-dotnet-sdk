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
    public class CreateTeamRequest
    {
        private PropertyValue<string> _teamId = new PropertyValue<string>(nameof(CreateTeamRequest), nameof(TeamId));
        
        [Required]
        [JsonPropertyName("teamId")]
        public string TeamId { get { return _teamId.GetValue(); } set { _teamId.SetValue(value); } }
    
    }
    
}
