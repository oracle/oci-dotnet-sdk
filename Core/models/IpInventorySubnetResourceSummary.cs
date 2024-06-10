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
    /// Provides the IP Inventory details of a subnet and its associated resources.
    /// 
    /// </summary>
    public class IpInventorySubnetResourceSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the IP address.
        /// </value>
        [JsonProperty(PropertyName = "ipId")]
        public string IpId { get; set; }
        
        /// <value>
        /// Lists the allocated private IP address.
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
                ///
        /// <value>
        /// Lifetime of the allocated private IP address.
        /// </value>
        ///
        public enum IpAddressLifetimeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "Ephemeral")]
            Ephemeral,
            [EnumMember(Value = "Reserved")]
            Reserved
        };

        /// <value>
        /// Lifetime of the allocated private IP address.
        /// </value>
        [JsonProperty(PropertyName = "ipAddressLifetime")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IpAddressLifetimeEnum> IpAddressLifetime { get; set; }
        
        /// <value>
        /// The address range the IP address is assigned from.
        /// </value>
        [JsonProperty(PropertyName = "parentCidr")]
        public string ParentCidr { get; set; }
        
        /// <value>
        /// Associated public IP address for the private IP address.
        /// </value>
        [JsonProperty(PropertyName = "associatedPublicIp")]
        public string AssociatedPublicIp { get; set; }
                ///
        /// <value>
        /// Lifetime of the assigned public IP address.
        /// </value>
        ///
        public enum PublicIpLifetimeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "Ephemeral")]
            Ephemeral,
            [EnumMember(Value = "Reserved")]
            Reserved
        };

        /// <value>
        /// Lifetime of the assigned public IP address.
        /// </value>
        [JsonProperty(PropertyName = "publicIpLifetime")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PublicIpLifetimeEnum> PublicIpLifetime { get; set; }
                ///
        /// <value>
        /// Public IP address Pool the IP address is allocated from.
        /// </value>
        ///
        public enum AssociatedPublicIpPoolEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ORACLE")]
            Oracle,
            [EnumMember(Value = "BYOIP")]
            Byoip
        };

        /// <value>
        /// Public IP address Pool the IP address is allocated from.
        /// </value>
        [JsonProperty(PropertyName = "associatedPublicIpPool")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AssociatedPublicIpPoolEnum> AssociatedPublicIpPool { get; set; }
        
        /// <value>
        /// DNS hostname of the IP address.
        /// </value>
        [JsonProperty(PropertyName = "dnsHostName")]
        public string DnsHostName { get; set; }
        
        /// <value>
        /// Name of the created resource.
        /// </value>
        [JsonProperty(PropertyName = "assignedResourceName")]
        public string AssignedResourceName { get; set; }
                ///
        /// <value>
        /// Type of the resource.
        /// </value>
        ///
        public enum AssignedResourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "Resource")]
            Resource
        };

        /// <value>
        /// Type of the resource.
        /// </value>
        [JsonProperty(PropertyName = "assignedResourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AssignedResourceTypeEnum> AssignedResourceType { get; set; }
        
        /// <value>
        /// Address type of the allocated private IP address.
        /// </value>
        [JsonProperty(PropertyName = "addressType")]
        public string AddressType { get; set; }
        
        /// <value>
        /// Assigned time of the private IP address.
        /// </value>
        [JsonProperty(PropertyName = "assignedTime")]
        public System.Nullable<System.DateTime> AssignedTime { get; set; }
        
    }
}