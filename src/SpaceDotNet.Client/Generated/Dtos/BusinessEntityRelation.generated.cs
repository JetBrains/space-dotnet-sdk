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
    public sealed class BusinessEntityRelation
         : IPropagatePropertyAccessPath
    {
        public BusinessEntityRelation() { }
        
        public BusinessEntityRelation(string id, TDMemberProfile member, BusinessEntity entity, bool archived, SpaceDate? since = null, SpaceDate? till = null)
        {
            Id = id;
            Member = member;
            Entity = entity;
            Since = since;
            Till = till;
            IsArchived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(BusinessEntityRelation), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile> _member = new PropertyValue<TDMemberProfile>(nameof(BusinessEntityRelation), nameof(Member));
        
        [Required]
        [JsonPropertyName("member")]
        public TDMemberProfile Member
        {
            get { return _member.GetValue(); }
            set { _member.SetValue(value); }
        }
    
        private PropertyValue<BusinessEntity> _entity = new PropertyValue<BusinessEntity>(nameof(BusinessEntityRelation), nameof(Entity));
        
        [Required]
        [JsonPropertyName("entity")]
        public BusinessEntity Entity
        {
            get { return _entity.GetValue(); }
            set { _entity.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _since = new PropertyValue<SpaceDate?>(nameof(BusinessEntityRelation), nameof(Since));
        
        [JsonPropertyName("since")]
        public SpaceDate? Since
        {
            get { return _since.GetValue(); }
            set { _since.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _till = new PropertyValue<SpaceDate?>(nameof(BusinessEntityRelation), nameof(Till));
        
        [JsonPropertyName("till")]
        public SpaceDate? Till
        {
            get { return _till.GetValue(); }
            set { _till.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(BusinessEntityRelation), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _member.SetAccessPath(path, validateHasBeenSet);
            _entity.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
