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


namespace Oci.GenerativeaiService.Models
{
    /// <summary>
    /// The capacity of a hosting type dedicated AI cluster.
    /// </summary>
    public class DedicatedAiClusterHostingCapacity : DedicatedAiClusterCapacity
    {
        
        /// <value>
        /// The total number of endpoints that can be hosted on this dedicated AI cluster.
        /// </value>
        [JsonProperty(PropertyName = "totalEndpointCapacity")]
        public System.Nullable<int> TotalEndpointCapacity { get; set; }
        
        /// <value>
        /// The number of endpoints hosted on this dedicated AI cluster.
        /// </value>
        [JsonProperty(PropertyName = "usedEndpointCapacity")]
        public System.Nullable<int> UsedEndpointCapacity { get; set; }
        
        [JsonProperty(PropertyName = "capacityType")]
        private readonly string capacityType = "HOSTING_CAPACITY";
    }
}
