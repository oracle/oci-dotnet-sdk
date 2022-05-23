/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Properties required to create an iOS channel.
    /// </summary>
    public class CreateIosChannelDetails : CreateChannelDetails
    {
        
        /// <value>
        /// The maximum time until the token expires (in minutes).
        /// </value>
        [JsonProperty(PropertyName = "maxTokenExpirationTimeInMinutes")]
        public System.Nullable<long> MaxTokenExpirationTimeInMinutes { get; set; }
        
        /// <value>
        /// Whether client authentication is enabled or not.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsClientAuthenticationEnabled is required.")]
        [JsonProperty(PropertyName = "isClientAuthenticationEnabled")]
        public System.Nullable<bool> IsClientAuthenticationEnabled { get; set; }
        
        /// <value>
        /// The ID of the Skill or Digital Assistant that the Channel is routed to.
        /// </value>
        [JsonProperty(PropertyName = "botId")]
        public string BotId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "IOS";
    }
}
