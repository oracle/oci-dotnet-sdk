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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Summary of the Certificates.
    /// </summary>
    public class CertificateSummary 
    {
        
        /// <value>
        /// The identifier key (unique name in the scope of the deployment) of the certificate being referenced. 
        /// It must be 1 to 32 characters long, must contain only alphanumeric characters and must start with a letter.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Possible certificate lifecycle states.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CertificateLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The Certificate subject.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Subject is required.")]
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
        
        /// <value>
        /// Indicates if the certificate is self signed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsSelfSigned is required.")]
        [JsonProperty(PropertyName = "isSelfSigned")]
        public System.Nullable<bool> IsSelfSigned { get; set; }
        
        /// <value>
        /// The time the certificate is valid to. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeValidTo is required.")]
        [JsonProperty(PropertyName = "timeValidTo")]
        public System.Nullable<System.DateTime> TimeValidTo { get; set; }
        
        /// <value>
        /// The time the resource was created. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
