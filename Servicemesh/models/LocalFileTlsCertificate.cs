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


namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// TLS certificate from the filesystem.
    /// </summary>
    public class LocalFileTlsCertificate : TlsCertificate
    {
        
        /// <value>
        /// Name of the secret.
        /// For Kubernetes this is the name of the Kubernetes secret of type tls.
        /// For other platforms the secrets must be mounted at: /etc/oci/secrets/${secretName}/tls.{key,crt}
        /// 
        /// </value>
        [JsonProperty(PropertyName = "secretName")]
        public string SecretName { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "LOCAL_FILE";
    }
}
