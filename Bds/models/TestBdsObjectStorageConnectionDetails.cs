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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Test access to specified Object Storage bucket using the API key.
    /// </summary>
    public class TestBdsObjectStorageConnectionDetails 
    {
        
        /// <value>
        /// An Oracle Cloud Infrastructure URI to which this connection must be attempted. See https://docs.cloud.oracle.com/iaas/Content/API/SDKDocs/hdfsconnector.htm#uriformat.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectStorageUri is required.")]
        [JsonProperty(PropertyName = "objectStorageUri")]
        public string ObjectStorageUri { get; set; }
        
        /// <value>
        /// Base64 passphrase used to secure the private key which will be created on user behalf.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Passphrase is required.")]
        [JsonProperty(PropertyName = "passphrase")]
        public string Passphrase { get; set; }
        
        /// <value>
        /// The name of the region to establish the Object Storage endpoint. Example us-phoenix-1 .
        /// </value>
        [JsonProperty(PropertyName = "objectStorageRegion")]
        public string ObjectStorageRegion { get; set; }
        
    }
}
