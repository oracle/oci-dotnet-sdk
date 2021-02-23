/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// A *network security group* (NSG) provides virtual firewall rules for a specific set of
    /// {@link Vnic} in a VCN. Compare NSGs with {@link SecurityList},
    /// which provide virtual firewall rules to all the VNICs in a *subnet*.
    /// <br/>
    /// A network security group consists of two items:
    /// <br/>
    ///   * The set of {@link Vnic} that all have the same security rule needs (for
    ///     example, a group of Compute instances all running the same application)
    ///   * A set of NSG {@link SecurityRule} that apply to the VNICs in the group
    /// <br/>
    /// After creating an NSG, you can add VNICs and security rules to it. For example, when you create
    /// an instance, you can specify one or more NSGs to add the instance to (see
    /// {@link #createVnicDetails(CreateVnicDetailsRequest) createVnicDetails}). Or you can add an existing
    /// instance to an NSG with {@link #updateVnic(UpdateVnicRequest) updateVnic}.
    /// <br/>
    /// To add security rules to an NSG, see
    /// {@link #addNetworkSecurityGroupSecurityRules(AddNetworkSecurityGroupSecurityRulesRequest) addNetworkSecurityGroupSecurityRules}.
    /// <br/>
    /// To list the VNICs in an NSG, see
    /// {@link #listNetworkSecurityGroupVnics(ListNetworkSecurityGroupVnicsRequest) listNetworkSecurityGroupVnics}.
    /// <br/>
    /// To list the security rules in an NSG, see
    /// {@link #listNetworkSecurityGroupSecurityRules(ListNetworkSecurityGroupSecurityRulesRequest) listNetworkSecurityGroupSecurityRules}.
    /// <br/>
    /// For more information about network security groups, see
    /// [Network Security Groups](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/networksecuritygroups.htm).
    /// <br/>
    /// **Important:** Oracle Cloud Infrastructure Compute service images automatically include firewall rules (for example,
    /// Linux iptables, Windows firewall). If there are issues with some type of access to an instance,
    /// make sure all of the following are set correctly:
    /// <br/>
    ///   * Any security rules in any NSGs the instance's VNIC belongs to
    ///   * Any {@link SecurityList} associated with the instance's subnet
    ///   * The instance's OS firewall rules
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class NetworkSecurityGroup 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment the network security group is in.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the network security group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The network security group's current state.
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
        /// The network security group's current state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the network security group was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the network security group's VCN.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
    }
}
