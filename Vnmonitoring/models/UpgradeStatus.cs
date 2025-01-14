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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// The upgrade status of a DRG.
    /// 
    /// </summary>
    public class UpgradeStatus 
    {
        
        /// <value>
        /// The `drgId` of the upgraded DRG.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrgId is required.")]
        [JsonProperty(PropertyName = "drgId")]
        public string DrgId { get; set; }
                ///
        /// <value>
        /// The current upgrade status of the DRG attachment.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "NOT_UPGRADED")]
            NotUpgraded,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "UPGRADED")]
            Upgraded
        };

        /// <value>
        /// The current upgrade status of the DRG attachment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The number of upgraded connections.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpgradedConnections is required.")]
        [JsonProperty(PropertyName = "upgradedConnections")]
        public string UpgradedConnections { get; set; }
        
    }
}
