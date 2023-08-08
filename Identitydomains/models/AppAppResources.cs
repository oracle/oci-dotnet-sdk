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
    /// A list of AppResources of this App.
    /// <br/>
    /// **Added In:** 19.2.1
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - caseExact: true
    ///  - idcsCompositeKey: [value]
    ///  - idcsSearchable: true
    ///  - multiValued: true
    ///  - mutability: readWrite
    ///  - required: false
    ///  - returned: default
    ///  - type: complex
    /// </summary>
    public class AppAppResources 
    {
        
        /// <value>
        /// The id of an AppResource of this App.
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
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
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// The URI of an AppResource of this App.
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: reference
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "$ref")]
        public string Ref { get; set; }
        
    }
}
