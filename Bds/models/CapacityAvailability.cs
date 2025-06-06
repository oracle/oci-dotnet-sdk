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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Information about the available capacity for a shape.
    /// </summary>
    public class CapacityAvailability 
    {
        
        /// <value>
        /// A flag denoting whether capacity is available.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityStatus is required.")]
        [JsonProperty(PropertyName = "availabilityStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AvailabilityStatus> AvailabilityStatus { get; set; }
        
        /// <value>
        /// The total number of new cluster nodes that can be created with the specified shape configuration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailableCount is required.")]
        [JsonProperty(PropertyName = "availableCount")]
        public System.Nullable<long> AvailableCount { get; set; }
        
    }
}
