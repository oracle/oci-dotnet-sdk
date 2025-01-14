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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// The description of work request, including its status.
    /// </summary>
    public class WorkRequest 
    {
        
        /// <value>
        /// The identifier of the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The identifier of the compartment that contains the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The identifier of the Digital Assistant instance to which this work request pertains.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OdaInstanceId is required.")]
        [JsonProperty(PropertyName = "odaInstanceId")]
        public string OdaInstanceId { get; set; }
        
        /// <value>
        /// The identifier of the resource to which this work request pertains.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
                ///
        /// <value>
        /// The type of the operation that's associated with the work request.
        /// </value>
        ///
        public enum RequestActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATE_ODA_INSTANCE")]
            CreateOdaInstance,
            [EnumMember(Value = "UPGRADE_ODA_INSTANCE")]
            UpgradeOdaInstance,
            [EnumMember(Value = "DELETE_ODA_INSTANCE")]
            DeleteOdaInstance,
            [EnumMember(Value = "PURGE_ODA_INSTANCE")]
            PurgeOdaInstance,
            [EnumMember(Value = "RECOVER_ODA_INSTANCE")]
            RecoverOdaInstance,
            [EnumMember(Value = "STOP_ODA_INSTANCE")]
            StopOdaInstance,
            [EnumMember(Value = "START_ODA_INSTANCE")]
            StartOdaInstance,
            [EnumMember(Value = "CHANGE_ODA_INSTANCE_COMPARTMENT")]
            ChangeOdaInstanceCompartment,
            [EnumMember(Value = "CHANGE_CUST_ENC_KEY")]
            ChangeCustEncKey,
            [EnumMember(Value = "DEACT_CUST_ENC_KEY")]
            DeactCustEncKey,
            [EnumMember(Value = "CREATE_ASSOCIATION")]
            CreateAssociation,
            [EnumMember(Value = "DELETE_ASSOCIATION")]
            DeleteAssociation,
            [EnumMember(Value = "CREATE_PCS_INSTANCE")]
            CreatePcsInstance,
            [EnumMember(Value = "UPDATE_ENTITLEMENTS_FOR_CACCT")]
            UpdateEntitlementsForCacct,
            [EnumMember(Value = "LOOKUP_ODA_INSTANCES_FOR_CACCT")]
            LookupOdaInstancesForCacct,
            [EnumMember(Value = "CREATE_ODA_INSTANCE_ATTACHMENT")]
            CreateOdaInstanceAttachment,
            [EnumMember(Value = "UPDATE_ODA_INSTANCE_ATTACHMENT")]
            UpdateOdaInstanceAttachment,
            [EnumMember(Value = "DELETE_ODA_INSTANCE_ATTACHMENT")]
            DeleteOdaInstanceAttachment,
            [EnumMember(Value = "CREATE_IMPORTED_PACKAGE")]
            CreateImportedPackage,
            [EnumMember(Value = "UPDATE_IMPORTED_PACKAGE")]
            UpdateImportedPackage,
            [EnumMember(Value = "DELETE_IMPORTED_PACKAGE")]
            DeleteImportedPackage,
            [EnumMember(Value = "IMPORT_BOT")]
            ImportBot,
            [EnumMember(Value = "CREATE_SKILL")]
            CreateSkill,
            [EnumMember(Value = "CLONE_SKILL")]
            CloneSkill,
            [EnumMember(Value = "EXTEND_SKILL")]
            ExtendSkill,
            [EnumMember(Value = "VERSION_SKILL")]
            VersionSkill,
            [EnumMember(Value = "EXPORT_SKILL")]
            ExportSkill,
            [EnumMember(Value = "CREATE_DIGITAL_ASSISTANT")]
            CreateDigitalAssistant,
            [EnumMember(Value = "CLONE_DIGITAL_ASSISTANT")]
            CloneDigitalAssistant,
            [EnumMember(Value = "EXTEND_DIGITAL_ASSISTANT")]
            ExtendDigitalAssistant,
            [EnumMember(Value = "VERSION_DIGITAL_ASSISTANT")]
            VersionDigitalAssistant,
            [EnumMember(Value = "EXPORT_DIGITAL_ASSISTANT")]
            ExportDigitalAssistant,
            [EnumMember(Value = "CREATE_ODA_PRIVATE_ENDPOINT")]
            CreateOdaPrivateEndpoint,
            [EnumMember(Value = "DELETE_ODA_PRIVATE_ENDPOINT")]
            DeleteOdaPrivateEndpoint,
            [EnumMember(Value = "UPDATE_ODA_PRIVATE_ENDPOINT")]
            UpdateOdaPrivateEndpoint,
            [EnumMember(Value = "CHANGE_ODA_PRIVATE_ENDPOINT_COMPARTMENT")]
            ChangeOdaPrivateEndpointCompartment,
            [EnumMember(Value = "CREATE_ODA_PRIVATE_ENDPOINT_SCAN_PROXY")]
            CreateOdaPrivateEndpointScanProxy,
            [EnumMember(Value = "DELETE_ODA_PRIVATE_ENDPOINT_SCAN_PROXY")]
            DeleteOdaPrivateEndpointScanProxy,
            [EnumMember(Value = "CREATE_ODA_PRIVATE_ENDPOINT_ATTACHMENT")]
            CreateOdaPrivateEndpointAttachment,
            [EnumMember(Value = "DELETE_ODA_PRIVATE_ENDPOINT_ATTACHMENT")]
            DeleteOdaPrivateEndpointAttachment,
            [EnumMember(Value = "TRAIN_SKILL")]
            TrainSkill,
            [EnumMember(Value = "DELETE_SKILL_ENTITIES")]
            DeleteSkillEntities,
            [EnumMember(Value = "IMPORT_SKILL_ENTITIES")]
            ImportSkillEntities
        };

        /// <value>
        /// The type of the operation that's associated with the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RequestAction is required.")]
        [JsonProperty(PropertyName = "requestAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RequestActionEnum> RequestAction { get; set; }
                ///
        /// <value>
        /// The status of current work request.
        /// </value>
        ///
        public enum StatusEnum {
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
            Canceled
        };

        /// <value>
        /// The status of current work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// A short message that provides more detail about the current status.
        /// For example, if a work request fails, then this may include information
        /// about why it failed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "statusMessage")]
        public string StatusMessage { get; set; }
        
        /// <value>
        /// The resources that this work request affects.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Resources is required.")]
        [JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.List<WorkRequestResource> Resources { get; set; }
        
        /// <value>
        /// Percentage of the request completed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PercentComplete is required.")]
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<float> PercentComplete { get; set; }
        
        /// <value>
        /// The date and time that the request was created, as described in
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeAccepted is required.")]
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// The date and time that the request was started, as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339), CKQ
        /// section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time that the object finished, as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339). CKQ
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
    }
}
