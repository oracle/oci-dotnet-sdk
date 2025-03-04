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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// An object containing credential details to authenticate/authorize a REST request.
    /// </summary>
    public class EndpointCredentials 
    {
                ///
        /// <value>
        /// The credential type. NONE indicates credentials are not needed to access the endpoint.
        /// BASIC_AUTH represents a username and password based model. TOKEN could be static or dynamic.
        /// In case of dynamic tokens, also specify the endpoint from which the token must be fetched.
        /// 
        /// </value>
        ///
        public enum CredentialTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "BASIC_AUTH")]
            BasicAuth,
            [EnumMember(Value = "STATIC_TOKEN")]
            StaticToken,
            [EnumMember(Value = "DYNAMIC_TOKEN")]
            DynamicToken
        };

        /// <value>
        /// The credential type. NONE indicates credentials are not needed to access the endpoint.
        /// BASIC_AUTH represents a username and password based model. TOKEN could be static or dynamic.
        /// In case of dynamic tokens, also specify the endpoint from which the token must be fetched.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "credentialType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CredentialTypeEnum> CredentialType { get; set; }
        
        /// <value>
        /// The named credential name on the management agent.
        /// </value>
        [JsonProperty(PropertyName = "credentialName")]
        public string CredentialName { get; set; }
        
        [JsonProperty(PropertyName = "credentialEndpoint")]
        public CredentialEndpoint CredentialEndpoint { get; set; }
        
    }
}
