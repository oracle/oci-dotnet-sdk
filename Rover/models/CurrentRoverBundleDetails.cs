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


namespace Oci.RoverService.Models
{
    /// <summary>
    /// Information required to list all available valid rover bundle versions that can be upgraded based on current bundle version.
    /// </summary>
    public class CurrentRoverBundleDetails 
    {
        
        /// <value>
        /// The version of current rover bundle on customer's roverNode or roverCluster device.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrentRoverBundleVersion is required.")]
        [JsonProperty(PropertyName = "currentRoverBundleVersion")]
        public string CurrentRoverBundleVersion { get; set; }
        
    }
}
