// ReSharper disable RedundantLogicalConditionalExpressionOperand

using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Generator;

internal static class FeatureFlags
{
    /// <summary>
    /// Hide request objects?
    /// 
    /// When true, will expose request object properties as API request parameters, making the API surface nicer to use.
    /// When false, will generate API method calls that require request objects to be passed.
    ///
    /// Recommended value: true
    /// </summary>
    public static bool DoNotExposeRequestObjects = true;

    /// <summary>
    /// Support relaxed <see cref="PropertyValue{T}"/> access?
    ///
    /// When true, getting properties will return null if the property was not requested from API.
    /// When false, getting properties will throw if the property was not requested from API.
    ///
    /// Recommended value: true
    /// </summary>
    public static bool SupportRelaxedPropertyValueAccess = false;
}