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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The scheduling details for the quarterly maintenance window. Patching and system updates take place during the maintenance window.
    /// 
    /// </summary>
    public class DbServerPatchingDetails 
    {
        
        /// <value>
        /// Estimated time, in minutes, to patch one database server.
        /// </value>
        [JsonProperty(PropertyName = "estimatedPatchDuration")]
        public System.Nullable<int> EstimatedPatchDuration { get; set; }
                ///
        /// <value>
        /// The status of the patching operation.
        /// </value>
        ///
        public enum PatchingStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SCHEDULED")]
            Scheduled,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "COMPLETE")]
            Complete
        };

        /// <value>
        /// The status of the patching operation.
        /// </value>
        [JsonProperty(PropertyName = "patchingStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatchingStatusEnum> PatchingStatus { get; set; }
        
        /// <value>
        /// The time when the patching operation started.
        /// </value>
        [JsonProperty(PropertyName = "timePatchingStarted")]
        public System.Nullable<System.DateTime> TimePatchingStarted { get; set; }
        
        /// <value>
        /// The time when the patching operation ended.
        /// </value>
        [JsonProperty(PropertyName = "timePatchingEnded")]
        public System.Nullable<System.DateTime> TimePatchingEnded { get; set; }
        
    }
}
