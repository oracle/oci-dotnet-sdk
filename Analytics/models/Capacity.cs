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


namespace Oci.AnalyticsService.Models
{
    /// <summary>
    /// Service instance capacity metadata (e.g.: OLPU count, number of users, ...etc...).
    /// 
    /// </summary>
    public class Capacity 
    {
        
        /// <value>
        /// The capacity model to use.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CapacityType is required.")]
        [JsonProperty(PropertyName = "capacityType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CapacityType> CapacityType { get; set; }
        
        /// <value>
        /// The capacity value selected (OLPU count, number of users, ...etc...). This parameter affects the
        /// number of CPUs, amount of memory or other resources allocated to the instance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CapacityValue is required.")]
        [JsonProperty(PropertyName = "capacityValue")]
        public System.Nullable<int> CapacityValue { get; set; }
        
    }
}
