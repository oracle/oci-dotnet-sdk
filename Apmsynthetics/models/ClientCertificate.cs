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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Client certificate in PEM format.
    /// 
    /// </summary>
    public class ClientCertificate 
    {
        
        /// <value>
        /// Name of the certificate file. The name should not contain any confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FileName is required.")]
        [JsonProperty(PropertyName = "fileName")]
        public string FileName { get; set; }
        
        /// <value>
        /// Content of the client certificate file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Content is required.")]
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
        
    }
}
