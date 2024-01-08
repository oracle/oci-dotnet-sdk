/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The tsk schedule summary information.
    /// </summary>
    public class TaskScheduleSummary 
    {
        
        /// <value>
        /// Generated key that can be used in API calls to identify taskSchedule. On scenarios where reference to the taskSchedule is needed, a value can be passed in create.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// This is a version number that is used by the service to upgrade objects if needed through releases of the service.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        /// <value>
        /// The type of the object.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        public string ModelType { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Detailed description for the object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// This is used by the service for optimistic locking of the object, to prevent multiple users from simultaneously updating the object.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        [JsonProperty(PropertyName = "scheduleRef")]
        public Schedule ScheduleRef { get; set; }
        
        [JsonProperty(PropertyName = "configProviderDelegate")]
        public ConfigProvider ConfigProviderDelegate { get; set; }
        
        /// <value>
        /// Whether the task schedule is enabled.
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The number of retries.
        /// </value>
        [JsonProperty(PropertyName = "numberOfRetries")]
        public System.Nullable<int> NumberOfRetries { get; set; }
        
        /// <value>
        /// The retry delay, the unit for measurement is in the property retry delay unit.
        /// </value>
        [JsonProperty(PropertyName = "retryDelay")]
        public System.Double RetryDelay { get; set; }
                ///
        /// <value>
        /// The unit for the retry delay.
        /// </value>
        ///
        public enum RetryDelayUnitEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SECONDS")]
            Seconds,
            [EnumMember(Value = "MINUTES")]
            Minutes,
            [EnumMember(Value = "HOURS")]
            Hours,
            [EnumMember(Value = "DAYS")]
            Days
        };

        /// <value>
        /// The unit for the retry delay.
        /// </value>
        [JsonProperty(PropertyName = "retryDelayUnit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RetryDelayUnitEnum> RetryDelayUnit { get; set; }
        
        /// <value>
        /// The start time in milliseconds.
        /// </value>
        [JsonProperty(PropertyName = "startTimeMillis")]
        public System.Nullable<long> StartTimeMillis { get; set; }
        
        /// <value>
        /// The end time in milliseconds.
        /// </value>
        [JsonProperty(PropertyName = "endTimeMillis")]
        public System.Nullable<long> EndTimeMillis { get; set; }
        
        /// <value>
        /// Whether the same task can be executed concurrently.
        /// </value>
        [JsonProperty(PropertyName = "isConcurrentAllowed")]
        public System.Nullable<bool> IsConcurrentAllowed { get; set; }
        
        /// <value>
        /// Whether the backfill is enabled.
        /// </value>
        [JsonProperty(PropertyName = "isBackfillEnabled")]
        public System.Nullable<bool> IsBackfillEnabled { get; set; }
                ///
        /// <value>
        /// The authorization mode for the task.
        /// </value>
        ///
        public enum AuthModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OBO")]
            Obo,
            [EnumMember(Value = "RESOURCE_PRINCIPAL")]
            ResourcePrincipal,
            [EnumMember(Value = "USER_CERTIFICATE")]
            UserCertificate
        };

        /// <value>
        /// The authorization mode for the task.
        /// </value>
        [JsonProperty(PropertyName = "authMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AuthModeEnum> AuthMode { get; set; }
        
        /// <value>
        /// The expected duration of the task execution.
        /// </value>
        [JsonProperty(PropertyName = "expectedDuration")]
        public System.Double ExpectedDuration { get; set; }
                ///
        /// <value>
        /// The expected duration unit of the task execution.
        /// </value>
        ///
        public enum ExpectedDurationUnitEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SECONDS")]
            Seconds,
            [EnumMember(Value = "MINUTES")]
            Minutes,
            [EnumMember(Value = "HOURS")]
            Hours,
            [EnumMember(Value = "DAYS")]
            Days
        };

        /// <value>
        /// The expected duration unit of the task execution.
        /// </value>
        [JsonProperty(PropertyName = "expectedDurationUnit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExpectedDurationUnitEnum> ExpectedDurationUnit { get; set; }
        
        /// <value>
        /// The time for next run in milliseconds.
        /// </value>
        [JsonProperty(PropertyName = "nextRunTimeMillis")]
        public System.Nullable<long> NextRunTimeMillis { get; set; }
        
        [JsonProperty(PropertyName = "lastRunDetails")]
        public LastRunDetails LastRunDetails { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
        
    }
}
