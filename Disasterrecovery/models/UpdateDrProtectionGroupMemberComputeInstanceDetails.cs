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
    /// Deprecated. Update properties for a compute instance member.
    /// </summary>
    public class UpdateDrProtectionGroupMemberComputeInstanceDetails : UpdateDrProtectionGroupMemberDetails
    {
        
        /// <value>
        /// A flag indicating if the compute instance should be moved during DR operations.
        /// <br/>
        /// Example: false
        /// </value>
        [JsonProperty(PropertyName = "isMovable")]
        public System.Nullable<bool> IsMovable { get; set; }
        
        /// <value>
        /// A list of compute instance VNIC mappings.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vnicMapping")]
        public System.Collections.Generic.List<ComputeInstanceVnicMappingDetails> VnicMapping { get; set; }
        
        /// <value>
        /// The OCID of a compartment in the destination region in which the compute instance
        /// should be launched.
        /// <br/>
        /// Example: ocid1.compartment.oc1..uniqueID
        /// </value>
        [JsonProperty(PropertyName = "destinationCompartmentId")]
        public string DestinationCompartmentId { get; set; }
        
        /// <value>
        /// The OCID of a dedicated VM host in the destination region on which the compute instance
        /// should be launched.
        /// <br/>
        /// Example: ocid1.dedicatedvmhost.oc1..uniqueID
        /// </value>
        [JsonProperty(PropertyName = "destinationDedicatedVmHostId")]
        public string DestinationDedicatedVmHostId { get; set; }
        
        [JsonProperty(PropertyName = "memberType")]
        private readonly string memberType = "COMPUTE_INSTANCE";
    }
}
