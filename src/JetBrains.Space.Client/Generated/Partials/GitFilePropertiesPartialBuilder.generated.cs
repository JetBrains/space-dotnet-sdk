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

namespace JetBrains.Space.Client.GitFilePropertiesPartialBuilder;

public static class GitFilePropertiesPartialExtensions
{
    public static Partial<GitFileProperties> WithIsLfs(this Partial<GitFileProperties> it)
        => it.AddFieldName("lfs");
    
    public static Partial<GitFileProperties> WithIsExecutable(this Partial<GitFileProperties> it)
        => it.AddFieldName("executable");
    
    public static Partial<GitFileProperties> WithAttributes(this Partial<GitFileProperties> it)
        => it.AddFieldName("attributes");
    
    public static Partial<GitFileProperties> WithAttributes(this Partial<GitFileProperties> it, Func<Partial<GitFileAttribute>, Partial<GitFileAttribute>> partialBuilder)
        => it.AddFieldName("attributes", partialBuilder(new Partial<GitFileAttribute>(it)));
    
}

