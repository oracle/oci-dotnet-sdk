/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// Details of resource usage by an Operations Insights Warehouse resource.
    /// </summary>
    public class SummarizeOperationsInsightsWarehouseResourceUsageAggregation 
    {
        
        /// <value>
        /// OPSI Warehouse OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Number of OCPUs used by OPSI Warehouse ADW. Can be fractional.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cpuUsed")]
        public System.Double CpuUsed { get; set; }
        
        /// <value>
        /// Storage by OPSI Warehouse ADW in GB.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "storageUsedInGBs")]
        public System.Double StorageUsedInGBs { get; set; }
        
        /// <value>
        /// Possible lifecycle states
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationsInsightsWarehouseLifecycleState> LifecycleState { get; set; }
        
    }
}
