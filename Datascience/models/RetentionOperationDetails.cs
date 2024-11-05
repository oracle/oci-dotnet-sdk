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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Retention operation details for the model.
    /// </summary>
    public class RetentionOperationDetails 
    {
        
        /// <value>
        /// The archival status of model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArchiveState is required.")]
        [JsonProperty(PropertyName = "archiveState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModelSettingActionState> ArchiveState { get; set; }
        
        /// <value>
        /// The archival state details of the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArchiveStateDetails is required.")]
        [JsonProperty(PropertyName = "archiveStateDetails")]
        public string ArchiveStateDetails { get; set; }
        
        /// <value>
        /// The estimated archival time of the model based on the provided retention setting.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeArchivalScheduled is required.")]
        [JsonProperty(PropertyName = "timeArchivalScheduled")]
        public System.Nullable<System.DateTime> TimeArchivalScheduled { get; set; }
        
        /// <value>
        /// The deletion status of the archived model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeleteState is required.")]
        [JsonProperty(PropertyName = "deleteState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModelSettingActionState> DeleteState { get; set; }
        
        /// <value>
        /// The deletion status details of the archived model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeleteStateDetails is required.")]
        [JsonProperty(PropertyName = "deleteStateDetails")]
        public string DeleteStateDetails { get; set; }
        
        /// <value>
        /// The estimated deletion time of the model based on the provided retention setting.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeDeletionScheduled is required.")]
        [JsonProperty(PropertyName = "timeDeletionScheduled")]
        public System.Nullable<System.DateTime> TimeDeletionScheduled { get; set; }
        
    }
}