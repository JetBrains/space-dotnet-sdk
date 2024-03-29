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

public sealed class RemoteRepositoryAuthSSH
     : RemoteRepositoryAuth, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "RemoteRepositoryAuth.SSH";
    
    public RemoteRepositoryAuthSSH() { }
    
    public RemoteRepositoryAuthSSH(string privateKey, string passphrase)
    {
        PrivateKey = privateKey;
        Passphrase = passphrase;
    }
    
    private PropertyValue<string> _privateKey = new PropertyValue<string>(nameof(RemoteRepositoryAuthSSH), nameof(PrivateKey), "privateKey");
    
    [Required]
    [JsonPropertyName("privateKey")]
    public string PrivateKey
    {
        get => _privateKey.GetValue(InlineErrors);
        set => _privateKey.SetValue(value);
    }

    private PropertyValue<string> _passphrase = new PropertyValue<string>(nameof(RemoteRepositoryAuthSSH), nameof(Passphrase), "passphrase");
    
    [Required]
    [JsonPropertyName("passphrase")]
    public string Passphrase
    {
        get => _passphrase.GetValue(InlineErrors);
        set => _passphrase.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _privateKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _passphrase.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

