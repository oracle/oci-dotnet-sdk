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
    /// A compute instance shape that can be used in {@link #launchInstance(LaunchInstanceRequest) launchInstance}.
    /// For more information, see [Overview of the Compute Service](https://docs.cloud.oracle.com/iaas/Content/Compute/Concepts/computeoverview.htm) and
    /// [Compute Shapes](https://docs.cloud.oracle.com/iaas/Content/Compute/References/computeshapes.htm).
    /// 
    /// </summary>
    public class Shape 
    {
                ///
        ///
        public enum BaselineOcpuUtilizationsEnum {
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
        /// For a subcore burstable VM, the supported baseline OCPU utilization for instances that use this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "baselineOcpuUtilizations", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<BaselineOcpuUtilizationsEnum> BaselineOcpuUtilizations { get; set; }
        
        /// <value>
        /// For a subcore burstable VM, the minimum total baseline OCPUs required. The total baseline OCPUs is equal to
        /// baselineOcpuUtilization chosen multiplied by the number of OCPUs chosen.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "minTotalBaselineOcpusRequired")]
        public System.Nullable<decimal> MinTotalBaselineOcpusRequired { get; set; }
        
        /// <value>
        /// The name of the shape. You can enumerate all available shapes by calling
        /// {@link #listShapes(ListShapesRequest) listShapes}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeProp is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string ShapeProp { get; set; }
        
        /// <value>
        /// A short description of the shape's processor (CPU).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "processorDescription")]
        public string ProcessorDescription { get; set; }
        
        /// <value>
        /// The default number of OCPUs available for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<float> Ocpus { get; set; }
        
        /// <value>
        /// The default amount of memory available for this shape, in gigabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<float> MemoryInGBs { get; set; }
        
        /// <value>
        /// The number of physical network interface card (NIC) ports available for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "networkPorts")]
        public System.Nullable<int> NetworkPorts { get; set; }
        
        /// <value>
        /// The networking bandwidth available for this shape, in gigabits per second.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "networkingBandwidthInGbps")]
        public System.Nullable<float> NetworkingBandwidthInGbps { get; set; }
        
        /// <value>
        /// The maximum number of VNIC attachments available for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxVnicAttachments")]
        public System.Nullable<int> MaxVnicAttachments { get; set; }
        
        /// <value>
        /// The number of GPUs available for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gpus")]
        public System.Nullable<int> Gpus { get; set; }
        
        /// <value>
        /// A short description of the graphics processing unit (GPU) available for this shape.
        /// <br/>
        /// If the shape does not have any GPUs, this field is `null`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gpuDescription")]
        public string GpuDescription { get; set; }
        
        /// <value>
        /// The number of local disks available for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localDisks")]
        public System.Nullable<int> LocalDisks { get; set; }
        
        /// <value>
        /// The aggregate size of the local disks available for this shape, in gigabytes.
        /// <br/>
        /// If the shape does not have any local disks, this field is `null`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localDisksTotalSizeInGBs")]
        public System.Nullable<float> LocalDisksTotalSizeInGBs { get; set; }
        
        /// <value>
        /// A short description of the local disks available for this shape.
        /// <br/>
        /// If the shape does not have any local disks, this field is `null`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localDiskDescription")]
        public string LocalDiskDescription { get; set; }
        
        /// <value>
        /// The number of networking ports available for the remote direct memory access (RDMA) network between nodes in
        /// a high performance computing (HPC) cluster network. If the shape does not support cluster networks, this
        /// value is `0`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rdmaPorts")]
        public System.Nullable<int> RdmaPorts { get; set; }
        
        /// <value>
        /// The networking bandwidth available for the remote direct memory access (RDMA) network for this shape, in
        /// gigabits per second.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rdmaBandwidthInGbps")]
        public System.Nullable<int> RdmaBandwidthInGbps { get; set; }
        
        /// <value>
        /// Whether live migration is supported for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLiveMigrationSupported")]
        public System.Nullable<bool> IsLiveMigrationSupported { get; set; }
        
        [JsonProperty(PropertyName = "ocpuOptions")]
        public ShapeOcpuOptions OcpuOptions { get; set; }
        
        [JsonProperty(PropertyName = "memoryOptions")]
        public ShapeMemoryOptions MemoryOptions { get; set; }
        
        [JsonProperty(PropertyName = "networkingBandwidthOptions")]
        public ShapeNetworkingBandwidthOptions NetworkingBandwidthOptions { get; set; }
        
        [JsonProperty(PropertyName = "maxVnicAttachmentOptions")]
        public ShapeMaxVnicAttachmentOptions MaxVnicAttachmentOptions { get; set; }
        
        [JsonProperty(PropertyName = "platformConfigOptions")]
        public ShapePlatformConfigOptions PlatformConfigOptions { get; set; }
        
        /// <value>
        /// Whether billing continues when the instances that use this shape are in the stopped state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isBilledForStoppedInstance")]
        public System.Nullable<bool> IsBilledForStoppedInstance { get; set; }
                ///
        /// <value>
        /// How instances that use this shape are charged.
        /// 
        /// </value>
        ///
        public enum BillingTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ALWAYS_FREE")]
            AlwaysFree,
            [EnumMember(Value = "LIMITED_FREE")]
            LimitedFree,
            [EnumMember(Value = "PAID")]
            Paid
        };

        /// <value>
        /// How instances that use this shape are charged.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "billingType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BillingTypeEnum> BillingType { get; set; }
        
        /// <value>
        /// The list of of compartment quotas for the shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "quotaNames")]
        public System.Collections.Generic.List<string> QuotaNames { get; set; }
        
        /// <value>
        /// Whether the shape supports creating subcore or burstable instances. A [burstable instance](https://docs.cloud.oracle.com/iaas/Content/Compute/References/burstable-instances.htm)
        /// is a virtual machine (VM) instance that provides a baseline level of CPU performance with the ability to burst to a higher level to support occasional
        /// spikes in usage.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSubcore")]
        public System.Nullable<bool> IsSubcore { get; set; }
        
        /// <value>
        /// Whether the shape supports creating flexible instances. A [flexible shape](https://docs.cloud.oracle.com/iaas/Content/Compute/References/computeshapes.htm#flexible)
        /// is a shape that lets you customize the number of OCPUs and the amount of memory when launching or resizing your instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isFlexible")]
        public System.Nullable<bool> IsFlexible { get; set; }
        
        /// <value>
        /// The list of compatible shapes that this shape can be changed to. For more information,
        /// see [Changing the Shape of an Instance](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/resizinginstances.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resizeCompatibleShapes")]
        public System.Collections.Generic.List<string> ResizeCompatibleShapes { get; set; }
        
        /// <value>
        /// The list of shapes and shape details (if applicable) that Oracle recommends that you use as an alternative to the current shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recommendedAlternatives")]
        public System.Collections.Generic.List<ShapeAlternativeObject> RecommendedAlternatives { get; set; }
        
    }
}
