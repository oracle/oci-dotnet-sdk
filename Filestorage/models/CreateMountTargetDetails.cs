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


namespace Oci.FilestorageService.Models
{
    /// <summary>
    /// Details for creating the mount target.
    /// </summary>
    public class CreateMountTargetDetails 
    {
        
        /// <value>
        /// The availability domain in which to create the mount target.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment in which to create the mount target.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. It does not have to be unique, and it is changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My mount target
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The hostname for the mount target's IP address, used for
        /// DNS resolution. The value is the hostname portion of the private IP
        /// address's fully qualified domain name (FQDN). For example,
        /// `files-1` in the FQDN `files-1.subnet123.vcn1.oraclevcn.com`.
        /// Must be unique across all VNICs in the subnet and comply
        /// with [RFC 952](https://tools.ietf.org/html/rfc952)
        /// and [RFC 1123](https://tools.ietf.org/html/rfc1123).
        /// <br/>
        /// Note: This attribute value is stored in the [PrivateIp](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/iaas/20160918/PrivateIp/) resource,
        /// not in the `mountTarget` resource.
        /// To update the `hostnameLabel`, use `GetMountTarget` to obtain the
        /// [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the mount target's
        /// private IPs (`privateIpIds`). Then, you can use
        /// [UpdatePrivateIp](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/iaas/20160918/PrivateIp/UpdatePrivateIp)
        /// to update the `hostnameLabel` value.
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// Example: files-1
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }
        
        /// <value>
        /// A private IP address of your choice. Must be an available IP address within
        /// the subnet's CIDR. If you don't specify a value, Oracle automatically
        /// assigns a private IP address from the subnet.
        /// <br/>
        /// Example: 10.0.3.3
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet in which to create the mount target.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The method used to map a Unix UID to secondary groups, if any.
        /// </value>
        [JsonProperty(PropertyName = "idmapType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MountTarget.IdmapTypeEnum> IdmapType { get; set; }
        
        [JsonProperty(PropertyName = "ldapIdmap")]
        public CreateLdapIdmapDetails LdapIdmap { get; set; }
        
        /// <value>
        /// A list of Network Security Group [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) associated with this mount target.
        /// A maximum of 5 is allowed.
        /// Setting this to an empty array after the list is created removes the mount target from all NSGs.
        /// For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        [JsonProperty(PropertyName = "kerberos")]
        public CreateKerberosDetails Kerberos { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair
        ///  with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
        /// <value>
        /// Throughput for mount target in Gbps. Currently only 1 Gbps of requestedThroughput is supported during create MountTarget.
        /// Available shapes and corresponding throughput are listed at [Mount Target Performance](https://docs.oracle.com/iaas/Content/File/Tasks/managingmounttargets.htm#performance).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "requestedThroughput")]
        public System.Nullable<long> RequestedThroughput { get; set; }
        
    }
}
