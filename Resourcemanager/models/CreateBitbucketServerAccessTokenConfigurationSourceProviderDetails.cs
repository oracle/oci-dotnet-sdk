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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// The details for creating a configuration source provider of the type `BITBUCKET_SERVER_ACCESS_TOKEN`.
    /// This type corresponds to a configuration source provider in Bitbucket server that is authenticated with a personal access token.
    /// 
    /// </summary>
    public class CreateBitbucketServerAccessTokenConfigurationSourceProviderDetails : CreateConfigurationSourceProviderDetails
    {
        
        /// <value>
        /// The secret ocid which is used to authorize the user.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecretId is required.")]
        [JsonProperty(PropertyName = "secretId")]
        public string SecretId { get; set; }
        
        /// <value>
        /// The Bitbucket Server service endpoint
        /// Example: https://bitbucket.org/
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApiEndpoint is required.")]
        [JsonProperty(PropertyName = "apiEndpoint")]
        public string ApiEndpoint { get; set; }
        
        [JsonProperty(PropertyName = "configSourceProviderType")]
        private readonly string configSourceProviderType = "BITBUCKET_SERVER_ACCESS_TOKEN";
    }
}
