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
    /// Assertion To User Mapping
    /// <br/>
    /// **Added In:** 20.1.3
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - caseExact: false
    ///  - idcsCompositeKey: [value]
    ///  - idcsSearchable: false
    ///  - mutability: immutable
    ///  - required: false
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class IdentityProviderJitUserProvAttributes 
    {
        
        /// <value>
        /// Mapped Attribute identifier
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - mutability: immutable
        ///  - required: true
        ///  - returned: default
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
        /// Mapped Attribute URI
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - mutability: immutable
        ///  - required: false
        ///  - returned: default
        ///  - type: reference
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "$ref")]
        public string Ref { get; set; }
        
    }
}
