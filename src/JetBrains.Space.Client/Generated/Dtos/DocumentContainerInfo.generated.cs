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

public interface DocumentContainerInfo
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static BookContainerInfo BookContainerInfo(KBBook? book = null, string? bookAlias = null, string? bookId = null, PRProject? project = null, List<string>? grantedRights = null)
        => new BookContainerInfo(book: book, bookAlias: bookAlias, bookId: bookId, project: project, grantedRights: grantedRights);
    
    public static InaccessibleContainerInfo InaccessibleContainerInfo(int? containerType = null, List<string>? grantedRights = null)
        => new InaccessibleContainerInfo(containerType: containerType, grantedRights: grantedRights);
    
    public static PersonalDocumentContainerInfo Personal(TDMemberProfile owner, List<string>? grantedRights = null)
        => new PersonalDocumentContainerInfo(owner: owner, grantedRights: grantedRights);
    
}

