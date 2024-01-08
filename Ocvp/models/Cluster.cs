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


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// An [Oracle Cloud VMware Solution](https://docs.cloud.oracle.com/iaas/Content/VMware/Concepts/ocvsoverview.htm) Cluster contains the resources required for a
    /// functional VMware environment. Instances in a Cluster
    /// (see {@link EsxiHost}) run in a virtual cloud network (VCN)
    /// and are preconfigured with VMware and storage. Use the vCenter utility to manage
    /// and deploy VMware virtual machines (VMs) in the Cluster.
    /// <br/>
    /// The Cluster uses a single management subnet for provisioning the Cluster. It also uses a
    /// set of VLANs for various components of the VMware environment (vSphere, vMotion,
    /// vSAN, and so on). See the Core Services API for information about VCN subnets and VLANs.
    /// 
    /// </summary>
    public class Cluster 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Cluster.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The availability domain the ESXi hosts are running in. For Multi-AD Cluster, it is `multi-AD`.
        /// <br/>
        /// Example: Uocm:PHX-AD-1, multi-AD
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeAvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "computeAvailabilityDomain")]
        public string ComputeAvailabilityDomain { get; set; }
        
        /// <value>
        /// A descriptive name for the Cluster. It must be unique, start with a letter, and contain only letters, digits,
        /// whitespaces, dashes and underscores.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A prefix used in the name of each ESXi host and Compute instance in the Cluster.
        /// If this isn't set, the Cluster's `displayName` is used as the prefix.
        /// <br/>
        /// For example, if the value is `MyCluster`, the ESXi hosts are named `MyCluster-1`,
        /// `MyCluster-2`, and so on.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "instanceDisplayNamePrefix")]
        public string InstanceDisplayNamePrefix { get; set; }
        
        /// <value>
        /// In general, this is a specific version of bundled VMware software supported by
        /// Oracle Cloud VMware Solution (see
        /// {@link #listSupportedVmwareSoftwareVersions(ListSupportedVmwareSoftwareVersionsRequest) listSupportedVmwareSoftwareVersions}).
        /// <br/>
        /// This attribute is not guaranteed to reflect the version of
        /// software currently installed on the ESXi hosts in the Cluster. The purpose
        /// of this attribute is to show the version of software that the Oracle
        /// Cloud VMware Solution will install on any new ESXi hosts that you *add to this
        /// Cluster in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you upgrade the existing ESXi hosts in the Cluster to use a newer
        /// version of bundled VMware software supported by the Oracle Cloud VMware Solution, you
        /// should use {@link #updateCluster(UpdateClusterRequest) updateCluster} to update the Cluster's
        /// `vmwareSoftwareVersion` with that new version.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VmwareSoftwareVersion is required.")]
        [JsonProperty(PropertyName = "vmwareSoftwareVersion")]
        public string VmwareSoftwareVersion { get; set; }
        
        /// <value>
        /// In general, this is a specific version of bundled ESXi software supported by
        /// Oracle Cloud VMware Solution (see
        /// {@link #listSupportedVmwareSoftwareVersions(ListSupportedVmwareSoftwareVersionsRequest) listSupportedVmwareSoftwareVersions}).
        /// <br/>
        /// This attribute is not guaranteed to reflect the version of
        /// software currently installed on the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the version of software that the Oracle
        /// Cloud VMware Solution will install on any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost} 
        /// unless a different version is configured on the ESXi host level.
        /// <br/>
        /// Therefore, if you upgrade the existing ESXi hosts in the Cluster to use a newer
        /// version of bundled ESXi software supported by the Oracle Cloud VMware Solution, you
        /// should use {@link #updateCluster(UpdateClusterRequest) updateCluster} to update the Cluster's
        /// `esxiSoftwareVersion` with that new version.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "esxiSoftwareVersion")]
        public string EsxiSoftwareVersion { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that
        /// contains the Cluster.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the SDDC that the
        /// Cluster belongs to.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SddcId is required.")]
        [JsonProperty(PropertyName = "sddcId")]
        public string SddcId { get; set; }
        
        /// <value>
        /// The number of ESXi hosts in the Cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EsxiHostsCount is required.")]
        [JsonProperty(PropertyName = "esxiHostsCount")]
        public System.Nullable<int> EsxiHostsCount { get; set; }
        
        /// <value>
        /// The billing option selected during Cluster creation.
        /// {@link #listSupportedCommitments(ListSupportedCommitmentsRequest) listSupportedCommitments}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "initialCommitment")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Commitment> InitialCommitment { get; set; }
        
        /// <value>
        /// The CIDR block for the IP addresses that VMware VMs in the SDDC use to run application
        /// workloads.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "workloadNetworkCidr")]
        public string WorkloadNetworkCidr { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NetworkConfiguration is required.")]
        [JsonProperty(PropertyName = "networkConfiguration")]
        public NetworkConfiguration NetworkConfiguration { get; set; }
        
        /// <value>
        /// The date and time the Cluster was created, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
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
        /// The date and time the Cluster was updated, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the Cluster.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// The vSphere licenses to use when upgrading the Cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "upgradeLicenses")]
        public System.Collections.Generic.List<VsphereLicense> UpgradeLicenses { get; set; }
        
        /// <value>
        /// The links to binary objects needed to upgrade vSphere.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vsphereUpgradeObjects")]
        public System.Collections.Generic.List<VsphereUpgradeObject> VsphereUpgradeObjects { get; set; }
        
        /// <value>
        /// The initial compute shape of the Cluster's ESXi hosts.
        /// {@link #listSupportedHostShapes(ListSupportedHostShapesRequest) listSupportedHostShapes}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InitialHostShapeName is required.")]
        [JsonProperty(PropertyName = "initialHostShapeName")]
        public string InitialHostShapeName { get; set; }
        
        /// <value>
        /// The initial OCPU count of the Cluster's ESXi hosts.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "initialHostOcpuCount")]
        public System.Nullable<float> InitialHostOcpuCount { get; set; }
        
        /// <value>
        /// Indicates whether shielded instance is enabled at the Cluster level.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isShieldedInstanceEnabled")]
        public System.Nullable<bool> IsShieldedInstanceEnabled { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Capacity Reservation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "capacityReservationId")]
        public string CapacityReservationId { get; set; }
        
        /// <value>
        /// Datastores used for the Cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "datastores")]
        public System.Collections.Generic.List<DatastoreDetails> Datastores { get; set; }
        
        /// <value>
        /// vSphere Cluster types.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VsphereType is required.")]
        [JsonProperty(PropertyName = "vsphereType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<VsphereTypes> VsphereType { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
