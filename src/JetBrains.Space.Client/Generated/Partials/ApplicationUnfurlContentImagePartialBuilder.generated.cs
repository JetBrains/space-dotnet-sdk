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

namespace JetBrains.Space.Client.ApplicationUnfurlContentImagePartialBuilder;

public static class ApplicationUnfurlContentImagePartialExtensions
{
    /// <summary>
    /// Optional icon to appear in the header above the image
    /// </summary>
    public static Partial<ApplicationUnfurlContentImage> WithIcon(this Partial<ApplicationUnfurlContentImage> it)
        => it.AddFieldName("icon");
    
    /// <summary>
    /// Optional icon to appear in the header above the image
    /// </summary>
    public static Partial<ApplicationUnfurlContentImage> WithIcon(this Partial<ApplicationUnfurlContentImage> it, Func<Partial<ApiIcon>, Partial<ApiIcon>> partialBuilder)
        => it.AddFieldName("icon", partialBuilder(new Partial<ApiIcon>(it)));
    
    /// <summary>
    /// Header text
    /// </summary>
    public static Partial<ApplicationUnfurlContentImage> WithTitle(this Partial<ApplicationUnfurlContentImage> it)
        => it.AddFieldName("title");
    
    /// <summary>
    /// Image url.
    /// 
    /// Space will download and store this image to your organization at the moment of link preview processing, so that further changes of the image available on that url won't affect the already generated link preview.
    /// </summary>
    public static Partial<ApplicationUnfurlContentImage> WithUrl(this Partial<ApplicationUnfurlContentImage> it)
        => it.AddFieldName("url");
    
}

