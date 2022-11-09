using JetBrains.Annotations;
using JetBrains.Space.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace JetBrains.Space.Common;

/// <summary>
/// Extensions methods for <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>.
/// </summary>
[PublicAPI]
public static class TriplePartialExtensions
{
    /// <summary>
    /// Add field name of the first element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>.</param>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TThird">The type of the third element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>, with an added field name.</returns>
    public static Partial<Triple<TFirst, TSecond, TThird>> WithFirst<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it)
        => it.AddFieldName("first");

    /// <summary>
    /// Add field name of the first element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>.</param>
    /// <param name="partialBuilder">A child <see cref="Partial{T}"/> of <typeparamref name="TFirst"/>.</param>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TThird">The type of the third element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>, with an added field name.</returns>
    public static Partial<Triple<TFirst, TSecond, TThird>> WithFirst<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it, Func<Partial<TFirst>, Partial<TFirst>> partialBuilder) 
        => it.AddFieldName("first", partialBuilder(new Partial<TFirst>()));
        
    /// <summary>
    /// Add field name of the second element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>.</param>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TThird">The type of the third element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>, with an added field name.</returns>
    public static Partial<Triple<TFirst, TSecond, TThird>> WithSecondFirst<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it) 
        => it.AddFieldName("second");
        
    /// <summary>
    /// Add field name of the second element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>.</param>
    /// <param name="partialBuilder">A child <see cref="Partial{T}"/> of <typeparamref name="TSecond"/>.</param>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TThird">The type of the third element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>, with an added field name.</returns>
    public static Partial<Triple<TFirst, TSecond, TThird>> WithSecond<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it, Func<Partial<TSecond>, Partial<TSecond>> partialBuilder) 
        => it.AddFieldName("second", partialBuilder(new Partial< TSecond>()));
        
    /// <summary>
    /// Add field name of the third element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>.</param>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TThird">The type of the third element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>, with an added field name.</returns>
    public static Partial<Triple<TFirst, TSecond, TThird>> WithThird<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it) 
        => it.AddFieldName("third");
        
    /// <summary>
    /// Add field name of the third element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>.</param>
    /// <param name="partialBuilder">A child <see cref="Partial{T}"/> of <typeparamref name="TThird"/>.</param>
    /// <typeparam name="TFirst">The type of the first element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TSecond">The type of the second element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <typeparam name="TThird">The type of the third element in the <see cref="Triple{TFirst,TSecond,TThird}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Triple{TFirst,TSecond,TThird}"/>, with an added field name.</returns>
    public static Partial<Triple<TFirst, TSecond, TThird>> WithThird<TFirst, TSecond, TThird>(this Partial<Triple<TFirst, TSecond, TThird>> it, Func<Partial<TThird>, Partial<TThird>> partialBuilder)
        => it.AddFieldName("third", partialBuilder(new Partial<TThird>()));
}