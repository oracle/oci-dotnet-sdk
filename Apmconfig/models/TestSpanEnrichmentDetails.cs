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


namespace Oci.ApmconfigService.Models
{
    /// <summary>
    /// Run a set of span enrichment rules on a given span to see the result.
    /// </summary>
    public class TestSpanEnrichmentDetails : TestDetails
    {
        
        /// <value>
        /// The span enrichment rules to test in the format of an Options resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Options is required.")]
        [JsonProperty(PropertyName = "options")]
        public System.Object Options { get; set; }
        
        /// <value>
        /// A list of filters to try against the given span.
        /// </value>
        [JsonProperty(PropertyName = "filters")]
        public System.Collections.Generic.List<FilterTextOrId> Filters { get; set; }
        
        /// <value>
        /// The span to test the rules on. This should be a valid JSON object that follows one
        /// of the formats used by distributed tracing frameworks, such as OpenTelemetry, Zipkin, or
        /// Oracle Application Performance Monitoring.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Span is required.")]
        [JsonProperty(PropertyName = "span")]
        public System.Object Span { get; set; }
        
        [JsonProperty(PropertyName = "testType")]
        private readonly string testType = "SPAN_ENRICHMENT";
    }
}
