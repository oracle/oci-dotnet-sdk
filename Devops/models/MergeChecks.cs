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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Criteria which must be satisfied to merge a pull request.
    /// </summary>
    public class MergeChecks 
    {
        
        /// <value>
        /// Indicates whether or not a pull request must have a successful build run and no queued builds before it can be merged
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LastBuildSucceeded is required.")]
        [JsonProperty(PropertyName = "lastBuildSucceeded")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MergeCheckSettingsValue> LastBuildSucceeded { get; set; }
        
    }
}