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
    /// Controls whether a user can update themselves or not via User related APIs
    /// </summary>
    public class ExtensionSelfChangeUser 
    {
        
        /// <value>
        /// If true, allows requesting user to update themselves. If false, requesting user can't update themself (default).
        /// <br/>
        /// **Added In:** 2205182039
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: writeOnly
        ///  - required: false
        ///  - returned: never
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "allowSelfChange")]
        public System.Nullable<bool> AllowSelfChange { get; set; }
        
    }
}
