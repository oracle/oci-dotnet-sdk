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
    /// A complex attribute that indicates a password recovery is locked (blocking any new sessions).
    /// <br/>
    /// **Added In:** 19.1.4
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsSearchable: false
    ///  - multiValued: false
    ///  - mutability: readWrite
    ///  - required: false
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class UserExtRecoveryLocked 
    {
        
        /// <value>
        /// Indicates that the recovery is locked.
        /// <br/>
        /// **Added In:** 19.1.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "on")]
        public System.Nullable<bool> On { get; set; }
        
        /// <value>
        /// The date and time that the current resource was locked.
        /// <br/>
        /// **Added In:** 19.1.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - required: false
        ///  - returned: default
        ///  - type: dateTime
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "lockDate")]
        public string LockDate { get; set; }
        
    }
}
