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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The shape configuration for an instance. The shape configuration determines
    /// the resources allocated to an instance.
    /// 
    /// </summary>
    public class InstanceShapeConfig 
    {
        
        /// <value>
        /// The total number of OCPUs available to the instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<float> Ocpus { get; set; }
        
        /// <value>
        /// The total amount of memory available to the instance, in gigabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<float> MemoryInGBs { get; set; }
                ///
        /// <value>
        /// The baseline OCPU utilization for a subcore burstable VM instance. Leave this attribute blank for a
        /// non-burstable instance, or explicitly specify non-burstable with `BASELINE_1_1`.
        /// <br/>
        /// The following values are supported:
        /// - `BASELINE_1_8` - baseline usage is 1/8 of an OCPU.
        /// - `BASELINE_1_2` - baseline usage is 1/2 of an OCPU.
        /// - `BASELINE_1_1` - baseline usage is the entire OCPU. This represents a non-burstable instance.
        /// 
        /// </value>
        ///
        public enum BaselineOcpuUtilizationEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "BASELINE_1_8")]
            Baseline18,
            [EnumMember(Value = "BASELINE_1_2")]
            Baseline12,
            [EnumMember(Value = "BASELINE_1_1")]
            Baseline11
        };

        /// <value>
        /// The baseline OCPU utilization for a subcore burstable VM instance. Leave this attribute blank for a
        /// non-burstable instance, or explicitly specify non-burstable with `BASELINE_1_1`.
        /// <br/>
        /// The following values are supported:
        /// - `BASELINE_1_8` - baseline usage is 1/8 of an OCPU.
        /// - `BASELINE_1_2` - baseline usage is 1/2 of an OCPU.
        /// - `BASELINE_1_1` - baseline usage is the entire OCPU. This represents a non-burstable instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "baselineOcpuUtilization")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BaselineOcpuUtilizationEnum> BaselineOcpuUtilization { get; set; }
        
        /// <value>
        /// A short description of the instance's processor (CPU).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "processorDescription")]
        public string ProcessorDescription { get; set; }
        
        /// <value>
        /// The networking bandwidth available to the instance, in gigabits per second.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "networkingBandwidthInGbps")]
        public System.Nullable<float> NetworkingBandwidthInGbps { get; set; }
        
        /// <value>
        /// The maximum number of VNIC attachments for the instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxVnicAttachments")]
        public System.Nullable<int> MaxVnicAttachments { get; set; }
        
        /// <value>
        /// The number of GPUs available to the instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gpus")]
        public System.Nullable<int> Gpus { get; set; }
        
        /// <value>
        /// A short description of the instance's graphics processing unit (GPU).
        /// <br/>
        /// If the instance does not have any GPUs, this field is `null`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gpuDescription")]
        public string GpuDescription { get; set; }
        
        /// <value>
        /// The number of local disks available to the instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localDisks")]
        public System.Nullable<int> LocalDisks { get; set; }
        
        /// <value>
        /// The aggregate size of all local disks, in gigabytes.
        /// <br/>
        /// If the instance does not have any local disks, this field is `null`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localDisksTotalSizeInGBs")]
        public System.Nullable<float> LocalDisksTotalSizeInGBs { get; set; }
        
        /// <value>
        /// A short description of the local disks available to this instance.
        /// <br/>
        /// If the instance does not have any local disks, this field is `null`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localDiskDescription")]
        public string LocalDiskDescription { get; set; }
        
        /// <value>
        /// The total number of VCPUs available to the instance. This can be used instead of OCPUs,
        /// in which case the actual number of OCPUs will be calculated based on this value
        /// and the actual hardware. This must be a multiple of 2.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcpus")]
        public System.Nullable<int> Vcpus { get; set; }
        
    }
}
