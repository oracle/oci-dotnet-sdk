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
    /// ADDM summary for a database
    /// </summary>
    public class AddmDbSummary 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseDetails is required.")]
        [JsonProperty(PropertyName = "databaseDetails")]
        public DatabaseDetails DatabaseDetails { get; set; }
        
        /// <value>
        /// Number of ADDM findings
        /// </value>
        [JsonProperty(PropertyName = "numberOfFindings")]
        public System.Nullable<int> NumberOfFindings { get; set; }
        
        /// <value>
        /// Number of ADDM tasks
        /// </value>
        [JsonProperty(PropertyName = "numberOfAddmTasks")]
        public System.Nullable<int> NumberOfAddmTasks { get; set; }
        
        /// <value>
        /// The start timestamp that was passed into the request.
        /// </value>
        [JsonProperty(PropertyName = "timeFirstSnapshotBegin")]
        public System.Nullable<System.DateTime> TimeFirstSnapshotBegin { get; set; }
        
        /// <value>
        /// The end timestamp that was passed into the request.
        /// </value>
        [JsonProperty(PropertyName = "timeLatestSnapshotEnd")]
        public System.Nullable<System.DateTime> TimeLatestSnapshotEnd { get; set; }
        
        /// <value>
        /// AWR snapshot id.
        /// </value>
        [JsonProperty(PropertyName = "snapshotIntervalStart")]
        public string SnapshotIntervalStart { get; set; }
        
        /// <value>
        /// AWR snapshot id.
        /// </value>
        [JsonProperty(PropertyName = "snapshotIntervalEnd")]
        public string SnapshotIntervalEnd { get; set; }
        
        /// <value>
        /// Maximum overall impact in terms of percentage of total activity
        /// </value>
        [JsonProperty(PropertyName = "maxOverallImpact")]
        public System.Double MaxOverallImpact { get; set; }
        
        /// <value>
        /// Category name
        /// </value>
        [JsonProperty(PropertyName = "mostFrequentCategoryName")]
        public string MostFrequentCategoryName { get; set; }
        
        /// <value>
        /// Category display name
        /// </value>
        [JsonProperty(PropertyName = "mostFrequentCategoryDisplayName")]
        public string MostFrequentCategoryDisplayName { get; set; }
        
    }
}
