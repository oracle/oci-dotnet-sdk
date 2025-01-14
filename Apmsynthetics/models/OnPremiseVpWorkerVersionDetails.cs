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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Image version details of the On-premise VP worker.
    /// </summary>
    public class OnPremiseVpWorkerVersionDetails 
    {
        
        /// <value>
        /// Current image version of the On-premise VP worker.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// Minimum supported image version of the On-premise VP worker.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MinSupportedVersion is required.")]
        [JsonProperty(PropertyName = "minSupportedVersion")]
        public string MinSupportedVersion { get; set; }
        
        /// <value>
        /// Latest image version of the On-premise VP worker.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LatestVersion is required.")]
        [JsonProperty(PropertyName = "latestVersion")]
        public string LatestVersion { get; set; }
        
    }
}
