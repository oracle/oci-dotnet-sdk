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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// A resource that is created or operated on by an asynchronous operation that is tracked by
    /// a work request.
    /// 
    /// </summary>
    public class WorkRequestResource 
    {
                ///
        /// <value>
        /// The way in which this resource was affected by the operation that spawned the work
        /// request.
        /// 
        /// </value>
        ///
        public enum ActionTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATED")]
            Created,
            [EnumMember(Value = "UPDATED")]
            Updated,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "RELATED")]
            Related,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress
        };

        /// <value>
        /// The way in which this resource was affected by the operation that spawned the work
        /// request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionType is required.")]
        [JsonProperty(PropertyName = "actionType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionTypeEnum> ActionType { get; set; }
        
        /// <value>
        /// The resource type the work request affects.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityType is required.")]
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// An [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) or other unique identifier for the
        /// resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The URI path that you can use for a GET request to access the resource metadata.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "entityUri")]
        public string EntityUri { get; set; }
        
    }
}
