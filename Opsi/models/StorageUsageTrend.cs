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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Usage data samples.
    /// </summary>
    public class StorageUsageTrend 
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
        /// Filesystem usage in GB.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FileSystemUsageInGBs is required.")]
        [JsonProperty(PropertyName = "fileSystemUsageInGBs")]
        public System.Double FileSystemUsageInGBs { get; set; }
        
        /// <value>
        /// Filesystem available in percent.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FileSystemAvailInPercent is required.")]
        [JsonProperty(PropertyName = "fileSystemAvailInPercent")]
        public System.Double FileSystemAvailInPercent { get; set; }
        
    }
}
