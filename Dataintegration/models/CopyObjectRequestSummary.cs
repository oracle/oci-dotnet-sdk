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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Copy metadata object response summary.
    /// </summary>
    public class CopyObjectRequestSummary 
    {
        
        /// <value>
        /// Copy object request key.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The workspace id of the source from where we need to copy object.
        /// </value>
        [JsonProperty(PropertyName = "sourceWorkspaceId")]
        public string SourceWorkspaceId { get; set; }
        
        /// <value>
        /// The list of the objects to be copied.
        /// </value>
        [JsonProperty(PropertyName = "objectKeys")]
        public System.Collections.Generic.List<string> ObjectKeys { get; set; }
        
        [JsonProperty(PropertyName = "copyConflictResolution")]
        public CopyConflictResolution CopyConflictResolution { get; set; }
                ///
        /// <value>
        /// Copy Object request status.
        /// </value>
        ///
        public enum CopyMetadataObjectRequestStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUCCESSFUL")]
            Successful,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "QUEUED")]
            Queued,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// Copy Object request status.
        /// </value>
        [JsonProperty(PropertyName = "copyMetadataObjectRequestStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CopyMetadataObjectRequestStatusEnum> CopyMetadataObjectRequestStatus { get; set; }
        
        /// <value>
        /// OCID of the user who initiated copy request.
        /// </value>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// Name of the user who created the copy object request.
        /// </value>
        [JsonProperty(PropertyName = "createdByName")]
        public string CreatedByName { get; set; }
        
        /// <value>
        /// Number of source objects to be copied.
        /// </value>
        [JsonProperty(PropertyName = "totalSourceObjectCount")]
        public System.Nullable<int> TotalSourceObjectCount { get; set; }
        
        /// <value>
        /// Number of objects copied into the target.
        /// </value>
        [JsonProperty(PropertyName = "totalObjectsCopiedIntoTarget")]
        public System.Nullable<int> TotalObjectsCopiedIntoTarget { get; set; }
        
        /// <value>
        /// Time at which the request started getting processed.
        /// </value>
        [JsonProperty(PropertyName = "timeStartedInMillis")]
        public System.Nullable<long> TimeStartedInMillis { get; set; }
        
        /// <value>
        /// Time at which the request was completely processed.
        /// </value>
        [JsonProperty(PropertyName = "timeEndedInMillis")]
        public System.Nullable<long> TimeEndedInMillis { get; set; }
        
        /// <value>
        /// The array of copy object details.
        /// </value>
        [JsonProperty(PropertyName = "copiedItems")]
        public System.Collections.Generic.List<CopyObjectMetadataSummary> CopiedItems { get; set; }
        
        /// <value>
        /// The array of copied referenced objects.
        /// </value>
        [JsonProperty(PropertyName = "referencedItems")]
        public System.Collections.Generic.List<CopyObjectMetadataSummary> ReferencedItems { get; set; }
        
        /// <value>
        /// Name of the copy object request.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }
}
