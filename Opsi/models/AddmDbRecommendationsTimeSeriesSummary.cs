/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// ADDM recommendation
    /// </summary>
    public class AddmDbRecommendationsTimeSeriesSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Database insight.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique ADDM task id
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskId is required.")]
        [JsonProperty(PropertyName = "taskId")]
        public System.Nullable<int> TaskId { get; set; }
        
        /// <value>
        /// ADDM task name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskName is required.")]
        [JsonProperty(PropertyName = "taskName")]
        public string TaskName { get; set; }
        
        /// <value>
        /// Timestamp when recommendation was generated
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timestamp is required.")]
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// Start Timestamp of snapshot
        /// </value>
        [JsonProperty(PropertyName = "timeAnalysisStarted")]
        public System.Nullable<System.DateTime> TimeAnalysisStarted { get; set; }
        
        /// <value>
        /// End Timestamp of snapshot
        /// </value>
        [JsonProperty(PropertyName = "timeAnalysisEnded")]
        public System.Nullable<System.DateTime> TimeAnalysisEnded { get; set; }
        
        /// <value>
        /// Type of recommendation
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// DB time in seconds for the snapshot
        /// </value>
        [JsonProperty(PropertyName = "analysisDbTimeInSecs")]
        public System.Double AnalysisDbTimeInSecs { get; set; }
        
        /// <value>
        /// DB avg active sessions for the snapshot
        /// </value>
        [JsonProperty(PropertyName = "analysisAvgActiveSessions")]
        public System.Double AnalysisAvgActiveSessions { get; set; }
        
        /// <value>
        /// Maximum estimated benefit in terms of percentage of total activity
        /// </value>
        [JsonProperty(PropertyName = "maxBenefitPercent")]
        public System.Double MaxBenefitPercent { get; set; }
        
        /// <value>
        /// Maximum estimated benefit in terms of seconds
        /// </value>
        [JsonProperty(PropertyName = "maxBenefitDbTimeInSecs")]
        public System.Double MaxBenefitDbTimeInSecs { get; set; }
        
        /// <value>
        /// Maximum estimated benefit in terms of average active sessions
        /// </value>
        [JsonProperty(PropertyName = "maxBenefitAvgActiveSessions")]
        public System.Double MaxBenefitAvgActiveSessions { get; set; }
        
        [JsonProperty(PropertyName = "relatedObject")]
        public RelatedObjectTypeDetails RelatedObject { get; set; }
        
    }
}
