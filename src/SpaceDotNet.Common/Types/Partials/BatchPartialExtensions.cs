using System;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace SpaceDotNet.Common
{
    [PublicAPI]
    public static class BatchPartialExtensions
    {     
        public static Partial<Batch<T>> WithData<T>(this Partial<Batch<T>> it) 
            => it.AddFieldName("data");
        
        public static Partial<Batch<T>> WithData<T>(this Partial<Batch<T>> it, Func<Partial<T>, Partial<T>> partialBuilder) 
            => it.AddFieldName("data", partialBuilder(new Partial<T>()));
        
        public static Partial<Batch<T>> WithNext<T>(this Partial<Batch<T>> it) 
            => it.AddFieldName("next");
        
        public static Partial<Batch<T>> WithTotalCount<T>(this Partial<Batch<T>> it) 
            => it.AddFieldName("totalCount");
    }
}