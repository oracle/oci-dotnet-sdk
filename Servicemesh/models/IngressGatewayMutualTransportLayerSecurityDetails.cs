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
    /// Mutual TLS settings used when sending requests to virtual services within the mesh.
    /// 
    /// </summary>
    public class IngressGatewayMutualTransportLayerSecurityDetails 
    {
        
        /// <value>
        /// The number of days the mTLS certificate is valid.  This value should be less than the Maximum Validity Duration 
        /// for Certificates (Days) setting on the Certificate Authority associated with this Mesh.  The certificate will
        /// be automatically renewed after 2/3 of the validity period, so a certificate with a maximum validity of 45 days
        /// will be renewed every 30 days.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maximumValidity")]
        public System.Nullable<int> MaximumValidity { get; set; }
        
    }
}
