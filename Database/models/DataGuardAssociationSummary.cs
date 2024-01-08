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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The properties that define a Data Guard association.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized, talk to an
    /// administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// For information about endpoints and signing API requests, see
    /// [About the API](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm). For information about available SDKs and tools, see
    /// [SDKS and Other Tools](https://docs.cloud.oracle.com/Content/API/Concepts/sdks.htm).
    /// 
    /// </summary>
    public class DataGuardAssociationSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Data Guard association.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the reporting database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseId is required.")]
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
                ///
        /// <value>
        /// The role of the reporting database in this Data Guard association.
        /// </value>
        ///
        public enum RoleEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "STANDBY")]
            Standby,
            [EnumMember(Value = "DISABLED_STANDBY")]
            DisabledStandby
        };

        /// <value>
        /// The role of the reporting database in this Data Guard association.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Role is required.")]
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }
                ///
        /// <value>
        /// The current state of the Data Guard association.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "UPGRADING")]
            Upgrading
        };

        /// <value>
        /// The current state of the Data Guard association.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycleState, if available.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the DB system containing the associated
        /// peer database.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeerDbSystemId is required.")]
        [JsonProperty(PropertyName = "peerDbSystemId")]
        public string PeerDbSystemId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Database Home containing the associated peer database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "peerDbHomeId")]
        public string PeerDbHomeId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the associated peer database.
        /// </value>
        [JsonProperty(PropertyName = "peerDatabaseId")]
        public string PeerDatabaseId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the peer database's Data Guard association.
        /// </value>
        [JsonProperty(PropertyName = "peerDataGuardAssociationId")]
        public string PeerDataGuardAssociationId { get; set; }
                ///
        /// <value>
        /// The role of the peer database in this Data Guard association.
        /// </value>
        ///
        public enum PeerRoleEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "STANDBY")]
            Standby,
            [EnumMember(Value = "DISABLED_STANDBY")]
            DisabledStandby
        };

        /// <value>
        /// The role of the peer database in this Data Guard association.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeerRole is required.")]
        [JsonProperty(PropertyName = "peerRole")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PeerRoleEnum> PeerRole { get; set; }
        
        /// <value>
        /// The lag time between updates to the primary database and application of the redo data on the standby database,
        /// as computed by the reporting database.
        /// <br/>
        /// Example: 9 seconds
        /// </value>
        [JsonProperty(PropertyName = "applyLag")]
        public string ApplyLag { get; set; }
        
        /// <value>
        /// The rate at which redo logs are synced between the associated databases.
        /// <br/>
        /// Example: 180 Mb per second
        /// </value>
        [JsonProperty(PropertyName = "applyRate")]
        public string ApplyRate { get; set; }
                ///
        /// <value>
        /// The protection mode of this Data Guard association. For more information, see
        /// [Oracle Data Guard Protection Modes](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-protection-modes.htm#SBYDB02000)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        ///
        public enum ProtectionModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MAXIMUM_AVAILABILITY")]
            MaximumAvailability,
            [EnumMember(Value = "MAXIMUM_PERFORMANCE")]
            MaximumPerformance,
            [EnumMember(Value = "MAXIMUM_PROTECTION")]
            MaximumProtection
        };

        /// <value>
        /// The protection mode of this Data Guard association. For more information, see
        /// [Oracle Data Guard Protection Modes](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-protection-modes.htm#SBYDB02000)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProtectionMode is required.")]
        [JsonProperty(PropertyName = "protectionMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProtectionModeEnum> ProtectionMode { get; set; }
                ///
        /// <value>
        /// The redo transport type used by this Data Guard association.  For more information, see
        /// [Redo Transport Services](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-redo-transport-services.htm#SBYDB00400)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        ///
        public enum TransportTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SYNC")]
            Sync,
            [EnumMember(Value = "ASYNC")]
            Async,
            [EnumMember(Value = "FASTSYNC")]
            Fastsync
        };

        /// <value>
        /// The redo transport type used by this Data Guard association.  For more information, see
        /// [Redo Transport Services](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-redo-transport-services.htm#SBYDB00400)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "transportType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TransportTypeEnum> TransportType { get; set; }
        
        /// <value>
        /// The date and time the Data Guard association was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// True if active Data Guard is enabled.
        /// </value>
        [JsonProperty(PropertyName = "isActiveDataGuardEnabled")]
        public System.Nullable<bool> IsActiveDataGuardEnabled { get; set; }
        
    }
}
