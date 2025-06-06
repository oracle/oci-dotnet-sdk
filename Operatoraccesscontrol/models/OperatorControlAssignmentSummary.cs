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
    /// Details of the operator control assignment.
    /// </summary>
    public class OperatorControlAssignmentSummary 
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
        /// The OCID of the target resource being governed by the operator control.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the operator control assignment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// resourceType for which the OperatorControlAssignment is applicable
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceTypes> ResourceType { get; set; }
        
        /// <value>
        /// Name of the target resource.
        /// </value>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// Name of the operator control name associated.
        /// </value>
        [JsonProperty(PropertyName = "opControlName")]
        public string OpControlName { get; set; }
        
        /// <value>
        /// The time at which the target resource will be brought under the governance of the operator control in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format. Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeAssignmentFrom")]
        public System.Nullable<System.DateTime> TimeAssignmentFrom { get; set; }
        
        /// <value>
        /// The time at which the target resource will leave the governance of the operator control in [RFC 3339](https://tools.ietf.org/html/rfc3339)timestamp format.Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeAssignmentTo")]
        public System.Nullable<System.DateTime> TimeAssignmentTo { get; set; }
        
        /// <value>
        /// If true, then the target resource is always governed by the operator control. Otherwise governance is time-based as specified by timeAssignmentTo and timeAssignmentFrom.
        /// </value>
        [JsonProperty(PropertyName = "isEnforcedAlways")]
        public System.Nullable<bool> IsEnforcedAlways { get; set; }
        
        /// <value>
        /// Time when the operator control assignment is created in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format. Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfAssignment")]
        public System.Nullable<System.DateTime> TimeOfAssignment { get; set; }
        
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
        /// If set, then the audit logs are being forwarded to the relevant remote logging server
        /// </value>
        [JsonProperty(PropertyName = "isLogForwarded")]
        public System.Nullable<bool> IsLogForwarded { get; set; }
        
        /// <value>
        /// The address of the remote syslog server where the audit logs are being forwarded to. Address in host or IP format.
        /// </value>
        [JsonProperty(PropertyName = "remoteSyslogServerAddress")]
        public string RemoteSyslogServerAddress { get; set; }
        
        /// <value>
        /// The listening port of the remote syslog server. The port range is 0 - 65535.
        /// </value>
        [JsonProperty(PropertyName = "remoteSyslogServerPort")]
        public System.Nullable<int> RemoteSyslogServerPort { get; set; }
        
        /// <value>
        /// If set, then the hypervisor audit logs will be forwarded to the relevant remote syslog server
        /// </value>
        [JsonProperty(PropertyName = "isHypervisorLogForwarded")]
        public System.Nullable<bool> IsHypervisorLogForwarded { get; set; }
        
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
