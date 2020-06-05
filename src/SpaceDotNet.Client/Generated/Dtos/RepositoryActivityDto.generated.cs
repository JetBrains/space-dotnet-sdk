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
    public sealed class RepositoryActivityDto
    {
        private PropertyValue<List<Pair<SpaceDate, int>>> _lastActivity = new PropertyValue<List<Pair<SpaceDate, int>>>(nameof(RepositoryActivityDto), nameof(LastActivity));
        
        [Required]
        [JsonPropertyName("lastActivity")]
        public List<Pair<SpaceDate, int>> LastActivity { get { return _lastActivity.GetValue(); } set { _lastActivity.SetValue(value); } }
    
    }
    
}
