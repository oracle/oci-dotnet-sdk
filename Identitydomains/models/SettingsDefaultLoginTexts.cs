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
    /// Default Login text in different locales
    /// </summary>
    public class SettingsDefaultLoginTexts 
    {
        
        /// <value>
        /// Login text
        /// <br/>
        /// **Added In:** 18.2.2
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - idcsSanitize: true
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Locale
        /// <br/>
        /// **Added In:** 18.2.2
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCanonicalValueSourceFilter: attrName eq \"locales\" and attrValues.value eq \"$(loginTexts.locale)\"
        ///  - idcsCanonicalValueSourceResourceType: AllowedValue
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Locale is required.")]
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }
        
    }
}
