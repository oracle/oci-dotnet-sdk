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
    /// Compute related properties.
    /// </summary>
    public class ComputeProperties 
    {
        
        /// <value>
        /// Primary IP address of the compute instance.
        /// </value>
        [JsonProperty(PropertyName = "primaryIp")]
        public string PrimaryIp { get; set; }
        
        /// <value>
        /// Fully Qualified DNS Name.
        /// </value>
        [JsonProperty(PropertyName = "dnsName")]
        public string DnsName { get; set; }
        
        /// <value>
        /// Information about the asset.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Number of CPUs.
        /// </value>
        [JsonProperty(PropertyName = "coresCount")]
        public System.Nullable<int> CoresCount { get; set; }
        
        /// <value>
        /// CPU model name.
        /// </value>
        [JsonProperty(PropertyName = "cpuModel")]
        public string CpuModel { get; set; }
        
        /// <value>
        /// Number of GPU devices.
        /// </value>
        [JsonProperty(PropertyName = "gpuDevicesCount")]
        public System.Nullable<int> GpuDevicesCount { get; set; }
        
        /// <value>
        /// List of GPU devices attached to a virtual machine.
        /// </value>
        [JsonProperty(PropertyName = "gpuDevices")]
        public System.Collections.Generic.List<GpuDevice> GpuDevices { get; set; }
        
        /// <value>
        /// Number of threads per core.
        /// </value>
        [JsonProperty(PropertyName = "threadsPerCoreCount")]
        public System.Nullable<int> ThreadsPerCoreCount { get; set; }
        
        /// <value>
        /// Memory size in MBs.
        /// </value>
        [JsonProperty(PropertyName = "memoryInMBs")]
        public System.Nullable<long> MemoryInMBs { get; set; }
        
        /// <value>
        /// Whether Pmem is enabled. Decides if NVDIMMs are used as a permanent memory.
        /// </value>
        [JsonProperty(PropertyName = "isPmemEnabled")]
        public System.Nullable<bool> IsPmemEnabled { get; set; }
        
        /// <value>
        /// Pmem size in MBs.
        /// </value>
        [JsonProperty(PropertyName = "pmemInMBs")]
        public System.Nullable<long> PmemInMBs { get; set; }
        
        /// <value>
        /// Operating system.
        /// </value>
        [JsonProperty(PropertyName = "operatingSystem")]
        public string OperatingSystem { get; set; }
        
        /// <value>
        /// Operating system version.
        /// </value>
        [JsonProperty(PropertyName = "operatingSystemVersion")]
        public string OperatingSystemVersion { get; set; }
        
        /// <value>
        /// Host name of the VM.
        /// </value>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// The current power state of the virtual machine.
        /// </value>
        [JsonProperty(PropertyName = "powerState")]
        public string PowerState { get; set; }
        
        /// <value>
        /// Guest state.
        /// </value>
        [JsonProperty(PropertyName = "guestState")]
        public string GuestState { get; set; }
        
        /// <value>
        /// Whether Trusted Platform Module (TPM) is enabled.
        /// </value>
        [JsonProperty(PropertyName = "isTpmEnabled")]
        public System.Nullable<bool> IsTpmEnabled { get; set; }
        
        /// <value>
        /// Number of connected networks.
        /// </value>
        [JsonProperty(PropertyName = "connectedNetworks")]
        public System.Nullable<int> ConnectedNetworks { get; set; }
        
        /// <value>
        /// Number of network ethernet cards.
        /// </value>
        [JsonProperty(PropertyName = "nicsCount")]
        public System.Nullable<int> NicsCount { get; set; }
        
        /// <value>
        /// List of network ethernet cards attached to a virtual machine.
        /// </value>
        [JsonProperty(PropertyName = "nics")]
        public System.Collections.Generic.List<Nic> Nics { get; set; }
        
        /// <value>
        /// Provision storage size in MBs.
        /// </value>
        [JsonProperty(PropertyName = "storageProvisionedInMBs")]
        public System.Nullable<long> StorageProvisionedInMBs { get; set; }
        
        /// <value>
        /// Number of disks.
        /// </value>
        [JsonProperty(PropertyName = "disksCount")]
        public System.Nullable<int> DisksCount { get; set; }
        
        /// <value>
        /// Lists the set of disks belonging to the virtual machine. This list is unordered.
        /// </value>
        [JsonProperty(PropertyName = "disks")]
        public System.Collections.Generic.List<Disk> Disks { get; set; }
        
        /// <value>
        /// Information about firmware type for this virtual machine.
        /// </value>
        [JsonProperty(PropertyName = "firmware")]
        public string Firmware { get; set; }
        
        /// <value>
        /// Latency sensitivity.
        /// </value>
        [JsonProperty(PropertyName = "latencySensitivity")]
        public string LatencySensitivity { get; set; }
        
        /// <value>
        /// The properties of the NVDIMMs attached to a virtual machine.
        /// </value>
        [JsonProperty(PropertyName = "nvdimms")]
        public System.Collections.Generic.List<Nvdimm> Nvdimms { get; set; }
        
        [JsonProperty(PropertyName = "nvdimmController")]
        public NvdimmController NvdimmController { get; set; }
        
        [JsonProperty(PropertyName = "scsiController")]
        public ScsiController ScsiController { get; set; }
        
        /// <value>
        /// Hardware version.
        /// </value>
        [JsonProperty(PropertyName = "hardwareVersion")]
        public string HardwareVersion { get; set; }
        
    }
}
