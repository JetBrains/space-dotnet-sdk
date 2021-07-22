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
    public sealed class ContainerImageLayer
         : IPropagatePropertyAccessPath
    {
        public ContainerImageLayer() { }
        
        public ContainerImageLayer(string id, string statement, string command, long? created = null, long? size = null)
        {
            Id = id;
            Created = created;
            Statement = statement;
            Command = command;
            Size = size;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ContainerImageLayer), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<long?> _created = new PropertyValue<long?>(nameof(ContainerImageLayer), nameof(Created));
        
        [JsonPropertyName("created")]
        public long? Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<string> _statement = new PropertyValue<string>(nameof(ContainerImageLayer), nameof(Statement));
        
        [Required]
        [JsonPropertyName("statement")]
        public string Statement
        {
            get => _statement.GetValue();
            set => _statement.SetValue(value);
        }
    
        private PropertyValue<string> _command = new PropertyValue<string>(nameof(ContainerImageLayer), nameof(Command));
        
        [Required]
        [JsonPropertyName("command")]
        public string Command
        {
            get => _command.GetValue();
            set => _command.SetValue(value);
        }
    
        private PropertyValue<long?> _size = new PropertyValue<long?>(nameof(ContainerImageLayer), nameof(Size));
        
        [JsonPropertyName("size")]
        public long? Size
        {
            get => _size.GetValue();
            set => _size.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _statement.SetAccessPath(path, validateHasBeenSet);
            _command.SetAccessPath(path, validateHasBeenSet);
            _size.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
