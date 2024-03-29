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

namespace JetBrains.Space.Client.PackagesAccessRecipientIdentifierPartialBuilder;

public static class PackagesAccessRecipientIdentifierPartialExtensions
{
    public static Partial<PackagesAccessRecipientIdentifier> WithAccess(this Partial<PackagesAccessRecipientIdentifier> it)
        => it.AddFieldName("access");
    
    public static Partial<PackagesAccessRecipientIdentifier> WithAccess(this Partial<PackagesAccessRecipientIdentifier> it, Func<Partial<PackagesSharingAccessType>, Partial<PackagesSharingAccessType>> partialBuilder)
        => it.AddFieldName("access", partialBuilder(new Partial<PackagesSharingAccessType>(it)));
    
    public static Partial<PackagesAccessRecipientIdentifier> WithRecipient(this Partial<PackagesAccessRecipientIdentifier> it)
        => it.AddFieldName("recipient");
    
    public static Partial<PackagesAccessRecipientIdentifier> WithRecipient(this Partial<PackagesAccessRecipientIdentifier> it, Func<Partial<PermissionsRecipientIdentifier>, Partial<PermissionsRecipientIdentifier>> partialBuilder)
        => it.AddFieldName("recipient", partialBuilder(new Partial<PermissionsRecipientIdentifier>(it)));
    
}

