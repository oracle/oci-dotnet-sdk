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
    /// Input arguments for running a query synchronosly and streaming the results as soon as they become available.
    /// 
    /// </summary>
    public class ExportDetails 
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
        /// Query to perform.
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
        /// List of filters to be applied when the query executes. More than one filter per field is not permitted. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scopeFilters")]
        public System.Collections.Generic.List<ScopeFilter> ScopeFilters { get; set; }
        
        /// <value>
        /// Maximum number of results retrieved from data source is determined by the specific query used and the maxTotalCount input field.
        /// If the export results can be streamed, the maximum will be 1,000,000. 
        /// If the results cannot be streamed, the maximum limit is 500 for queries that include the link command
        /// and 10,000 for the queries that does not include the link command. 
        /// <br/>
        /// Queries that include certain commands such as head, tail or stats cannot be streamed and are subject to a maximum of 10,000 results.
        /// Queries that include the sort command cannot be streamed unless the sort fields are restricted to id and/or time.
        /// The maximum number of results retrieved is the lesser of the maxTotalCount input provided and the applicable limit described above.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxTotalCount")]
        public System.Nullable<int> MaxTotalCount { get; set; }
        
        [JsonProperty(PropertyName = "timeFilter")]
        public TimeRange TimeFilter { get; set; }
        
        /// <value>
        /// Amount of time, in seconds, allowed for a query to execute. If this time expires before the query is complete, any partial results will be returned.
        /// </value>
        [JsonProperty(PropertyName = "queryTimeoutInSeconds")]
        public System.Nullable<int> QueryTimeoutInSeconds { get; set; }
        
        /// <value>
        /// Include columns in response
        /// </value>
        [JsonProperty(PropertyName = "shouldIncludeColumns")]
        public System.Nullable<bool> ShouldIncludeColumns { get; set; }
                ///
        /// <value>
        /// Specifies the format for the returned results.
        /// </value>
        ///
        public enum OutputFormatEnum {
            [EnumMember(Value = "CSV")]
            Csv,
            [EnumMember(Value = "JSON")]
            Json
        };

        /// <value>
        /// Specifies the format for the returned results.
        /// </value>
        [JsonProperty(PropertyName = "outputFormat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OutputFormatEnum> OutputFormat { get; set; }
        
        /// <value>
        /// Localize results, including header columns, List-Of-Values and timestamp values.
        /// </value>
        [JsonProperty(PropertyName = "shouldLocalize")]
        public System.Nullable<bool> ShouldLocalize { get; set; }
        
        /// <value>
        /// Controls if query should ignore pre-calculated results if available and only use raw data.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shouldUseAcceleration")]
        public System.Nullable<bool> ShouldUseAcceleration { get; set; }
        
    }
}
