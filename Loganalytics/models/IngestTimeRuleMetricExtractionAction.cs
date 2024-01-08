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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Details of metric to post to OCI Monitoring if ingest time rule condition(s) are satisfied.
    /// 
    /// </summary>
    public class IngestTimeRuleMetricExtractionAction : IngestTimeRuleAction
    {
        
        /// <value>
        /// The compartment OCID (/iaas/Content/General/Concepts/identifiers.htm) of the extracted metric.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The namespace of the extracted metric.
        /// A valid value starts with an alphabetical character and includes only
        /// alphanumeric characters and underscores (_).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// The metric name of the extracted metric.
        /// A valid value starts with an alphabetical character and includes only
        /// alphanumeric characters, periods (.), underscores (_), hyphens (-), and dollar signs ($).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricName is required.")]
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }
        
        /// <value>
        /// The resourceGroup of the extracted metric.
        /// A valid value starts with an alphabetical character and includes only
        /// alphanumeric characters, periods (.), underscores (_), hyphens (-), and dollar signs ($).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }
        
        /// <value>
        /// Additional dimensions to publish for the extracted metric.
        /// A valid list contains the source field names whose values are to be published as dimensions.
        /// The source name itself is specified using a special macro SOURCE_NAME
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.List<string> Dimensions { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "METRIC_EXTRACTION";
    }
}
