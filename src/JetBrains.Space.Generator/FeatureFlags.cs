// ReSharper disable RedundantLogicalConditionalExpressionOperand

namespace JetBrains.Space.Generator
{
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
    }
}