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
    public sealed class RecurrenceRuleEndsOnDateDto
         : RecurrenceRuleEndsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        private PropertyValue<SpaceDate> _date = new PropertyValue<SpaceDate>(nameof(RecurrenceRuleEndsOnDateDto), nameof(Date));
        
        [Required]
        [JsonPropertyName("date")]
        public SpaceDate Date
        {
            get { return _date.GetValue(); }
            set { _date.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _date.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
