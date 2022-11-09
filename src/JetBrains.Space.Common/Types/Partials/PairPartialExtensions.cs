using JetBrains.Annotations;
using JetBrains.Space.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace JetBrains.Space.Common;

/// <summary>
/// Extensions methods for <see cref="Partial{T}"/> of <see cref="Pair{TFirst,TSecond}"/>.
/// </summary>
[PublicAPI]
public static class PairPartialExtensions
{
    /// <summary>
    /// Add field name of the first element in the <see cref="Pair{TFirst,TSecond}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Pair{TFirst,TSecond}"/>.</param>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Pair{TFirst,TSecond}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Pair{TFirst,TSecond}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Pair{TFirst,TSecond}"/>, with an added field name.</returns>
    public static Partial<Pair<TFirst, TSecond>> WithFirst<TFirst, TSecond>(this Partial<Pair<TFirst, TSecond>> it) 
        => it.AddFieldName("first");
        
    /// <summary>
    /// Add field name of the first element in the <see cref="Pair{TFirst,TSecond}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Pair{TFirst,TSecond}"/>.</param>
    /// <param name="partialBuilder">A child <see cref="Partial{T}"/> of <typeparamref name="TFirst"/>.</param>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Pair{TFirst,TSecond}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Pair{TFirst,TSecond}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Pair{TFirst,TSecond}"/>, with an added field name.</returns>
    public static Partial<Pair<TFirst, TSecond>> WithFirst<TFirst, TSecond>(this Partial<Pair<TFirst, TSecond>> it, Func<Partial<TFirst>, Partial<TFirst>> partialBuilder) 
        => it.AddFieldName("first", partialBuilder(new Partial<TFirst>()));
        
    /// <summary>
    /// Add field name of the second element in the <see cref="Pair{TFirst,TSecond}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Pair{TFirst,TSecond}"/>.</param>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Pair{TFirst,TSecond}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Pair{TFirst,TSecond}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Pair{TFirst,TSecond}"/>, with an added field name.</returns>
    public static Partial<Pair<TFirst, TSecond>> WithSecond<TFirst, TSecond>(this Partial<Pair<TFirst, TSecond>> it) 
        => it.AddFieldName("second");
        
    /// <summary>
    /// Add field name of the second element in the <see cref="Pair{TFirst,TSecond}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Pair{TFirst,TSecond}"/>.</param>
    /// <param name="partialBuilder">A child <see cref="Partial{T}"/> of <typeparamref name="TSecond"/>.</param>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Pair{TFirst,TSecond}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Pair{TFirst,TSecond}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Pair{TFirst,TSecond}"/>, with an added field name.</returns>
    public static Partial<Pair<TFirst, TSecond>> WithSecond<TFirst, TSecond>(this Partial<Pair<TFirst, TSecond>> it, Func<Partial<TSecond>, Partial<TSecond>> partialBuilder) 
        => it.AddFieldName("second", partialBuilder(new Partial<TSecond>()));
}