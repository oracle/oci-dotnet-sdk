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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// Details of a group in a DR plan.
    /// </summary>
    public class DrPlanGroup 
    {
        
        /// <value>
        /// The unique id of the group. Must not be modified by user.
        /// <br/>
        /// Example: sgid1.group..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The group type.
        /// <br/>
        /// Example: BUILT_IN
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrPlanGroupType> Type { get; set; }
        
        /// <value>
        /// The DR plan group refresh status.
        /// <br/>
        /// Example: GROUP_MODIFIED
        /// </value>
        [JsonProperty(PropertyName = "refreshStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrPlanGroupRefreshStatus> RefreshStatus { get; set; }
        
        /// <value>
        /// The display name of the group.
        /// <br/>
        /// Example: DATABASE_SWITCHOVER
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A flag indicating whether this group should be enabled for execution.
        /// This flag is only applicable to the `USER_DEFINED_PAUSE` group. The flag should be null for the remaining group types.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "isPauseEnabled")]
        public System.Nullable<bool> IsPauseEnabled { get; set; }
        
        /// <value>
        /// The list of steps in the group.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Steps is required.")]
        [JsonProperty(PropertyName = "steps")]
        public System.Collections.Generic.List<DrPlanStep> Steps { get; set; }
        
    }
}
