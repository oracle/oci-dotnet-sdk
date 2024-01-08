/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// This extension defines attributes used to manage account passwords within a Service Provider. The extension is typically applied to a User resource, but MAY be applied to other resources that use passwords.
    /// </summary>
    public class ExtensionPasswordStateUser 
    {
        
        /// <value>
        /// A DateTime that specifies the date and time when the current password was set
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: dateTime
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "lastSuccessfulSetDate")]
        public string LastSuccessfulSetDate { get; set; }
        
        /// <value>
        /// Indicates that the current password MAY NOT be changed and all other password expiry settings SHALL be ignored
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "cantChange")]
        public System.Nullable<bool> CantChange { get; set; }
        
        /// <value>
        /// Indicates that the password expiry policy will not be applied for the current Resource
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "cantExpire")]
        public System.Nullable<bool> CantExpire { get; set; }
        
        /// <value>
        /// Indicates that the subject password value MUST change on next login. If not changed, typically the account is locked. The value may be set indirectly when the subject's current password expires or directly set by an administrator.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "mustChange")]
        public System.Nullable<bool> MustChange { get; set; }
        
        /// <value>
        /// Indicates that the password has expired
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "expired")]
        public System.Nullable<bool> Expired { get; set; }
        
        /// <value>
        /// A DateTime that specifies the date and time when last successful password validation was set
        /// <br/>
        /// **Added In:** 2011192329
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: dateTime
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "lastSuccessfulValidationDate")]
        public string LastSuccessfulValidationDate { get; set; }
        
        /// <value>
        /// A DateTime that specifies the date and time when last failed password validation was set
        /// <br/>
        /// **Added In:** 2011192329
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: dateTime
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "lastFailedValidationDate")]
        public string LastFailedValidationDate { get; set; }
        
        [JsonProperty(PropertyName = "applicablePasswordPolicy")]
        public UserExtApplicablePasswordPolicy ApplicablePasswordPolicy { get; set; }
        
    }
}
