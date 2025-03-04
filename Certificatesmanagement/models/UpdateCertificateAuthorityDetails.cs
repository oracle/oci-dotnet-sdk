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
    /// The details for updating a certificate authority (CA).
    /// </summary>
    public class UpdateCertificateAuthorityDetails 
    {
        
        /// <value>
        /// A brief description of the CA.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Makes this version the current version. This property cannot be updated in combination with any other properties.
        /// </value>
        [JsonProperty(PropertyName = "currentVersionNumber")]
        public System.Nullable<long> CurrentVersionNumber { get; set; }
        
        [JsonProperty(PropertyName = "certificateAuthorityConfig")]
        public UpdateCertificateAuthorityConfigDetails CertificateAuthorityConfig { get; set; }
        
        [JsonProperty(PropertyName = "certificateRevocationListDetails")]
        public CertificateRevocationListDetails CertificateRevocationListDetails { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A list of rules that control how the CA is used and managed.
        /// </value>
        [JsonProperty(PropertyName = "certificateAuthorityRules")]
        public System.Collections.Generic.List<CertificateAuthorityRule> CertificateAuthorityRules { get; set; }
        
    }
}
