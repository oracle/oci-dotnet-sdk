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
    /// For use with Oracle Cloud Infrastructure FastConnect.
    /// <br/>
    /// A virtual circuit is an isolated network path that runs over one or more physical
    /// network connections to provide a single, logical connection between the edge router
    /// on the customer's existing network and Oracle Cloud Infrastructure. *Private*
    /// virtual circuits support private peering, and *public* virtual circuits support
    /// public peering. For more information, see [FastConnect Overview](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/fastconnect.htm).
    /// <br/>
    /// Each virtual circuit is made up of information shared between a customer, Oracle,
    /// and a provider (if the customer is using FastConnect via a provider). Who fills in
    /// a given property of a virtual circuit depends on whether the BGP session related to
    /// that virtual circuit goes from the customer's edge router to Oracle, or from the provider's
    /// edge router to Oracle. Also, in the case where the customer is using a provider, values
    /// for some of the properties may not be present immediately, but may get filled in as the
    /// provider and Oracle each do their part to provision the virtual circuit.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class VirtualCircuit 
    {
        
        /// <value>
        /// The provisioned data rate of the connection. To get a list of the
        /// available bandwidth levels (that is, shapes), see
        /// {@link #listFastConnectProviderVirtualCircuitBandwidthShapes(ListFastConnectProviderVirtualCircuitBandwidthShapesRequest) listFastConnectProviderVirtualCircuitBandwidthShapes}.
        /// <br/>
        /// Example: 10 Gbps
        /// </value>
        [JsonProperty(PropertyName = "bandwidthShapeName")]
        public string BandwidthShapeName { get; set; }
                ///
        /// <value>
        /// Deprecated. Instead use the information in
        /// {@link FastConnectProviderService}.
        /// 
        /// </value>
        ///
        public enum BgpManagementEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CUSTOMER_MANAGED")]
            CustomerManaged,
            [EnumMember(Value = "PROVIDER_MANAGED")]
            ProviderManaged,
            [EnumMember(Value = "ORACLE_MANAGED")]
            OracleManaged
        };

        /// <value>
        /// Deprecated. Instead use the information in
        /// {@link FastConnectProviderService}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bgpManagement")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BgpManagementEnum> BgpManagement { get; set; }
                ///
        /// <value>
        /// The state of the Ipv4 BGP session associated with the virtual circuit.
        /// </value>
        ///
        public enum BgpSessionStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UP")]
            Up,
            [EnumMember(Value = "DOWN")]
            Down
        };

        /// <value>
        /// The state of the Ipv4 BGP session associated with the virtual circuit.
        /// </value>
        [JsonProperty(PropertyName = "bgpSessionState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BgpSessionStateEnum> BgpSessionState { get; set; }
                ///
        /// <value>
        /// The state of the Ipv6 BGP session associated with the virtual circuit.
        /// </value>
        ///
        public enum BgpIpv6SessionStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UP")]
            Up,
            [EnumMember(Value = "DOWN")]
            Down
        };

        /// <value>
        /// The state of the Ipv6 BGP session associated with the virtual circuit.
        /// </value>
        [JsonProperty(PropertyName = "bgpIpv6SessionState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BgpIpv6SessionStateEnum> BgpIpv6SessionState { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the virtual circuit.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// An array of mappings, each containing properties for a
        /// cross-connect or cross-connect group that is associated with this
        /// virtual circuit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "crossConnectMappings")]
        public System.Collections.Generic.List<CrossConnectMapping> CrossConnectMappings { get; set; }
                ///
        ///
        public enum RoutingPolicyEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ORACLE_SERVICE_NETWORK")]
            OracleServiceNetwork,
            [EnumMember(Value = "REGIONAL")]
            Regional,
            [EnumMember(Value = "MARKET_LEVEL")]
            MarketLevel,
            [EnumMember(Value = "GLOBAL")]
            Global
        };

        /// <value>
        /// The routing policy sets how routing information about the Oracle cloud is shared over a public virtual circuit.
        /// Policies available are: `ORACLE_SERVICE_NETWORK`, `REGIONAL`, `MARKET_LEVEL`, and `GLOBAL`.
        /// See [Route Filtering](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/routingonprem.htm#route_filtering) for details.
        /// By default, routing information is shared for all routes in the same market.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routingPolicy", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<RoutingPolicyEnum> RoutingPolicy { get; set; }
                ///
        /// <value>
        /// Set to `ENABLED` (the default) to activate the BGP session of the virtual circuit, set to `DISABLED` to deactivate the virtual circuit.
        /// 
        /// </value>
        ///
        public enum BgpAdminStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// Set to `ENABLED` (the default) to activate the BGP session of the virtual circuit, set to `DISABLED` to deactivate the virtual circuit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bgpAdminState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BgpAdminStateEnum> BgpAdminState { get; set; }
        
        /// <value>
        /// Set to `true` to enable BFD for IPv4 BGP peering, or set to `false` to disable BFD. If this is not set, the default is `false`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isBfdEnabled")]
        public System.Nullable<bool> IsBfdEnabled { get; set; }
        
        /// <value>
        /// Set to `true` for the virtual circuit to carry only encrypted traffic, or set to `false` for the virtual circuit to carry unencrypted traffic. If this is not set, the default is `false`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isTransportMode")]
        public System.Nullable<bool> IsTransportMode { get; set; }
        
        /// <value>
        /// Deprecated. Instead use `customerAsn`.
        /// If you specify values for both, the request will be rejected.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customerBgpAsn")]
        public System.Nullable<int> CustomerBgpAsn { get; set; }
        
        /// <value>
        /// The BGP ASN of the network at the other end of the BGP
        /// session from Oracle. If the session is between the customer's
        /// edge router and Oracle, the value is the customer's ASN. If the BGP
        /// session is between the provider's edge router and Oracle, the value
        /// is the provider's ASN.
        /// Can be a 2-byte or 4-byte ASN. Uses \"asplain\" format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customerAsn")]
        public System.Nullable<long> CustomerAsn { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
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
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the customer's {@link Drg}
        /// that this virtual circuit uses. Applicable only to private virtual circuits.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gatewayId")]
        public string GatewayId { get; set; }
        
        /// <value>
        /// The virtual circuit's Oracle ID ([OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)).
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The virtual circuit's current state. For information about
        /// the different states, see
        /// [FastConnect Overview](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/fastconnect.htm).
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PENDING_PROVIDER")]
            PendingProvider,
            [EnumMember(Value = "VERIFYING")]
            Verifying,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "PROVISIONED")]
            Provisioned,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// The virtual circuit's current state. For information about
        /// the different states, see
        /// [FastConnect Overview](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/fastconnect.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The Oracle BGP ASN.
        /// </value>
        [JsonProperty(PropertyName = "oracleBgpAsn")]
        public System.Nullable<int> OracleBgpAsn { get; set; }
        
        /// <value>
        /// Deprecated. Instead use `providerServiceId`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerName")]
        public string ProviderName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the service offered by the provider (if the customer is connecting via a provider).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerServiceId")]
        public string ProviderServiceId { get; set; }
        
        /// <value>
        /// The service key name offered by the provider (if the customer is connecting via a provider).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerServiceKeyName")]
        public string ProviderServiceKeyName { get; set; }
        
        /// <value>
        /// Deprecated. Instead use `providerServiceId`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerServiceName")]
        public string ProviderServiceName { get; set; }
                ///
        /// <value>
        /// The provider's state in relation to this virtual circuit (if the
        /// customer is connecting via a provider). ACTIVE means
        /// the provider has provisioned the virtual circuit from their end.
        /// INACTIVE means the provider has not yet provisioned the virtual
        /// circuit, or has de-provisioned it.
        /// 
        /// </value>
        ///
        public enum ProviderStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive
        };

        /// <value>
        /// The provider's state in relation to this virtual circuit (if the
        /// customer is connecting via a provider). ACTIVE means
        /// the provider has provisioned the virtual circuit from their end.
        /// INACTIVE means the provider has not yet provisioned the virtual
        /// circuit, or has de-provisioned it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProviderStateEnum> ProviderState { get; set; }
        
        /// <value>
        /// For a public virtual circuit. The public IP prefixes (CIDRs) the customer wants to
        /// advertise across the connection. All prefix sizes are allowed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "publicPrefixes")]
        public System.Collections.Generic.List<string> PublicPrefixes { get; set; }
        
        /// <value>
        /// Provider-supplied reference information about this virtual circuit
        /// (if the customer is connecting via a provider).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "referenceComment")]
        public string ReferenceComment { get; set; }
        
        /// <value>
        /// The Oracle Cloud Infrastructure region where this virtual
        /// circuit is located.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
                ///
        /// <value>
        /// Provider service type.
        /// 
        /// </value>
        ///
        public enum ServiceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "COLOCATED")]
            Colocated,
            [EnumMember(Value = "LAYER2")]
            Layer2,
            [EnumMember(Value = "LAYER3")]
            Layer3
        };

        /// <value>
        /// Provider service type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "serviceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ServiceTypeEnum> ServiceType { get; set; }
        
        /// <value>
        /// The date and time the virtual circuit was created,
        /// in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// Whether the virtual circuit supports private or public peering. For more information,
        /// see [FastConnect Overview](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/fastconnect.htm).
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PUBLIC")]
            Public,
            [EnumMember(Value = "PRIVATE")]
            Private
        };

        /// <value>
        /// Whether the virtual circuit supports private or public peering. For more information,
        /// see [FastConnect Overview](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/fastconnect.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The layer 3 IP MTU to use on this virtual circuit.
        /// </value>
        [JsonProperty(PropertyName = "ipMtu")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<VirtualCircuitIpMtu> IpMtu { get; set; }
        
        [JsonProperty(PropertyName = "virtualCircuitRedundancyMetadata")]
        public VirtualCircuitRedundancyMetadata VirtualCircuitRedundancyMetadata { get; set; }
        
    }
}
