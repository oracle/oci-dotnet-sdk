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


namespace Oci.CloudbridgeService.Models
{
    /// <summary>
    /// The assets disk.
    /// </summary>
    public class Disk 
    {
        
        /// <value>
        /// Disk name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Order of boot volumes.
        /// </value>
        [JsonProperty(PropertyName = "bootOrder")]
        public System.Nullable<int> BootOrder { get; set; }
        
        /// <value>
        /// Disk UUID for the virtual disk, if available.
        /// </value>
        [JsonProperty(PropertyName = "uuid")]
        public string Uuid { get; set; }
        
        /// <value>
        /// Disk UUID LUN for the virtual disk, if available.
        /// </value>
        [JsonProperty(PropertyName = "uuidLun")]
        public string UuidLun { get; set; }
        
        /// <value>
        /// The size of the volume in MBs.
        /// </value>
        [JsonProperty(PropertyName = "sizeInMBs")]
        public System.Nullable<long> SizeInMBs { get; set; }
        
        /// <value>
        /// Location of the boot/data volume.
        /// </value>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }
        
        /// <value>
        /// The disk persistent mode.
        /// </value>
        [JsonProperty(PropertyName = "persistentMode")]
        public string PersistentMode { get; set; }
        
        /// <value>
        /// Indicates that CBT (change disk tracking) is enabled for this virtual disk.
        /// </value>
        [JsonProperty(PropertyName = "isCbtEnabled")]
        public System.Nullable<bool> IsCbtEnabled { get; set; }
        
    }
}
