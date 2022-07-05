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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsConfigWorkRequest
    /// </summary>
    public class LogAnalyticsConfigWorkRequest 
    {
        
        /// <value>
        /// The workrequest unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The compartment unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The operation type.  There are two classes of operations, association operations and
        /// lookup operations.  Associations may be created or deleted, and lookup operations include
        /// append, update and delete.
        /// 
        /// </value>
        ///
        public enum OperationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATE_ASSOCIATIONS")]
            CreateAssociations,
            [EnumMember(Value = "DELETE_ASSOCIATIONS")]
            DeleteAssociations,
            [EnumMember(Value = "APPEND_LOOKUP_DATA")]
            AppendLookupData,
            [EnumMember(Value = "UPDATE_LOOKUP_DATA")]
            UpdateLookupData,
            [EnumMember(Value = "DELETE_LOOKUP")]
            DeleteLookup
        };

        /// <value>
        /// The operation type.  There are two classes of operations, association operations and
        /// lookup operations.  Associations may be created or deleted, and lookup operations include
        /// append, update and delete.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
        
        /// <value>
        /// The list of config work request responses.
        /// </value>
        [JsonProperty(PropertyName = "payload")]
        public System.Collections.Generic.List<LogAnalyticsConfigWorkRequestPayload> Payload { get; set; }
        
        /// <value>
        /// The completion percentage.
        /// </value>
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<long> PercentComplete { get; set; }
        
        /// <value>
        /// The time at which the work request was started.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time at which the work request was accepted.
        /// </value>
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// The time at which the work request was finished.
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
                ///
        /// <value>
        /// The lifecycle status.  Valid values are ACCEPTED, IN_PROGRESS, SUCCEEDED
        /// or FAILED
        /// 
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
            Failed
        };

        /// <value>
        /// The lifecycle status.  Valid values are ACCEPTED, IN_PROGRESS, SUCCEEDED
        /// or FAILED
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
    }
}
