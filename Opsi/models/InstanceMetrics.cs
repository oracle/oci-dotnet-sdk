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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Object containing instance metrics.
    /// </summary>
    public class InstanceMetrics 
    {
        
        /// <value>
        /// The hostname of the database insight resource.
        /// </value>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// The instance name of the database insight resource.
        /// </value>
        [JsonProperty(PropertyName = "instanceName")]
        public string InstanceName { get; set; }
        
        /// <value>
        /// Total amount used of the resource metric type (CPU, STORAGE).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "usage")]
        public System.Double Usage { get; set; }
        
        /// <value>
        /// The maximum allocated amount of the resource metric type  (CPU, STORAGE) for a set of databases.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "capacity")]
        public System.Double Capacity { get; set; }
        
        /// <value>
        /// The maximum host CPUs (cores x threads/core) on the underlying infrastructure. This only applies to CPU and does not not apply for Autonomous Databases.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalHostCapacity")]
        public System.Double TotalHostCapacity { get; set; }
        
        /// <value>
        /// Resource utilization in percentage
        /// </value>
        [JsonProperty(PropertyName = "utilizationPercent")]
        public System.Double UtilizationPercent { get; set; }
        
        /// <value>
        /// Change in resource utilization in percentage
        /// </value>
        [JsonProperty(PropertyName = "usageChangePercent")]
        public System.Double UsageChangePercent { get; set; }
        
    }
}
