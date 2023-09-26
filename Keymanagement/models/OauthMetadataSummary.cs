/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// Summary about authorization to be returned to the customer as a response.
    /// </summary>
    public class OauthMetadataSummary 
    {
        
        /// <value>
        /// Base URL of the IDCS account where confidential client app is created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdcsAccountNameUrl is required.")]
        [JsonProperty(PropertyName = "idcsAccountNameUrl")]
        public string IdcsAccountNameUrl { get; set; }
        
        /// <value>
        /// ID of the client app created in IDP.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClientAppId is required.")]
        [JsonProperty(PropertyName = "clientAppId")]
        public string ClientAppId { get; set; }
        
    }
}
