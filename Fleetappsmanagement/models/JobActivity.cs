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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Activity details including status corresponding to an Action Group.
    /// </summary>
    public class JobActivity 
    {
        
        /// <value>
        /// Unique activity id at the action group level.
        /// In most cases, this would be a generated ActionGroupId.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Status of the Job at Action Group Level.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<JobStatus> Status { get; set; }
        
        /// <value>
        /// The time the execution for the Action Group started. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time the execution for the Action Group ended. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// OCID of the runbook associated with the Action Group.
        /// </value>
        [JsonProperty(PropertyName = "runbookId")]
        public string RunbookId { get; set; }
        
        /// <value>
        /// Name of the runbook associated with the Action Group.
        /// </value>
        [JsonProperty(PropertyName = "runbookName")]
        public string RunbookName { get; set; }
        
        /// <value>
        /// A description of the Job Activity status.
        /// If there are any errors, this can also include a short error message.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// List of Resource executions associated with the Action Group.
        /// </value>
        [JsonProperty(PropertyName = "resourceLevelExecutions")]
        public System.Collections.Generic.List<EntityExecutionDetails> ResourceLevelExecutions { get; set; }
        
    }
}
