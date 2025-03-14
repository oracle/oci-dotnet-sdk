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


namespace Oci.OnsService.Models
{
    /// <summary>
    /// The response to a PublishMessage call.
    /// 
    /// </summary>
    public class PublishResult 
    {
        
        /// <value>
        /// The UUID of the message.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MessageId is required.")]
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }
        
        /// <value>
        /// The time that the service received the message.
        /// </value>
        [JsonProperty(PropertyName = "timeStamp")]
        public System.Nullable<System.DateTime> TimeStamp { get; set; }
        
    }
}
