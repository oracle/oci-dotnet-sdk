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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// A resource that is created or operated on by an asynchronous operation that is tracked by a work request.
    /// </summary>
    public class WorkRequestResource 
    {
        
        /// <value>
        /// The resource type affected by the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityType is required.")]
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// The way in which this resource was affected by the operation that spawned the work request.
        /// A resource being created, updated, or deleted will remain in the IN_PROGRESS state until
        /// work is complete for that resource at which point it will transition to CREATED, UPDATED,
        /// or DELETED, respectively.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionType is required.")]
        [JsonProperty(PropertyName = "actionType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionType> ActionType { get; set; }
        
        /// <value>
        /// An [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) or other unique identifier of the resource affected by the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The URI path that the user can perform a GET operation to access the resource metadata.
        /// </value>
        [JsonProperty(PropertyName = "entityUri")]
        public string EntityUri { get; set; }
        
    }
}
