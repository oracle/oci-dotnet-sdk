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
    /// The configuration for an Application channel.
    /// </summary>
    public class CreateApplicationChannelResult : CreateChannelResult
    {
        
        /// <value>
        /// The secret key used to verify the authenticity of received messages.
        /// This is only returned this once.  If it is lost the keys will need to be rotated to generate a new key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecretKey is required.")]
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }
        
        /// <value>
        /// The URL to send response and error messages to.
        /// </value>
        [JsonProperty(PropertyName = "outboundUrl")]
        public string OutboundUrl { get; set; }
        
        /// <value>
        /// True if the user id in the AIC message should be treated as an authenticated user id.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAuthenticatedUserId is required.")]
        [JsonProperty(PropertyName = "isAuthenticatedUserId")]
        public System.Nullable<bool> IsAuthenticatedUserId { get; set; }
        
        /// <value>
        /// The URL to use to send messages to this channel.
        /// This will be generally be used to configure a webhook in a 3rd party messaging system to send messages to this channel.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WebhookUrl is required.")]
        [JsonProperty(PropertyName = "webhookUrl")]
        public string WebhookUrl { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "APPLICATION";
    }
}
