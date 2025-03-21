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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Instance launch details.
    /// Use the `sourceDetails` parameter to specify whether a boot volume or an image should be used to launch a new instance.
    /// 
    /// </summary>
    public class LaunchInstanceDetails 
    {
        
        /// <value>
        /// The availability domain of the instance.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The OCID of the compute capacity reservation under which this instance is launched.
        /// You can opt out of all default reservations by specifying an empty string as input for this field.
        /// For more information, see [Capacity Reservations](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/reserve-capacity.htm#default).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "capacityReservationId")]
        public string CapacityReservationId { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "createVnicDetails")]
        public CreateVnicDetails CreateVnicDetails { get; set; }
        
        /// <value>
        /// The OCID of the dedicated VM host.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dedicatedVmHostId")]
        public string DedicatedVmHostId { get; set; }
        
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
        /// A fault domain is a grouping of hardware and infrastructure within an availability domain.
        /// Each availability domain contains three fault domains. Fault domains lets you distribute your
        /// instances so that they are not on the same physical hardware within a single availability domain.
        /// A hardware failure or Compute hardware maintenance that affects one fault domain does not affect
        /// instances in other fault domains.
        /// <br/>
        /// If you do not specify the fault domain, the system selects one for you.
        /// <br/>
        /// 
        /// To get a list of fault domains, use the
        /// {@link #listFaultDomains(ListFaultDomainsRequest) listFaultDomains} operation in the
        /// Identity and Access Management Service API.
        /// <br/>
        /// Example: FAULT-DOMAIN-1
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. It exists only for cross-compatibility.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Deprecated. Instead use `hostnameLabel` in
        /// {@link CreateVnicDetails}.
        /// If you provide both, the values must match.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }
        
        /// <value>
        /// This is an advanced option.
        /// <br/>
        /// When a bare metal or virtual machine
        /// instance boots, the iPXE firmware that runs on the instance is
        /// configured to run an iPXE script to continue the boot process.
        /// <br/>
        /// If you want more control over the boot process, you can provide
        /// your own custom iPXE script that will run when the instance boots.
        /// Be aware that the same iPXE script will run
        /// every time an instance boots, not only after the initial
        /// LaunchInstance call.
        /// <br/>
        /// By default, the iPXE script connects to the instance's local boot
        /// volume over iSCSI and performs a network boot. If you use a custom iPXE
        /// script and want to network-boot from the instance's local boot volume
        /// over iSCSI in the same way as the default iPXE script, use the
        /// following iSCSI IP address: 169.254.0.2, and boot volume IQN:
        /// iqn.2015-02.oracle.boot.
        /// <br/>
        /// If your instance boot volume type is paravirtualized,
        /// the boot volume is attached to the instance through virtio-scsi and no iPXE script is used.
        /// If your instance boot volume type is paravirtualized
        /// and you use custom iPXE to perform network-boot into your instance,
        /// the primary boot volume is attached as a data volume through the virtio-scsi drive.
        /// <br/>
        /// For more information about the Bring Your Own Image feature of
        /// Oracle Cloud Infrastructure, see
        /// [Bring Your Own Image](https://docs.cloud.oracle.com/iaas/Content/Compute/References/bringyourownimage.htm).
        /// <br/>
        /// For more information about iPXE, see http://ipxe.org.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipxeScript")]
        public string IpxeScript { get; set; }
        
        [JsonProperty(PropertyName = "instanceOptions")]
        public InstanceOptions InstanceOptions { get; set; }
        
        [JsonProperty(PropertyName = "preemptibleInstanceConfig")]
        public PreemptibleInstanceConfigDetails PreemptibleInstanceConfig { get; set; }
        
        [JsonProperty(PropertyName = "agentConfig")]
        public LaunchInstanceAgentConfigDetails AgentConfig { get; set; }
        
        /// <value>
        /// The shape of an instance. The shape determines the number of CPUs, amount of memory,
        /// and other resources allocated to the instance.
        /// <br/>
        /// You can enumerate all available shapes by calling {@link #listShapes(ListShapesRequest) listShapes}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        [JsonProperty(PropertyName = "shapeConfig")]
        public LaunchInstanceShapeConfigDetails ShapeConfig { get; set; }
        
        [JsonProperty(PropertyName = "sourceDetails")]
        public InstanceSourceDetails SourceDetails { get; set; }
        
        /// <value>
        /// Whether to enable in-transit encryption for the data volume's paravirtualized attachment. This field applies to both block volumes and boot volumes. By default, the value is false.
        /// </value>
        [JsonProperty(PropertyName = "isPvEncryptionInTransitEnabled")]
        public System.Nullable<bool> IsPvEncryptionInTransitEnabled { get; set; }
        
    }
}
