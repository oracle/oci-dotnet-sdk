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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// A resource that tracks the differences between sensitive columns in the sensitive data model and masking columns in the masking policy
    /// </summary>
    public class SdmMaskingPolicyDifference 
    {
        
        /// <value>
        /// The OCID of the Sensitive data model and masking policy difference resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the Sensitive data model and masking policy difference resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The type of the SDM masking policy difference. It defines the difference scope.
        /// NEW identifies new sensitive columns in the sensitive data model that are not in the masking policy.
        /// DELETED identifies columns that are present in the masking policy but have been deleted from the sensitive data model.
        /// MODIFIED identifies columns that are present in the sensitive data model as well as the masking policy but some of their attributes have been modified.
        /// ALL covers all the above three scenarios and reports new, deleted and modified columns.
        /// 
        /// </value>
        ///
        public enum DifferenceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ALL")]
            All,
            [EnumMember(Value = "NEW")]
            New,
            [EnumMember(Value = "MODIFIED")]
            Modified,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The type of the SDM masking policy difference. It defines the difference scope.
        /// NEW identifies new sensitive columns in the sensitive data model that are not in the masking policy.
        /// DELETED identifies columns that are present in the masking policy but have been deleted from the sensitive data model.
        /// MODIFIED identifies columns that are present in the sensitive data model as well as the masking policy but some of their attributes have been modified.
        /// ALL covers all the above three scenarios and reports new, deleted and modified columns.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DifferenceType is required.")]
        [JsonProperty(PropertyName = "differenceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DifferenceTypeEnum> DifferenceType { get; set; }
        
        /// <value>
        /// The display name of the SDM masking policy difference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The date and time the SDM masking policy difference was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the SDM masking policy difference creation started, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreationStarted is required.")]
        [JsonProperty(PropertyName = "timeCreationStarted")]
        public System.Nullable<System.DateTime> TimeCreationStarted { get; set; }
                ///
        /// <value>
        /// The current state of the SDM masking policy difference.
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
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the SDM masking policy difference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The OCID of the sensitive data model associated with the SDM masking policy difference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SensitiveDataModelId is required.")]
        [JsonProperty(PropertyName = "sensitiveDataModelId")]
        public string SensitiveDataModelId { get; set; }
        
        /// <value>
        /// The OCID of the masking policy associated with the SDM masking policy difference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaskingPolicyId is required.")]
        [JsonProperty(PropertyName = "maskingPolicyId")]
        public string MaskingPolicyId { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace. For more information, see Resource Tags.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
