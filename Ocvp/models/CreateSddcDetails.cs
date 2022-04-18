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


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// Details of the SDDC.
    /// </summary>
    public class CreateSddcDetails 
    {
        
        /// <value>
        /// The availability domain to create the SDDC's ESXi hosts in. For multi-AD SDDC deployment, set to `multi-AD`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeAvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "computeAvailabilityDomain")]
        public string ComputeAvailabilityDomain { get; set; }
        
        /// <value>
        /// A descriptive name for the SDDC.
        /// SDDC name requirements are 1-16 character length limit, Must start with a letter, Must be English letters, numbers, - only, No repeating hyphens, Must be unique within the region.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The VMware software bundle to install on the ESXi hosts in the SDDC. To get a
        /// list of the available versions, use
        /// {@link #listSupportedVmwareSoftwareVersions(ListSupportedVmwareSoftwareVersionsRequest) listSupportedVmwareSoftwareVersions}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VmwareSoftwareVersion is required.")]
        [JsonProperty(PropertyName = "vmwareSoftwareVersion")]
        public string VmwareSoftwareVersion { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment to contain the SDDC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A prefix used in the name of each ESXi host and Compute instance in the SDDC.
        /// If this isn't set, the SDDC's `displayName` is used as the prefix.
        /// <br/>
        /// For example, if the value is `mySDDC`, the ESXi hosts are named `mySDDC-1`,
        /// `mySDDC-2`, and so on.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "instanceDisplayNamePrefix")]
        public string InstanceDisplayNamePrefix { get; set; }
        
        /// <value>
        /// The number of ESXi hosts to create in the SDDC. You can add more hosts later
        /// (see {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}).
        /// <br/>
        /// **Note:** If you later delete EXSi hosts from the SDDC to total less than 3,
        /// you are still billed for the 3 minimum recommended ESXi hosts. Also,
        /// you cannot add more VMware workloads to the SDDC until it again has at least
        /// 3 ESXi hosts.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EsxiHostsCount is required.")]
        [JsonProperty(PropertyName = "esxiHostsCount")]
        public System.Nullable<int> EsxiHostsCount { get; set; }
        
        /// <value>
        /// The billing option selected during SDDC creation.
        /// {@link #listSupportedSkus(ListSupportedSkusRequest) listSupportedSkus}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "initialSku")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Sku> InitialSku { get; set; }
        
        /// <value>
        /// Indicates whether to enable HCX for this SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHcxEnabled")]
        public System.Nullable<bool> IsHcxEnabled { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for the HCX
        /// component of the VMware environment. This value is required only when `isHcxEnabled` is true.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hcxVlanId")]
        public string HcxVlanId { get; set; }
        
        /// <value>
        /// Indicates whether to enable HCX Enterprise for this SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHcxEnterpriseEnabled")]
        public System.Nullable<bool> IsHcxEnterpriseEnabled { get; set; }
        
        /// <value>
        /// One or more public SSH keys to be included in the `~/.ssh/authorized_keys` file for
        /// the default user on each ESXi host. Use a newline character to separate multiple keys.
        /// The SSH keys must be in the format required for the `authorized_keys` file
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SshAuthorizedKeys is required.")]
        [JsonProperty(PropertyName = "sshAuthorizedKeys")]
        public string SshAuthorizedKeys { get; set; }
        
        /// <value>
        /// The CIDR block for the IP addresses that VMware VMs in the SDDC use to run application
        /// workloads.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "workloadNetworkCidr")]
        public string WorkloadNetworkCidr { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the management subnet to use
        /// for provisioning the SDDC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProvisioningSubnetId is required.")]
        [JsonProperty(PropertyName = "provisioningSubnetId")]
        public string ProvisioningSubnetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for the vSphere
        /// component of the VMware environment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VsphereVlanId is required.")]
        [JsonProperty(PropertyName = "vsphereVlanId")]
        public string VsphereVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for the vMotion
        /// component of the VMware environment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VmotionVlanId is required.")]
        [JsonProperty(PropertyName = "vmotionVlanId")]
        public string VmotionVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for the vSAN
        /// component of the VMware environment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VsanVlanId is required.")]
        [JsonProperty(PropertyName = "vsanVlanId")]
        public string VsanVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for the NSX VTEP
        /// component of the VMware environment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NsxVTepVlanId is required.")]
        [JsonProperty(PropertyName = "nsxVTepVlanId")]
        public string NsxVTepVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for the NSX Edge VTEP
        /// component of the VMware environment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NsxEdgeVTepVlanId is required.")]
        [JsonProperty(PropertyName = "nsxEdgeVTepVlanId")]
        public string NsxEdgeVTepVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for the NSX Edge
        /// Uplink 1 component of the VMware environment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NsxEdgeUplink1VlanId is required.")]
        [JsonProperty(PropertyName = "nsxEdgeUplink1VlanId")]
        public string NsxEdgeUplink1VlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for the NSX Edge
        /// Uplink 2 component of the VMware environment.
        /// <br/>
        /// **Note:** This VLAN is reserved for future use to deploy public-facing applications on the VMware SDDC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NsxEdgeUplink2VlanId is required.")]
        [JsonProperty(PropertyName = "nsxEdgeUplink2VlanId")]
        public string NsxEdgeUplink2VlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the vSphere Replication component of the VMware environment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "replicationVlanId")]
        public string ReplicationVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the Provisioning component of the VMware environment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "provisioningVlanId")]
        public string ProvisioningVlanId { get; set; }
        
        /// <value>
        /// The initial compute shape of the SDDC's ESXi hosts.
        /// {@link #listSupportedHostShapes(ListSupportedHostShapesRequest) listSupportedHostShapes}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "initialHostShapeName")]
        public string InitialHostShapeName { get; set; }
        
        /// <value>
        /// The initial OCPU count of the SDDC's ESXi hosts.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "initialHostOcpuCount")]
        public System.Nullable<float> InitialHostOcpuCount { get; set; }
        
        /// <value>
        /// Indicates whether shielded instance is enabled for this SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isShieldedInstanceEnabled")]
        public System.Nullable<bool> IsShieldedInstanceEnabled { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
