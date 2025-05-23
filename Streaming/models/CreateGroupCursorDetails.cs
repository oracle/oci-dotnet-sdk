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


namespace Oci.StreamingService.Models
{
    /// <summary>
    /// Object used to create a group cursor.
    /// </summary>
    public class CreateGroupCursorDetails 
    {
                ///
        /// <value>
        /// The type of the cursor. This value is only used when the group is created.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "AT_TIME")]
            AtTime,
            [EnumMember(Value = "LATEST")]
            Latest,
            [EnumMember(Value = "TRIM_HORIZON")]
            TrimHorizon
        };

        /// <value>
        /// The type of the cursor. This value is only used when the group is created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The time to consume from if type is AT_TIME.
        /// </value>
        [JsonProperty(PropertyName = "time")]
        public System.Nullable<System.DateTime> Time { get; set; }
        
        /// <value>
        /// Name of the consumer group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GroupName is required.")]
        [JsonProperty(PropertyName = "groupName")]
        public string GroupName { get; set; }
        
        /// <value>
        /// A unique identifier for the instance joining the consumer group. If an instanceName is not provided, a UUID will be generated and used.
        /// </value>
        [JsonProperty(PropertyName = "instanceName")]
        public string InstanceName { get; set; }
        
        /// <value>
        /// The amount of a consumer instance inactivity time, before partition reservations are released.
        /// </value>
        [JsonProperty(PropertyName = "timeoutInMs")]
        public System.Nullable<int> TimeoutInMs { get; set; }
        
        /// <value>
        /// When using consumer-groups, the default commit-on-get behaviour can be overriden by setting this value to false.
        /// If disabled, a consumer must manually commit their cursors.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "commitOnGet")]
        public System.Nullable<bool> CommitOnGet { get; set; }
        
    }
}
