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


namespace Oci.DesktopsService.Models
{
    /// <summary>
    /// Provides information about a desktop pool including all configuration parameters.
    /// </summary>
    public class DesktopPool 
    {
        
        /// <value>
        /// The OCID of the desktop pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment of the desktop pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user friendly display name. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A user friendly description providing additional information about the resource.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The current state of the desktop pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the resource was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The maximum number of desktops permitted in the desktop pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaximumSize is required.")]
        [JsonProperty(PropertyName = "maximumSize")]
        public System.Nullable<int> MaximumSize { get; set; }
        
        /// <value>
        /// The maximum number of standby desktops available in the desktop pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StandbySize is required.")]
        [JsonProperty(PropertyName = "standbySize")]
        public System.Nullable<int> StandbySize { get; set; }
        
        /// <value>
        /// The shape of the desktop pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        [JsonProperty(PropertyName = "shapeConfig")]
        public DesktopPoolShapeConfig ShapeConfig { get; set; }
                ///
        /// <value>
        /// Indicates whether the desktop pool uses dedicated virtual machine hosts.
        /// </value>
        ///
        public enum UseDedicatedVmHostEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TRUE")]
            True,
            [EnumMember(Value = "FALSE")]
            False,
            [EnumMember(Value = "AUTO")]
            Auto
        };

        /// <value>
        /// Indicates whether the desktop pool uses dedicated virtual machine hosts.
        /// </value>
        [JsonProperty(PropertyName = "useDedicatedVmHost")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UseDedicatedVmHostEnum> UseDedicatedVmHost { get; set; }
        
        /// <value>
        /// Indicates whether storage is enabled for the desktop pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsStorageEnabled is required.")]
        [JsonProperty(PropertyName = "isStorageEnabled")]
        public System.Nullable<bool> IsStorageEnabled { get; set; }
        
        /// <value>
        /// The size in GBs of the storage for the desktop pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StorageSizeInGBs is required.")]
        [JsonProperty(PropertyName = "storageSizeInGBs")]
        public System.Nullable<int> StorageSizeInGBs { get; set; }
        
        /// <value>
        /// The backup policy OCID of the storage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StorageBackupPolicyId is required.")]
        [JsonProperty(PropertyName = "storageBackupPolicyId")]
        public string StorageBackupPolicyId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DevicePolicy is required.")]
        [JsonProperty(PropertyName = "devicePolicy")]
        public DesktopDevicePolicy DevicePolicy { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityPolicy is required.")]
        [JsonProperty(PropertyName = "availabilityPolicy")]
        public DesktopAvailabilityPolicy AvailabilityPolicy { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Image is required.")]
        [JsonProperty(PropertyName = "image")]
        public DesktopImage Image { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NetworkConfiguration is required.")]
        [JsonProperty(PropertyName = "networkConfiguration")]
        public DesktopNetworkConfiguration NetworkConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "sessionLifecycleActions")]
        public DesktopSessionLifecycleActions SessionLifecycleActions { get; set; }
        
        /// <value>
        /// The start time of the desktop pool.
        /// </value>
        [JsonProperty(PropertyName = "timeStartScheduled")]
        public System.Nullable<System.DateTime> TimeStartScheduled { get; set; }
        
        /// <value>
        /// The stop time of the desktop pool.
        /// </value>
        [JsonProperty(PropertyName = "timeStopScheduled")]
        public System.Nullable<System.DateTime> TimeStopScheduled { get; set; }
        
        /// <value>
        /// Contact information of the desktop pool administrator.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContactDetails is required.")]
        [JsonProperty(PropertyName = "contactDetails")]
        public string ContactDetails { get; set; }
        
        /// <value>
        /// Indicates whether desktop pool users have administrative privileges on their desktop.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArePrivilegedUsers is required.")]
        [JsonProperty(PropertyName = "arePrivilegedUsers")]
        public System.Nullable<bool> ArePrivilegedUsers { get; set; }
        
        /// <value>
        /// The availability domain of the desktop pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
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
        /// A list of network security groups for the network.
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        [JsonProperty(PropertyName = "privateAccessDetails")]
        public DesktopPoolPrivateAccessDetails PrivateAccessDetails { get; set; }
        
    }
}
