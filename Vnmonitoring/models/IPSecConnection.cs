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
    /// <summary>
    /// A connection between a DRG and CPE. This connection consists of multiple IPSec
    /// tunnels. Creating this connection is one of the steps required when setting up
    /// a Site-to-Site VPN.
    /// <br/>
    /// **Important:**  Each tunnel in an IPSec connection can use either static routing or BGP dynamic
    /// routing (see the {@link IPSecConnectionTunnel} object's
    /// `routing` attribute). Originally only static routing was supported and
    /// every IPSec connection was required to have at least one static route configured.
    /// To maintain backward compatibility in the API when support for BPG dynamic routing was introduced,
    /// the API accepts an empty list of static routes if you configure both of the IPSec tunnels to use
    /// BGP dynamic routing. If you switch a tunnel's routing from `BGP` to `STATIC`, you must first
    /// ensure that the IPSec connection is configured with at least one valid CIDR block static route.
    /// Oracle uses the IPSec connection's static routes when routing a tunnel's traffic *only*
    /// if that tunnel's `routing` attribute = `STATIC`. Otherwise the static routes are ignored.
    /// <br/>
    /// For more information about the workflow for setting up an IPSec connection, see
    /// [Site-to-Site VPN Overview](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/overviewIPsec.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class IPSecConnection 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the IPSec connection.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the {@link Cpe} object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpeId is required.")]
        [JsonProperty(PropertyName = "cpeId")]
        public string CpeId { get; set; }
        
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
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrgId is required.")]
        [JsonProperty(PropertyName = "drgId")]
        public string DrgId { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The IPSec connection's Oracle ID ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The IPSec connection's current state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// The IPSec connection's current state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Your identifier for your CPE device. Can be either an IP address or a hostname (specifically,
        /// the fully qualified domain name (FQDN)). The type of identifier here must correspond
        /// to the value for `cpeLocalIdentifierType`.
        /// <br/>
        /// If you don't provide a value when creating the IPSec connection, the `ipAddress` attribute
        /// for the {@link Cpe} object specified by `cpeId` is used as the `cpeLocalIdentifier`.
        /// <br/>
        /// For information about why you'd provide this value, see
        /// [If Your CPE Is Behind a NAT Device](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/overviewIPsec.htm#nat).
        /// <br/>
        /// Example IP address: `10.0.3.3`
        /// <br/>
        /// Example hostname: `cpe.example.com`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cpeLocalIdentifier")]
        public string CpeLocalIdentifier { get; set; }
                ///
        /// <value>
        /// The type of identifier for your CPE device. The value here must correspond to the value
        /// for `cpeLocalIdentifier`.
        /// 
        /// </value>
        ///
        public enum CpeLocalIdentifierTypeEnum {
            [EnumMember(Value = "IP_ADDRESS")]
            IpAddress,
            [EnumMember(Value = "HOSTNAME")]
            Hostname
        };

        /// <value>
        /// The type of identifier for your CPE device. The value here must correspond to the value
        /// for `cpeLocalIdentifier`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cpeLocalIdentifierType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CpeLocalIdentifierTypeEnum> CpeLocalIdentifierType { get; set; }
        
        /// <value>
        /// Static routes to the CPE. The CIDR must not be a
        /// multicast address or class E address.
        /// <br/>
        /// Used for routing a given IPSec tunnel's traffic only if the tunnel
        /// is using static routing. If you configure at least one tunnel to use static routing, then
        /// you must provide at least one valid static route. If you configure both
        /// tunnels to use BGP dynamic routing, you can provide an empty list for the static routes.
        /// <br/>
        /// The CIDR can be either IPv4 or IPv6. IPv6 addressing is supported for all commercial and government regions.
        /// See [IPv6 Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/ipv6.htm).
        /// <br/>
        /// Example: 10.0.1.0/24
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StaticRoutes is required.")]
        [JsonProperty(PropertyName = "staticRoutes")]
        public System.Collections.Generic.List<string> StaticRoutes { get; set; }
        
        /// <value>
        /// The date and time the IPSec connection was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The transport type used for the IPSec connection.
        /// 
        /// </value>
        ///
        public enum TransportTypeEnum {
            [EnumMember(Value = "INTERNET")]
            Internet,
            [EnumMember(Value = "FASTCONNECT")]
            Fastconnect
        };

        /// <value>
        /// The transport type used for the IPSec connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "transportType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TransportTypeEnum> TransportType { get; set; }
        
    }
}
