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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Vault Credential Details to connect to the database.
    /// </summary>
    public class CredentialByVault : CredentialDetails
    {
        
        /// <value>
        /// database user name.
        /// </value>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        /// <value>
        /// The secret [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) mapping to the database credentials.
        /// </value>
        [JsonProperty(PropertyName = "passwordSecretId")]
        public string PasswordSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the database keystore contents are stored. This is used for TCPS support in BM/VM/ExaCS cases.
        /// </value>
        [JsonProperty(PropertyName = "walletSecretId")]
        public string WalletSecretId { get; set; }
                ///
        /// <value>
        /// database user role.
        /// </value>
        ///
        public enum RoleEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NORMAL")]
            Normal
        };

        /// <value>
        /// database user role.
        /// </value>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }
        
        [JsonProperty(PropertyName = "credentialType")]
        private readonly string credentialType = "CREDENTIALS_BY_VAULT";
    }
}
