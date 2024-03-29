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

public sealed class RdFromDevfile
     : RdConfigurationSource, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "RdFromDevfile";
    
    public RdFromDevfile() { }
    
    public RdFromDevfile(string path, string configurationRevision)
    {
        Path = path;
        ConfigurationRevision = configurationRevision;
    }
    
    private PropertyValue<string> _path = new PropertyValue<string>(nameof(RdFromDevfile), nameof(Path), "path");
    
    [Required]
    [JsonPropertyName("path")]
    public string Path
    {
        get => _path.GetValue(InlineErrors);
        set => _path.SetValue(value);
    }

    private PropertyValue<string> _configurationRevision = new PropertyValue<string>(nameof(RdFromDevfile), nameof(ConfigurationRevision), "configurationRevision");
    
    [Required]
    [JsonPropertyName("configurationRevision")]
    public string ConfigurationRevision
    {
        get => _configurationRevision.GetValue(InlineErrors);
        set => _configurationRevision.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _path.SetAccessPath(parentChainPath, validateHasBeenSet);
        _configurationRevision.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

