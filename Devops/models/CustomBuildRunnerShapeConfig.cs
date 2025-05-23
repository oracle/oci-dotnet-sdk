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
    /// Specifies the custom build runner shape config.
    /// </summary>
    public class CustomBuildRunnerShapeConfig : BuildRunnerShapeConfig
    {
        
        /// <value>
        /// The total number of OCPUs set for the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ocpus is required.")]
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<int> Ocpus { get; set; }
        
        /// <value>
        /// The total amount of memory set for the instance in gigabytes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MemoryInGBs is required.")]
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<int> MemoryInGBs { get; set; }
        
        [JsonProperty(PropertyName = "buildRunnerType")]
        private readonly string buildRunnerType = "CUSTOM";
    }
}
