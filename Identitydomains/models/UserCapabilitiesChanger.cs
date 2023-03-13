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
    /// User Capabilities Changer
    /// </summary>
    public class UserCapabilitiesChanger 
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
        /// Indicates weather a user can use api keys
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
        [JsonProperty(PropertyName = "canUseApiKeys")]
        public System.Nullable<bool> CanUseApiKeys { get; set; }
        
        /// <value>
        /// Indicates weather a user can use auth tokens
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
        [JsonProperty(PropertyName = "canUseAuthTokens")]
        public System.Nullable<bool> CanUseAuthTokens { get; set; }
        
        /// <value>
        /// Indicates weather a user can use console password
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
        [JsonProperty(PropertyName = "canUseConsolePassword")]
        public System.Nullable<bool> CanUseConsolePassword { get; set; }
        
        /// <value>
        /// Indicates weather a user can use customer secret keys
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
        [JsonProperty(PropertyName = "canUseCustomerSecretKeys")]
        public System.Nullable<bool> CanUseCustomerSecretKeys { get; set; }
        
        /// <value>
        /// Indicates weather a user can use oauth2 client credentials
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
        [JsonProperty(PropertyName = "canUseOAuth2ClientCredentials")]
        public System.Nullable<bool> CanUseOAuth2ClientCredentials { get; set; }
        
        /// <value>
        /// Indicates weather a user can use smtp credentials
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
        [JsonProperty(PropertyName = "canUseSmtpCredentials")]
        public System.Nullable<bool> CanUseSmtpCredentials { get; set; }
        
        /// <value>
        /// Indicates weather a user can use db credentials
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
        [JsonProperty(PropertyName = "canUseDbCredentials")]
        public System.Nullable<bool> CanUseDbCredentials { get; set; }
        
        [JsonProperty(PropertyName = "urn:ietf:params:scim:schemas:oracle:idcs:extension:selfChange:User")]
        public ExtensionSelfChangeUser UrnIetfParamsScimSchemasOracleIdcsExtensionSelfChangeUser { get; set; }
        
    }
}
