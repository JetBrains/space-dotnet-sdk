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

internal class TeamDirectoryProfilesForProfileNotificationSettingsPatchRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryProfilesForProfileNotificationSettingsPatchRequest() { }
    
    public TeamDirectoryProfilesForProfileNotificationSettingsPatchRequest(bool? emailNotificationsEnabled = null, string? notificationEmail = null, bool? slackNotificationsEnabled = null, bool? pushNotificationEnabled = null, int? desktopInactivityTimeout = null)
    {
        IsEmailNotificationsEnabled = emailNotificationsEnabled;
        NotificationEmail = notificationEmail;
        IsSlackNotificationsEnabled = slackNotificationsEnabled;
        IsPushNotificationEnabled = pushNotificationEnabled;
        DesktopInactivityTimeout = desktopInactivityTimeout;
    }
    
    private PropertyValue<bool?> _emailNotificationsEnabled = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfileNotificationSettingsPatchRequest), nameof(IsEmailNotificationsEnabled), "emailNotificationsEnabled");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("emailNotificationsEnabled")]
    public bool? IsEmailNotificationsEnabled
    {
        get => _emailNotificationsEnabled.GetValue(InlineErrors);
        set => _emailNotificationsEnabled.SetValue(value);
    }

    private PropertyValue<string?> _notificationEmail = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileNotificationSettingsPatchRequest), nameof(NotificationEmail), "notificationEmail");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("notificationEmail")]
    public string? NotificationEmail
    {
        get => _notificationEmail.GetValue(InlineErrors);
        set => _notificationEmail.SetValue(value);
    }

    private PropertyValue<bool?> _slackNotificationsEnabled = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfileNotificationSettingsPatchRequest), nameof(IsSlackNotificationsEnabled), "slackNotificationsEnabled");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("slackNotificationsEnabled")]
    public bool? IsSlackNotificationsEnabled
    {
        get => _slackNotificationsEnabled.GetValue(InlineErrors);
        set => _slackNotificationsEnabled.SetValue(value);
    }

    private PropertyValue<bool?> _pushNotificationEnabled = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfileNotificationSettingsPatchRequest), nameof(IsPushNotificationEnabled), "pushNotificationEnabled");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("pushNotificationEnabled")]
    public bool? IsPushNotificationEnabled
    {
        get => _pushNotificationEnabled.GetValue(InlineErrors);
        set => _pushNotificationEnabled.SetValue(value);
    }

    private PropertyValue<int?> _desktopInactivityTimeout = new PropertyValue<int?>(nameof(TeamDirectoryProfilesForProfileNotificationSettingsPatchRequest), nameof(DesktopInactivityTimeout), "desktopInactivityTimeout");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("desktopInactivityTimeout")]
    public int? DesktopInactivityTimeout
    {
        get => _desktopInactivityTimeout.GetValue(InlineErrors);
        set => _desktopInactivityTimeout.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _emailNotificationsEnabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _notificationEmail.SetAccessPath(parentChainPath, validateHasBeenSet);
        _slackNotificationsEnabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _pushNotificationEnabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _desktopInactivityTimeout.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

