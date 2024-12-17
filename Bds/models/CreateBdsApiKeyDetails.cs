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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// API key created on user's behalf.
    /// </summary>
    public class CreateBdsApiKeyDetails 
    {
        
        /// <value>
        /// The OCID of the user for whom this new generated API key pair will be created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserId is required.")]
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
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
        /// The name of the region to establish the Object Storage endpoint. See https://docs.oracle.com/en-us/iaas/api/#/en/identity/20160918/Region/
        /// for additional information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultRegion")]
        public string DefaultRegion { get; set; }
        
        /// <value>
        /// User friendly identifier used to uniquely differentiate between different API keys associated with this Big Data Service cluster.
        /// Only ASCII alphanumeric characters with no spaces allowed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyAlias is required.")]
        [JsonProperty(PropertyName = "keyAlias")]
        public string KeyAlias { get; set; }
        
        /// <value>
        /// Identity domain OCID , where user is present. For default domain , this field will be optional.
        /// </value>
        [JsonProperty(PropertyName = "domainOcid")]
        public string DomainOcid { get; set; }
        
    }
}
