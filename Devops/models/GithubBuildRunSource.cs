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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies details of build run through GitHub.
    /// </summary>
    public class GithubBuildRunSource : BuildRunSource
    {
        
        /// <value>
        /// The trigger that invoked the build run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TriggerId is required.")]
        [JsonProperty(PropertyName = "triggerId")]
        public string TriggerId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TriggerInfo is required.")]
        [JsonProperty(PropertyName = "triggerInfo")]
        public TriggerInfo TriggerInfo { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "GITHUB";
    }
}
