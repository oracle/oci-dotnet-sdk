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
    /// Settings related to the bypass code, such as bypass code length, bypass code expiry, max active bypass codes, and so on
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsSearchable: false
    ///  - multiValued: false
    ///  - mutability: readWrite
    ///  - required: true
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class AuthenticationFactorSettingsBypassCodeSettings 
    {
        
        /// <value>
        /// If true, indicates that self-service bypass code generation is enabled
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
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
        [Required(ErrorMessage = "SelfServiceGenerationEnabled is required.")]
        [JsonProperty(PropertyName = "selfServiceGenerationEnabled")]
        public System.Nullable<bool> SelfServiceGenerationEnabled { get; set; }
        
        /// <value>
        /// If true, indicates that help desk bypass code generation is enabled
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
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
        [Required(ErrorMessage = "HelpDeskGenerationEnabled is required.")]
        [JsonProperty(PropertyName = "helpDeskGenerationEnabled")]
        public System.Nullable<bool> HelpDeskGenerationEnabled { get; set; }
        
        /// <value>
        /// Exact length of the bypass code to be generated
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 20
        ///  - idcsMinValue: 8
        ///  - idcsSearchable: false
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
        [Required(ErrorMessage = "Length is required.")]
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<int> Length { get; set; }
        
        /// <value>
        /// The maximum number of bypass codes that can be issued to any user
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 6
        ///  - idcsMinValue: 1
        ///  - idcsSearchable: false
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
        [Required(ErrorMessage = "MaxActive is required.")]
        [JsonProperty(PropertyName = "maxActive")]
        public System.Nullable<int> MaxActive { get; set; }
        
        /// <value>
        /// Expiry (in minutes) of any bypass code that is generated by the help desk
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 9999999
        ///  - idcsMinValue: 1
        ///  - idcsSearchable: false
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
        [Required(ErrorMessage = "HelpDeskCodeExpiryInMins is required.")]
        [JsonProperty(PropertyName = "helpDeskCodeExpiryInMins")]
        public System.Nullable<int> HelpDeskCodeExpiryInMins { get; set; }
        
        /// <value>
        /// The maximum number of times that any bypass code that is generated by the help desk can be used
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 999
        ///  - idcsMinValue: 1
        ///  - idcsSearchable: false
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
        [Required(ErrorMessage = "HelpDeskMaxUsage is required.")]
        [JsonProperty(PropertyName = "helpDeskMaxUsage")]
        public System.Nullable<int> HelpDeskMaxUsage { get; set; }
        
    }
}
