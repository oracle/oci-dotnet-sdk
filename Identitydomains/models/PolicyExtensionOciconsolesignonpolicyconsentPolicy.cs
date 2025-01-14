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
    /// This extension defines attributes used to record consent for modification of the \"Security Policy for OCI Console\" sign-on policy, Rule, Condition or ConditionGroup.
    /// </summary>
    public class PolicyExtensionOciconsolesignonpolicyconsentPolicy 
    {
        
        /// <value>
        /// Set to true when an identity domain administrator opts to change the Oracle security defaults for the \"Security Policy for OCI Console\" shipped by Oracle. Defaults to false.
        /// <br/>
        /// **Added In:** 2405220110
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: writeOnly
        ///  - required: false
        ///  - returned: never
        ///  - type: boolean
        /// </value>
        [JsonProperty(PropertyName = "consent")]
        public System.Nullable<bool> Consent { get; set; }
        
        /// <value>
        /// The justification for the change when an identity domain administrator opts to modify the Oracle security defaults for the \"Security Policy for OCI Console\" sign-on policy shipped by Oracle.
        /// <br/>
        /// **Added In:** 2405220110
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: writeOnly
        ///  - required: false
        ///  - returned: never
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "justification")]
        public string Justification { get; set; }
        
        /// <value>
        /// The detailed reason for the change when an identity domain administrator opts to modify the Oracle security defaults for the \"Security Policy for OCI Console\" sign-on policy shipped by Oracle.
        /// <br/>
        /// **Added In:** 2405220110
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: writeOnly
        ///  - required: false
        ///  - returned: never
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
        
    }
}
