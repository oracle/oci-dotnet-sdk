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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Description of the VM target environment.
    /// </summary>
    public class VmTargetEnvironment : TargetEnvironment
    {
        
        /// <value>
        /// Availability Domain of the VM configuration.
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// Fault domain of the VM configuration.
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// OCID of the VM configuration VCN.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Vcn is required.")]
        [JsonProperty(PropertyName = "vcn")]
        public string Vcn { get; set; }
        
        /// <value>
        /// OCID of the VM configuration subnet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Subnet is required.")]
        [JsonProperty(PropertyName = "subnet")]
        public string Subnet { get; set; }
        
        /// <value>
        /// OCID of the dedicated VM configuration host.
        /// </value>
        [JsonProperty(PropertyName = "dedicatedVmHost")]
        public string DedicatedVmHost { get; set; }
        
        /// <value>
        /// Microsoft license for the VM configuration.
        /// </value>
        [JsonProperty(PropertyName = "msLicense")]
        public string MsLicense { get; set; }
        
        /// <value>
        /// Preferred VM shape type provided by the customer.
        /// </value>
        [JsonProperty(PropertyName = "preferredShapeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VmTargetAsset.PreferredShapeTypeEnum> PreferredShapeType { get; set; }
        
        [JsonProperty(PropertyName = "targetEnvironmentType")]
        private readonly string targetEnvironmentType = "VM_TARGET_ENV";
    }
}
