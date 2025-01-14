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
    /// TLS enforcement config for the ingress listener.
    /// </summary>
    public class IngressListenerTlsConfig 
    {
                ///
        /// <value>
        /// DISABLED: Connection can only be plaintext.
        /// PERMISSIVE: Connection can be either plaintext or TLS/mTLS. If the clientValidation.trustedCaBundle property is configured for the listener, mTLS is performed and the client's certificates are validated by the gateway.
        /// TLS: Connection can only be TLS. 
        /// MUTUAL_TLS: Connection can only be MTLS.
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
            [EnumMember(Value = "TLS")]
            Tls,
            [EnumMember(Value = "MUTUAL_TLS")]
            MutualTls
        };

        /// <value>
        /// DISABLED: Connection can only be plaintext.
        /// PERMISSIVE: Connection can be either plaintext or TLS/mTLS. If the clientValidation.trustedCaBundle property is configured for the listener, mTLS is performed and the client's certificates are validated by the gateway.
        /// TLS: Connection can only be TLS. 
        /// MUTUAL_TLS: Connection can only be MTLS.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Mode is required.")]
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModeEnum> Mode { get; set; }
        
        [JsonProperty(PropertyName = "serverCertificate")]
        public TlsCertificate ServerCertificate { get; set; }
        
        [JsonProperty(PropertyName = "clientValidation")]
        public IngressListenerClientValidationConfig ClientValidation { get; set; }
        
    }
}
