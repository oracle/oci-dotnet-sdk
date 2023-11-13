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
    /// Self Registration Profile
    /// </summary>
    public class SelfRegistrationProfile 
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
        /// Name of the profile
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
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
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// **SCIM++ Properties:**
        /// - caseExact: false
        /// - idcsSearchable: true
        /// - multiValued: false
        /// - mutability: readWrite
        /// - required: true
        /// - returned: default
        /// - type: boolean
        /// - uniqueness: none
        /// A Boolean value that indicates whether Account verification email is required to be sent before login or not 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActivationEmailRequired is required.")]
        [JsonProperty(PropertyName = "activationEmailRequired")]
        public System.Nullable<bool> ActivationEmailRequired { get; set; }
        
        /// <value>
        /// Number of days redirect URL is valid
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumberOfDaysRedirectUrlIsValid is required.")]
        [JsonProperty(PropertyName = "numberOfDaysRedirectUrlIsValid")]
        public System.Nullable<int> NumberOfDaysRedirectUrlIsValid { get; set; }
        
        /// <value>
        /// A Boolean value that indicates whether the profile is enabled or not
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
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
        /// A Boolean value that indicates whether the profile should be displayed on login page
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShowOnLoginPage is required.")]
        [JsonProperty(PropertyName = "showOnLoginPage")]
        public System.Nullable<bool> ShowOnLoginPage { get; set; }
        
        /// <value>
        /// A Multivalue String value for Email domains which are valid for this profile
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "allowedEmailDomains")]
        public System.Collections.Generic.List<string> AllowedEmailDomains { get; set; }
        
        /// <value>
        /// A Multivalue String Value for Email domains to be handled as exceptions
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "disallowedEmailDomains")]
        public System.Collections.Generic.List<string> DisallowedEmailDomains { get; set; }
        
        /// <value>
        /// Reference to header logo
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: reference
        /// </value>
        [JsonProperty(PropertyName = "headerLogo")]
        public string HeaderLogo { get; set; }
        
        /// <value>
        /// References to footer logo
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: reference
        /// </value>
        [JsonProperty(PropertyName = "footerLogo")]
        public string FooterLogo { get; set; }
        
        /// <value>
        /// This URL will be replaced in email notification sent to user. When activation email required is set to true, user is created in \\\"pending verification\\\" state, upon clicking this link user will be able to activate himself. When activation email required is set to false, user is created in \\\"verified\\\" state, this link will be used to verify user's email.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RedirectUrl is required.")]
        [JsonProperty(PropertyName = "redirectUrl")]
        public string RedirectUrl { get; set; }
        
        /// <value>
        /// A boolean value that indicates whether the consent text is present.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConsentTextPresent is required.")]
        [JsonProperty(PropertyName = "consentTextPresent")]
        public System.Nullable<bool> ConsentTextPresent { get; set; }
        
        /// <value>
        /// Registration page name
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [locale]
        ///  - idcsMultiLanguage: true
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public System.Collections.Generic.List<SelfRegistrationProfileDisplayName> DisplayName { get; set; }
        
        /// <value>
        /// Text to be displayed on UI after doing self registration
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [locale]
        ///  - idcsMultiLanguage: true
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "afterSubmitText")]
        public System.Collections.Generic.List<SelfRegistrationProfileAfterSubmitText> AfterSubmitText { get; set; }
        
        /// <value>
        /// **SCIM++ Properties:**
        /// - idcsCompositeKey: [value]
        /// - idcsSearchable: true
        /// - multiValued: true
        /// - mutability: readWrite
        /// - required: false
        /// - returned: default
        /// - type: complex
        /// - uniqueness: none
        /// User Attributes 
        /// </value>
        [JsonProperty(PropertyName = "userAttributes")]
        public System.Collections.Generic.List<SelfRegistrationProfileUserAttributes> UserAttributes { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EmailTemplate is required.")]
        [JsonProperty(PropertyName = "emailTemplate")]
        public SelfRegistrationProfileEmailTemplate EmailTemplate { get; set; }
        
        /// <value>
        /// Default groups assigned to the user
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value]
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: request
        ///  - type: complex
        /// </value>
        [JsonProperty(PropertyName = "defaultGroups")]
        public System.Collections.Generic.List<SelfRegistrationProfileDefaultGroups> DefaultGroups { get; set; }
        
        /// <value>
        /// Header text
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [locale]
        ///  - idcsMultiLanguage: true
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "headerText")]
        public System.Collections.Generic.List<SelfRegistrationProfileHeaderText> HeaderText { get; set; }
        
        /// <value>
        /// Footer text
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [locale]
        ///  - idcsMultiLanguage: true
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "footerText")]
        public System.Collections.Generic.List<SelfRegistrationProfileFooterText> FooterText { get; set; }
        
        /// <value>
        /// Consent text
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [locale]
        ///  - idcsMultiLanguage: true
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "consentText")]
        public System.Collections.Generic.List<SelfRegistrationProfileConsentText> ConsentText { get; set; }
        
    }
}