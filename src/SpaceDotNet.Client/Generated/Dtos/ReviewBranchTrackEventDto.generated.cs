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
    public sealed class ReviewBranchTrackEventDto
         : FeedEventDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ReviewBranchTrackEventDto), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<string> _branch = new PropertyValue<string>(nameof(ReviewBranchTrackEventDto), nameof(Branch));
        
        [Required]
        [JsonPropertyName("branch")]
        public string Branch
        {
            get { return _branch.GetValue(); }
            set { _branch.SetValue(value); }
        }
    
        private PropertyValue<bool> _track = new PropertyValue<bool>(nameof(ReviewBranchTrackEventDto), nameof(Track));
        
        [Required]
        [JsonPropertyName("track")]
        public bool Track
        {
            get { return _track.GetValue(); }
            set { _track.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _repository.SetAccessPath(path + "->WithRepository()", validateHasBeenSet);
            _branch.SetAccessPath(path + "->WithBranch()", validateHasBeenSet);
            _track.SetAccessPath(path + "->WithTrack()", validateHasBeenSet);
        }
    
    }
    
}
