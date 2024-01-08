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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Details about a node.
    /// </summary>
    public class Node 
    {
        
        /// <value>
        /// The OCID of the underlying Oracle Cloud Infrastructure Compute instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
        
        /// <value>
        /// The name of the node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The state of the node.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "STOPPED")]
            Stopped,
            [EnumMember(Value = "STOPPING")]
            Stopping,
            [EnumMember(Value = "STARTING")]
            Starting
        };

        /// <value>
        /// The state of the node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// Cluster node type.
        /// </value>
        ///
        public enum NodeTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MASTER")]
            Master,
            [EnumMember(Value = "EDGE")]
            Edge,
            [EnumMember(Value = "UTILITY")]
            Utility,
            [EnumMember(Value = "WORKER")]
            Worker,
            [EnumMember(Value = "COMPUTE_ONLY_WORKER")]
            ComputeOnlyWorker,
            [EnumMember(Value = "KAFKA_BROKER")]
            KafkaBroker,
            [EnumMember(Value = "BURSTING")]
            Bursting,
            [EnumMember(Value = "CLOUD_SQL")]
            CloudSql
        };

        /// <value>
        /// Cluster node type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeType is required.")]
        [JsonProperty(PropertyName = "nodeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NodeTypeEnum> NodeType { get; set; }
        
        /// <value>
        /// Shape of the node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The list of block volumes attached to a given node.
        /// </value>
        [JsonProperty(PropertyName = "attachedBlockVolumes")]
        public System.Collections.Generic.List<VolumeAttachmentDetail> AttachedBlockVolumes { get; set; }
        
        /// <value>
        /// The OCID of the subnet in which the node is to be created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// IP address of the node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddress is required.")]
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The fully-qualified hostname (FQDN) of the node.
        /// </value>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The OCID of the image from which the node was created.
        /// </value>
        [JsonProperty(PropertyName = "imageId")]
        public string ImageId { get; set; }
        
        /// <value>
        /// The fingerprint of the SSH key used for node access.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SshFingerprint is required.")]
        [JsonProperty(PropertyName = "sshFingerprint")]
        public string SshFingerprint { get; set; }
        
        /// <value>
        /// The name of the availability domain in which the node is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The name of the fault domain in which the node is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FaultDomain is required.")]
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// The time the node was created, shown as an RFC 3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the cluster was updated, shown as an RFC 3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The total number of OCPUs available to the node.
        /// </value>
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<int> Ocpus { get; set; }
        
        /// <value>
        /// The total amount of memory available to the node, in gigabytes.
        /// </value>
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<int> MemoryInGBs { get; set; }
        
        /// <value>
        /// The number of NVMe drives to be used for storage. A single drive has 6.8 TB available.
        /// </value>
        [JsonProperty(PropertyName = "nvmes")]
        public System.Nullable<int> Nvmes { get; set; }
        
        /// <value>
        /// The aggregate size of all local disks, in gigabytes. If the instance does not have any local disks, this field is null.
        /// </value>
        [JsonProperty(PropertyName = "localDisksTotalSizeInGBs")]
        public System.Double LocalDisksTotalSizeInGBs { get; set; }
        
        /// <value>
        /// The date and time the instance is expected to be stopped / started, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeMaintenanceRebootDue")]
        public System.Nullable<System.DateTime> TimeMaintenanceRebootDue { get; set; }
        
    }
}
