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

[JsonConverter(typeof(ClassNameDtoTypeConverter))]
public class JenkinsBuild
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "JenkinsBuild";
    
    public static JenkinsBuildQueueItem QueueItem(long id, string url, bool cancelled, bool stuck, string? why = null, JenkinsBuildQueueItemExecutable? executable = null)
        => new JenkinsBuildQueueItem(id: id, url: url, cancelled: cancelled, stuck: stuck, why: why, executable: executable);
    
    public static JenkinsBuildRunningBuild RunningBuild(string id, string url, string fullDisplayName, bool inProgress, long? duration = null, string? result = null, long? initialQueueItemId = null)
        => new JenkinsBuildRunningBuild(id: id, url: url, fullDisplayName: fullDisplayName, inProgress: inProgress, duration: duration, result: result, initialQueueItemId: initialQueueItemId);
    
    public JenkinsBuild() { }
    
    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
