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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Represents a specific version of a registration profile.
    /// </summary>
    public class ProfileVersion 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the registration profile.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains the registration profile.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name for the profile.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The description of the registration profile.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the management station to associate with an 
        /// instance once registered. Management stations are only used with non-OCI instances.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "managementStationId")]
        public string ManagementStationId { get; set; }
        
        /// <value>
        /// The list of software sources that the registration profile will use.
        /// </value>
        [JsonProperty(PropertyName = "softwareSources")]
        public System.Collections.Generic.List<SoftwareSourceDetails> SoftwareSources { get; set; }
        
        [JsonProperty(PropertyName = "managedInstanceGroup")]
        public ManagedInstanceGroupDetails ManagedInstanceGroup { get; set; }
        
        [JsonProperty(PropertyName = "lifecycleEnvironment")]
        public LifecycleEnvironmentDetails LifecycleEnvironment { get; set; }
        
        [JsonProperty(PropertyName = "lifecycleStage")]
        public LifecycleStageDetails LifecycleStage { get; set; }
        
        /// <value>
        /// The type of profile.
        /// </value>
        [JsonProperty(PropertyName = "profileType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProfileType> ProfileType { get; set; }
        
        /// <value>
        /// The vendor of the operating system for the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VendorName is required.")]
        [JsonProperty(PropertyName = "vendorName")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<VendorName> VendorName { get; set; }
        
        /// <value>
        /// The operating system family.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsFamily is required.")]
        [JsonProperty(PropertyName = "osFamily")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OsFamily> OsFamily { get; set; }
        
        /// <value>
        /// The architecture type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArchType is required.")]
        [JsonProperty(PropertyName = "archType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ArchType> ArchType { get; set; }
        
        /// <value>
        /// The time the registration profile was created (in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) format).
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the registration profile was last modified (in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) format).
        /// </value>
        [JsonProperty(PropertyName = "timeModified")]
        public System.Nullable<System.DateTime> TimeModified { get; set; }
        
        /// <value>
        /// The version of the profile.
        /// </value>
        [JsonProperty(PropertyName = "profileVersion")]
        public string ProfileVersionProp { get; set; }
        
        /// <value>
        /// The current state of the registration profile.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Profile.LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// The type of instance to register.
        /// </value>
        ///
        public enum RegistrationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OCI_LINUX")]
            OciLinux,
            [EnumMember(Value = "NON_OCI_LINUX")]
            NonOciLinux,
            [EnumMember(Value = "OCI_WINDOWS")]
            OciWindows,
            [EnumMember(Value = "AUTONOMOUS_LINUX")]
            AutonomousLinux
        };

        /// <value>
        /// The type of instance to register.
        /// </value>
        [JsonProperty(PropertyName = "registrationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RegistrationTypeEnum> RegistrationType { get; set; }
        
        /// <value>
        /// Indicates if the profile is set as the default. There is exactly one default profile for a specified architecture, OS family, registration type, and vendor. When registering an instance with the corresonding characteristics, the default profile is used, unless another profile is specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDefaultProfile")]
        public System.Nullable<bool> IsDefaultProfile { get; set; }
        
        /// <value>
        /// Indicates if the profile was created by the service. OS Management Hub provides a limited set of standardized profiles that can be used to register Autonomous Linux or Windows instances.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isServiceProvidedProfile")]
        public System.Nullable<bool> IsServiceProvidedProfile { get; set; }
        
    }
}
