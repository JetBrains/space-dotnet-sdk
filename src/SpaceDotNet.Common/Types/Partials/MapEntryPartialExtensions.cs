using System;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace SpaceDotNet.Common
{
    [PublicAPI]
    public static class MapEntryPartialExtensions
    {    
        
        public static Partial<MapEntry<TKey, TValue>> WithKey<TKey, TValue>(this Partial<MapEntry<TKey, TValue>> it) 
            => it.AddFieldName("key");
        
        public static Partial<MapEntry<TKey, TValue>> WithKey<TKey, TValue>(this Partial<MapEntry<TKey, TValue>> it, Func<Partial<TKey>, Partial<TKey>> partialBuilder) 
            => it.AddFieldName("key", partialBuilder(new Partial<TKey>()));
        
        public static Partial<MapEntry<TKey, TValue>> WithValue<TKey, TValue>(this Partial<MapEntry<TKey, TValue>> it) 
            => it.AddFieldName("value");
        
        public static Partial<MapEntry<TKey, TValue>> WithValue<TKey, TValue>(this Partial<MapEntry<TKey, TValue>> it, Func<Partial<TValue>, Partial<TValue>> partialBuilder) 
            => it.AddFieldName("value", partialBuilder(new Partial<TValue>()));
    }
}