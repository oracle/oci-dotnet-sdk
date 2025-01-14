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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Required pipeline options to configure the replication process (Extract or Replicat).
    /// 
    /// </summary>
    public class ProcessOptions 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InitialDataLoad is required.")]
        [JsonProperty(PropertyName = "initialDataLoad")]
        public InitialDataLoad InitialDataLoad { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReplicateSchemaChange is required.")]
        [JsonProperty(PropertyName = "replicateSchemaChange")]
        public ReplicateSchemaChange ReplicateSchemaChange { get; set; }
                ///
        /// <value>
        /// If ENABLED, then the replication process restarts itself upon failure. This option applies when creating or updating a pipeline.
        /// 
        /// </value>
        ///
        public enum ShouldRestartOnFailureEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// If ENABLED, then the replication process restarts itself upon failure. This option applies when creating or updating a pipeline.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShouldRestartOnFailure is required.")]
        [JsonProperty(PropertyName = "shouldRestartOnFailure")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ShouldRestartOnFailureEnum> ShouldRestartOnFailure { get; set; }
        
    }
}
