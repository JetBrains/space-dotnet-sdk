using System;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace SpaceDotNet.Common
{
    [PublicAPI]
    public static class TriplePartialExtensions
    {    
        public static Partial<Triple<TFirst, TSecond, TThird>> WithFirst<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it)
            => it.AddFieldName("first");
        public static Partial<Triple<TFirst, TSecond, TThird>> WithFirst<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it, Func<Partial<TFirst>, Partial<TFirst>> partialBuilder) 
            => it.AddFieldName("first", partialBuilder(new Partial<TFirst>()));
        
        public static Partial<Triple<TFirst, TSecond, TThird>> WithSecondFirst<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it) 
            => it.AddFieldName("second");
        
        public static Partial<Triple<TFirst, TSecond, TThird>> WithSecond<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it, Func<Partial<TSecond>, Partial<TSecond>> partialBuilder) 
            => it.AddFieldName("second", partialBuilder(new Partial< TSecond>()));
        
        public static Partial<Triple<TFirst, TSecond, TThird>> WithThird<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it) 
            => it.AddFieldName("third");
        
        public static Partial<Triple<TFirst, TSecond, TThird>> WithThird<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it, Func<Partial<TThird>, Partial<TThird>> partialBuilder)
            => it.AddFieldName("third", partialBuilder(new Partial<TThird>()));
    }
}