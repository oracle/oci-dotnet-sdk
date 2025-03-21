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


namespace Oci.OptimizerService.Models
{
    /// <summary>
    /// Details about bulk recommendation actions.
    /// </summary>
    public class BulkApplyRecommendationsDetails 
    {
        
        /// <value>
        /// The unique OCIDs of the resource actions that recommendations are applied to.
        /// <br/>
        /// This field is deprecated.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceActionIds")]
        public System.Collections.Generic.List<string> ResourceActionIds { get; set; }
        
        /// <value>
        /// The unique resource actions that recommendations are applied to.
        /// </value>
        [JsonProperty(PropertyName = "actions")]
        public System.Collections.Generic.List<BulkApplyResourceAction> Actions { get; set; }
        
        /// <value>
        /// The current status of the recommendation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Status> Status { get; set; }
        
        /// <value>
        /// The date and time the current status will change. The format is defined by RFC3339.
        /// <br/>
        /// For example, \"The current `postponed` status of the resource action will end and change to `pending` on this
        /// date and time.\"
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStatusEnd")]
        public System.Nullable<System.DateTime> TimeStatusEnd { get; set; }
        
    }
}
