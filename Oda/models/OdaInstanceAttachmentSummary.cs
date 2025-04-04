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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Description of an ODA instance attachment.
    /// </summary>
    public class OdaInstanceAttachmentSummary 
    {
        
        /// <value>
        /// Unique immutable identifier that was assigned when the ODA instance attachment was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the ODA instance to which the attachment applies.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
        
        /// <value>
        /// The OCID of the target instance (which could be any other OCI PaaS/SaaS resource), to which the ODA instance is or is being attached.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttachToId is required.")]
        [JsonProperty(PropertyName = "attachToId")]
        public string AttachToId { get; set; }
                ///
        /// <value>
        /// The type of attachment defined as an enum.
        /// </value>
        ///
        public enum AttachmentTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FUSION")]
            Fusion,
            [EnumMember(Value = "MAX")]
            Max
        };

        /// <value>
        /// The type of attachment defined as an enum.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttachmentType is required.")]
        [JsonProperty(PropertyName = "attachmentType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AttachmentTypeEnum> AttachmentType { get; set; }
        
        /// <value>
        /// Attachment-specific metadata, defined by the target service.
        /// </value>
        [JsonProperty(PropertyName = "attachmentMetadata")]
        public string AttachmentMetadata { get; set; }
        
        /// <value>
        /// List of operation names that are restricted while this ODA instance is attached.
        /// </value>
        [JsonProperty(PropertyName = "restrictedOperations")]
        public System.Collections.Generic.List<string> RestrictedOperations { get; set; }
        
        [JsonProperty(PropertyName = "owner")]
        public OdaInstanceOwner Owner { get; set; }
        
        /// <value>
        /// The time the attachment was created. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the attachment was last modified. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeLastUpdate")]
        public System.Nullable<System.DateTime> TimeLastUpdate { get; set; }
        
        /// <value>
        /// The current state of the attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OdaInstanceAttachment.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
