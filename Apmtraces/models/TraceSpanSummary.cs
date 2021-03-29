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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Trace Span summary object is the summary of the span information for the spans in the span collection
    /// in the trace window that is being queried.
    /// 
    /// </summary>
    public class TraceSpanSummary 
    {
        
        /// <value>
        /// Unique identifier (traceId) for the trace that represents the span set.  Note that this field is
        /// defined as traceKey in the API to comply with OCI API fields naming conventions.  The traceKey maps to
        /// the traceId in the APM repository.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Root span name associated with the trace. This is usually the flow start operation name.
        /// Null if the root span is not yet completed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rootSpanOperationName")]
        public string RootSpanOperationName { get; set; }
        
        /// <value>
        /// Start time of the earliest span in this span collection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEarliestSpanStarted is required.")]
        [JsonProperty(PropertyName = "timeEarliestSpanStarted")]
        public System.Nullable<System.DateTime> TimeEarliestSpanStarted { get; set; }
        
        /// <value>
        /// End time of the span that most recently ended in this span collection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLatestSpanEnded is required.")]
        [JsonProperty(PropertyName = "timeLatestSpanEnded")]
        public System.Nullable<System.DateTime> TimeLatestSpanEnded { get; set; }
        
        /// <value>
        /// The number of spans that have been processed by the system for this trace.  Note that there
        /// could be additional spans that have not been processed or reported yet if the trace is still
        /// in progress.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SpanCount is required.")]
        [JsonProperty(PropertyName = "spanCount")]
        public System.Nullable<int> SpanCount { get; set; }
        
        /// <value>
        /// The number of spans with error that have been processed by the system for this trace.
        /// Note that the number of spans with errors may be less than the total number of actual spans
        /// in this trace.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ErrorSpanCount is required.")]
        [JsonProperty(PropertyName = "errorSpanCount")]
        public System.Nullable<int> ErrorSpanCount { get; set; }
        
        /// <value>
        /// Service associated with this trace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rootSpanServiceName")]
        public string RootSpanServiceName { get; set; }
        
        /// <value>
        /// Start time of the root span for this span collection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeRootSpanStarted")]
        public System.Nullable<System.DateTime> TimeRootSpanStarted { get; set; }
        
        /// <value>
        /// End time of the root span for this span collection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeRootSpanEnded")]
        public System.Nullable<System.DateTime> TimeRootSpanEnded { get; set; }
        
        /// <value>
        /// Time taken for the root span operation to complete in milliseconds.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rootSpanDurationInMs")]
        public System.Nullable<int> RootSpanDurationInMs { get; set; }
        
        /// <value>
        /// Time between the start of the earliest span and the end of the most recent span in milliseconds.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TraceDurationInMs is required.")]
        [JsonProperty(PropertyName = "traceDurationInMs")]
        public System.Nullable<int> TraceDurationInMs { get; set; }
        
        /// <value>
        /// Boolean flag that indicates whether the trace errored out.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsFault is required.")]
        [JsonProperty(PropertyName = "isFault")]
        public System.Nullable<bool> IsFault { get; set; }
        
        /// <value>
        /// The status of the trace.
        /// The trace statuses are defined as follows:
        /// complete \u2013 a root span has been recorded, but there is no information on the errors.
        /// success - a complete root span is recorded there is a successful error type and error code - HTTP 200.
        /// incomplete - the root span has not yet been received.
        /// error - the root span returned with an error. There may or may not be an associated error code or error type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TraceStatus is required.")]
        [JsonProperty(PropertyName = "traceStatus")]
        public string TraceStatus { get; set; }
        
        /// <value>
        /// Error type of the trace.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TraceErrorType is required.")]
        [JsonProperty(PropertyName = "traceErrorType")]
        public string TraceErrorType { get; set; }
        
        /// <value>
        /// Error code of the trace.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TraceErrorCode is required.")]
        [JsonProperty(PropertyName = "traceErrorCode")]
        public string TraceErrorCode { get; set; }
        
        /// <value>
        /// A summary of the spans by service
        /// 
        /// </value>
        [JsonProperty(PropertyName = "serviceSummaries")]
        public System.Collections.Generic.List<TraceServiceSummary> ServiceSummaries { get; set; }
        
    }
}