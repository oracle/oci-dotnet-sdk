/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// A span filter is a named setting that specifies filter criteria to match a subset of the spans.
    /// </summary>
    public class SpanFilter : Config
    {
        
        /// <value>
        /// The name by which this filter can be displayed in the UI.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The string that defines the Span Filter expression.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "filterText")]
        public string FilterText { get; set; }
        
        /// <value>
        /// An optional string that describes what the filter is intended or used for.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "SPAN_FILTER";
    }
}
