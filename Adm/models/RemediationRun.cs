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


namespace Oci.AdmService.Models
{
    /// <summary>
    /// A remediation run represents an execution of a Remediation Recipe to detect and fix vulnerabilities based on current state of the 
    /// Vulnerabilities curated in the Knowledge Base.
    /// A Run can be triggered manually or when a new CVE is discovered.
    /// 
    /// </summary>
    public class RemediationRun 
    {
        
        /// <value>
        /// The Oracle Cloud Identifier ([OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)) of the remediation run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the remediation run.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The list of remediation run stage summaries.
        /// </value>
        [JsonProperty(PropertyName = "stages")]
        public System.Collections.Generic.List<StageSummary> Stages { get; set; }
        
        /// <value>
        /// The Oracle Cloud Identifier ([OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)) of the Remediation Recipe.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RemediationRecipeId is required.")]
        [JsonProperty(PropertyName = "remediationRecipeId")]
        public string RemediationRecipeId { get; set; }
                ///
        /// <value>
        /// The source that triggered the Remediation Recipe.
        /// </value>
        ///
        public enum RemediationRunSourceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MANUAL")]
            Manual,
            [EnumMember(Value = "KNOWLEDGE_BASE")]
            KnowledgeBase
        };

        /// <value>
        /// The source that triggered the Remediation Recipe.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RemediationRunSource is required.")]
        [JsonProperty(PropertyName = "remediationRunSource")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RemediationRunSourceEnum> RemediationRunSource { get; set; }
        
        /// <value>
        /// The creation date and time of the remediation run (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the remediation run was last updated (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The date and time of the start of the remediation run (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time of the finish of the remediation run (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// The type of the current stage of the remediation run.
        /// </value>
        [JsonProperty(PropertyName = "currentStageType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RemediationRunStageType> CurrentStageType { get; set; }
        
        /// <value>
        /// The compartment Oracle Cloud Identifier ([OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)) of the remediation run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the remediation run.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "CANCELED")]
            Canceled,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current lifecycle state of the remediation run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
