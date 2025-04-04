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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// A DetectorRecipeDetectorRule resource defines a single recipe rule in the collection for a DetectorRecipe resource.
    /// </summary>
    public class DetectorRecipeDetectorRule 
    {
        
        /// <value>
        /// The unique identifier of the detector rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DetectorRuleId is required.")]
        [JsonProperty(PropertyName = "detectorRuleId")]
        public string DetectorRuleId { get; set; }
        
        /// <value>
        /// Display name for DetectorRecipeDetectorRule resource
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description for DetectorRecipeDetectorRule resource
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Recommendation for DetectorRecipeDetectorRule resource
        /// </value>
        [JsonProperty(PropertyName = "recommendation")]
        public string Recommendation { get; set; }
        
        /// <value>
        /// Detector recipe for the rule
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Detector is required.")]
        [JsonProperty(PropertyName = "detector")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DetectorEnum> Detector { get; set; }
        
        /// <value>
        /// Service type of the configuration to which the rule is applied
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceType is required.")]
        [JsonProperty(PropertyName = "serviceType")]
        public string ServiceType { get; set; }
        
        /// <value>
        /// Resource type of the configuration to which the rule is applied
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        [JsonProperty(PropertyName = "details")]
        public DetectorDetails Details { get; set; }
                ///
        ///
        public enum ManagedListTypesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CIDR_BLOCK")]
            CidrBlock,
            [EnumMember(Value = "USERS")]
            Users,
            [EnumMember(Value = "GROUPS")]
            Groups,
            [EnumMember(Value = "IPV4ADDRESS")]
            Ipv4Address,
            [EnumMember(Value = "IPV6ADDRESS")]
            Ipv6Address,
            [EnumMember(Value = "RESOURCE_OCID")]
            ResourceOcid,
            [EnumMember(Value = "REGION")]
            Region,
            [EnumMember(Value = "COUNTRY")]
            Country,
            [EnumMember(Value = "STATE")]
            State,
            [EnumMember(Value = "CITY")]
            City,
            [EnumMember(Value = "TAGS")]
            Tags,
            [EnumMember(Value = "GENERIC")]
            Generic,
            [EnumMember(Value = "FUSION_APPS_ROLE")]
            FusionAppsRole,
            [EnumMember(Value = "FUSION_APPS_PERMISSION")]
            FusionAppsPermission
        };

        /// <value>
        /// List of managed list types related to this rule
        /// </value>
        [JsonProperty(PropertyName = "managedListTypes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<ManagedListTypesEnum> ManagedListTypes { get; set; }
        
        /// <value>
        /// List of responder rules that can be used to remediate this detector rule
        /// </value>
        [JsonProperty(PropertyName = "candidateResponderRules")]
        public System.Collections.Generic.List<CandidateResponderRule> CandidateResponderRules { get; set; }
        
        /// <value>
        /// The date and time the detector recipe rule was created. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the detector recipe rule was last updated. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current lifecycle state of the detector rule.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The unique identifier of the attached data source
        /// </value>
        [JsonProperty(PropertyName = "dataSourceId")]
        public string DataSourceId { get; set; }
        
        /// <value>
        /// Data source entities mapping for the detector rule
        /// </value>
        [JsonProperty(PropertyName = "entitiesMappings")]
        public System.Collections.Generic.List<EntitiesMapping> EntitiesMappings { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
    }
}
