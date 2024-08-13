// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public interface ESOAuth2AuthModuleSettings
     : ESFederatedAuthModuleSettings, IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static ESAzureAuthModuleSettings ESAzureAuthModuleSettings(string tenantId, string clientId, string clientSecret, bool registerNewUsers, bool emailVerified, List<AzureRegisterNewUserRule>? registerNewUserRules = null)
        => new ESAzureAuthModuleSettings(tenantId: tenantId, clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, emailVerified: emailVerified, registerNewUserRules: registerNewUserRules);
    
    public static ESGithubAuthModuleSettings ESGithubAuthModuleSettings(string githubUrl, string clientId, string clientSecret, bool registerNewUsers, List<string> organizations, List<GithubRegisterNewUserRule>? registerNewUserRules = null)
        => new ESGithubAuthModuleSettings(githubUrl: githubUrl, clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, organizations: organizations, registerNewUserRules: registerNewUserRules);
    
    public static ESGoogleAuthModuleSettings ESGoogleAuthModuleSettings(string clientId, string clientSecret, bool registerNewUsers, List<string> domains, List<GoogleRegisterNewUserRule>? registerNewUserRules = null)
        => new ESGoogleAuthModuleSettings(clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, domains: domains, registerNewUserRules: registerNewUserRules);
    
    public static ESHubAuthModuleSettings ESHubAuthModuleSettings(string hubUrl, string clientId, string clientSecret, bool registerNewUsers, string? orgAuthProviderName = null, List<string>? groups = null, List<HubRegisterNewUserRule>? registerNewUserRules = null)
        => new ESHubAuthModuleSettings(hubUrl: hubUrl, clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, orgAuthProviderName: orgAuthProviderName, groups: groups, registerNewUserRules: registerNewUserRules);
    
    public static ESOIDCAuthModuleSettings ESOIDCAuthModuleSettings(string clientId, string clientSecret, bool registerNewUsers, string issuer, string authorizationEndpoint, string tokenEndpoint, string tokenKeysEndpoint, string userInfoEndpoint, List<string> domains, string? discoveryUrl = null, List<OidcRegisterNewUserRule>? registerNewUserRules = null)
        => new ESOIDCAuthModuleSettings(clientId: clientId, clientSecret: clientSecret, registerNewUsers: registerNewUsers, issuer: issuer, authorizationEndpoint: authorizationEndpoint, tokenEndpoint: tokenEndpoint, tokenKeysEndpoint: tokenKeysEndpoint, userInfoEndpoint: userInfoEndpoint, domains: domains, discoveryUrl: discoveryUrl, registerNewUserRules: registerNewUserRules);
    
}

