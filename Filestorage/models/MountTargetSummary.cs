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
    /// Summary information for the specified mount target.
    /// 
    /// </summary>
    public class MountTargetSummary 
    {
        
        /// <value>
        /// The availability domain the mount target is in. May be unset
        /// as a blank or NULL value.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that contains the mount target.
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
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the associated export set. Controls what file
        /// systems will be exported using Network File System (NFS) protocol on
        /// this mount target.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "exportSetId")]
        public string ExportSetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the mount target.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The current state of the mount target.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The current state of the mount target.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The OCIDs of the private IP addresses associated with this mount target.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrivateIpIds is required.")]
        [JsonProperty(PropertyName = "privateIpIds")]
        public System.Collections.Generic.List<string> PrivateIpIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet the mount target is in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// A list of Network Security Group [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) associated with this mount target.
        /// A maximum of 5 is allowed.
        /// Setting this to an empty array after the list is created removes the mount target from all NSGs.
        /// For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// The date and time the mount target current billing cycle will end, expressed in 
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339) timestamp format. Once a cycle ends, it is updated 
        /// automatically to next timestamp which is after 30 days.
        /// <br/>
        ///   Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeBillingCycleEnd")]
        public System.Nullable<System.DateTime> TimeBillingCycleEnd { get; set; }
        
        /// <value>
        /// Current billed throughput for mount target in Gbps. This corresponds to shape of mount target.
        /// Available shapes and corresponding throughput are listed at [Mount Target Performance](https://docs.oracle.com/iaas/Content/File/Tasks/managingmounttargets.htm#performance).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "observedThroughput")]
        public System.Nullable<long> ObservedThroughput { get; set; }
        
        /// <value>
        /// - New throughput for mount target at the end of billing cycle in Gbps.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "requestedThroughput")]
        public System.Nullable<long> RequestedThroughput { get; set; }
        
        /// <value>
        /// - Reserved capacity (GB) associated with this mount target. Reserved capacity depends on observedThroughput value
        /// of mount target. Value is listed at [Mount Target Performance](https://docs.oracle.com/iaas/Content/File/Tasks/managingmounttargets.htm#performance).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "reservedStorageCapacity")]
        public System.Nullable<long> ReservedStorageCapacity { get; set; }
        
        /// <value>
        /// The date and time the mount target was created, expressed
        /// in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) timestamp format.
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
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
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
        /// System tags for this resource.
        /// System tags are applied to resources by internal OCI services.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
