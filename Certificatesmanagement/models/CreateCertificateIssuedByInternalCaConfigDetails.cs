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
    /// The details of the configuration for creating an internally managed certificate which is issued by a private certificate authority (CA).
    /// </summary>
    public class CreateCertificateIssuedByInternalCaConfigDetails : CreateCertificateConfigDetails
    {
        
        /// <value>
        /// The name of the profile used to create the certificate, which depends on the type of certificate you need.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateProfileType is required.")]
        [JsonProperty(PropertyName = "certificateProfileType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CertificateProfileType> CertificateProfileType { get; set; }
        
        /// <value>
        /// The OCID of the private CA.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IssuerCertificateAuthorityId is required.")]
        [JsonProperty(PropertyName = "issuerCertificateAuthorityId")]
        public string IssuerCertificateAuthorityId { get; set; }
        
        [JsonProperty(PropertyName = "validity")]
        public Validity Validity { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Subject is required.")]
        [JsonProperty(PropertyName = "subject")]
        public CertificateSubject Subject { get; set; }
        
        /// <value>
        /// A list of subject alternative names.
        /// </value>
        [JsonProperty(PropertyName = "subjectAlternativeNames")]
        public System.Collections.Generic.List<CertificateSubjectAlternativeName> SubjectAlternativeNames { get; set; }
        
        /// <value>
        /// The algorithm to use to create key pairs.
        /// </value>
        [JsonProperty(PropertyName = "keyAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<KeyAlgorithm> KeyAlgorithm { get; set; }
        
        /// <value>
        /// The algorithm to use to sign the public key certificate.
        /// </value>
        [JsonProperty(PropertyName = "signatureAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SignatureAlgorithm> SignatureAlgorithm { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "ISSUED_BY_INTERNAL_CA";
    }
}
