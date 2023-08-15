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

internal class TeamDirectoryProfilesForProfileSettingsPatchRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryProfilesForProfileSettingsPatchRequest() { }
    
    public TeamDirectoryProfilesForProfileSettingsPatchRequest(DarkTheme? darkTheme = null, string? themeName = null, Weekday? firstDayOfWeek = null, DraftDocumentType? draftType = null, TypographySettings? typographySettings = null, bool? todoFilters = null, string? calendarView = null, bool? emailNotificationsEnabled = null, string? notificationEmail = null, string? preferredLanguage = null, ProjectIdentifier? defaultProject = null)
    {
        DarkTheme = darkTheme;
        ThemeName = themeName;
        FirstDayOfWeek = firstDayOfWeek;
        DraftType = draftType;
        TypographySettings = typographySettings;
        IsTodoFilters = todoFilters;
        CalendarView = calendarView;
        IsEmailNotificationsEnabled = emailNotificationsEnabled;
        NotificationEmail = notificationEmail;
        PreferredLanguage = preferredLanguage;
        DefaultProject = defaultProject;
    }
    
    private PropertyValue<DarkTheme?> _darkTheme = new PropertyValue<DarkTheme?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(DarkTheme), "darkTheme");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("darkTheme")]
    public DarkTheme? DarkTheme
    {
        get => _darkTheme.GetValue(InlineErrors);
        set => _darkTheme.SetValue(value);
    }

    private PropertyValue<string?> _themeName = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(ThemeName), "themeName");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("themeName")]
    public string? ThemeName
    {
        get => _themeName.GetValue(InlineErrors);
        set => _themeName.SetValue(value);
    }

    private PropertyValue<Weekday?> _firstDayOfWeek = new PropertyValue<Weekday?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(FirstDayOfWeek), "firstDayOfWeek");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("firstDayOfWeek")]
    public Weekday? FirstDayOfWeek
    {
        get => _firstDayOfWeek.GetValue(InlineErrors);
        set => _firstDayOfWeek.SetValue(value);
    }

    private PropertyValue<DraftDocumentType?> _draftType = new PropertyValue<DraftDocumentType?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(DraftType), "draftType");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("draftType")]
    public DraftDocumentType? DraftType
    {
        get => _draftType.GetValue(InlineErrors);
        set => _draftType.SetValue(value);
    }

    private PropertyValue<TypographySettings?> _typographySettings = new PropertyValue<TypographySettings?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(TypographySettings), "typographySettings");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("typographySettings")]
    public TypographySettings? TypographySettings
    {
        get => _typographySettings.GetValue(InlineErrors);
        set => _typographySettings.SetValue(value);
    }

    private PropertyValue<bool?> _todoFilters = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(IsTodoFilters), "todoFilters");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("todoFilters")]
    public bool? IsTodoFilters
    {
        get => _todoFilters.GetValue(InlineErrors);
        set => _todoFilters.SetValue(value);
    }

    private PropertyValue<string?> _calendarView = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(CalendarView), "calendarView");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("calendarView")]
    public string? CalendarView
    {
        get => _calendarView.GetValue(InlineErrors);
        set => _calendarView.SetValue(value);
    }

    private PropertyValue<bool?> _emailNotificationsEnabled = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(IsEmailNotificationsEnabled), "emailNotificationsEnabled");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [Obsolete("Use notification-settings (since 24 Feb 2021) (will be removed in a future version)")]
    [JsonPropertyName("emailNotificationsEnabled")]
    public bool? IsEmailNotificationsEnabled
    {
        get => _emailNotificationsEnabled.GetValue(InlineErrors);
        set => _emailNotificationsEnabled.SetValue(value);
    }

    private PropertyValue<string?> _notificationEmail = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(NotificationEmail), "notificationEmail");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [Obsolete("Use notification-settings (since 24 Feb 2021) (will be removed in a future version)")]
    [JsonPropertyName("notificationEmail")]
    public string? NotificationEmail
    {
        get => _notificationEmail.GetValue(InlineErrors);
        set => _notificationEmail.SetValue(value);
    }

    private PropertyValue<string?> _preferredLanguage = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(PreferredLanguage), "preferredLanguage");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("preferredLanguage")]
    public string? PreferredLanguage
    {
        get => _preferredLanguage.GetValue(InlineErrors);
        set => _preferredLanguage.SetValue(value);
    }

    private PropertyValue<ProjectIdentifier?> _defaultProject = new PropertyValue<ProjectIdentifier?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(DefaultProject), "defaultProject");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("defaultProject")]
    public ProjectIdentifier? DefaultProject
    {
        get => _defaultProject.GetValue(InlineErrors);
        set => _defaultProject.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _darkTheme.SetAccessPath(parentChainPath, validateHasBeenSet);
        _themeName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _firstDayOfWeek.SetAccessPath(parentChainPath, validateHasBeenSet);
        _draftType.SetAccessPath(parentChainPath, validateHasBeenSet);
        _typographySettings.SetAccessPath(parentChainPath, validateHasBeenSet);
        _todoFilters.SetAccessPath(parentChainPath, validateHasBeenSet);
        _calendarView.SetAccessPath(parentChainPath, validateHasBeenSet);
        _emailNotificationsEnabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _notificationEmail.SetAccessPath(parentChainPath, validateHasBeenSet);
        _preferredLanguage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultProject.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

