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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Content types that the news report can handle.
    /// </summary>
    public class NewsContentTypes 
    {
        
        /// <value>
        /// Supported resources for capacity planning content type.
        /// </value>
        [JsonProperty(PropertyName = "capacityPlanningResources")]
        public System.Collections.Generic.List<NewsContentTypesResource> CapacityPlanningResources { get; set; }
        
        /// <value>
        /// Supported resources for SQL insights - fleet analysis content type.
        /// </value>
        [JsonProperty(PropertyName = "sqlInsightsFleetAnalysisResources")]
        public System.Collections.Generic.List<NewsSqlInsightsContentTypesResource> SqlInsightsFleetAnalysisResources { get; set; }
        
        /// <value>
        /// Supported resources for SQL insights - plan changes content type.
        /// </value>
        [JsonProperty(PropertyName = "sqlInsightsPlanChangesResources")]
        public System.Collections.Generic.List<NewsSqlInsightsContentTypesResource> SqlInsightsPlanChangesResources { get; set; }
        
        /// <value>
        /// Supported resources for SQL insights - top databases content type.
        /// </value>
        [JsonProperty(PropertyName = "sqlInsightsTopDatabasesResources")]
        public System.Collections.Generic.List<NewsSqlInsightsContentTypesResource> SqlInsightsTopDatabasesResources { get; set; }
        
        /// <value>
        /// Supported resources for SQL insights - top SQL by insights content type.
        /// </value>
        [JsonProperty(PropertyName = "sqlInsightsTopSqlByInsightsResources")]
        public System.Collections.Generic.List<NewsSqlInsightsContentTypesResource> SqlInsightsTopSqlByInsightsResources { get; set; }
        
        /// <value>
        /// Supported resources for SQL insights - top SQL content type.
        /// </value>
        [JsonProperty(PropertyName = "sqlInsightsTopSqlResources")]
        public System.Collections.Generic.List<NewsSqlInsightsContentTypesResource> SqlInsightsTopSqlResources { get; set; }
        
        /// <value>
        /// Supported resources for SQL insights - performance degradation content type.
        /// </value>
        [JsonProperty(PropertyName = "sqlInsightsPerformanceDegradationResources")]
        public System.Collections.Generic.List<NewsSqlInsightsContentTypesResource> SqlInsightsPerformanceDegradationResources { get; set; }
        
        /// <value>
        /// Supported resources for actionable insights content type.
        /// </value>
        [JsonProperty(PropertyName = "actionableInsightsResources")]
        public System.Collections.Generic.List<ActionableInsightsContentTypesResource> ActionableInsightsResources { get; set; }
        
    }
}
