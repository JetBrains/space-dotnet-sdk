// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class ESLdapAuthModuleSettingsDto
         : ESExternalPasswordAuthModuleSettingsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_LdapAuthModuleSettings";
        
        public ESLdapAuthModuleSettingsDto() { }
        
        public ESLdapAuthModuleSettingsDto(LdapModuleType type, bool registerNewUsers, string serverUrl, int connectionTimeout, int readTimeout, List<ESTeamMappingDto> teamMappings, bool referralIgnored, string filter, string bindUserDN, string bindUserPassword, ESLdapAttributeNamesDto attributeNames, SSLKeystoreDto? sslKeystore = null)
        {
            Type = type;
            RegisterNewUsers = registerNewUsers;
            ServerUrl = serverUrl;
            ConnectionTimeout = connectionTimeout;
            ReadTimeout = readTimeout;
            SslKeystore = sslKeystore;
            TeamMappings = teamMappings;
            ReferralIgnored = referralIgnored;
            Filter = filter;
            BindUserDN = bindUserDN;
            BindUserPassword = bindUserPassword;
            AttributeNames = attributeNames;
        }
        
        private PropertyValue<LdapModuleType> _type = new PropertyValue<LdapModuleType>(nameof(ESLdapAuthModuleSettingsDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public LdapModuleType Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<bool> _registerNewUsers = new PropertyValue<bool>(nameof(ESLdapAuthModuleSettingsDto), nameof(RegisterNewUsers));
        
        [Required]
        [JsonPropertyName("registerNewUsers")]
        public bool RegisterNewUsers
        {
            get { return _registerNewUsers.GetValue(); }
            set { _registerNewUsers.SetValue(value); }
        }
    
        private PropertyValue<string> _serverUrl = new PropertyValue<string>(nameof(ESLdapAuthModuleSettingsDto), nameof(ServerUrl));
        
        [Required]
        [JsonPropertyName("serverUrl")]
        public string ServerUrl
        {
            get { return _serverUrl.GetValue(); }
            set { _serverUrl.SetValue(value); }
        }
    
        private PropertyValue<int> _connectionTimeout = new PropertyValue<int>(nameof(ESLdapAuthModuleSettingsDto), nameof(ConnectionTimeout));
        
        [Required]
        [JsonPropertyName("connectionTimeout")]
        public int ConnectionTimeout
        {
            get { return _connectionTimeout.GetValue(); }
            set { _connectionTimeout.SetValue(value); }
        }
    
        private PropertyValue<int> _readTimeout = new PropertyValue<int>(nameof(ESLdapAuthModuleSettingsDto), nameof(ReadTimeout));
        
        [Required]
        [JsonPropertyName("readTimeout")]
        public int ReadTimeout
        {
            get { return _readTimeout.GetValue(); }
            set { _readTimeout.SetValue(value); }
        }
    
        private PropertyValue<SSLKeystoreDto?> _sslKeystore = new PropertyValue<SSLKeystoreDto?>(nameof(ESLdapAuthModuleSettingsDto), nameof(SslKeystore));
        
        [JsonPropertyName("sslKeystore")]
        public SSLKeystoreDto? SslKeystore
        {
            get { return _sslKeystore.GetValue(); }
            set { _sslKeystore.SetValue(value); }
        }
    
        private PropertyValue<List<ESTeamMappingDto>> _teamMappings = new PropertyValue<List<ESTeamMappingDto>>(nameof(ESLdapAuthModuleSettingsDto), nameof(TeamMappings));
        
        [Required]
        [JsonPropertyName("teamMappings")]
        public List<ESTeamMappingDto> TeamMappings
        {
            get { return _teamMappings.GetValue(); }
            set { _teamMappings.SetValue(value); }
        }
    
        private PropertyValue<bool> _referralIgnored = new PropertyValue<bool>(nameof(ESLdapAuthModuleSettingsDto), nameof(ReferralIgnored));
        
        [Required]
        [JsonPropertyName("referralIgnored")]
        public bool ReferralIgnored
        {
            get { return _referralIgnored.GetValue(); }
            set { _referralIgnored.SetValue(value); }
        }
    
        private PropertyValue<string> _filter = new PropertyValue<string>(nameof(ESLdapAuthModuleSettingsDto), nameof(Filter));
        
        [Required]
        [JsonPropertyName("filter")]
        public string Filter
        {
            get { return _filter.GetValue(); }
            set { _filter.SetValue(value); }
        }
    
        private PropertyValue<string> _bindUserDN = new PropertyValue<string>(nameof(ESLdapAuthModuleSettingsDto), nameof(BindUserDN));
        
        [Required]
        [JsonPropertyName("bindUserDN")]
        public string BindUserDN
        {
            get { return _bindUserDN.GetValue(); }
            set { _bindUserDN.SetValue(value); }
        }
    
        private PropertyValue<string> _bindUserPassword = new PropertyValue<string>(nameof(ESLdapAuthModuleSettingsDto), nameof(BindUserPassword));
        
        [Required]
        [JsonPropertyName("bindUserPassword")]
        public string BindUserPassword
        {
            get { return _bindUserPassword.GetValue(); }
            set { _bindUserPassword.SetValue(value); }
        }
    
        private PropertyValue<ESLdapAttributeNamesDto> _attributeNames = new PropertyValue<ESLdapAttributeNamesDto>(nameof(ESLdapAuthModuleSettingsDto), nameof(AttributeNames));
        
        [Required]
        [JsonPropertyName("attributeNames")]
        public ESLdapAttributeNamesDto AttributeNames
        {
            get { return _attributeNames.GetValue(); }
            set { _attributeNames.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _registerNewUsers.SetAccessPath(path, validateHasBeenSet);
            _serverUrl.SetAccessPath(path, validateHasBeenSet);
            _connectionTimeout.SetAccessPath(path, validateHasBeenSet);
            _readTimeout.SetAccessPath(path, validateHasBeenSet);
            _sslKeystore.SetAccessPath(path, validateHasBeenSet);
            _teamMappings.SetAccessPath(path, validateHasBeenSet);
            _referralIgnored.SetAccessPath(path, validateHasBeenSet);
            _filter.SetAccessPath(path, validateHasBeenSet);
            _bindUserDN.SetAccessPath(path, validateHasBeenSet);
            _bindUserPassword.SetAccessPath(path, validateHasBeenSet);
            _attributeNames.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
