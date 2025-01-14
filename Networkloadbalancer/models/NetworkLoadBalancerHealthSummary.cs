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


namespace Oci.NetworkloadbalancerService.Models
{
    /// <summary>
    /// A health status summary for the specified network load balancer
    /// </summary>
    public class NetworkLoadBalancerHealthSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network load balancer with which the health status is associated.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NetworkLoadBalancerId is required.")]
        [JsonProperty(PropertyName = "networkLoadBalancerId")]
        public string NetworkLoadBalancerId { get; set; }
                ///
        /// <value>
        /// The overall health status of the network load balancer.
        /// <br/>
        /// *  **OK:** All backend sets associated with the network load balancer return a status of `OK`.
        /// <br/>
        /// *  **WARNING:** At least one of the backend sets associated with the network load balancer returns a status of `WARNING`,
        /// no backend sets return a status of `CRITICAL`, and the network load balancer life cycle state is `ACTIVE`.
        /// <br/>
        /// *  **CRITICAL:** One or more of the backend sets associated with the network load balancer returns a status of `CRITICAL`.
        /// <br/>
        /// *  **UNKNOWN:** If any one of the following conditions is true:
        /// <br/>
        ///     *  The network load balancer life cycle state is not `ACTIVE`.
        /// <br/>
        ///     *  No backend sets are defined for the network load balancer.
        /// <br/>
        ///     *  More than half of the backend sets associated with the network load balancer return a status of `UNKNOWN`, none of the backend
        ///        sets returns a status of `WARNING` or `CRITICAL`, and the network load balancer life cycle state is `ACTIVE`.
        /// <br/>
        ///     *  The system could not retrieve metrics for any reason.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OK")]
            Ok,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// The overall health status of the network load balancer.
        /// <br/>
        /// *  **OK:** All backend sets associated with the network load balancer return a status of `OK`.
        /// <br/>
        /// *  **WARNING:** At least one of the backend sets associated with the network load balancer returns a status of `WARNING`,
        /// no backend sets return a status of `CRITICAL`, and the network load balancer life cycle state is `ACTIVE`.
        /// <br/>
        /// *  **CRITICAL:** One or more of the backend sets associated with the network load balancer returns a status of `CRITICAL`.
        /// <br/>
        /// *  **UNKNOWN:** If any one of the following conditions is true:
        /// <br/>
        ///     *  The network load balancer life cycle state is not `ACTIVE`.
        /// <br/>
        ///     *  No backend sets are defined for the network load balancer.
        /// <br/>
        ///     *  More than half of the backend sets associated with the network load balancer return a status of `UNKNOWN`, none of the backend
        ///        sets returns a status of `WARNING` or `CRITICAL`, and the network load balancer life cycle state is `ACTIVE`.
        /// <br/>
        ///     *  The system could not retrieve metrics for any reason.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
    }
}
