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


namespace Oci.OperatoraccesscontrolService.Models
{
    /// <summary>
    /// An Operator Control Assignment identifies the target resource that is placed under the governance of an Operator Control. Creating an Operator Control Assignment Assignment with a time duration ensures that 
    /// human accesses to the target resource will be governed by Operator Control for the duration specified.
    /// 
    /// </summary>
    public class OperatorControlAssignment 
    {
        
        /// <value>
        /// The OCID of the operator control assignment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the operator control.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperatorControlId is required.")]
        [JsonProperty(PropertyName = "operatorControlId")]
        public string OperatorControlId { get; set; }
        
        /// <value>
        /// The OCID of the target resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Name of the target resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the target resource.
        /// </value>
        [JsonProperty(PropertyName = "resourceCompartmentId")]
        public string ResourceCompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the comparment that contains the operator control assignment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// resourceType for which the OperatorControlAssignment is applicable
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceTypes> ResourceType { get; set; }
        
        /// <value>
        /// The time at which the target resource will be brought under the governance of the operator control expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format. 
        /// Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeAssignmentFrom")]
        public System.Nullable<System.DateTime> TimeAssignmentFrom { get; set; }
        
        /// <value>
        /// The time at which the target resource will leave the governance of the operator control expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeAssignmentTo")]
        public System.Nullable<System.DateTime> TimeAssignmentTo { get; set; }
        
        /// <value>
        /// If set, then the target resource is always governed by the operator control.
        /// </value>
        [JsonProperty(PropertyName = "isEnforcedAlways")]
        public System.Nullable<bool> IsEnforcedAlways { get; set; }
        
        /// <value>
        /// The current lifcycle state of the OperatorControl.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperatorControlAssignmentLifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// More in detail about the lifeCycleState.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The OCID of the user who created this operator control assignment.
        /// </value>
        [JsonProperty(PropertyName = "assignerId")]
        public string AssignerId { get; set; }
        
        /// <value>
        /// Time when the operator control assignment is created in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format. Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfAssignment")]
        public System.Nullable<System.DateTime> TimeOfAssignment { get; set; }
        
        /// <value>
        /// Comment about the assignment of the operator control to this target resource.
        /// </value>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        
        /// <value>
        /// User id who released the operatorControl.
        /// </value>
        [JsonProperty(PropertyName = "unassignerId")]
        public string UnassignerId { get; set; }
        
        /// <value>
        /// Time on which the operator control assignment was deleted in [RFC 3339](https://tools.ietf.org/html/rfc3339)timestamp format.Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfDeletion")]
        public System.Nullable<System.DateTime> TimeOfDeletion { get; set; }
        
        /// <value>
        /// description containing reason for releasing of OperatorControl.
        /// </value>
        [JsonProperty(PropertyName = "detachmentDescription")]
        public string DetachmentDescription { get; set; }
        
        /// <value>
        /// If set indicates that the audit logs are being forwarded to the relevant remote logging server
        /// </value>
        [JsonProperty(PropertyName = "isLogForwarded")]
        public System.Nullable<bool> IsLogForwarded { get; set; }
        
        /// <value>
        /// The address of the remote syslog server where the audit logs are being forwarded to. Address in host or IP format.
        /// </value>
        [JsonProperty(PropertyName = "remoteSyslogServerAddress")]
        public string RemoteSyslogServerAddress { get; set; }
        
        /// <value>
        /// The listening port of the remote syslog server. The port range is 0 - 65535. Only TCP supported.
        /// </value>
        [JsonProperty(PropertyName = "remoteSyslogServerPort")]
        public System.Nullable<int> RemoteSyslogServerPort { get; set; }
        
        /// <value>
        /// The CA certificate of the remote syslog server.
        /// </value>
        [JsonProperty(PropertyName = "remoteSyslogServerCACert")]
        public string RemoteSyslogServerCACert { get; set; }
        
        /// <value>
        /// If set, then the hypervisor audit logs will be forwarded to the relevant remote syslog server
        /// </value>
        [JsonProperty(PropertyName = "isHypervisorLogForwarded")]
        public System.Nullable<bool> IsHypervisorLogForwarded { get; set; }
        
        /// <value>
        /// Name of the operator control name associated.
        /// </value>
        [JsonProperty(PropertyName = "opControlName")]
        public string OpControlName { get; set; }
        
        /// <value>
        /// The boolean if true would autoApprove during maintenance.
        /// </value>
        [JsonProperty(PropertyName = "isAutoApproveDuringMaintenance")]
        public System.Nullable<bool> IsAutoApproveDuringMaintenance { get; set; }
        
        /// <value>
        /// The code identifying the error occurred during Assignment operation.
        /// </value>
        [JsonProperty(PropertyName = "errorCode")]
        public System.Nullable<int> ErrorCode { get; set; }
        
        /// <value>
        /// The message describing the error occurred during Assignment operation.
        /// </value>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
        /// <value>
        /// Whether the assignment is a default assignment.   
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDefaultAssignment")]
        public System.Nullable<bool> IsDefaultAssignment { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
