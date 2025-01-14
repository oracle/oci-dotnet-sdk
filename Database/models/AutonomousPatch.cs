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
    
    public class AutonomousPatch 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the patch.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The text describing this patch package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The type of patch. BUNDLE is one example.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// A descriptive text associated with the lifecycleState.
        /// Typically can contain additional displayable text.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
                ///
        /// <value>
        /// The current state of the patch as a result of lastAction.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the patch as a result of lastAction.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time that the patch was released.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeReleased is required.")]
        [JsonProperty(PropertyName = "timeReleased")]
        public System.Nullable<System.DateTime> TimeReleased { get; set; }
        
        /// <value>
        /// The version of this patch package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
                ///
        /// <value>
        /// Database patching model preference. See [My Oracle Support note 2285040.1](https://support.oracle.com/rs?type=doc&id=2285040.1) for information on the Release Update (RU) and Release Update Revision (RUR) patching models.
        /// </value>
        ///
        public enum PatchModelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RELEASE_UPDATES")]
            ReleaseUpdates,
            [EnumMember(Value = "RELEASE_UPDATE_REVISIONS")]
            ReleaseUpdateRevisions
        };

        /// <value>
        /// Database patching model preference. See [My Oracle Support note 2285040.1](https://support.oracle.com/rs?type=doc&id=2285040.1) for information on the Release Update (RU) and Release Update Revision (RUR) patching models.
        /// </value>
        [JsonProperty(PropertyName = "patchModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatchModelEnum> PatchModel { get; set; }
        
        /// <value>
        /// First month of the quarter in which the patch was released.
        /// </value>
        [JsonProperty(PropertyName = "quarter")]
        public string Quarter { get; set; }
        
        /// <value>
        /// Year in which the patch was released.
        /// </value>
        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }
                ///
        /// <value>
        /// Maintenance run type, either \"QUARTERLY\" or \"TIMEZONE\".
        /// 
        /// </value>
        ///
        public enum AutonomousPatchTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "QUARTERLY")]
            Quarterly,
            [EnumMember(Value = "TIMEZONE")]
            Timezone
        };

        /// <value>
        /// Maintenance run type, either \"QUARTERLY\" or \"TIMEZONE\".
        /// 
        /// </value>
        [JsonProperty(PropertyName = "autonomousPatchType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AutonomousPatchTypeEnum> AutonomousPatchType { get; set; }
        
    }
}
