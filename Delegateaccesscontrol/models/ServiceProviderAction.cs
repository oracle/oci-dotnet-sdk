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


namespace Oci.DelegateaccesscontrolService.Models
{
    /// <summary>
    /// Details of the Service Provider Action. Service provider actions are a pre-defined set of commands available to the support operator on different layers of the infrastructure. Although the groupings may differ depending on the infrastructure layers, 
    /// the groups are designed to enable the support operator access to commands to resolve a specific set of issues.
    /// 
    /// </summary>
    public class ServiceProviderAction 
    {
        
        /// <value>
        /// Unique Oracle assigned identifier for the Service Provider Action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique name of the Service Provider Action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Display Name of the Service Provider Action.
        /// </value>
        [JsonProperty(PropertyName = "customerDisplayName")]
        public string CustomerDisplayName { get; set; }
        
        /// <value>
        /// Name of the infrastructure layer associated with the Service Provider Action.
        /// </value>
        [JsonProperty(PropertyName = "component")]
        public string Component { get; set; }
        
        /// <value>
        /// resourceType for which the ServiceProviderAction is applicable
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DelegationControlResourceType> ResourceType { get; set; }
        
        /// <value>
        /// List of Service Provider Service Types that this Service Provider Action is applicable to.
        /// </value>
        [JsonProperty(PropertyName = "serviceProviderServiceTypes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<ServiceProviderServiceType> ServiceProviderServiceTypes { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the Service Provider Action.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive
        };

        /// <value>
        /// The current lifecycle state of the Service Provider Action.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Description of the Service Provider Action in terms of associated risk profile, and characteristics of the operating system commands made
        /// available to the support operator under this Service Provider Action.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Fine grained properties associated with the Delegation Control.
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.List<ServiceProviderActionProperties> Properties { get; set; }
        
    }
}
