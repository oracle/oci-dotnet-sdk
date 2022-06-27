/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// <summary>
    /// For use with Oracle Cloud Infrastructure FastConnect. A cross-connect represents a
    /// physical connection between an existing network and Oracle. Customers who are colocated
    /// with Oracle in a FastConnect location create and use cross-connects. For more
    /// information, see [FastConnect Overview](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/fastconnect.htm).
    /// <br/>
    /// Oracle recommends you create each cross-connect in a
    /// {@link CrossConnectGroup} so you can use link aggregation
    /// with the connection.
    /// <br/>
    /// **Note:** If you're a provider who is setting up a physical connection to Oracle so customers
    /// can use FastConnect over the connection, be aware that your connection is modeled the
    /// same way as a colocated customer's (with `CrossConnect` and `CrossConnectGroup` objects, and so on).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class CrossConnect 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the cross-connect group.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the cross-connect group this cross-connect belongs to (if any).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "crossConnectGroupId")]
        public string CrossConnectGroupId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The cross-connect's Oracle ID (OCID).
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The cross-connect's current state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PENDING_CUSTOMER")]
            PendingCustomer,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "PROVISIONED")]
            Provisioned,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// The cross-connect's current state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The name of the FastConnect location where this cross-connect is installed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "locationName")]
        public string LocationName { get; set; }
        
        /// <value>
        /// A string identifying the meet-me room port for this cross-connect.
        /// </value>
        [JsonProperty(PropertyName = "portName")]
        public string PortName { get; set; }
        
        /// <value>
        /// The port speed for this cross-connect.
        /// <br/>
        /// Example: 10 Gbps
        /// </value>
        [JsonProperty(PropertyName = "portSpeedShapeName")]
        public string PortSpeedShapeName { get; set; }
        
        /// <value>
        /// The date and time the cross-connect was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
