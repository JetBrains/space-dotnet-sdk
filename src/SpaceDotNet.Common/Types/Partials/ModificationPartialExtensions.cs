using System;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace SpaceDotNet.Common
{
    [PublicAPI]
    public static class ModificationPartialExtensions
    {    
        public static Partial<Modification<T>> WithOld<T>(this Partial<Modification<T>> it)
            => it.AddFieldName("old");
        
        public static Partial<Modification<T>> WithOld<T>(this Partial<Modification<T>> it, Func<Partial<T>, Partial<T>> partialBuilder) 
            => it.AddFieldName("old", partialBuilder(new Partial<T>()));
        
        public static Partial<Modification<T>> WithNew<T>(this Partial<Modification<T>> it) 
            => it.AddFieldName("new");
        
        public static Partial<Modification<T>> WithNew<T>(this Partial<Modification<T>> it, Func<Partial<T>, Partial<T>> partialBuilder) 
            => it.AddFieldName("new", partialBuilder(new Partial<T>()));
    }
}