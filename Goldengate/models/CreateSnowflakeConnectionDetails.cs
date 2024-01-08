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
    /// The information about a new Snowflake Connection.
    /// 
    /// </summary>
    public class CreateSnowflakeConnectionDetails : CreateConnectionDetails
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
        /// The password Oracle GoldenGate uses to connect to Snowflake platform.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// The base64 encoded content of private key file in PEM format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateKeyFile")]
        public string PrivateKeyFile { get; set; }
        
        /// <value>
        /// Password if the private key file is encrypted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateKeyPassphrase")]
        public string PrivateKeyPassphrase { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "SNOWFLAKE";
    }
}
