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


namespace Oci.SecurityattributeService.Models
{
    /// <summary>
    /// Details of the security attribute to be updated for a specific security attribute namespace.
    /// 
    /// </summary>
    public class UpdateSecurityAttributeDetails 
    {
        
        /// <value>
        /// The description of the security attribute during creation.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Whether the security attribute is retired.
        /// See [Managing Security Attributes](https://docs.cloud.oracle.com/Content/zero-trust-packet-routing/managing-security-attributes.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRetired")]
        public System.Nullable<bool> IsRetired { get; set; }
        
        [JsonProperty(PropertyName = "validator")]
        public BaseSecurityAttributeValidator Validator { get; set; }
        
    }
}
