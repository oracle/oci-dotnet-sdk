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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Secure connection configuration details.
    /// 
    /// </summary>
    public class SecureConnectionDetails 
    {
        
        /// <value>
        /// The OCID of the certificate to use.
        /// </value>
        [JsonProperty(PropertyName = "certificateId")]
        public string CertificateId { get; set; }
        
        /// <value>
        /// Select whether to use MySQL Database Service-managed certificate (SYSTEM) or your own certificate (BYOC).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateGenerationType is required.")]
        [JsonProperty(PropertyName = "certificateGenerationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CertificateGenerationType> CertificateGenerationType { get; set; }
        
    }
}
