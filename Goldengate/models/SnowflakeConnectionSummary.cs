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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Summary of the Snowflake Connection.
    /// 
    /// </summary>
    public class SnowflakeConnectionSummary : ConnectionSummary
    {
        
        /// <value>
        /// The Snowflake technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SnowflakeConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// JDBC connection URL.
        /// e.g.: 'jdbc:snowflake://<account_name>.snowflakecomputing.com/?warehouse=<warehouse-name>&db=<db-name>'
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionUrl is required.")]
        [JsonProperty(PropertyName = "connectionUrl")]
        public string ConnectionUrl { get; set; }
        
        /// <value>
        /// Used authentication mechanism to access Snowflake.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthenticationType is required.")]
        [JsonProperty(PropertyName = "authenticationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SnowflakeConnection.AuthenticationTypeEnum> AuthenticationType { get; set; }
        
        /// <value>
        /// The username Oracle GoldenGate uses to connect to Snowflake.
        /// This username must already exist and be available by Snowflake platform to be connected to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the password is stored.
        /// The password Oracle GoldenGate uses to connect the associated system of the given technology.
        /// It must conform to the specific security requirements including length, case sensitivity, and so on.
        /// If secretId is used plaintext field must not be provided.
        /// Note: When provided, 'password' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "passwordSecretId")]
        public string PasswordSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret that stores the content of the private key file (PEM file) corresponding to the API key of the fingerprint.
        /// See documentation: https://docs.oracle.com/en-us/iaas/Content/Identity/Tasks/managingcredentials.htm
        /// Note: When provided, 'privateKeyFile' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateKeyFileSecretId")]
        public string PrivateKeyFileSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret that stores the password for the private key file.
        /// Note: When provided, 'privateKeyPassphrase' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateKeyPassphraseSecretId")]
        public string PrivateKeyPassphraseSecretId { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "SNOWFLAKE";
    }
}
