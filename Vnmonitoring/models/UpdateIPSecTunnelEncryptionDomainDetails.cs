/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Request to update a multi-encryption domain policy on the IPSec tunnel.
    /// There can't be more than 50 security associations in use at one time. See [Encryption domain for policy-based
    /// tunnels](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/ipsecencryptiondomains.htm#spi_policy_based_tunnel) for more.
    /// 
    /// </summary>
    public class UpdateIPSecTunnelEncryptionDomainDetails 
    {
        
        /// <value>
        /// Lists IPv4 or IPv6-enabled subnets in your Oracle tenancy.
        /// </value>
        [JsonProperty(PropertyName = "oracleTrafficSelector")]
        public System.Collections.Generic.List<string> OracleTrafficSelector { get; set; }
        
        /// <value>
        /// Lists IPv4 or IPv6-enabled subnets in your on-premises network.
        /// </value>
        [JsonProperty(PropertyName = "cpeTrafficSelector")]
        public System.Collections.Generic.List<string> CpeTrafficSelector { get; set; }
        
    }
}
