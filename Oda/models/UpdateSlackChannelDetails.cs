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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Properties to update a Slack channel.
    /// </summary>
    public class UpdateSlackChannelDetails : UpdateChannelDetails
    {
        
        /// <value>
        /// The Slack Client Id for the Slack app.
        /// </value>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }
        
        /// <value>
        /// The URL to redirect to when authentication is successful.
        /// </value>
        [JsonProperty(PropertyName = "authSuccessUrl")]
        public string AuthSuccessUrl { get; set; }
        
        /// <value>
        /// The URL to redirect to when authentication is unsuccessful.
        /// </value>
        [JsonProperty(PropertyName = "authErrorUrl")]
        public string AuthErrorUrl { get; set; }
        
        /// <value>
        /// The Signing Secret for the Slack App.
        /// </value>
        [JsonProperty(PropertyName = "signingSecret")]
        public string SigningSecret { get; set; }
        
        /// <value>
        /// The Client Secret for the Slack App.
        /// </value>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }
        
        /// <value>
        /// The ID of the Skill or Digital Assistant that the Channel is routed to.
        /// </value>
        [JsonProperty(PropertyName = "botId")]
        public string BotId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SLACK";
    }
}
