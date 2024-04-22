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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides additional information for a software update event.
    /// </summary>
    public class SoftwareUpdateEventData 
    {
                ///
        /// <value>
        /// Type of software update operation.
        /// </value>
        ///
        public enum OperationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UPDATE_ALL_PACKAGES")]
            UpdateAllPackages,
            [EnumMember(Value = "INSTALL_PACKAGES")]
            InstallPackages,
            [EnumMember(Value = "REMOVE_PACKAGES")]
            RemovePackages,
            [EnumMember(Value = "UPDATE_PACKAGES")]
            UpdatePackages,
            [EnumMember(Value = "UPDATE_SECURITY")]
            UpdateSecurity,
            [EnumMember(Value = "UPDATE_BUGFIX")]
            UpdateBugfix,
            [EnumMember(Value = "UPDATE_ENHANCEMENT")]
            UpdateEnhancement,
            [EnumMember(Value = "UPDATE_OTHER")]
            UpdateOther
        };

        /// <value>
        /// Type of software update operation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
        
        /// <value>
        /// Status of the software update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EventStatus> Status { get; set; }
        
        [JsonProperty(PropertyName = "additionalDetails")]
        public WorkRequestEventDataAdditionalDetails AdditionalDetails { get; set; }
        
    }
}
