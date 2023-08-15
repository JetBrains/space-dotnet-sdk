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
public abstract class AnyOfCFFilter
     : CFFilter, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "AnyOfCFFilter";
    
    public static BooleanCFFilter BooleanCFFilter(List<BooleanCFValue> values)
        => new BooleanCFFilter(values: values);
    
    public static DeploymentCFFilter DeploymentCFFilter(List<DeploymentCFInputValue> values)
        => new DeploymentCFFilter(values: values);
    
    public static DocumentCFFilter DocumentCFFilter(List<DocumentCFInputValue> values)
        => new DocumentCFFilter(values: values);
    
    public static EnumCFFilter EnumCFFilter(List<EnumCFValue> values)
        => new EnumCFFilter(values: values);
    
    public static FractionCFFilter FractionCFFilter(List<FractionCFValue> values)
        => new FractionCFFilter(values: values);
    
    public static IssueCFFilter IssueCFFilter(List<IssueCFInputValue> values)
        => new IssueCFFilter(values: values);
    
    public static LocationCFFilter LocationCFFilter(List<LocationCFInputValue> values)
        => new LocationCFFilter(values: values);
    
    public static ProfileCFFilter ProfileCFFilter(List<ProfileCFInputValue> values)
        => new ProfileCFFilter(values: values);
    
    public static ProjectCFFilter ProjectCFFilter(List<ProjectCFInputValue> values)
        => new ProjectCFFilter(values: values);
    
    public static TargetCFFilter TargetCFFilter(List<TargetCFInputValue> values)
        => new TargetCFFilter(values: values);
    
    public static TeamCFFilter TeamCFFilter(List<TeamCFInputValue> values)
        => new TeamCFFilter(values: values);
    
    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
