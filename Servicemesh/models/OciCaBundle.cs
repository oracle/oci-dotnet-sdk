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


namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// CA Bundle from OCI Certificates service.
    /// </summary>
    public class OciCaBundle : CaBundle
    {
        
        /// <value>
        /// The OCID of the CA Bundle resource.
        /// </value>
        [JsonProperty(PropertyName = "caBundleId")]
        public string CaBundleId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "OCI_CERTIFICATES";
    }
}
