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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// A software source contains a collection of packages
    /// </summary>
    public class SoftwareSource 
    {
        
        /// <value>
        /// OCID for the Software Source
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// OCID for the Compartment
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// User friendly name for the software source
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Information specified by the user about the software source
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Type of the Software Source
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RepoType is required.")]
        [JsonProperty(PropertyName = "repoType")]
        public string RepoType { get; set; }
        
        /// <value>
        /// The architecture type supported by the Software Source
        /// </value>
        [JsonProperty(PropertyName = "archType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ArchTypes> ArchType { get; set; }
        
        /// <value>
        /// URL for the repostiory
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Url is required.")]
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// OCID for the parent software source, if there is one
        /// </value>
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; set; }
        
        /// <value>
        /// Display name the parent software source, if there is one
        /// </value>
        [JsonProperty(PropertyName = "parentName")]
        public string ParentName { get; set; }
        
        /// <value>
        /// The yum repository checksum type used by this software source
        /// </value>
        [JsonProperty(PropertyName = "checksumType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ChecksumTypes> ChecksumType { get; set; }
        
        /// <value>
        /// Name of the person maintaining this software source
        /// </value>
        [JsonProperty(PropertyName = "maintainerName")]
        public string MaintainerName { get; set; }
        
        /// <value>
        /// Email address of the person maintaining this software source
        /// </value>
        [JsonProperty(PropertyName = "maintainerEmail")]
        public string MaintainerEmail { get; set; }
        
        /// <value>
        /// Phone number of the person maintaining this software source
        /// </value>
        [JsonProperty(PropertyName = "maintainerPhone")]
        public string MaintainerPhone { get; set; }
        
        /// <value>
        /// URL of the GPG key for this software source
        /// </value>
        [JsonProperty(PropertyName = "gpgKeyUrl")]
        public string GpgKeyUrl { get; set; }
        
        /// <value>
        /// ID of the GPG key for this software source
        /// </value>
        [JsonProperty(PropertyName = "gpgKeyId")]
        public string GpgKeyId { get; set; }
        
        /// <value>
        /// Fingerprint of the GPG key for this software source
        /// </value>
        [JsonProperty(PropertyName = "gpgKeyFingerprint")]
        public string GpgKeyFingerprint { get; set; }
                ///
        /// <value>
        /// status of the software source.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NORMAL")]
            Normal,
            [EnumMember(Value = "UNREACHABLE")]
            Unreachable,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARNING")]
            Warning
        };

        /// <value>
        /// status of the software source.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The current state of the Software Source.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Number of packages
        /// </value>
        [JsonProperty(PropertyName = "packages")]
        public System.Nullable<int> Packages { get; set; }
        
        /// <value>
        /// list of the Managed Instances associated with this Software Sources
        /// </value>
        [JsonProperty(PropertyName = "associatedManagedInstances")]
        public System.Collections.Generic.List<Id> AssociatedManagedInstances { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
