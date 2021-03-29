/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// This is the size and time range of data to be released
    /// </summary>
    public class EstimateReleaseDataSizeResult 
    {
        
        /// <value>
        /// This is the end of the time range of data to be released.  timeDataStarted and timeDataEnded delineate
        /// the time range of the recalled data to be released.  They may not be exact the same as the
        /// parameters in the request input (EstimateReleaseDataSizeDetails).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeDataEnded is required.")]
        [JsonProperty(PropertyName = "timeDataEnded")]
        public System.Nullable<System.DateTime> TimeDataEnded { get; set; }
        
        /// <value>
        /// This is the start of the time range of data to be released
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeDataStarted is required.")]
        [JsonProperty(PropertyName = "timeDataStarted")]
        public System.Nullable<System.DateTime> TimeDataStarted { get; set; }
        
        /// <value>
        /// This is the size in bytes
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SizeInBytes is required.")]
        [JsonProperty(PropertyName = "sizeInBytes")]
        public System.Nullable<long> SizeInBytes { get; set; }
        
    }
}