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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class UnfurlDetailsDateTimeRange
         : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsDateTimeRange";
        
        public UnfurlDetailsDateTimeRange() { }
        
        public UnfurlDetailsDateTimeRange(long since, long till, DateTimeViewParams? @params = null)
        {
            Since = since;
            Till = till;
            Params = @params;
        }
        
        private PropertyValue<long> _since = new PropertyValue<long>(nameof(UnfurlDetailsDateTimeRange), nameof(Since));
        
        [Required]
        [JsonPropertyName("since")]
        public long Since
        {
            get => _since.GetValue();
            set => _since.SetValue(value);
        }
    
        private PropertyValue<long> _till = new PropertyValue<long>(nameof(UnfurlDetailsDateTimeRange), nameof(Till));
        
        [Required]
        [JsonPropertyName("till")]
        public long Till
        {
            get => _till.GetValue();
            set => _till.SetValue(value);
        }
    
        private PropertyValue<DateTimeViewParams?> _params = new PropertyValue<DateTimeViewParams?>(nameof(UnfurlDetailsDateTimeRange), nameof(Params));
        
        [JsonPropertyName("params")]
        public DateTimeViewParams? Params
        {
            get => _params.GetValue();
            set => _params.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _params.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}