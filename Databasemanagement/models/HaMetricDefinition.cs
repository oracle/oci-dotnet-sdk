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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The metric definition for HA and backup metrics.
    /// </summary>
    public class HaMetricDefinition 
    {
        
        /// <value>
        /// The name of the metric.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricName is required.")]
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }
        
        /// <value>
        /// The metadata qualifiers provided in the definition of the returned metric.
        /// Available metadata vary by metric.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Metadata is required.")]
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }
        
        /// <value>
        /// The dimension qualifiers provided in the definition of the returned metric.
        /// Available dimensions vary by metric namespace. Each dimension takes the form of a key-value pair.
        /// Example: {&quot;resourceId&quot;: &quot;ocid1.instance.region1.phx.exampleuniqueID&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Dimensions is required.")]
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, string> Dimensions { get; set; }
        
        /// <value>
        /// The data point date and time in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timestamp is required.")]
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// The target value of the metric.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public System.Double Value { get; set; }
        
    }
}
