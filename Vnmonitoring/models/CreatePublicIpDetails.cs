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


namespace Oci.VnmonitoringService.Models
{
    
    public class CreatePublicIpDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment to contain the public IP. For ephemeral public IPs,
        /// you must set this to the private IP's compartment [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
                ///
        /// <value>
        /// Defines when the public IP is deleted and released back to the Oracle Cloud
        /// Infrastructure public IP pool. For more information, see
        /// [Public IP Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingpublicIPs.htm).
        /// 
        /// </value>
        ///
        public enum LifetimeEnum {
            [EnumMember(Value = "EPHEMERAL")]
            Ephemeral,
            [EnumMember(Value = "RESERVED")]
            Reserved
        };

        /// <value>
        /// Defines when the public IP is deleted and released back to the Oracle Cloud
        /// Infrastructure public IP pool. For more information, see
        /// [Public IP Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingpublicIPs.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Lifetime is required.")]
        [JsonProperty(PropertyName = "lifetime")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifetimeEnum> Lifetime { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the private IP to assign the public IP to.
        /// <br/>
        /// Required for an ephemeral public IP because it must always be assigned to a private IP
        /// (specifically a *primary* private IP).
        /// <br/>
        /// Optional for a reserved public IP. If you don't provide it, the public IP is created but not
        /// assigned to a private IP. You can later assign the public IP with
        /// {@link #updatePublicIp(UpdatePublicIpRequest) updatePublicIp}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateIpId")]
        public string PrivateIpId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the public IP pool.
        /// </value>
        [JsonProperty(PropertyName = "publicIpPoolId")]
        public string PublicIpPoolId { get; set; }
        
    }
}
