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
    public class UpdatePointRequest
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<int?> _x = new PropertyValue<int?>(nameof(UpdatePointRequest), nameof(X));
        
        [JsonPropertyName("x")]
        public int? X
        {
            get { return _x.GetValue(); }
            set { _x.SetValue(value); }
        }
    
        private PropertyValue<int?> _y = new PropertyValue<int?>(nameof(UpdatePointRequest), nameof(Y));
        
        [JsonPropertyName("y")]
        public int? Y
        {
            get { return _y.GetValue(); }
            set { _y.SetValue(value); }
        }
    
        private PropertyValue<string?> _mapId = new PropertyValue<string?>(nameof(UpdatePointRequest), nameof(MapId));
        
        [JsonPropertyName("mapId")]
        public string? MapId
        {
            get { return _mapId.GetValue(); }
            set { _mapId.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _x.SetAccessPath(path + "->WithX()", validateHasBeenSet);
            _y.SetAccessPath(path + "->WithY()", validateHasBeenSet);
            _mapId.SetAccessPath(path + "->WithMapId()", validateHasBeenSet);
        }
    
    }
    
}
