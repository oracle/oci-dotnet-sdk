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
    /// A collection of Localized canonical values.
    /// </summary>
    public class SchemaLocalizedCanonicalValues 
    {
        
        /// <value>
        /// Localized display value
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Canonical values
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "canonicalValue")]
        public System.Collections.Generic.List<string> CanonicalValue { get; set; }
        
        /// <value>
        /// Locale used
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }
        
    }
}