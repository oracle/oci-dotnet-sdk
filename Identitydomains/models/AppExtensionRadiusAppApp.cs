/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
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
    /// This extension defines attributes specific to Apps that represent instances of Radius App.
    /// </summary>
    public class AppExtensionRadiusAppApp 
    {
        
        /// <value>
        /// This is the IP address of the RADIUS Client like Oracle Database server. It can be only IP address and not hostname.
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClientIP is required.")]
        [JsonProperty(PropertyName = "clientIP")]
        public string ClientIP { get; set; }
        
        /// <value>
        /// This is the port of RADIUS Proxy which RADIUS client will connect to.
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }
        
        /// <value>
        /// Secret key used to secure communication between RADIUS Proxy and RADIUS client
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecretKey is required.")]
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }
        
        /// <value>
        /// Secret key used to secure communication between RADIUS Proxy and RADIUS client. This will be available only for few releases for an internal migration requirement. Use secretKey attribute instead of this attribute for all other requirements.
        /// <br/>
        /// **Added In:** 2306131901
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - idcsSensitive: encrypt
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: never
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "secretKeyTemporary")]
        public string SecretKeyTemporary { get; set; }
        
        /// <value>
        /// Indicates to include groups in RADIUS response
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: boolean
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IncludeGroupInResponse is required.")]
        [JsonProperty(PropertyName = "includeGroupInResponse")]
        public System.Nullable<bool> IncludeGroupInResponse { get; set; }
        
        /// <value>
        /// If true, capture the client IP address from the RADIUS request packet. IP Address is used for auditing, policy-evaluation and country-code calculation.
        /// <br/>
        /// **Added In:** 2205120021
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        /// </value>
        [JsonProperty(PropertyName = "captureClientIp")]
        public System.Nullable<bool> CaptureClientIp { get; set; }
        
        /// <value>
        /// Value consists of type of RADIUS App. Type can be Oracle Database, VPN etc
        /// <br/>
        /// **Added In:** 2205120021
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "typeOfRadiusApp")]
        public string TypeOfRadiusApp { get; set; }
        
        /// <value>
        /// The name of the attribute that contains the Internet Protocol address of the end-user.
        /// <br/>
        /// **Added In:** 2205120021
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "endUserIPAttribute")]
        public string EndUserIPAttribute { get; set; }
        
        /// <value>
        /// ID used to identify a particular vendor.
        /// <br/>
        /// **Added In:** 2205120021
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "radiusVendorSpecificId")]
        public string RadiusVendorSpecificId { get; set; }
        
        /// <value>
        /// Vendor-specific identifier of the attribute in the RADIUS response that will contain the end-user's country code. This is an integer-value in the range 1 to 255
        /// <br/>
        /// **Added In:** 2205120021
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "countryCodeResponseAttributeId")]
        public string CountryCodeResponseAttributeId { get; set; }
        
        /// <value>
        /// RADIUS attribute that RADIUS-enabled system uses to pass the group membership
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "groupMembershipRadiusAttribute")]
        public string GroupMembershipRadiusAttribute { get; set; }
        
        /// <value>
        /// Configure the responseFormat based on vendor in order to pass it to RADIUS infra
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "responseFormat")]
        public string ResponseFormat { get; set; }
        
        /// <value>
        /// The delimiter used if group membership responseFormat is a delimited list instead of repeating attributes
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "responseFormatDelimiter")]
        public string ResponseFormatDelimiter { get; set; }
        
        /// <value>
        /// Configure the groupNameFormat based on vendor in order to pass it to RADIUS infra
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "groupNameFormat")]
        public string GroupNameFormat { get; set; }
        
        /// <value>
        /// Indicates if password and OTP are passed in the same sign-in request or not.
        /// <br/>
        /// **Added In:** 2205120021
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        /// </value>
        [JsonProperty(PropertyName = "passwordAndOtpTogether")]
        public System.Nullable<bool> PasswordAndOtpTogether { get; set; }
        
        /// <value>
        /// In a successful authentication response, Oracle Identity Cloud Service will pass user's group information restricted to groups persisted in this attribute, in the specified RADIUS attribute.
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value]
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: request
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "groupMembershipToReturn")]
        public System.Collections.Generic.List<AppGroupMembershipToReturn> GroupMembershipToReturn { get; set; }
        
    }
}
