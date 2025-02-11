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
    /// The information to update a Databricks Connection.
    /// 
    /// </summary>
    public class UpdateDatabricksConnectionDetails : UpdateConnectionDetails
    {
        
        /// <value>
        /// Used authentication mechanism to access Databricks.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "authenticationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DatabricksConnection.AuthenticationTypeEnum> AuthenticationType { get; set; }
        
        /// <value>
        /// Connection URL.
        /// e.g.: 'jdbc:databricks://adb-33934.4.azuredatabricks.net:443/default;transportMode=http;ssl=1;httpPath=sql/protocolv1/o/3393########44/0##3-7-hlrb'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionUrl")]
        public string ConnectionUrl { get; set; }
        
        /// <value>
        /// The password used to connect to Databricks.
        /// Only applicable for authenticationType == PERSONAL_ACCESS_TOKEN.
        /// Deprecated: This field is deprecated and replaced by \"passwordSecretId\". This field will be removed after February 15 2026.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the password is stored.
        /// Note: When provided, 'password' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "passwordSecretId")]
        public string PasswordSecretId { get; set; }
        
        /// <value>
        /// OAuth client id, only applicable for authenticationType == OAUTH_M2M
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }
        
        /// <value>
        /// OAuth client secret, only applicable for authenticationType == OAUTH_M2M
        /// Deprecated: This field is deprecated and replaced by \"clientSecretSecretId\". This field will be removed after February 15 2026.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the client secret is stored.
        /// Only applicable for authenticationType == OAUTH_M2M.
        /// Note: When provided, 'clientSecret' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clientSecretSecretId")]
        public string ClientSecretSecretId { get; set; }
        
        /// <value>
        /// Optional. External storage credential name to access files on object storage such as ADLS Gen2, S3 or GCS.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "storageCredentialName")]
        public string StorageCredentialName { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "DATABRICKS";
    }
}
