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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// Properties for a movable compute instance member of a DR protection group.
    /// </summary>
    public class DrProtectionGroupMemberComputeInstanceMovable : DrProtectionGroupMember
    {
        
        /// <value>
        /// A flag indicating if the compute instance should be moved to the same fault domain in the destination region. 
        /// The compute instance launch will fail if this flag is set to true and capacity is not available in the 
        /// specified fault domain in the destination region.
        /// <br/>
        /// Example: false
        /// </value>
        [JsonProperty(PropertyName = "isRetainFaultDomain")]
        public System.Nullable<bool> IsRetainFaultDomain { get; set; }
        
        /// <value>
        /// The OCID of a capacity reservation in the destination region which will be used to launch
        /// the compute instance.
        /// <br/>
        /// Example: ocid1.capacityreservation.oc1..uniqueID
        /// </value>
        [JsonProperty(PropertyName = "destinationCapacityReservationId")]
        public string DestinationCapacityReservationId { get; set; }
        
        /// <value>
        /// A list of compute instance VNIC mappings.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vnicMappings")]
        public System.Collections.Generic.List<ComputeInstanceMovableVnicMapping> VnicMappings { get; set; }
        
        /// <value>
        /// The OCID of a compartment in the destination region in which the compute instance
        /// should be launched.
        /// <br/>
        /// Example: ocid1.compartment.oc1..uniqueID
        /// </value>
        [JsonProperty(PropertyName = "destinationCompartmentId")]
        public string DestinationCompartmentId { get; set; }
        
        /// <value>
        /// The OCID of a dedicated VM host in the destination region where the compute instance
        /// should be launched.
        /// <br/>
        /// Example: ocid1.dedicatedvmhost.oc1..uniqueID
        /// </value>
        [JsonProperty(PropertyName = "destinationDedicatedVmHostId")]
        public string DestinationDedicatedVmHostId { get; set; }
        
        /// <value>
        /// A list of details of operations performed on file systems.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fileSystemOperations")]
        public System.Collections.Generic.List<ComputeInstanceMovableFileSystemOperation> FileSystemOperations { get; set; }
        
        [JsonProperty(PropertyName = "memberType")]
        private readonly string memberType = "COMPUTE_INSTANCE_MOVABLE";
    }
}
