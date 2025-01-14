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
    /// The IP Inventory CIDR utilization details of a subnet.
    /// </summary>
    public class IpInventoryCidrUtilizationCollection 
    {
        
        /// <value>
        /// Specifies the count for the number of results for the response.
        /// </value>
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<int> Count { get; set; }
        
        /// <value>
        /// The Timestamp of the latest update from the database in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "lastUpdatedTimestamp")]
        public System.Nullable<System.DateTime> LastUpdatedTimestamp { get; set; }
        
        /// <value>
        /// Lists 'IpInventoryCidrUtilizationSummary` object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipInventoryCidrUtilizationSummary")]
        public System.Collections.Generic.List<IpInventoryCidrUtilizationSummary> IpInventoryCidrUtilizationSummary { get; set; }
        
        /// <value>
        /// Indicates the status of the data.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// Compartment of the subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
    }
}
