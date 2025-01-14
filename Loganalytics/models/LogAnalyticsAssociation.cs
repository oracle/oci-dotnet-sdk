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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsAssociation
    /// </summary>
    public class LogAnalyticsAssociation 
    {
        
        /// <value>
        /// The failure message.
        /// </value>
        [JsonProperty(PropertyName = "failureMessage")]
        public string FailureMessage { get; set; }
        
        /// <value>
        /// The agent unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "agentId")]
        public string AgentId { get; set; }
        
        /// <value>
        /// The last attempt date.
        /// </value>
        [JsonProperty(PropertyName = "timeLastAttempted")]
        public System.Nullable<System.DateTime> TimeLastAttempted { get; set; }
        
        /// <value>
        /// The number of times the association will be attempted
        /// before failing.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "retryCount")]
        public System.Nullable<long> RetryCount { get; set; }
        
        /// <value>
        /// The source name.
        /// </value>
        [JsonProperty(PropertyName = "sourceName")]
        public string SourceName { get; set; }
        
        /// <value>
        /// The source display name.
        /// </value>
        [JsonProperty(PropertyName = "sourceDisplayName")]
        public string SourceDisplayName { get; set; }
        
        /// <value>
        /// The source type internal name.
        /// </value>
        [JsonProperty(PropertyName = "sourceTypeName")]
        public string SourceTypeName { get; set; }
                ///
        /// <value>
        /// The lifecycle status.  Valid values are ACCEPTED, IN_PROGRESS, SUCCEEDED
        /// or FAILED.
        /// 
        /// </value>
        ///
        public enum LifeCycleStateEnum {
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
        /// or FAILED.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifeCycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifeCycleStateEnum> LifeCycleState { get; set; }
        
        /// <value>
        /// The entity unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }
        
        /// <value>
        /// The entity name.
        /// </value>
        [JsonProperty(PropertyName = "entityName")]
        public string EntityName { get; set; }
        
        /// <value>
        /// The entity type internal name.
        /// </value>
        [JsonProperty(PropertyName = "entityTypeName")]
        public string EntityTypeName { get; set; }
        
        /// <value>
        /// The host name.
        /// </value>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// The name of the entity which contains the agent.
        /// </value>
        [JsonProperty(PropertyName = "agentEntityName")]
        public string AgentEntityName { get; set; }
        
        /// <value>
        /// The entity type display name.
        /// </value>
        [JsonProperty(PropertyName = "entityTypeDisplayName")]
        public string EntityTypeDisplayName { get; set; }
        
        /// <value>
        /// The log group unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "logGroupId")]
        public string LogGroupId { get; set; }
        
        /// <value>
        /// The log group name.
        /// </value>
        [JsonProperty(PropertyName = "logGroupName")]
        public string LogGroupName { get; set; }
        
        /// <value>
        /// The log group compartment.
        /// </value>
        [JsonProperty(PropertyName = "logGroupCompartment")]
        public string LogGroupCompartment { get; set; }
        
        /// <value>
        /// A list of association properties.
        /// </value>
        [JsonProperty(PropertyName = "associationProperties")]
        public System.Collections.Generic.List<AssociationProperty> AssociationProperties { get; set; }
        
    }
}
