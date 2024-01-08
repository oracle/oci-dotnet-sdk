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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Attributes of fleet's export status.
    /// </summary>
    public class ExportStatus 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the fleet.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FleetId is required.")]
        [JsonProperty(PropertyName = "fleetId")]
        public string FleetId { get; set; }
        
        /// <value>
        /// The date and time of the last export run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastRun is required.")]
        [JsonProperty(PropertyName = "timeLastRun")]
        public System.Nullable<System.DateTime> TimeLastRun { get; set; }
        
        /// <value>
        /// The date and time of the next export run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeNextRun is required.")]
        [JsonProperty(PropertyName = "timeNextRun")]
        public System.Nullable<System.DateTime> TimeNextRun { get; set; }
        
        /// <value>
        /// The status of the latest export run.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LatestRunStatus is required.")]
        [JsonProperty(PropertyName = "latestRunStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExportRunStatus> LatestRunStatus { get; set; }
        
    }
}
