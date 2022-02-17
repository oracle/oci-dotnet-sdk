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


namespace Oci.AispeechService.Models
{
    /// <summary>
    /// Description of Transcription Job.
    /// </summary>
    public class TranscriptionJob 
    {
        
        /// <value>
        /// Unique identifier that is immutable on creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Job name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the transcriptionJob.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Job description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelDetails is required.")]
        [JsonProperty(PropertyName = "modelDetails")]
        public TranscriptionModelDetails ModelDetails { get; set; }
        
        [JsonProperty(PropertyName = "normalization")]
        public TranscriptionNormalization Normalization { get; set; }
        
        /// <value>
        /// Job accepted time.
        /// </value>
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// Job started time.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// Job finished time.
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// Total tasks in a job.
        /// </value>
        [JsonProperty(PropertyName = "totalTasks")]
        public System.Nullable<int> TotalTasks { get; set; }
        
        /// <value>
        /// Total outstanding tasks in a job.
        /// </value>
        [JsonProperty(PropertyName = "outstandingTasks")]
        public System.Nullable<int> OutstandingTasks { get; set; }
        
        /// <value>
        /// Total successful tasks in a job.
        /// </value>
        [JsonProperty(PropertyName = "successfulTasks")]
        public System.Nullable<int> SuccessfulTasks { get; set; }
        
        /// <value>
        /// Time to live duration in days for Job. Job will be available till max 90 days.
        /// </value>
        [JsonProperty(PropertyName = "ttlInDays")]
        public System.Nullable<int> TtlInDays { get; set; }
        
        /// <value>
        /// How much progress the operation has made, vs the total amount of work that must be performed.
        /// </value>
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<int> PercentComplete { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InputLocation is required.")]
        [JsonProperty(PropertyName = "inputLocation")]
        public InputLocation InputLocation { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OutputLocation is required.")]
        [JsonProperty(PropertyName = "outputLocation")]
        public OutputLocation OutputLocation { get; set; }
        
        /// <value>
        /// OCID of the user who created the transcriptionJob.
        /// </value>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
                ///
        /// <value>
        /// The current state of the Job.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// The current state of the Job.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
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
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
