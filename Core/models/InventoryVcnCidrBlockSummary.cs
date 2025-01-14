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
    /// Lists the CIDRs and utilization within a VCN.
    /// 
    /// </summary>
    public class InventoryVcnCidrBlockSummary 
    {
        
        /// <value>
        /// The CIDR prefix within a VCN.
        /// </value>
        [JsonProperty(PropertyName = "ipCidrBlock")]
        public string IpCidrBlock { get; set; }
        
        /// <value>
        /// The CIDR utilization of a VCN.
        /// </value>
        [JsonProperty(PropertyName = "utilization")]
        public System.Nullable<float> Utilization { get; set; }
        
    }
}
