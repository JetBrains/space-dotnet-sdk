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
    public sealed class DateCFValueDto
         : CFValueDto, IClassNameConvertible
    {
        private PropertyValue<SpaceDate?> _value = new PropertyValue<SpaceDate?>(nameof(DateCFValueDto), nameof(Value));
        
        [JsonPropertyName("value")]
        public SpaceDate? Value { get { return _value.GetValue(); } set { _value.SetValue(value); } }
    
    }
    
}
