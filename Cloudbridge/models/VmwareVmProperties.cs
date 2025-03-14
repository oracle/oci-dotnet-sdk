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


namespace Oci.CloudbridgeService.Models
{
    /// <summary>
    /// VMware virtual machine related properties.
    /// </summary>
    public class VmwareVmProperties 
    {
        
        /// <value>
        /// Cluster name.
        /// </value>
        [JsonProperty(PropertyName = "cluster")]
        public string Cluster { get; set; }
        
        /// <value>
        /// Customer fields.
        /// </value>
        [JsonProperty(PropertyName = "customerFields")]
        public System.Collections.Generic.List<string> CustomerFields { get; set; }
        
        /// <value>
        /// Customer defined tags.
        /// </value>
        [JsonProperty(PropertyName = "customerTags")]
        public System.Collections.Generic.List<CustomerTag> CustomerTags { get; set; }
        
        /// <value>
        /// vCenter-specific identifier of the virtual machine.
        /// </value>
        [JsonProperty(PropertyName = "instanceUuid")]
        public string InstanceUuid { get; set; }
        
        /// <value>
        /// Path directory of the asset.
        /// </value>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <value>
        /// VMware tools status.
        /// </value>
        [JsonProperty(PropertyName = "vmwareToolsStatus")]
        public string VmwareToolsStatus { get; set; }
        
        /// <value>
        /// Whether changed block tracking for this VM's disk is active.
        /// </value>
        [JsonProperty(PropertyName = "isDisksUuidEnabled")]
        public System.Nullable<bool> IsDisksUuidEnabled { get; set; }
        
        /// <value>
        /// Indicates that change tracking is supported for virtual disks of this virtual machine.
        /// However, even if change tracking is supported, it might not be available for all disks of the virtual machine.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDisksCbtEnabled")]
        public System.Nullable<bool> IsDisksCbtEnabled { get; set; }
        
        /// <value>
        /// Fault tolerance state.
        /// </value>
        [JsonProperty(PropertyName = "faultToleranceState")]
        public string FaultToleranceState { get; set; }
        
        /// <value>
        /// Fault tolerance bandwidth.
        /// </value>
        [JsonProperty(PropertyName = "faultToleranceBandwidth")]
        public System.Nullable<int> FaultToleranceBandwidth { get; set; }
        
        /// <value>
        /// Fault tolerance to secondary latency.
        /// </value>
        [JsonProperty(PropertyName = "faultToleranceSecondaryLatency")]
        public System.Nullable<int> FaultToleranceSecondaryLatency { get; set; }
        
    }
}
