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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// The count of resources for specified dimension.
    /// </summary>
    public class MonitoredResourcesCountAggregation 
    {
        
        /// <value>
        /// Qualifiers provided in a metric definition. 
        /// Available dimensions vary based on groupBy parameter.
        /// Each dimension takes the form of a key-value pair.
        /// <br/>
        /// Example: &quot;resourceType&quot;: &quot;oci_autonomous_database&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Dimensions is required.")]
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, string> Dimensions { get; set; }
        
        /// <value>
        /// the value of this metric
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Count is required.")]
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<int> Count { get; set; }
        
    }
}
