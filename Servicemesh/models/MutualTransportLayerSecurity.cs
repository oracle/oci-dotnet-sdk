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
    /// Mutual TLS settings used when communicating with other virtual services or ingress gateways within the mesh.
    /// 
    /// </summary>
    public class MutualTransportLayerSecurity 
    {
        
        /// <value>
        /// The OCID of the certificate resource that will be used for mTLS authentication with other virtual services in the mesh.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateId is required.")]
        [JsonProperty(PropertyName = "certificateId")]
        public string CertificateId { get; set; }
        
        /// <value>
        /// The number of days the mTLS certificate is valid.  This value should be less than the Maximum Validity Duration 
        /// for Certificates (Days) setting on the Certificate Authority associated with this Mesh.  The certificate will
        /// be automatically renewed after 2/3 of the validity period, so a certificate with a maximum validity of 45 days
        /// will be renewed every 30 days.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maximumValidity")]
        public System.Nullable<int> MaximumValidity { get; set; }
                ///
        /// <value>
        /// DISABLED: Connection is not tunneled.
        /// PERMISSIVE: Connection can be either plaintext or an mTLS tunnel.
        /// STRICT: Connection is an mTLS tunnel.  Clients without a valid certificate will be rejected.
        /// 
        /// </value>
        ///
        public enum ModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DISABLED")]
            Disabled,
            [EnumMember(Value = "PERMISSIVE")]
            Permissive,
            [EnumMember(Value = "STRICT")]
            Strict
        };

        /// <value>
        /// DISABLED: Connection is not tunneled.
        /// PERMISSIVE: Connection can be either plaintext or an mTLS tunnel.
        /// STRICT: Connection is an mTLS tunnel.  Clients without a valid certificate will be rejected.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Mode is required.")]
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModeEnum> Mode { get; set; }
        
    }
}
