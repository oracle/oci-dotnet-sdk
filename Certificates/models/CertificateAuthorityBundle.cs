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


namespace Oci.CertificatesService.Models
{
    /// <summary>
    /// The contents of the certificate, properties of the certificate (and certificate version), and user-provided contextual metadata for the certificate.
    /// 
    /// </summary>
    public class CertificateAuthorityBundle 
    {
        
        /// <value>
        /// The OCID of the certificate authority (CA).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateAuthorityId is required.")]
        [JsonProperty(PropertyName = "certificateAuthorityId")]
        public string CertificateAuthorityId { get; set; }
        
        /// <value>
        /// The name of the CA.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateAuthorityName is required.")]
        [JsonProperty(PropertyName = "certificateAuthorityName")]
        public string CertificateAuthorityName { get; set; }
        
        /// <value>
        /// A unique certificate identifier used in certificate revocation tracking, formatted as octets.
        /// Example: 03 AC FC FA CC B3 CB 02 B8 F8 DE F5 85 E7 7B FF
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SerialNumber is required.")]
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }
        
        /// <value>
        /// The certificate (in PEM format) for this CA version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificatePem is required.")]
        [JsonProperty(PropertyName = "certificatePem")]
        public string CertificatePem { get; set; }
        
        /// <value>
        /// The certificate chain (in PEM format) for this CA version.
        /// </value>
        [JsonProperty(PropertyName = "certChainPem")]
        public string CertChainPem { get; set; }
        
        /// <value>
        /// The name of the CA.
        /// </value>
        [JsonProperty(PropertyName = "versionName")]
        public string VersionName { get; set; }
        
        /// <value>
        /// A property indicating when the CA was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The version number of the CA.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VersionNumber is required.")]
        [JsonProperty(PropertyName = "versionNumber")]
        public System.Nullable<long> VersionNumber { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Validity is required.")]
        [JsonProperty(PropertyName = "validity")]
        public Validity Validity { get; set; }
        
        /// <value>
        /// A list of rotation states for this CA.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Stages is required.")]
        [JsonProperty(PropertyName = "stages", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<VersionStage> Stages { get; set; }
        
        [JsonProperty(PropertyName = "revocationStatus")]
        public RevocationStatus RevocationStatus { get; set; }
        
    }
}
