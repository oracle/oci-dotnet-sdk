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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Usage data per filesystem.
    /// </summary>
    public class StorageUsageTrendAggregation 
    {
        
        /// <value>
        /// Name of filesystem.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FileSystemName is required.")]
        [JsonProperty(PropertyName = "fileSystemName")]
        public string FileSystemName { get; set; }
        
        /// <value>
        /// Mount points are specialized NTFS filesystem objects.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MountPoint is required.")]
        [JsonProperty(PropertyName = "mountPoint")]
        public string MountPoint { get; set; }
        
        /// <value>
        /// Size of filesystem.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FileSystemSizeInGBs is required.")]
        [JsonProperty(PropertyName = "fileSystemSizeInGBs")]
        public System.Double FileSystemSizeInGBs { get; set; }
        
        /// <value>
        /// List of usage data samples for a filesystem.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageData is required.")]
        [JsonProperty(PropertyName = "usageData")]
        public System.Collections.Generic.List<StorageUsageTrend> UsageData { get; set; }
        
    }
}
