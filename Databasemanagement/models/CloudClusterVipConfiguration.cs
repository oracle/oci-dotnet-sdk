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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of the Virtual IP (VIP) address for a node in a cloud cluster.
    /// </summary>
    public class CloudClusterVipConfiguration 
    {
        
        /// <value>
        /// The name of the node with the VIP.
        /// </value>
        [JsonProperty(PropertyName = "nodeName")]
        public string NodeName { get; set; }
        
        /// <value>
        /// The VIP name or IP address.
        /// </value>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
        
        /// <value>
        /// The network number from which VIPs are obtained.
        /// </value>
        [JsonProperty(PropertyName = "networkNumber")]
        public System.Nullable<int> NetworkNumber { get; set; }
        
    }
}
