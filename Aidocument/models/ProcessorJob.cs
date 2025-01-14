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


namespace Oci.AidocumentService.Models
{
    /// <summary>
    /// Details of a processor job.
    /// </summary>
    public class ProcessorJob 
    {
        
        /// <value>
        /// The id of the processor job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The compartment identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the processor job.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProcessorConfig is required.")]
        [JsonProperty(PropertyName = "processorConfig")]
        public ProcessorConfig ProcessorConfig { get; set; }
        
        [JsonProperty(PropertyName = "inputLocation")]
        public InputLocation InputLocation { get; set; }
        
        /// <value>
        /// The job acceptance time.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeAccepted is required.")]
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// The job start time.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The job finish time.
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// How much progress the operation has made, compared to the total amount of work to be performed.
        /// </value>
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<float> PercentComplete { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OutputLocation is required.")]
        [JsonProperty(PropertyName = "outputLocation")]
        public OutputLocation OutputLocation { get; set; }
                ///
        /// <value>
        /// The current state of the processor job.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "CANCELED")]
            Canceled,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "CANCELING")]
            Canceling
        };

        /// <value>
        /// The current state of the processor job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// The detailed status of FAILED state.
        /// </value>
        ///
        public enum LifecycleDetailsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PARTIALLY_SUCCEEDED")]
            PartiallySucceeded,
            [EnumMember(Value = "COMPLETELY_FAILED")]
            CompletelyFailed
        };

        /// <value>
        /// The detailed status of FAILED state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleDetailsEnum> LifecycleDetails { get; set; }
        
    }
}
