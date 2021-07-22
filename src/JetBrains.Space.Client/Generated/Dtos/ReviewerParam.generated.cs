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
    public sealed class ReviewerParam
         : IPropagatePropertyAccessPath
    {
        public ReviewerParam() { }
        
        public ReviewerParam(string profileId, CodeReviewParticipantSlotBase? qualityGateSlot = null)
        {
            ProfileId = profileId;
            QualityGateSlot = qualityGateSlot;
        }
        
        private PropertyValue<string> _profileId = new PropertyValue<string>(nameof(ReviewerParam), nameof(ProfileId));
        
        [Required]
        [JsonPropertyName("profileId")]
        public string ProfileId
        {
            get => _profileId.GetValue();
            set => _profileId.SetValue(value);
        }
    
        private PropertyValue<CodeReviewParticipantSlotBase?> _qualityGateSlot = new PropertyValue<CodeReviewParticipantSlotBase?>(nameof(ReviewerParam), nameof(QualityGateSlot));
        
        [JsonPropertyName("qualityGateSlot")]
        public CodeReviewParticipantSlotBase? QualityGateSlot
        {
            get => _qualityGateSlot.GetValue();
            set => _qualityGateSlot.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profileId.SetAccessPath(path, validateHasBeenSet);
            _qualityGateSlot.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
