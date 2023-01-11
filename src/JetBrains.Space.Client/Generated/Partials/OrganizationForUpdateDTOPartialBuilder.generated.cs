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

namespace JetBrains.Space.Client.OrganizationForUpdateDTOPartialBuilder;

public static class OrganizationForUpdateDTOPartialExtensions
{
    public static Partial<OrganizationForUpdateDTO> WithName(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("name");
    
    public static Partial<OrganizationForUpdateDTO> WithSlogan(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("slogan");
    
    public static Partial<OrganizationForUpdateDTO> WithLogoId(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("logoId");
    
    public static Partial<OrganizationForUpdateDTO> WithLogoSmall(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("logoSmall");
    
    public static Partial<OrganizationForUpdateDTO> WithLogo(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("logo");
    
    public static Partial<OrganizationForUpdateDTO> WithIsOnboardingRequired(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("onboardingRequired");
    
    public static Partial<OrganizationForUpdateDTO> WithIsUserAgreementAccepted(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("userAgreementAccepted");
    
    public static Partial<OrganizationForUpdateDTO> WithTimezone(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("timezone");
    
    public static Partial<OrganizationForUpdateDTO> WithTimezone(this Partial<OrganizationForUpdateDTO> it, Func<Partial<ATimeZone>, Partial<ATimeZone>> partialBuilder)
        => it.AddFieldName("timezone", partialBuilder(new Partial<ATimeZone>(it)));
    
    public static Partial<OrganizationForUpdateDTO> WithLicense(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("license");
    
    public static Partial<OrganizationForUpdateDTO> WithOrgSize(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("orgSize");
    
    public static Partial<OrganizationForUpdateDTO> WithOrgSize(this Partial<OrganizationForUpdateDTO> it, Func<Partial<OrgSizeDTO>, Partial<OrgSizeDTO>> partialBuilder)
        => it.AddFieldName("orgSize", partialBuilder(new Partial<OrgSizeDTO>(it)));
    
    public static Partial<OrganizationForUpdateDTO> WithOrgIndustry(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("orgIndustry");
    
    public static Partial<OrganizationForUpdateDTO> WithOrgIndustry(this Partial<OrganizationForUpdateDTO> it, Func<Partial<OrgIndustryDTO>, Partial<OrgIndustryDTO>> partialBuilder)
        => it.AddFieldName("orgIndustry", partialBuilder(new Partial<OrgIndustryDTO>(it)));
    
    public static Partial<OrganizationForUpdateDTO> WithIsSendAnonymousDataAgreementAccepted(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("sendAnonymousDataAgreementAccepted");
    
    public static Partial<OrganizationForUpdateDTO> WithIsMarketplaceEnabled(this Partial<OrganizationForUpdateDTO> it)
        => it.AddFieldName("marketplaceEnabled");
    
}

