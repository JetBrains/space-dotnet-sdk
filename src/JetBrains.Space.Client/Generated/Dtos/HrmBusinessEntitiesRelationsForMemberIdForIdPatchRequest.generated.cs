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
    public class HrmBusinessEntitiesRelationsForMemberIdForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public HrmBusinessEntitiesRelationsForMemberIdForIdPatchRequest() { }
        
        public HrmBusinessEntitiesRelationsForMemberIdForIdPatchRequest(DateTime? since = null, DateTime? till = null)
        {
            Since = since;
            Till = till;
        }
        
        private PropertyValue<DateTime?> _since = new PropertyValue<DateTime?>(nameof(HrmBusinessEntitiesRelationsForMemberIdForIdPatchRequest), nameof(Since));
        
        [JsonPropertyName("since")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? Since
        {
            get => _since.GetValue();
            set => _since.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _till = new PropertyValue<DateTime?>(nameof(HrmBusinessEntitiesRelationsForMemberIdForIdPatchRequest), nameof(Till));
        
        [JsonPropertyName("till")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? Till
        {
            get => _till.GetValue();
            set => _till.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}