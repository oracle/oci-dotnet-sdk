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


namespace Oci.CapacitymanagementService.Models
{
    /// <summary>
    /// Details about the associated capacity requests against which the resources were provisioned by oracle.
    /// 
    /// </summary>
    public class AssociatedCapacityRequestDetails 
    {
        
        /// <value>
        /// The OCID of the capacity request against which the resources were provisioned.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OccCapacityRequestId is required.")]
        [JsonProperty(PropertyName = "occCapacityRequestId")]
        public string OccCapacityRequestId { get; set; }
        
        /// <value>
        /// The total quantity of the bare metal hardware that was made available corresponding to the capacity request ocid.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HandoverQuantity is required.")]
        [JsonProperty(PropertyName = "handoverQuantity")]
        public System.Nullable<long> HandoverQuantity { get; set; }
        
    }
}
