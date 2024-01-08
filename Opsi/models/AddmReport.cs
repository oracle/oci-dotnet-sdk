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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// ADDM Tasks.
    /// </summary>
    public class AddmReport 
    {
        
        /// <value>
        /// The start timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalStart is required.")]
        [JsonProperty(PropertyName = "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }
        
        /// <value>
        /// The end timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalEnd is required.")]
        [JsonProperty(PropertyName = "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
        
        /// <value>
        /// TASK_ID in the oracle database view DBA_ADDM_TASKS
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskIdentifier is required.")]
        [JsonProperty(PropertyName = "taskIdentifier")]
        public string TaskIdentifier { get; set; }
        
        /// <value>
        /// Internal id of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseIdentifier is required.")]
        [JsonProperty(PropertyName = "databaseIdentifier")]
        public string DatabaseIdentifier { get; set; }
        
        /// <value>
        /// AWR snapshot id.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SnapshotIntervalStart is required.")]
        [JsonProperty(PropertyName = "snapshotIntervalStart")]
        public string SnapshotIntervalStart { get; set; }
        
        /// <value>
        /// AWR snapshot id.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SnapshotIntervalEnd is required.")]
        [JsonProperty(PropertyName = "snapshotIntervalEnd")]
        public string SnapshotIntervalEnd { get; set; }
        
        /// <value>
        /// The complete ADDM report
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AddmReportProp is required.")]
        [JsonProperty(PropertyName = "addmReport")]
        public string AddmReportProp { get; set; }
        
    }
}
