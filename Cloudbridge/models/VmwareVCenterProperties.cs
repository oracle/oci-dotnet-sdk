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


namespace Oci.CloudbridgeService.Models
{
    /// <summary>
    /// VMware vCenter related properties.
    /// </summary>
    public class VmwareVCenterProperties 
    {
        
        /// <value>
        /// vCenter unique key.
        /// </value>
        [JsonProperty(PropertyName = "vcenterKey")]
        public string VcenterKey { get; set; }
        
        /// <value>
        /// Dot-separated version string.
        /// </value>
        [JsonProperty(PropertyName = "vcenterVersion")]
        public string VcenterVersion { get; set; }
        
        /// <value>
        /// Data center name.
        /// </value>
        [JsonProperty(PropertyName = "dataCenter")]
        public string DataCenter { get; set; }
        
    }
}
