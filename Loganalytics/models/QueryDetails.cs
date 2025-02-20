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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Input arguments for running a log anlaytics query. If the request is set to run in asynchronous mode
    /// then shouldIncludeColumns and shouldIncludeFields can be overwritten when retrieving the results.
    /// 
    /// </summary>
    public class QueryDetails 
    {
        
        /// <value>
        /// Compartment Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Flag to search all child compartments of the compartment Id specified in the compartmentId query parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// Saved search OCID for this query if known.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "savedSearchId")]
        public string SavedSearchId { get; set; }
        
        /// <value>
        /// Query to perform. Must conform to logging analytic querylanguage syntax. Syntax errors will be returned if present.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "QueryString is required.")]
        [JsonProperty(PropertyName = "queryString")]
        public string QueryString { get; set; }
        
        /// <value>
        /// Default subsystem to qualify fields with in the queryString if not specified.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubSystem is required.")]
        [JsonProperty(PropertyName = "subSystem")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SubSystemName> SubSystem { get; set; }
        
        /// <value>
        /// Maximum number of results to count.  Note a maximum of 2001 will be enforced; that is, actualMaxTotalCountUsed = Math.min(maxTotalCount, 2001).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxTotalCount")]
        public System.Nullable<int> MaxTotalCount { get; set; }
        
        [JsonProperty(PropertyName = "timeFilter")]
        public TimeRange TimeFilter { get; set; }
        
        /// <value>
        /// List of filters to be applied when the query executes. More than one filter per field is not permitted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scopeFilters")]
        public System.Collections.Generic.List<ScopeFilter> ScopeFilters { get; set; }
        
        /// <value>
        /// Amount of time, in seconds, allowed for a query to execute. If this time expires before the query is complete, any partial results will be returned.
        /// </value>
        [JsonProperty(PropertyName = "queryTimeoutInSeconds")]
        public System.Nullable<int> QueryTimeoutInSeconds { get; set; }
        
        /// <value>
        /// Option to run the query asynchronously. This will lead to a LogAnalyticsQueryJobWorkRequest being submitted and the {workRequestId} will be returned to use for fetching the results.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shouldRunAsync")]
        public System.Nullable<bool> ShouldRunAsync { get; set; }
        
        /// <value>
        /// Execution mode for the query if running asynchronously i.e (shouldRunAsync is set to true).
        /// </value>
        [JsonProperty(PropertyName = "asyncMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JobMode> AsyncMode { get; set; }
        
        /// <value>
        /// Include the total number of results from the query. Note, this value will always be equal to or less than maxTotalCount.
        /// </value>
        [JsonProperty(PropertyName = "shouldIncludeTotalCount")]
        public System.Nullable<bool> ShouldIncludeTotalCount { get; set; }
        
        /// <value>
        /// Include columns in response
        /// </value>
        [JsonProperty(PropertyName = "shouldIncludeColumns")]
        public System.Nullable<bool> ShouldIncludeColumns { get; set; }
        
        /// <value>
        /// Include fields in response
        /// </value>
        [JsonProperty(PropertyName = "shouldIncludeFields")]
        public System.Nullable<bool> ShouldIncludeFields { get; set; }
        
        /// <value>
        /// Controls if query should ignore pre-calculated results if available and only use raw data. If set and no acceleration data is found it will fallback to raw data.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shouldUseAcceleration")]
        public System.Nullable<bool> ShouldUseAcceleration { get; set; }
        
    }
}
