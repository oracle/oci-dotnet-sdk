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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Optional mutable instance options
    /// </summary>
    public class InstanceOptions 
    {
        
        /// <value>
        /// Whether to disable the legacy (/v1) instance metadata service endpoints.
        /// Customers who have migrated to /v2 should set this to true for added security.
        /// Default is false.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "areLegacyImdsEndpointsDisabled")]
        public System.Nullable<bool> AreLegacyImdsEndpointsDisabled { get; set; }
        
    }
}
