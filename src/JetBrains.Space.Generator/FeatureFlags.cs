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
        public const bool DoNotExposeRequestObjects = true;
        
        /// <summary>
        /// Generate optional parameter defaults with reference types?
        ///
        /// When true, will generate optional parameter defaults with reference types, resulting in code that does not compile.
        /// When false, will generate code that compiles.
        /// 
        /// Recommended value: false
        /// </summary>
        public const bool GenerateOptionalParameterDefaultReferenceTypes = false;

        /// <summary>
        /// Generate alternative for optional parameter defaults with reference types?
        ///
        /// When true, will generate null value and default value fallback for optional parameter defaults with reference types.
        /// When false, will ignore optional parameter defaults with reference types.
        /// 
        /// Recommended value: true
        /// </summary>
        public const bool GenerateAlternativeForOptionalParameterDefaultReferenceTypes = !GenerateOptionalParameterDefaultReferenceTypes && true;
    }
}