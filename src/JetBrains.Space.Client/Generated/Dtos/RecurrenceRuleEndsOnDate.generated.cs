// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class RecurrenceRuleEndsOnDate
         : RecurrenceRuleEnds, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "RecurrenceRuleEnds.OnDate";
        
        public RecurrenceRuleEndsOnDate() { }
        
        public RecurrenceRuleEndsOnDate(DateTime date)
        {
            Date = date;
        }
        
        private PropertyValue<DateTime> _date = new PropertyValue<DateTime>(nameof(RecurrenceRuleEndsOnDate), nameof(Date));
        
        [Required]
        [JsonPropertyName("date")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime Date
        {
            get => _date.GetValue();
            set => _date.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _date.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
