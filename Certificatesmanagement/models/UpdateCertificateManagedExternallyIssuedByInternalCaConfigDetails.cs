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


namespace Oci.CertificatesmanagementService.Models
{
    /// <summary>
    /// The details for updating an externally managed certificate which is issued by a private certificate authority (CA).
    /// </summary>
    public class UpdateCertificateManagedExternallyIssuedByInternalCaConfigDetails : UpdateCertificateConfigDetails
    {
        
        /// <value>
        /// The certificate signing request (in PEM format).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CsrPem is required.")]
        [JsonProperty(PropertyName = "csrPem")]
        public string CsrPem { get; set; }
        
        [JsonProperty(PropertyName = "validity")]
        public Validity Validity { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "MANAGED_EXTERNALLY_ISSUED_BY_INTERNAL_CA";
    }
}
