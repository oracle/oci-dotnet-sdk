/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.IdentitydomainsService.Models
{
    /// <summary>
    /// User Account
    /// </summary>
    public class Me 
    {
        
        /// <value>
        /// Unique identifier for the SCIM Resource as defined by the Service Provider. Each representation of the Resource MUST include a non-empty id value. This identifier MUST be unique across the Service Provider's entire set of Resources. It MUST be a stable, non-reassignable identifier that does not change when the same Resource is returned in subsequent requests. The value of the id attribute is always issued by the Service Provider and MUST never be specified by the Service Consumer. bulkId: is a reserved keyword and MUST NOT be used in the unique identifier.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: always
        ///  - type: string
        ///  - uniqueness: global
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique OCI identifier for the SCIM Resource.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: global
        /// </value>
        [JsonProperty(PropertyName = "ocid")]
        public string Ocid { get; set; }
        
        /// <value>
        /// REQUIRED. The schemas attribute is an array of Strings which allows introspection of the supported schema version for a SCIM representation as well any schema extensions supported by that representation. Each String value must be a unique URI. This specification defines URIs for User, Group, and a standard \\\"enterprise\\\" extension. All representations of SCIM schema MUST include a non-zero value array with value(s) of the URIs supported by that representation. Duplicate values MUST NOT be included. Value order is not specified and MUST not impact behavior.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Schemas is required.")]
        [JsonProperty(PropertyName = "schemas")]
        public System.Collections.Generic.List<string> Schemas { get; set; }
        
        [JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }
        
        [JsonProperty(PropertyName = "idcsCreatedBy")]
        public IdcsCreatedBy IdcsCreatedBy { get; set; }
        
        [JsonProperty(PropertyName = "idcsLastModifiedBy")]
        public IdcsLastModifiedBy IdcsLastModifiedBy { get; set; }
        
        /// <value>
        /// Each value of this attribute specifies an operation that only an internal client may perform on this particular resource.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "idcsPreventedOperations", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<IdcsPreventedOperations> IdcsPreventedOperations { get; set; }
        
        /// <value>
        /// A list of tags on this resource.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [key, value]
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: request
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.List<Tags> Tags { get; set; }
        
        /// <value>
        /// A boolean flag indicating this resource in the process of being deleted. Usually set to true when synchronous deletion of the resource would take too long.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "deleteInProgress")]
        public System.Nullable<bool> DeleteInProgress { get; set; }
        
        /// <value>
        /// The release number when the resource was upgraded.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "idcsLastUpgradedInRelease")]
        public string IdcsLastUpgradedInRelease { get; set; }
        
        /// <value>
        /// OCI Domain Id (ocid) in which the resource lives.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "domainOcid")]
        public string DomainOcid { get; set; }
        
        /// <value>
        /// OCI Compartment Id (ocid) in which the resource lives.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "compartmentOcid")]
        public string CompartmentOcid { get; set; }
        
        /// <value>
        /// OCI Tenant Id (ocid) in which the resource lives.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "tenancyOcid")]
        public string TenancyOcid { get; set; }
        
        /// <value>
        /// An identifier for the Resource as defined by the Service Consumer. The externalId may simplify identification of the Resource between Service Consumer and Service Provider by allowing the Consumer to refer to the Resource with its own identifier, obviating the need to store a local mapping between the local identifier of the Resource and the identifier used by the Service Provider. Each Resource MAY include a non-empty externalId value. The value of the externalId attribute is always issued by the Service Consumer and can never be specified by the Service Provider. The Service Provider MUST always interpret the externalId as scoped to the Service Consumer's tenant.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:External Id]]
        ///  - idcsPii: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }
        
        /// <value>
        /// User name
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: User ID
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:User Name, deprecatedColumnHeaderName:User ID]]
        ///  - idcsPii: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: always
        ///  - type: string
        ///  - uniqueness: global
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserName is required.")]
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        /// <value>
        /// Description of the user
        /// <br/>
        /// **Added In:** 2012271618
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsPii: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Display name
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: Display Name
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Display Name]]
        ///  - idcsPii: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Nick name
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: Nick Name
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Nick Name]]
        ///  - idcsPii: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "nickName")]
        public string NickName { get; set; }
        
        /// <value>
        /// A fully-qualified URL to a page representing the User's online profile
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: Profile URL
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Profile Url]]
        ///  - idcsPii: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: reference
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "profileUrl")]
        public string ProfileUrl { get; set; }
        
        /// <value>
        /// Title
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: Title
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Title]]
        ///  - idcsPii: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
                ///
        /// <value>
        /// Used to identify the organization-to-user relationship
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: User Type
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:User Type]]
        ///  - idcsPii: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum UserTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "Contractor")]
            Contractor,
            [EnumMember(Value = "Employee")]
            Employee,
            [EnumMember(Value = "Intern")]
            Intern,
            [EnumMember(Value = "Temp")]
            Temp,
            [EnumMember(Value = "External")]
            External,
            [EnumMember(Value = "Service")]
            Service,
            [EnumMember(Value = "Generic")]
            Generic
        };

        /// <value>
        /// Used to identify the organization-to-user relationship
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: User Type
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:User Type]]
        ///  - idcsPii: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "userType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UserTypeEnum> UserType { get; set; }
        
        /// <value>
        /// Used to indicate the User's default location for purposes of localizing items such as currency, date and time format, numerical representations, and so on.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: Locale
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Locale]]
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }
        
        /// <value>
        /// User's preferred written or spoken language used for localized user interfaces
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: Preferred Language
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Preferred Language]]
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "preferredLanguage")]
        public string PreferredLanguage { get; set; }
        
        /// <value>
        /// User's timezone
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCanonicalValueSourceFilter: attrName eq \"timezones\" and attrValues.value eq \"$(timezone)\"
        ///  - idcsCanonicalValueSourceResourceType: AllowedValue
        ///  - idcsCsvAttributeName: TimeZone
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Time Zone, deprecatedColumnHeaderName:TimeZone]]
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }
        
        /// <value>
        /// User status
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCsvAttributeName: Active
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Active]]
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "active")]
        public System.Nullable<bool> Active { get; set; }
        
        /// <value>
        /// Password attribute. Max length for password is controlled via Password Policy.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCsvAttributeName: Password
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Password]]
        ///  - idcsPii: true
        ///  - idcsSearchable: false
        ///  - idcsSensitive: hash
        ///  - multiValued: false
        ///  - mutability: writeOnly
        ///  - required: false
        ///  - returned: never
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public MeName Name { get; set; }
        
        /// <value>
        /// A complex attribute representing emails
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value, type]
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Work Email, mapsTo:emails[work].value], [columnHeaderName:Home Email, mapsTo:emails[home].value], [columnHeaderName:Primary Email Type, mapsTo:emails[$(type)].primary], [columnHeaderName:Other Email, mapsTo:emails[other].value], [columnHeaderName:Recovery Email, mapsTo:emails[recovery].value], [columnHeaderName:Work Email Verified, mapsTo:emails[work].verified], [columnHeaderName:Home Email Verified, mapsTo:emails[home].verified], [columnHeaderName:Other Email Verified, mapsTo:emails[other].verified], [columnHeaderName:Recovery Email Verified, mapsTo:emails[recovery].verified]]
        ///  - idcsPii: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "emails")]
        public System.Collections.Generic.List<MeEmails> Emails { get; set; }
        
        /// <value>
        /// Phone numbers
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value, type]
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Work Phone, mapsTo:phoneNumbers[work].value], [columnHeaderName:Mobile No, mapsTo:phoneNumbers[mobile].value], [columnHeaderName:Home Phone, mapsTo:phoneNumbers[home].value], [columnHeaderName:Fax, mapsTo:phoneNumbers[fax].value], [columnHeaderName:Pager, mapsTo:phoneNumbers[pager].value], [columnHeaderName:Other Phone, mapsTo:phoneNumbers[other].value], [columnHeaderName:Recovery Phone, mapsTo:phoneNumbers[recovery].value], [columnHeaderName:Primary Phone Type, mapsTo:phoneNumbers[$(type)].primary]]
        ///  - idcsPii: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "phoneNumbers")]
        public System.Collections.Generic.List<MePhoneNumbers> PhoneNumbers { get; set; }
        
        /// <value>
        /// User's instant messaging addresses
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value, type]
        ///  - idcsPii: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "ims")]
        public System.Collections.Generic.List<MeIms> Ims { get; set; }
        
        /// <value>
        /// URLs of photos for the User
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value, type]
        ///  - idcsPii: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "photos")]
        public System.Collections.Generic.List<MePhotos> Photos { get; set; }
        
        /// <value>
        /// A physical mailing address for this User, as described in (address Element). Canonical Type Values of work, home, and other. The value attribute is a complex type with the following sub-attributes.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [type]
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Work Address Street, deprecatedColumnHeaderName:Work Street Address, mapsTo:addresses[work].streetAddress], [columnHeaderName:Work Address Locality, deprecatedColumnHeaderName:Work City, mapsTo:addresses[work].locality], [columnHeaderName:Work Address Region, deprecatedColumnHeaderName:Work State, mapsTo:addresses[work].region], [columnHeaderName:Work Address Postal Code, deprecatedColumnHeaderName:Work Postal Code, mapsTo:addresses[work].postalCode], [columnHeaderName:Work Address Country, deprecatedColumnHeaderName:Work Country, mapsTo:addresses[work].country], [columnHeaderName:Work Address Formatted, mapsTo:addresses[work].formatted], [columnHeaderName:Home Address Formatted, mapsTo:addresses[home].formatted], [columnHeaderName:Other Address Formatted, mapsTo:addresses[other].formatted], [columnHeaderName:Home Address Street, mapsTo:addresses[home].streetAddress], [columnHeaderName:Other Address Street, mapsTo:addresses[other].streetAddress], [columnHeaderName:Home Address Locality, mapsTo:addresses[home].locality], [columnHeaderName:Other Address Locality, mapsTo:addresses[other].locality], [columnHeaderName:Home Address Region, mapsTo:addresses[home].region], [columnHeaderName:Other Address Region, mapsTo:addresses[other].region], [columnHeaderName:Home Address Country, mapsTo:addresses[home].country], [columnHeaderName:Other Address Country, mapsTo:addresses[other].country], [columnHeaderName:Home Address Postal Code, mapsTo:addresses[home].postalCode], [columnHeaderName:Other Address Postal Code, mapsTo:addresses[other].postalCode], [columnHeaderName:Primary Address Type, mapsTo:addresses[$(type)].primary]]
        ///  - idcsPii: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "addresses")]
        public System.Collections.Generic.List<Addresses> Addresses { get; set; }
        
        /// <value>
        /// A list of groups that the user belongs to, either thorough direct membership, nested groups, or dynamically calculated
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value]
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "groups")]
        public System.Collections.Generic.List<MeGroups> Groups { get; set; }
        
        /// <value>
        /// A list of entitlements for the User that represent a thing the User has.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value, type]
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "entitlements")]
        public System.Collections.Generic.List<MeEntitlements> Entitlements { get; set; }
        
        /// <value>
        /// A list of roles for the User that collectively represent who the User is; e.g., 'Student', 'Faculty'.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value, type]
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "roles")]
        public System.Collections.Generic.List<MeRoles> Roles { get; set; }
        
        /// <value>
        /// A list of certificates issued to the User.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value]
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "x509Certificates")]
        public System.Collections.Generic.List<MeX509Certificates> X509Certificates { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:extension:enterprise:2.0:User")]
        public ExtensionEnterprise20User UrnIetfParamsScimSchemasExtensionEnterprise20User { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:user:User")]
        public ExtensionUserUser UrnIetfParamsScimSchemasOracleIdcsExtensionUserUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:passwordState:User")]
        public ExtensionPasswordStateUser UrnIetfParamsScimSchemasOracleIdcsExtensionPasswordStateUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:userState:User")]
        public ExtensionUserStateUser UrnIetfParamsScimSchemasOracleIdcsExtensionUserStateUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:me:User")]
        public ExtensionMeUser UrnIetfParamsScimSchemasOracleIdcsExtensionMeUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:posix:User")]
        public ExtensionPosixUser UrnIetfParamsScimSchemasOracleIdcsExtensionPosixUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:mfa:User")]
        public ExtensionMfaUser UrnIetfParamsScimSchemasOracleIdcsExtensionMfaUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:securityQuestions:User")]
        public ExtensionSecurityQuestionsUser UrnIetfParamsScimSchemasOracleIdcsExtensionSecurityQuestionsUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:selfRegistration:User")]
        public ExtensionSelfRegistrationUser UrnIetfParamsScimSchemasOracleIdcsExtensionSelfRegistrationUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:termsOfUse:User")]
        public ExtensionTermsOfUseUser UrnIetfParamsScimSchemasOracleIdcsExtensionTermsOfUseUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:OCITags")]
        public ExtensionOCITags UrnIetfParamsScimSchemasOracleIdcsExtensionOciTags { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:userCredentials:User")]
        public ExtensionUserCredentialsUser UrnIetfParamsScimSchemasOracleIdcsExtensionUserCredentialsUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:capabilities:User")]
        public ExtensionCapabilitiesUser UrnIetfParamsScimSchemasOracleIdcsExtensionCapabilitiesUser { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:dbCredentials:User")]
        public ExtensionDbCredentialsUser UrnIetfParamsScimSchemasOracleIdcsExtensionDbCredentialsUser { get; set; }
        
    }
}