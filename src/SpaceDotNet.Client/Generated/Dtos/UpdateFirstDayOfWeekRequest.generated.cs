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
    public class UpdateFirstDayOfWeekRequest
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<Weekday> _firstDayOfWeek = new PropertyValue<Weekday>(nameof(UpdateFirstDayOfWeekRequest), nameof(FirstDayOfWeek));
        
        [Required]
        [JsonPropertyName("firstDayOfWeek")]
        public Weekday FirstDayOfWeek
        {
            get { return _firstDayOfWeek.GetValue(); }
            set { _firstDayOfWeek.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _firstDayOfWeek.SetAccessPath(path + "->WithFirstDayOfWeek()", validateHasBeenSet);
        }
    
    }
    
}
