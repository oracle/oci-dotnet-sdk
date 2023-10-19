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


namespace Oci.ComputecloudatcustomerService.Models
{
    /// <summary>
    /// Static routing information for a rack.
    /// </summary>
    public class CccInfrastructureRoutingStaticDetails 
    {
        
        /// <value>
        /// The virtual local area network (VLAN) identifier used to connect to the uplink
        /// (only access mode is supported).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "uplinkVlan")]
        public System.Nullable<int> UplinkVlan { get; set; }
        
        /// <value>
        /// The uplink Hot Standby Router Protocol (HSRP) group value for the switch in the
        /// Compute Cloud@Customer infrastructure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "uplinkHsrpGroup")]
        public System.Nullable<int> UplinkHsrpGroup { get; set; }
        
    }
}