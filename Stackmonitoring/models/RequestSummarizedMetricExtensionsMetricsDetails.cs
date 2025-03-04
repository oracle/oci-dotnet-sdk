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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Filtering criteria data to be specified in the request. Either metricExtensionId or compartmentId must be passed even when no other filter property is passed.
    /// </summary>
    public class RequestSummarizedMetricExtensionsMetricsDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of Metric Extension resource
        /// </value>
        [JsonProperty(PropertyName = "metricExtensionId")]
        public string MetricExtensionId { get; set; }
        
        /// <value>
        /// Resource type to which Metric Extension applies
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Filter for metric extension resources which contain the given metric name
        /// </value>
        [JsonProperty(PropertyName = "containsMetricWithName")]
        public string ContainsMetricWithName { get; set; }
                ///
        /// <value>
        /// Result will ne sorted by this parameter value
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "COUNT")]
            Count
        };

        /// <value>
        /// Result will ne sorted by this parameter value
        /// </value>
        [JsonProperty(PropertyName = "sortBy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortByEnum> SortBy { get; set; }
                ///
        /// <value>
        /// Sort orders
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// Sort orders
        /// </value>
        [JsonProperty(PropertyName = "sortOrder")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
    }
}
