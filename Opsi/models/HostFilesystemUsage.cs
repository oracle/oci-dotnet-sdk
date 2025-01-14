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
    /// Filesystem Usage metric for the host.
    /// 
    /// </summary>
    public class HostFilesystemUsage : HostPerformanceMetricGroup
    {
        
        /// <value>
        /// Mount points are specialized NTFS filesystem objects
        /// </value>
        [JsonProperty(PropertyName = "mountPoint")]
        public string MountPoint { get; set; }
        
        [JsonProperty(PropertyName = "fileSystemUsageInGB")]
        public System.Double FileSystemUsageInGB { get; set; }
        
        [JsonProperty(PropertyName = "fileSystemAvailInPercent")]
        public System.Double FileSystemAvailInPercent { get; set; }
        
        [JsonProperty(PropertyName = "fileSystemAvailInGBs")]
        public System.Double FileSystemAvailInGBs { get; set; }
        
        [JsonProperty(PropertyName = "metricName")]
        private readonly string metricName = "HOST_FILESYSTEM_USAGE";
    }
}
