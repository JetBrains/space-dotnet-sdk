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

namespace JetBrains.Space.Client.CFCommitIdentifierFullPartialBuilder;

public static class CFCommitIdentifierFullPartialExtensions
{
    public static Partial<CFCommitIdentifierFull> WithProject(this Partial<CFCommitIdentifierFull> it)
        => it.AddFieldName("project");
    
    public static Partial<CFCommitIdentifierFull> WithProject(this Partial<CFCommitIdentifierFull> it, Func<Partial<ProjectIdentifier>, Partial<ProjectIdentifier>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<ProjectIdentifier>(it)));
    
    public static Partial<CFCommitIdentifierFull> WithRepository(this Partial<CFCommitIdentifierFull> it)
        => it.AddFieldName("repository");
    
    public static Partial<CFCommitIdentifierFull> WithCommitHash(this Partial<CFCommitIdentifierFull> it)
        => it.AddFieldName("commitHash");
    
}

