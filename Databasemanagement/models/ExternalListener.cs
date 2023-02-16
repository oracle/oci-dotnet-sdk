/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of an external listener.
    /// </summary>
    public class ExternalListener 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the external listener.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The user-friendly name for the external listener. The name does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The name of the external listener.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComponentName is required.")]
        [JsonProperty(PropertyName = "componentName")]
        public string ComponentName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the external DB system that the listener is a part of.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExternalDbSystemId is required.")]
        [JsonProperty(PropertyName = "externalDbSystemId")]
        public string ExternalDbSystemId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the external connector.
        /// </value>
        [JsonProperty(PropertyName = "externalConnectorId")]
        public string ExternalConnectorId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the external DB node.
        /// </value>
        [JsonProperty(PropertyName = "externalDbNodeId")]
        public string ExternalDbNodeId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the external DB home.
        /// </value>
        [JsonProperty(PropertyName = "externalDbHomeId")]
        public string ExternalDbHomeId { get; set; }
        
        /// <value>
        /// The listener alias.
        /// </value>
        [JsonProperty(PropertyName = "listenerAlias")]
        public string ListenerAlias { get; set; }
                ///
        /// <value>
        /// The type of listener.
        /// </value>
        ///
        public enum ListenerTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ASM")]
            Asm,
            [EnumMember(Value = "LOCAL")]
            Local,
            [EnumMember(Value = "SCAN")]
            Scan
        };

        /// <value>
        /// The type of listener.
        /// </value>
        [JsonProperty(PropertyName = "listenerType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ListenerTypeEnum> ListenerType { get; set; }
        
        /// <value>
        /// The additional details of the external listener defined in `{\"key\": \"value\"}` format.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "additionalDetails")]
        public System.Collections.Generic.Dictionary<string, string> AdditionalDetails { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the external listener.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "NOT_CONNECTED")]
            NotConnected,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
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
        /// The current lifecycle state of the external listener.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The location of the listener configuration file listener.ora.
        /// </value>
        [JsonProperty(PropertyName = "listenerOraLocation")]
        public string ListenerOraLocation { get; set; }
        
        /// <value>
        /// The Oracle home location of the listener.
        /// </value>
        [JsonProperty(PropertyName = "oracleHome")]
        public string OracleHome { get; set; }
        
        /// <value>
        /// The name of the host on which the external listener is running.
        /// </value>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// The directory that stores tracing and logging incidents when Automatic Diagnostic Repository (ADR) is enabled.
        /// </value>
        [JsonProperty(PropertyName = "adrHomeDirectory")]
        public string AdrHomeDirectory { get; set; }
        
        /// <value>
        /// The destination directory of the listener log file.
        /// </value>
        [JsonProperty(PropertyName = "logDirectory")]
        public string LogDirectory { get; set; }
        
        /// <value>
        /// The destination directory of the listener trace file.
        /// </value>
        [JsonProperty(PropertyName = "traceDirectory")]
        public string TraceDirectory { get; set; }
        
        /// <value>
        /// The listener version.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The list of protocol addresses the listener is configured to listen on.
        /// </value>
        [JsonProperty(PropertyName = "endpoints")]
        public System.Collections.Generic.List<ExternalListenerEndpoint> Endpoints { get; set; }
        
        /// <value>
        /// The list of databases that are serviced by the listener.
        /// </value>
        [JsonProperty(PropertyName = "servicedDatabases")]
        public System.Collections.Generic.List<ExternalListenerServicedDatabase> ServicedDatabases { get; set; }
        
        /// <value>
        /// The list of ASMs that are serviced by the listener.
        /// </value>
        [JsonProperty(PropertyName = "servicedAsms")]
        public System.Collections.Generic.List<ExternalServicedAsm> ServicedAsms { get; set; }
        
        /// <value>
        /// The date and time the external listener was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the external listener was last updated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
    }
}
