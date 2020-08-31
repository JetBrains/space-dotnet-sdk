// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class ProjectHit
         : EntityHit, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ProjectHit";
        
        public ProjectHit() { }
        
        public ProjectHit(string id, double score, string key, string name, PRProject @ref, string? description = null)
        {
            Id = id;
            Score = score;
            Key = key;
            Name = name;
            Description = description;
            Ref = @ref;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ProjectHit), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<double> _score = new PropertyValue<double>(nameof(ProjectHit), nameof(Score));
        
        [Required]
        [JsonPropertyName("score")]
        public double Score
        {
            get { return _score.GetValue(); }
            set { _score.SetValue(value); }
        }
    
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(ProjectHit), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectHit), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectHit), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<PRProject> _ref = new PropertyValue<PRProject>(nameof(ProjectHit), nameof(Ref));
        
        [Required]
        [JsonPropertyName("ref")]
        public PRProject Ref
        {
            get { return _ref.GetValue(); }
            set { _ref.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _score.SetAccessPath(path, validateHasBeenSet);
            _key.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _ref.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
