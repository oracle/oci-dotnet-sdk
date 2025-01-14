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
    /// Requestable Group
    /// </summary>
    public class ExtensionRequestableGroup 
    {
        
        /// <value>
        /// Flag controlling whether group membership can be request by user through self service console.
        /// <br/>
        /// **Added In:** 17.3.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - idcsCsvAttributeNameMappings: [[columnHeaderName:Requestable, mapsTo:requestable]]
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: request
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "requestable")]
        public System.Nullable<bool> Requestable { get; set; }
        
    }
}
