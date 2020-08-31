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
    public sealed class BilledItems
         : IPropagatePropertyAccessPath
    {
        public BilledItems() { }
        
        public BilledItems(BilledItem users, BilledItem chatMessages, BilledItem apps)
        {
            Users = users;
            ChatMessages = chatMessages;
            Apps = apps;
        }
        
        private PropertyValue<BilledItem> _users = new PropertyValue<BilledItem>(nameof(BilledItems), nameof(Users));
        
        [Required]
        [JsonPropertyName("users")]
        public BilledItem Users
        {
            get { return _users.GetValue(); }
            set { _users.SetValue(value); }
        }
    
        private PropertyValue<BilledItem> _chatMessages = new PropertyValue<BilledItem>(nameof(BilledItems), nameof(ChatMessages));
        
        [Required]
        [JsonPropertyName("chatMessages")]
        public BilledItem ChatMessages
        {
            get { return _chatMessages.GetValue(); }
            set { _chatMessages.SetValue(value); }
        }
    
        private PropertyValue<BilledItem> _apps = new PropertyValue<BilledItem>(nameof(BilledItems), nameof(Apps));
        
        [Required]
        [JsonPropertyName("apps")]
        public BilledItem Apps
        {
            get { return _apps.GetValue(); }
            set { _apps.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _users.SetAccessPath(path, validateHasBeenSet);
            _chatMessages.SetAccessPath(path, validateHasBeenSet);
            _apps.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
