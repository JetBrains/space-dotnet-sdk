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

namespace JetBrains.Space.Client;

public sealed class BusinessEntityRelationEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "BusinessEntityRelationEvent";
    
    public BusinessEntityRelationEvent() { }
    
    public BusinessEntityRelationEvent(KMetaMod meta, string relation, string entity, TDMemberProfile member, Modification<DateTime?>? since = null, Modification<DateTime?>? till = null, Modification<bool?>? archived = null)
    {
        Meta = meta;
        Relation = relation;
        Entity = entity;
        Member = member;
        Since = since;
        Till = till;
        Archived = archived;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(BusinessEntityRelationEvent), nameof(Meta), "meta");
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue(InlineErrors);
        set => _meta.SetValue(value);
    }

    private PropertyValue<string> _relation = new PropertyValue<string>(nameof(BusinessEntityRelationEvent), nameof(Relation), "relation");
    
    [Required]
    [JsonPropertyName("relation")]
    public string Relation
    {
        get => _relation.GetValue(InlineErrors);
        set => _relation.SetValue(value);
    }

    private PropertyValue<string> _entity = new PropertyValue<string>(nameof(BusinessEntityRelationEvent), nameof(Entity), "entity");
    
    [Required]
    [JsonPropertyName("entity")]
    public string Entity
    {
        get => _entity.GetValue(InlineErrors);
        set => _entity.SetValue(value);
    }

    private PropertyValue<TDMemberProfile> _member = new PropertyValue<TDMemberProfile>(nameof(BusinessEntityRelationEvent), nameof(Member), "member");
    
    [Required]
    [JsonPropertyName("member")]
    public TDMemberProfile Member
    {
        get => _member.GetValue(InlineErrors);
        set => _member.SetValue(value);
    }

    private PropertyValue<Modification<DateTime?>?> _since = new PropertyValue<Modification<DateTime?>?>(nameof(BusinessEntityRelationEvent), nameof(Since), "since");
    
    [JsonPropertyName("since")]
    public Modification<DateTime?>? Since
    {
        get => _since.GetValue(InlineErrors);
        set => _since.SetValue(value);
    }

    private PropertyValue<Modification<DateTime?>?> _till = new PropertyValue<Modification<DateTime?>?>(nameof(BusinessEntityRelationEvent), nameof(Till), "till");
    
    [JsonPropertyName("till")]
    public Modification<DateTime?>? Till
    {
        get => _till.GetValue(InlineErrors);
        set => _till.SetValue(value);
    }

    private PropertyValue<Modification<bool?>?> _archived = new PropertyValue<Modification<bool?>?>(nameof(BusinessEntityRelationEvent), nameof(Archived), "archived");
    
    [JsonPropertyName("archived")]
    public Modification<bool?>? Archived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _relation.SetAccessPath(parentChainPath, validateHasBeenSet);
        _entity.SetAccessPath(parentChainPath, validateHasBeenSet);
        _member.SetAccessPath(parentChainPath, validateHasBeenSet);
        _since.SetAccessPath(parentChainPath, validateHasBeenSet);
        _till.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

