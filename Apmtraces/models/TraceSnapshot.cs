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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Definition of a trace snapshot object.
    /// 
    /// </summary>
    public class TraceSnapshot 
    {
        
        /// <value>
        /// Unique identifier (traceId) for the trace that represents the span set.  Note that this field is
        /// defined as traceKey in the API and it maps to the traceId in the trace data in Application Performance
        /// Monitoring.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Start time of the trace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// End time of the trace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// Trace snapshots properties.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "traceSnapshotDetails")]
        public System.Collections.Generic.List<SnapshotDetail> TraceSnapshotDetails { get; set; }
        
        /// <value>
        /// List of spans.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SpanSnapshots is required.")]
        [JsonProperty(PropertyName = "spanSnapshots")]
        public System.Collections.Generic.List<SpanSnapshot> SpanSnapshots { get; set; }
        
    }
}
