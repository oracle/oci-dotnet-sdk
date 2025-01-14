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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// It is the event in which the maintenance action will be be performed on the customer instance on the scheduled date and time.
    /// 
    /// </summary>
    public class InstanceMaintenanceEvent 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the maintenance event.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the instance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// This indicates the priority and allowed actions for this Maintenance. Higher priority forms of Maintenance have
        /// tighter restrictions and may not be rescheduled, while lower priority/severity Maintenance can be rescheduled,
        /// deferred, or even cancelled. Please see the
        /// [Instance Maintenance](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/placeholder.htm) documentation for details.
        /// 
        /// </value>
        ///
        public enum MaintenanceCategoryEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EMERGENCY")]
            Emergency,
            [EnumMember(Value = "MANDATORY")]
            Mandatory,
            [EnumMember(Value = "FLEXIBLE")]
            Flexible,
            [EnumMember(Value = "OPTIONAL")]
            Optional,
            [EnumMember(Value = "NOTIFICATION")]
            Notification
        };

        /// <value>
        /// This indicates the priority and allowed actions for this Maintenance. Higher priority forms of Maintenance have
        /// tighter restrictions and may not be rescheduled, while lower priority/severity Maintenance can be rescheduled,
        /// deferred, or even cancelled. Please see the
        /// [Instance Maintenance](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/placeholder.htm) documentation for details.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaintenanceCategory is required.")]
        [JsonProperty(PropertyName = "maintenanceCategory")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MaintenanceCategoryEnum> MaintenanceCategory { get; set; }
                ///
        /// <value>
        /// This is the reason that Maintenance is being performed. See
        /// [Instance Maintenance](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/placeholder.htm) documentation for details.
        /// 
        /// </value>
        ///
        public enum MaintenanceReasonEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EVACUATION")]
            Evacuation,
            [EnumMember(Value = "ENVIRONMENTAL_FACTORS")]
            EnvironmentalFactors,
            [EnumMember(Value = "DECOMMISSION")]
            Decommission,
            [EnumMember(Value = "HARDWARE_REPLACEMENT")]
            HardwareReplacement,
            [EnumMember(Value = "FIRMWARE_UPDATE")]
            FirmwareUpdate,
            [EnumMember(Value = "SECURITY_UPDATE")]
            SecurityUpdate
        };

        /// <value>
        /// This is the reason that Maintenance is being performed. See
        /// [Instance Maintenance](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/placeholder.htm) documentation for details.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaintenanceReason is required.")]
        [JsonProperty(PropertyName = "maintenanceReason")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MaintenanceReasonEnum> MaintenanceReason { get; set; }
                ///
        /// <value>
        /// This is the action that will be performed on the Instance by OCI when the Maintenance begins.
        /// 
        /// </value>
        ///
        public enum InstanceActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "REBOOT_MIGRATION")]
            RebootMigration,
            [EnumMember(Value = "TERMINATE")]
            Terminate,
            [EnumMember(Value = "STOP")]
            Stop,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// This is the action that will be performed on the Instance by OCI when the Maintenance begins.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceAction is required.")]
        [JsonProperty(PropertyName = "instanceAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<InstanceActionEnum> InstanceAction { get; set; }
        
        /// <value>
        /// These are alternative actions to the requested instanceAction that can be taken to resolve the Maintenance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AlternativeResolutionActions is required.")]
        [JsonProperty(PropertyName = "alternativeResolutionActions", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<InstanceMaintenanceAlternativeResolutionActions> AlternativeResolutionActions { get; set; }
        
        /// <value>
        /// The time at which the Maintenance actually started.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time at which the Maintenance actually finished.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// The beginning of the time window when Maintenance is scheduled to begin. The Maintenance will not begin before
        /// this time.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeWindowStart is required.")]
        [JsonProperty(PropertyName = "timeWindowStart")]
        public System.Nullable<System.DateTime> TimeWindowStart { get; set; }
        
        /// <value>
        /// The duration of the time window Maintenance is scheduled to begin within.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "startWindowDuration")]
        public string StartWindowDuration { get; set; }
        
        /// <value>
        /// This is the estimated duration of the Maintenance, once the Maintenance has entered the STARTED state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "estimatedDuration")]
        public string EstimatedDuration { get; set; }
        
        /// <value>
        /// It is the scheduled hard due date and time of the maintenance event.
        /// The maintenance event will happen at this time and the due date will not be extended.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeHardDueDate")]
        public System.Nullable<System.DateTime> TimeHardDueDate { get; set; }
        
        /// <value>
        /// Indicates if this MaintenanceEvent is capable of being rescheduled up to the timeHardDueDate.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CanReschedule is required.")]
        [JsonProperty(PropertyName = "canReschedule")]
        public System.Nullable<bool> CanReschedule { get; set; }
        
        /// <value>
        /// The date and time the maintenance event was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The current state of the maintenance event.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SCHEDULED")]
            Scheduled,
            [EnumMember(Value = "STARTED")]
            Started,
            [EnumMember(Value = "PROCESSING")]
            Processing,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// The current state of the maintenance event.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Provides more details about the state of the maintenance event.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
                ///
        /// <value>
        /// The creator of the maintenance event.
        /// 
        /// </value>
        ///
        public enum CreatedByEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CUSTOMER")]
            Customer,
            [EnumMember(Value = "SYSTEM")]
            System
        };

        /// <value>
        /// The creator of the maintenance event.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreatedBy is required.")]
        [JsonProperty(PropertyName = "createdBy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CreatedByEnum> CreatedBy { get; set; }
        
        /// <value>
        /// It is the descriptive information about the maintenance taking place on the customer instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A unique identifier that will group Instances that have a relationship with one another and must be scheduled
        /// together for the Maintenance to proceed. Any Instances that have a relationship with one another from a Maintenance
        /// perspective will have a matching correlationToken.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "correlationToken")]
        public string CorrelationToken { get; set; }
        
        /// <value>
        /// For Instances that have local storage, this field is set to true when local storage
        /// will be deleted as a result of the Maintenance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "canDeleteLocalStorage")]
        public System.Nullable<bool> CanDeleteLocalStorage { get; set; }
        
        /// <value>
        /// Additional details of the maintenance in the form of json.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "additionalDetails")]
        public System.Collections.Generic.Dictionary<string, string> AdditionalDetails { get; set; }
        
    }
}
