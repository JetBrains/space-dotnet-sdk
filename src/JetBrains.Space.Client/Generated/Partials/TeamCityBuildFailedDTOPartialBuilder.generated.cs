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

namespace JetBrains.Space.Client.TeamCityBuildFailedDTOPartialBuilder;

public static class TeamCityBuildFailedDTOPartialExtensions
{
    public static Partial<TeamCityBuildFailedDTO> WithName(this Partial<TeamCityBuildFailedDTO> it)
        => it.AddFieldName("name");
    
    public static Partial<TeamCityBuildFailedDTO> WithUrl(this Partial<TeamCityBuildFailedDTO> it)
        => it.AddFieldName("url");
    
    public static Partial<TeamCityBuildFailedDTO> WithMessage(this Partial<TeamCityBuildFailedDTO> it)
        => it.AddFieldName("message");
    
    public static Partial<TeamCityBuildFailedDTO> WithFailedTestsCount(this Partial<TeamCityBuildFailedDTO> it)
        => it.AddFieldName("failedTestsCount");
    
    public static Partial<TeamCityBuildFailedDTO> WithFailedTests(this Partial<TeamCityBuildFailedDTO> it)
        => it.AddFieldName("failedTests");
    
    public static Partial<TeamCityBuildFailedDTO> WithFailedTests(this Partial<TeamCityBuildFailedDTO> it, Func<Partial<TeamCityFailedTestDTO>, Partial<TeamCityFailedTestDTO>> partialBuilder)
        => it.AddFieldName("failedTests", partialBuilder(new Partial<TeamCityFailedTestDTO>(it)));
    
}

