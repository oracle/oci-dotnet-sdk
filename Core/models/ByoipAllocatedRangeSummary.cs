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
    /// A summary of CIDR block subranges that are currently allocated to an IP pool.
    /// </summary>
    public class ByoipAllocatedRangeSummary 
    {
        
        /// <value>
        /// The BYOIP CIDR block range or subrange allocated to an IP pool. This could be all or part of a BYOIP CIDR block.
        /// </value>
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the IP pool containing the CIDR block.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "publicIpPoolId")]
        public string PublicIpPoolId { get; set; }
        
    }
}
