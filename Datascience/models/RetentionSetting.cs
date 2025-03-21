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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Retention setting details of the model.
    /// </summary>
    public class RetentionSetting 
    {
        
        /// <value>
        /// Number of days after which the model will be archived.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArchiveAfterDays is required.")]
        [JsonProperty(PropertyName = "archiveAfterDays")]
        public System.Nullable<int> ArchiveAfterDays { get; set; }
        
        /// <value>
        /// Number of days after which the archived model will be deleted.
        /// </value>
        [JsonProperty(PropertyName = "deleteAfterDays")]
        public System.Nullable<int> DeleteAfterDays { get; set; }
        
        /// <value>
        /// Customer notification options on success/failure of archival, deletion events.
        /// </value>
        [JsonProperty(PropertyName = "customerNotificationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModelSettingCustomerNotificationType> CustomerNotificationType { get; set; }
        
    }
}
