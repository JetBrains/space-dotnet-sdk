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
    public sealed class ReactionTypeRecordDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ReactionTypeRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ReactionTypeRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<ReactionDataDto> _data = new PropertyValue<ReactionDataDto>(nameof(ReactionTypeRecordDto), nameof(Data));
        
        [Required]
        [JsonPropertyName("data")]
        public ReactionDataDto Data
        {
            get { return _data.GetValue(); }
            set { _data.SetValue(value); }
        }
    
        private PropertyValue<CPrincipalDto> _provider = new PropertyValue<CPrincipalDto>(nameof(ReactionTypeRecordDto), nameof(Provider));
        
        [Required]
        [JsonPropertyName("provider")]
        public CPrincipalDto Provider
        {
            get { return _provider.GetValue(); }
            set { _provider.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate> _addedAt = new PropertyValue<SpaceDate>(nameof(ReactionTypeRecordDto), nameof(AddedAt));
        
        [Required]
        [JsonPropertyName("addedAt")]
        public SpaceDate AddedAt
        {
            get { return _addedAt.GetValue(); }
            set { _addedAt.SetValue(value); }
        }
    
        private PropertyValue<int?> _order = new PropertyValue<int?>(nameof(ReactionTypeRecordDto), nameof(Order));
        
        [JsonPropertyName("order")]
        public int? Order
        {
            get { return _order.GetValue(); }
            set { _order.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path + "->WithId()", validateHasBeenSet);
            _archived.SetAccessPath(path + "->WithArchived()", validateHasBeenSet);
            _data.SetAccessPath(path + "->WithData()", validateHasBeenSet);
            _provider.SetAccessPath(path + "->WithProvider()", validateHasBeenSet);
            _addedAt.SetAccessPath(path + "->WithAddedAt()", validateHasBeenSet);
            _order.SetAccessPath(path + "->WithOrder()", validateHasBeenSet);
        }
    
    }
    
}
