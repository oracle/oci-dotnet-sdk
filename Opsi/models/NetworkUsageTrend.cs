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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Usage data samples.
    /// </summary>
    public class NetworkUsageTrend 
    {
        
        /// <value>
        /// The timestamp in which the current sampling period ends in RFC 3339 format.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EndTimestamp is required.")]
        [JsonProperty(PropertyName = "endTimestamp")]
        public System.Nullable<System.DateTime> EndTimestamp { get; set; }
        
        /// <value>
        /// Network read in Mbps.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AllNetworkReadInMbps is required.")]
        [JsonProperty(PropertyName = "allNetworkReadInMbps")]
        public System.Double AllNetworkReadInMbps { get; set; }
        
        /// <value>
        /// Network write in Mbps.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AllNetworkWriteInMbps is required.")]
        [JsonProperty(PropertyName = "allNetworkWriteInMbps")]
        public System.Double AllNetworkWriteInMbps { get; set; }
        
        /// <value>
        /// Network input/output in Mbps.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AllNetworkIoInMbps is required.")]
        [JsonProperty(PropertyName = "allNetworkIoInMbps")]
        public System.Double AllNetworkIoInMbps { get; set; }
        
    }
}
