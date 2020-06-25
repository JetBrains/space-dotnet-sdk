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
    public class TeamDirectoryTeamsRestoreRequest
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<List<string>> _ids = new PropertyValue<List<string>>(nameof(TeamDirectoryTeamsRestoreRequest), nameof(Ids));
        
        [Required]
        [JsonPropertyName("ids")]
        public List<string> Ids
        {
            get { return _ids.GetValue(); }
            set { _ids.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _ids.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}