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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Progress of the Action in execution. If the Exadata Fleet Update Action has not started yet, this will be omitted.
    /// 
    /// </summary>
    public class FsuActionProgressDetails 
    {
        
        /// <value>
        /// Number of targets with jobs in progress.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "inProgressTargets")]
        public System.Nullable<int> InProgressTargets { get; set; }
        
        /// <value>
        /// Number of targets with completed jobs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "completedTargets")]
        public System.Nullable<int> CompletedTargets { get; set; }
        
        /// <value>
        /// Number of targets with failed jobs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "failedTargets")]
        public System.Nullable<int> FailedTargets { get; set; }
        
        /// <value>
        /// Number of targets with jobs waiting for batch to execute or for user to resume.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "waitingTargets")]
        public System.Nullable<int> WaitingTargets { get; set; }
        
        /// <value>
        /// Total number of targets impacted by Exadata Fleet Update Action.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalTargets")]
        public System.Nullable<int> TotalTargets { get; set; }
        
    }
}
