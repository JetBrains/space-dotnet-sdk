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

public sealed class MenuActionPayload
     : ApplicationPayload, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MenuActionPayload";
    
    public MenuActionPayload() { }
    
    public MenuActionPayload(string menuItemUniqueCode, string clientId, string userId, MenuActionContext? context = null, string? verificationToken = null)
    {
        MenuItemUniqueCode = menuItemUniqueCode;
        Context = context;
        ClientId = clientId;
        UserId = userId;
        VerificationToken = verificationToken;
    }
    
    private PropertyValue<string> _menuItemUniqueCode = new PropertyValue<string>(nameof(MenuActionPayload), nameof(MenuItemUniqueCode), "menuItemUniqueCode");
    
    [Required]
    [JsonPropertyName("menuItemUniqueCode")]
    public string MenuItemUniqueCode
    {
        get => _menuItemUniqueCode.GetValue(InlineErrors);
        set => _menuItemUniqueCode.SetValue(value);
    }

    private PropertyValue<MenuActionContext?> _context = new PropertyValue<MenuActionContext?>(nameof(MenuActionPayload), nameof(Context), "context");
    
    [JsonPropertyName("context")]
    public MenuActionContext? Context
    {
        get => _context.GetValue(InlineErrors);
        set => _context.SetValue(value);
    }

    private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(MenuActionPayload), nameof(ClientId), "clientId");
    
    [Required]
    [JsonPropertyName("clientId")]
    public string ClientId
    {
        get => _clientId.GetValue(InlineErrors);
        set => _clientId.SetValue(value);
    }

    private PropertyValue<string> _userId = new PropertyValue<string>(nameof(MenuActionPayload), nameof(UserId), "userId");
    
    [Required]
    [JsonPropertyName("userId")]
    public string UserId
    {
        get => _userId.GetValue(InlineErrors);
        set => _userId.SetValue(value);
    }

    private PropertyValue<string?> _verificationToken = new PropertyValue<string?>(nameof(MenuActionPayload), nameof(VerificationToken), "verificationToken");
    
    [Obsolete("Verification token is only sent for old applications that have the Verification Token authentication set up. New applications cannot use this authentication. (since 2022-11-16) (will be removed in a future version)")]
    [JsonPropertyName("verificationToken")]
    public string? VerificationToken
    {
        get => _verificationToken.GetValue(InlineErrors);
        set => _verificationToken.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _menuItemUniqueCode.SetAccessPath(parentChainPath, validateHasBeenSet);
        _context.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _userId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _verificationToken.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

