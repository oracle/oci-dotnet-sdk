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


namespace Oci.VisualbuilderService.Models
{
    /// <summary>
    /// Details for a custom endpoint for the vb instance.
    /// </summary>
    public class CustomEndpointDetails 
    {
        
        /// <value>
        /// A custom hostname to be used for the vb instance URL, in FQDN format.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hostname is required.")]
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// Optional OCID of a vault/secret containing a private SSL certificate bundle to be used for the custom hostname.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "certificateSecretId")]
        public string CertificateSecretId { get; set; }
        
        /// <value>
        /// The secret version used for the certificate-secret-id (if certificate-secret-id is specified).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "certificateSecretVersion")]
        public System.Nullable<int> CertificateSecretVersion { get; set; }
        
    }
}
