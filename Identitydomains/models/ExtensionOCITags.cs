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
    /// OCI Tags.
    /// </summary>
    public class ExtensionOCITags 
    {
        
        /// <value>
        /// OCI Freeform Tags
        /// <br/>
        /// **Added In:** 2011192329
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [key, value]
        ///  - idcsSearchable: true
        ///  - type: complex
        ///  - required: false
        ///  - mutability: readWrite
        ///  - returned: default
        ///  - multiValued: true
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.List<FreeformTags> FreeformTags { get; set; }
        
        /// <value>
        /// OCI Defined Tags
        /// <br/>
        /// **Added In:** 2011192329
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [namespace, key, value]
        ///  - type: complex
        ///  - idcsSearchable: true
        ///  - required: false
        ///  - mutability: readWrite
        ///  - multiValued: true
        ///  - returned: default
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.List<DefinedTags> DefinedTags { get; set; }
        
        /// <value>
        /// OCI Tag slug
        /// <br/>
        /// **Added In:** 2011192329
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - type: binary
        ///  - mutability: readOnly
        ///  - returned: request
        /// </value>
        [JsonProperty(PropertyName = "tagSlug")]
        public System.Object TagSlug { get; set; }
        
    }
}