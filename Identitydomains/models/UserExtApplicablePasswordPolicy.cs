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
    /// Applicable Password Policy
    /// <br/>
    /// **Added In:** 20.1.3
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - caseExact: false
    ///  - idcsCompositeKey: [value]
    ///  - idcsSearchable: true
    ///  - multiValued: false
    ///  - mutability: readOnly
    ///  - required: false
    ///  - returned: request
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class UserExtApplicablePasswordPolicy 
    {
        
        /// <value>
        /// The identifier of the password policy.
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: true
        ///  - returned: always
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// The URI of the corresponding PasswordPolicy resource.
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: reference
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "$ref")]
        public string Ref { get; set; }
        
        /// <value>
        /// Password Policy Display Name
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "display")]
        public string Display { get; set; }
        
        /// <value>
        /// PasswordPolicy priority
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "priority")]
        public System.Nullable<int> Priority { get; set; }
        
    }
}
