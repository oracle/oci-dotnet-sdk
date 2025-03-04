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
    /// Describes association information for an Elastic IP address (IPv4).
    /// </summary>
    public class InstanceNetworkInterfaceAssociation 
    {
        
        /// <value>
        /// The carrier IP address associated with the network interface.
        /// </value>
        [JsonProperty(PropertyName = "carrierIp")]
        public string CarrierIp { get; set; }
        
        /// <value>
        /// The customer-owned IP address associated with the network interface.
        /// </value>
        [JsonProperty(PropertyName = "customerOwnedIp")]
        public string CustomerOwnedIp { get; set; }
        
        /// <value>
        /// The ID of the owner of the Elastic IP address.
        /// </value>
        [JsonProperty(PropertyName = "ipOwnerKey")]
        public string IpOwnerKey { get; set; }
        
        /// <value>
        /// The public DNS name.
        /// </value>
        [JsonProperty(PropertyName = "publicDnsName")]
        public string PublicDnsName { get; set; }
        
        /// <value>
        /// The public IP address or Elastic IP address bound to the network interface.
        /// </value>
        [JsonProperty(PropertyName = "publicIp")]
        public string PublicIp { get; set; }
        
    }
}
