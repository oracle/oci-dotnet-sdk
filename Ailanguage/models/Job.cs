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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// Job details which contain input document details on which prediction need to run, features (which and all language services ) need to run and where to store results
    /// </summary>
    public class Job 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A user-friendly display name for the job.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A short description of the job.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InputLocation is required.")]
        [JsonProperty(PropertyName = "inputLocation")]
        public InputLocation InputLocation { get; set; }
        
        [JsonProperty(PropertyName = "inputConfiguration")]
        public InputConfiguration InputConfiguration { get; set; }
        
        /// <value>
        /// training model details
        /// For this release only one model is allowed to be input here.
        /// One of the three modelType, ModelId, endpointId should be given other wise error will be thrown from API
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelMetadataDetails is required.")]
        [JsonProperty(PropertyName = "modelMetadataDetails")]
        public System.Collections.Generic.List<ModelMetadataDetails> ModelMetadataDetails { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment where you want to create the job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The current state of the Job.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
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
            Canceled,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current state of the Job.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// How much progress the operation has made, vs the total amount of work that must be performed.
        /// </value>
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<int> PercentComplete { get; set; }
        
        /// <value>
        /// Total number of documents given as input for prediction. For CSV this signifies number of rows and for TXT this signifies number of files.
        /// </value>
        [JsonProperty(PropertyName = "totalDocuments")]
        public System.Nullable<int> TotalDocuments { get; set; }
        
        /// <value>
        /// Number of documents still to process. For CSV this signifies number of rows and for TXT this signifies number of files.
        /// </value>
        [JsonProperty(PropertyName = "pendingDocuments")]
        public System.Nullable<int> PendingDocuments { get; set; }
        
        /// <value>
        /// Number of documents processed for prediction. For CSV this signifies number of rows and for TXT this signifies number of files.
        /// </value>
        [JsonProperty(PropertyName = "completedDocuments")]
        public System.Nullable<int> CompletedDocuments { get; set; }
        
        /// <value>
        /// Number of documents failed for prediction. For CSV this signifies number of rows and for TXT this signifies number of files.
        /// </value>
        [JsonProperty(PropertyName = "failedDocuments")]
        public System.Nullable<int> FailedDocuments { get; set; }
        
        /// <value>
        /// warnings count
        /// </value>
        [JsonProperty(PropertyName = "warningsCount")]
        public System.Nullable<int> WarningsCount { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OutputLocation is required.")]
        [JsonProperty(PropertyName = "outputLocation")]
        public ObjectPrefixOutputLocation OutputLocation { get; set; }
        
        /// <value>
        /// Time to live duration in days for Job. Job will be available till max 90 days.
        /// </value>
        [JsonProperty(PropertyName = "ttlInDays")]
        public System.Nullable<int> TtlInDays { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the user who created the job.
        /// </value>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
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
        [JsonProperty(PropertyName = "timeCompleted")]
        public System.Nullable<System.DateTime> TimeCompleted { get; set; }
        
    }
}
