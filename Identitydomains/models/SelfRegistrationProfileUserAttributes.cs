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
    /// User Attributes 
    /// </summary>
    public class SelfRegistrationProfileUserAttributes 
    {
        
        /// <value>
        /// name of the attribute
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
        /// **SCIM++ Properties:**
        /// - idcsSearchable: true
        /// - multiValued: false
        /// - mutability: readWrite
        /// - required: false
        /// - returned: default
        /// - type: string
        /// - uniqueness: none
        /// Fully Qualified Attribute Name 
        /// </value>
        [JsonProperty(PropertyName = "fullyQualifiedAttributeName")]
        public string FullyQualifiedAttributeName { get; set; }
        
        /// <value>
        /// **SCIM++ Properties:**
        /// - idcsSearchable: true
        /// - multiValued: false
        /// - mutability: readWrite
        /// - required: true
        /// - returned: default
        /// - type: integer
        /// - uniqueness: none
        /// Sequence Number for the attribute 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SeqNumber is required.")]
        [JsonProperty(PropertyName = "seqNumber")]
        public System.Nullable<int> SeqNumber { get; set; }
        
        /// <value>
        /// If this attribute can be deleted
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "deletable")]
        public System.Nullable<bool> Deletable { get; set; }
        
        /// <value>
        /// Metadata of the user attribute
        /// <br/>
        /// **Added In:** 18.1.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public string Metadata { get; set; }
        
    }
}
