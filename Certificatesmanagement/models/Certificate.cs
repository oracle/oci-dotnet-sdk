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
    /// The details of the certificate. This object does not contain the certificate contents.
    /// </summary>
    public class Certificate 
    {
        
        /// <value>
        /// The OCID of the certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the certificate authority (CA) that issued the certificate.
        /// </value>
        [JsonProperty(PropertyName = "issuerCertificateAuthorityId")]
        public string IssuerCertificateAuthorityId { get; set; }
        
        /// <value>
        /// A user-friendly name for the certificate. Names are unique within a compartment. Avoid entering confidential information. Valid characters are uppercase or lowercase letters, numbers, hyphens, underscores, and periods.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A brief description of the certificate. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A list of rules that control how the certificate is used and managed.
        /// </value>
        [JsonProperty(PropertyName = "certificateRules")]
        public System.Collections.Generic.List<CertificateRule> CertificateRules { get; set; }
        
        /// <value>
        /// A property indicating when the certificate was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// An optional property indicating when to delete the certificate version, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeOfDeletion")]
        public System.Nullable<System.DateTime> TimeOfDeletion { get; set; }
        
        /// <value>
        /// The current lifecycle state of the certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CertificateLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state of the certificate.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The OCID of the compartment where you want to create the certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "currentVersion")]
        public CertificateVersionSummary CurrentVersion { get; set; }
        
        [JsonProperty(PropertyName = "subject")]
        public CertificateSubject Subject { get; set; }
        
        [JsonProperty(PropertyName = "certificateRevocationListDetails")]
        public CertificateRevocationListDetails CertificateRevocationListDetails { get; set; }
        
        /// <value>
        /// The origin of the certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfigType is required.")]
        [JsonProperty(PropertyName = "configType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CertificateConfigType> ConfigType { get; set; }
        
        /// <value>
        /// The algorithm used to create key pairs.
        /// </value>
        [JsonProperty(PropertyName = "keyAlgorithm")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<KeyAlgorithm> KeyAlgorithm { get; set; }
        
        /// <value>
        /// The algorithm used to sign the public key certificate.
        /// </value>
        [JsonProperty(PropertyName = "signatureAlgorithm")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SignatureAlgorithm> SignatureAlgorithm { get; set; }
        
        /// <value>
        /// The name of the profile used to create the certificate, which depends on the type of certificate you need.
        /// </value>
        [JsonProperty(PropertyName = "certificateProfileType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CertificateProfileType> CertificateProfileType { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
