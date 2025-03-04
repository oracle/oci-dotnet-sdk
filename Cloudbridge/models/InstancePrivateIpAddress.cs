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
    /// Describes a private IPv4 address.
    /// </summary>
    public class InstancePrivateIpAddress 
    {
        
        [JsonProperty(PropertyName = "association")]
        public InstanceNetworkInterfaceAssociation Association { get; set; }
        
        /// <value>
        /// Indicates whether this IPv4 address is the primary private IP address of the network interface.
        /// </value>
        [JsonProperty(PropertyName = "isPrimary")]
        public System.Nullable<bool> IsPrimary { get; set; }
        
        /// <value>
        /// The private IPv4 DNS name.
        /// </value>
        [JsonProperty(PropertyName = "privateDnsName")]
        public string PrivateDnsName { get; set; }
        
        /// <value>
        /// The private IPv4 address of the network interface.
        /// </value>
        [JsonProperty(PropertyName = "privateIpAddress")]
        public string PrivateIpAddress { get; set; }
        
    }
}
