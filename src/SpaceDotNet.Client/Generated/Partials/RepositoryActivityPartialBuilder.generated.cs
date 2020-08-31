// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.RepositoryActivityPartialBuilder
{
    public static class RepositoryActivityPartialExtensions
    {
        public static Partial<RepositoryActivity> WithLastActivity(this Partial<RepositoryActivity> it)
            => it.AddFieldName("lastActivity");
        
        public static Partial<RepositoryActivity> WithLastActivity(this Partial<RepositoryActivity> it, Func<Partial<Pair<SpaceDate, int>>, Partial<Pair<SpaceDate, int>>> partialBuilder)
            => it.AddFieldName("lastActivity", partialBuilder(new Partial<Pair<SpaceDate, int>>(it)));
        
    }
    
}
