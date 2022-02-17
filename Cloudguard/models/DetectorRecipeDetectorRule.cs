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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Detector Recipe Rule
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
        /// Display name for DetectorRecipeDetectorRule.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description for DetectorRecipeDetectorRule.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Recommendation for DetectorRecipeDetectorRule
        /// </value>
        [JsonProperty(PropertyName = "recommendation")]
        public string Recommendation { get; set; }
        
        /// <value>
        /// detector for the rule
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Detector is required.")]
        [JsonProperty(PropertyName = "detector")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DetectorEnum> Detector { get; set; }
        
        /// <value>
        /// service type of the configuration to which the rule is applied
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceType is required.")]
        [JsonProperty(PropertyName = "serviceType")]
        public string ServiceType { get; set; }
        
        /// <value>
        /// resource type of the configuration to which the rule is applied
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
            Generic
        };

        /// <value>
        /// List of cloudguard managed list types related to this rule
        /// </value>
        [JsonProperty(PropertyName = "managedListTypes", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<ManagedListTypesEnum> ManagedListTypes { get; set; }
        
        /// <value>
        /// List of CandidateResponderRule related to this rule
        /// </value>
        [JsonProperty(PropertyName = "candidateResponderRules")]
        public System.Collections.Generic.List<CandidateResponderRule> CandidateResponderRules { get; set; }
        
        /// <value>
        /// The date and time the detector recipe rule was created. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the detector recipe rule was updated. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the DetectorRule.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
    }
}
