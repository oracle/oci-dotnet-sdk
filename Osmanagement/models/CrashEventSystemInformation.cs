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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// Detailed information about system at the time of the crash.
    /// </summary>
    public class CrashEventSystemInformation 
    {
        
        /// <value>
        /// system architecture
        /// </value>
        [JsonProperty(PropertyName = "architecture")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ArchTypes> Architecture { get; set; }
        
        /// <value>
        /// Active ksplice kernel version (uptrack-uname -r)
        /// </value>
        [JsonProperty(PropertyName = "kspliceEffectiveKernelVersion")]
        public string KspliceEffectiveKernelVersion { get; set; }
        
        /// <value>
        /// The Operating System type of the managed instance.
        /// </value>
        [JsonProperty(PropertyName = "osFamily")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OsFamilies> OsFamily { get; set; }
        
        /// <value>
        /// Operating System Name (OCA value)
        /// </value>
        [JsonProperty(PropertyName = "osName")]
        public string OsName { get; set; }
        
        /// <value>
        /// Operating System Kernel Release (uname -v)
        /// </value>
        [JsonProperty(PropertyName = "osKernelRelease")]
        public string OsKernelRelease { get; set; }
        
        /// <value>
        /// Operating System Kernel Version (uname -r)
        /// </value>
        [JsonProperty(PropertyName = "osKernelVersion")]
        public string OsKernelVersion { get; set; }
        
        /// <value>
        /// Version of the OS (VERSION from /etc/os-release)
        /// </value>
        [JsonProperty(PropertyName = "osSystemVersion")]
        public string OsSystemVersion { get; set; }
        
    }
}
