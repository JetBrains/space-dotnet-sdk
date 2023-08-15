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

public sealed class DevConfigurationHotPool
     : IPropagatePropertyAccessPath
{
    public DevConfigurationHotPool() { }
    
    public DevConfigurationHotPool(bool enabled, int size, string cronSchedule, string timezone)
    {
        IsEnabled = enabled;
        Size = size;
        CronSchedule = cronSchedule;
        Timezone = timezone;
    }
    
    private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(DevConfigurationHotPool), nameof(IsEnabled), "enabled");
    
    [Required]
    [JsonPropertyName("enabled")]
    public bool IsEnabled
    {
        get => _enabled.GetValue(InlineErrors);
        set => _enabled.SetValue(value);
    }

    private PropertyValue<int> _size = new PropertyValue<int>(nameof(DevConfigurationHotPool), nameof(Size), "size");
    
    [Required]
    [JsonPropertyName("size")]
    public int Size
    {
        get => _size.GetValue(InlineErrors);
        set => _size.SetValue(value);
    }

    private PropertyValue<string> _cronSchedule = new PropertyValue<string>(nameof(DevConfigurationHotPool), nameof(CronSchedule), "cronSchedule");
    
    [Required]
    [JsonPropertyName("cronSchedule")]
    public string CronSchedule
    {
        get => _cronSchedule.GetValue(InlineErrors);
        set => _cronSchedule.SetValue(value);
    }

    private PropertyValue<string> _timezone = new PropertyValue<string>(nameof(DevConfigurationHotPool), nameof(Timezone), "timezone");
    
    [Required]
    [JsonPropertyName("timezone")]
    public string Timezone
    {
        get => _timezone.GetValue(InlineErrors);
        set => _timezone.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _enabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _size.SetAccessPath(parentChainPath, validateHasBeenSet);
        _cronSchedule.SetAccessPath(parentChainPath, validateHasBeenSet);
        _timezone.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
