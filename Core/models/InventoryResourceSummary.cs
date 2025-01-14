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
    /// Lists resources and its properties under a given subnet.
    /// </summary>
    public class InventoryResourceSummary 
    {
        
        /// <value>
        /// The name of the resource created.
        /// </value>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
                ///
        /// <value>
        /// Resource types of the resource.
        /// </value>
        ///
        public enum ResourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "Resource")]
            Resource
        };

        /// <value>
        /// Resource types of the resource.
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceTypeEnum> ResourceType { get; set; }
        
        /// <value>
        /// Lists the 'IpAddressCollection' object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipAddressCollection")]
        public System.Collections.Generic.List<InventoryIpAddressSummary> IpAddressCollection { get; set; }
        
        /// <value>
        /// The region name of the corresponding resource.
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
    }
}
