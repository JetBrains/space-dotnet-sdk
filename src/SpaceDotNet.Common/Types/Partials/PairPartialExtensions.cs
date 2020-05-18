using System;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace SpaceDotNet.Common
{
    [PublicAPI]
    public static class PairPartialExtensions
    {
        public static Partial<Pair<TFirst, TSecond>> WithFirst<TFirst, TSecond>(this Partial<Pair<TFirst, TSecond>> it) 
            => it.AddFieldName("first");
        
        public static Partial<Pair<TFirst, TSecond>> WithFirst<TFirst, TSecond>(this Partial<Pair<TFirst, TSecond>> it, Func<Partial<TFirst>, Partial<TFirst>> partialBuilder) 
            => it.AddFieldName("first", partialBuilder(new Partial<TFirst>()));
        
        public static Partial<Pair<TFirst, TSecond>> WithSecond<TFirst, TSecond>(this Partial<Pair<TFirst, TSecond>> it) 
            => it.AddFieldName("second");
        
        public static Partial<Pair<TFirst, TSecond>> WithSecond<TFirst, TSecond>(this Partial<Pair<TFirst, TSecond>> it, Func<Partial<TSecond>, Partial<TSecond>> partialBuilder) 
            => it.AddFieldName("second", partialBuilder(new Partial<TSecond>()));
    }
}