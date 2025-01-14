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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// Resource Bundle associated with an Offer
    /// </summary>
    public class ResourceBundle 
    {
                ///
        /// <value>
        /// The type of resources in the bundle
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "LISTING")]
            Listing
        };

        /// <value>
        /// The type of resources in the bundle
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The quantity of a resources associated with the bundle
        /// </value>
        [JsonProperty(PropertyName = "quantity")]
        public System.Nullable<long> Quantity { get; set; }
                ///
        /// <value>
        /// The unit of measurement for the resource bundle
        /// </value>
        ///
        public enum UnitOfMeasurementEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OCPU_PER_HOUR")]
            OcpuPerHour,
            [EnumMember(Value = "INSTANCE_PER_HOUR")]
            InstancePerHour,
            [EnumMember(Value = "CREDITS")]
            Credits,
            [EnumMember(Value = "INSTANCES")]
            Instances,
            [EnumMember(Value = "NODES")]
            Nodes
        };

        /// <value>
        /// The unit of measurement for the resource bundle
        /// </value>
        [JsonProperty(PropertyName = "unitOfMeasurement")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UnitOfMeasurementEnum> UnitOfMeasurement { get; set; }
        
        /// <value>
        /// the ids of the resources in the Offer
        /// </value>
        [JsonProperty(PropertyName = "resourceIds")]
        public System.Collections.Generic.List<string> ResourceIds { get; set; }
        
    }
}
