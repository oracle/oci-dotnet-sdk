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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Progress details of a Migration Job.
    /// 
    /// </summary>
    public class MigrationJobProgressResource 
    {
        
        /// <value>
        /// Current status of the job.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrentStatus is required.")]
        [JsonProperty(PropertyName = "currentStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<JobPhaseStatus> CurrentStatus { get; set; }
        
        /// <value>
        /// Current phase of the job.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrentPhase is required.")]
        [JsonProperty(PropertyName = "currentPhase")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OdmsJobPhases> CurrentPhase { get; set; }
        
        /// <value>
        /// List of phase status for the job.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Phases is required.")]
        [JsonProperty(PropertyName = "phases")]
        public System.Collections.Generic.List<PhaseStatus> Phases { get; set; }
        
    }
}
