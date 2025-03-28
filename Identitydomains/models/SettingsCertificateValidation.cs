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
    /// Certificate Validation Config
    /// <br/>
    /// **Added In:** 2010242156
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - caseExact: false
    ///  - multiValued: false
    ///  - mutability: readWrite
    ///  - required: false
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class SettingsCertificateValidation 
    {
        
        /// <value>
        /// CRL is enabled Configuration
        /// <br/>
        /// **Added In:** 2010242156
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "crlEnabled")]
        public System.Nullable<bool> CrlEnabled { get; set; }
        
        /// <value>
        /// Use CRL as Fallback.
        /// <br/>
        /// **Added In:** 2010242156
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "crlCheckOnOCSPFailureEnabled")]
        public System.Nullable<bool> CrlCheckOnOCSPFailureEnabled { get; set; }
        
        /// <value>
        /// CRL Location.
        /// <br/>
        /// **Added In:** 2010242156
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "crlLocation")]
        public string CrlLocation { get; set; }
        
        /// <value>
        /// The CRL refresh interval in minutes
        /// <br/>
        /// **Added In:** 2010242156
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "crlRefreshInterval")]
        public System.Nullable<int> CrlRefreshInterval { get; set; }
        
        /// <value>
        /// OCSP is enabled Configuration
        /// <br/>
        /// **Added In:** 2010242156
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "ocspEnabled")]
        public System.Nullable<bool> OcspEnabled { get; set; }
        
        /// <value>
        /// OCSP Accept unknown response status from ocsp responder.
        /// <br/>
        /// **Added In:** 2010242156
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "ocspUnknownResponseStatusAllowed")]
        public System.Nullable<bool> OcspUnknownResponseStatusAllowed { get; set; }
        
        /// <value>
        /// OCSP Responder URL
        /// <br/>
        /// **Added In:** 2010242156
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "ocspResponderURL")]
        public string OcspResponderURL { get; set; }
        
        /// <value>
        /// This setting says, OCSP Responder URL present in the issued certificate must be used. Otherwise, OCSP Responder URL from IDP or Settings.
        /// <br/>
        /// **Added In:** 2010242156
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "ocspSettingsResponderURLPreferred")]
        public System.Nullable<bool> OcspSettingsResponderURLPreferred { get; set; }
        
        /// <value>
        /// The OCSP Timeout duration in minutes
        /// <br/>
        /// **Added In:** 2010242156
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 10
        ///  - idcsMinValue: 1
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "ocspTimeoutDuration")]
        public System.Nullable<int> OcspTimeoutDuration { get; set; }
        
        /// <value>
        /// OCSP Signing Certificate Alias
        /// <br/>
        /// **Added In:** 2010242156
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "ocspSigningCertificateAlias")]
        public string OcspSigningCertificateAlias { get; set; }
        
    }
}
