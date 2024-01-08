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


namespace Oci.QueueService.Models
{
    /// <summary>
    /// An updated message with the new visibility.
    /// </summary>
    public class UpdatedMessage 
    {
        
        /// <value>
        /// The ID of the message that's been updated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public System.Nullable<long> Id { get; set; }
        
        /// <value>
        /// The time after which the message will be visible to other consumers, expressed in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) timestamp format.
        /// <br/>
        /// Example: 2018-04-20T00:00:07.405Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VisibleAfter is required.")]
        [JsonProperty(PropertyName = "visibleAfter")]
        public System.Nullable<System.DateTime> VisibleAfter { get; set; }
        
    }
}
