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


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// An object that encapsulates the necessary partition certificates.
    /// </summary>
    public class UploadPartitionCertificatesDetails 
    {
        
        /// <value>
        /// Base64 encoded (StandardCharsets.UTF_8) Partition Certificate, which gets created when the CSR is signed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PartitionCertificate is required.")]
        [JsonProperty(PropertyName = "partitionCertificate")]
        public string PartitionCertificate { get; set; }
        
        /// <value>
        /// Base64 encoded (StandardCharsets.UTF_8) Partition Owner Certificate, which is used to help sign the CSR.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PartitionOwnerCertificate is required.")]
        [JsonProperty(PropertyName = "partitionOwnerCertificate")]
        public string PartitionOwnerCertificate { get; set; }
        
    }
}
