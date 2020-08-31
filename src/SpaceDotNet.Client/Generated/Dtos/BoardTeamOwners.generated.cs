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
    public sealed class BoardTeamOwners
         : IPropagatePropertyAccessPath
    {
        public BoardTeamOwners() { }
        
        public BoardTeamOwners(List<TDTeam> teams)
        {
            Teams = teams;
        }
        
        private PropertyValue<List<TDTeam>> _teams = new PropertyValue<List<TDTeam>>(nameof(BoardTeamOwners), nameof(Teams));
        
        [Required]
        [JsonPropertyName("teams")]
        public List<TDTeam> Teams
        {
            get { return _teams.GetValue(); }
            set { _teams.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _teams.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
