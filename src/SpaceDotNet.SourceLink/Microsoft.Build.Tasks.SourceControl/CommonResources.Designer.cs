﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Build.Tasks.SourceControl {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CommonResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CommonResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SpaceDotNet.SourceLink.Microsoft.Build.Tasks.SourceControl.CommonResources", typeof(CommonResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} item group is empty. At least one {1} repository host is required in order to generate SourceLink..
        /// </summary>
        internal static string AtLeastOneRepositoryHostIsRequired {
            get {
                return ResourceManager.GetString("AtLeastOneRepositoryHostIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item &apos;{0}&apos; of item group &apos;{1}&apos; must specify metadata &apos;{2}&apos;.
        /// </summary>
        internal static string ItemOfItemGroupMustSpecifyMetadata {
            get {
                return ResourceManager.GetString("ItemOfItemGroupMustSpecifyMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine repository url, the source code won&apos;t be available via source link..
        /// </summary>
        internal static string UnableToDetermineRepositoryUrl {
            get {
                return ResourceManager.GetString("UnableToDetermineRepositoryUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of {0} with identity &apos;{1}&apos; is invalid: &apos;{2}&apos;.
        /// </summary>
        internal static string ValueOfWithIdentityIsInvalid {
            get {
                return ResourceManager.GetString("ValueOfWithIdentityIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of {0} with identity &apos;{1}&apos; is not a valid commit hash: &apos;{2}&apos;.
        /// </summary>
        internal static string ValueOfWithIdentityIsNotValidCommitHash {
            get {
                return ResourceManager.GetString("ValueOfWithIdentityIsNotValidCommitHash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value passed to task parameter {0} is not a valid domain name: &apos;{1}&apos;.
        /// </summary>
        internal static string ValuePassedToTaskParameterNotValidDomainName {
            get {
                return ResourceManager.GetString("ValuePassedToTaskParameterNotValidDomainName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value passed to task parameter {0} is not a valid host URI: &apos;{1}&apos;.
        /// </summary>
        internal static string ValuePassedToTaskParameterNotValidHostUri {
            get {
                return ResourceManager.GetString("ValuePassedToTaskParameterNotValidHostUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value passed to task parameter {0} is not a valid URI: &apos;{1}&apos;.
        /// </summary>
        internal static string ValuePassedToTaskParameterNotValidUri {
            get {
                return ResourceManager.GetString("ValuePassedToTaskParameterNotValidUri", resourceCulture);
            }
        }
    }
}
