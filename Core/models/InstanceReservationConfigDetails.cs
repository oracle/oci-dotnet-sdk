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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// A template that contains the settings to use when defining the instance capacity configuration.
    /// 
    /// </summary>
    public class InstanceReservationConfigDetails 
    {
        
        /// <value>
        /// The shape requested when launching instances using reserved capacity.
        /// The shape determines the number of CPUs, amount of memory,
        /// and other resources allocated to the instance.
        /// You can list all available shapes by calling {@link ListComputeCapacityReservationInstanceShapes}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceShape is required.")]
        [JsonProperty(PropertyName = "instanceShape")]
        public string InstanceShape { get; set; }
        
        [JsonProperty(PropertyName = "instanceShapeConfig")]
        public InstanceReservationShapeConfigDetails InstanceShapeConfig { get; set; }
        
        /// <value>
        /// The fault domain to use for instances created using this capacity configuration.
        /// For more information, see [Fault Domains](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/regions.htm#fault).
        /// If you do not specify the fault domain, the capacity is available for an instance
        /// that does not specify a fault domain. To change the fault domain for a reservation,
        /// delete the reservation and create a new one in the preferred fault domain.
        /// <br/>
        /// To retrieve a list of fault domains, use the `ListFaultDomains` operation in
        /// the [Identity and Access Management Service API](https://docs.cloud.oracle.com/iaas/api/#/en/identity/20160918/).
        /// <br/>
        /// Example: FAULT-DOMAIN-1
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        [JsonProperty(PropertyName = "clusterConfig")]
        public ClusterConfigDetails ClusterConfig { get; set; }
        
        /// <value>
        /// The total number of instances that can be launched from the capacity configuration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReservedCount is required.")]
        [JsonProperty(PropertyName = "reservedCount")]
        public System.Nullable<long> ReservedCount { get; set; }
        
        /// <value>
        /// The OCID of the cluster placement group for this instance reservation capacity configuration.
        /// </value>
        [JsonProperty(PropertyName = "clusterPlacementGroupId")]
        public string ClusterPlacementGroupId { get; set; }
        
    }
}
