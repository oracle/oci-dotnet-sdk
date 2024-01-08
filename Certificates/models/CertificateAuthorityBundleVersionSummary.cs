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


namespace Oci.CertificatesService.Models
{
    /// <summary>
    /// The properties of a version of a bundle for a certificate authority (CA). Certificate authority bundle version summary objects do not include the actual contents of the certificate.
    /// 
    /// </summary>
    public class CertificateAuthorityBundleVersionSummary 
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
        /// A unique certificate identifier used in certificate revocation tracking, formatted as octets.
        /// Example: 03 AC FC FA CC B3 CB 02 B8 F8 DE F5 85 E7 7B FF
        /// </value>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }
        
        /// <value>
        /// An optional property indicating when the CA version was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
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
        
        /// <value>
        /// The name of the CA version. When this value is not null, the name is unique across CA versions for a given CA.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "versionName")]
        public string VersionName { get; set; }
        
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
        /// An optional property indicating when to delete the CA version, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeOfDeletion")]
        public System.Nullable<System.DateTime> TimeOfDeletion { get; set; }
        
        [JsonProperty(PropertyName = "validity")]
        public Validity Validity { get; set; }
        
        /// <value>
        /// A list of rotation states for this CA version.
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
