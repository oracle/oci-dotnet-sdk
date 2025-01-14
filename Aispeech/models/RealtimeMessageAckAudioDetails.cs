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


namespace Oci.AispeechService.Models
{
    /// <summary>
    /// Details object for the websocket ack message received from service.
    /// </summary>
    public class RealtimeMessageAckAudioDetails 
    {
        
        /// <value>
        /// Sequence number of the acknowledged packet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Number is required.")]
        [JsonProperty(PropertyName = "number")]
        public System.Nullable<int> Number { get; set; }
        
        /// <value>
        /// Offset of the acknowledged packet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Offset is required.")]
        [JsonProperty(PropertyName = "offset")]
        public System.Nullable<int> Offset { get; set; }
        
        /// <value>
        /// Length in bytes of the acknowledged packet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Length is required.")]
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<int> Length { get; set; }
        
    }
}
