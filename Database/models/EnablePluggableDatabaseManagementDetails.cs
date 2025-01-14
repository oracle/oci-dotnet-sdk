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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Data to enable the Database Management service for the pluggable database.
    /// 
    /// </summary>
    public class EnablePluggableDatabaseManagementDetails 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CredentialDetails is required.")]
        [JsonProperty(PropertyName = "credentialDetails")]
        public DatabaseCredentialDetails CredentialDetails { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the private endpoint.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrivateEndPointId is required.")]
        [JsonProperty(PropertyName = "privateEndPointId")]
        public string PrivateEndPointId { get; set; }
        
        /// <value>
        /// The name of the Oracle Database service that will be used to connect to the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceName is required.")]
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
                ///
        /// <value>
        /// Protocol used by the database connection.
        /// </value>
        ///
        public enum ProtocolEnum {
            [EnumMember(Value = "TCP")]
            Tcp,
            [EnumMember(Value = "TCPS")]
            Tcps
        };

        /// <value>
        /// Protocol used by the database connection.
        /// </value>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProtocolEnum> Protocol { get; set; }
        
        /// <value>
        /// The port used to connect to the pluggable database.
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Cloud Infrastructure [secret](https://docs.cloud.oracle.com/Content/KeyManagement/Concepts/keyoverview.htm#concepts).
        /// </value>
        [JsonProperty(PropertyName = "sslSecretId")]
        public string SslSecretId { get; set; }
                ///
        /// <value>
        /// The role of the user that will be connecting to the pluggable database.
        /// </value>
        ///
        public enum RoleEnum {
            [EnumMember(Value = "SYSDBA")]
            Sysdba,
            [EnumMember(Value = "NORMAL")]
            Normal,
            [EnumMember(Value = "SYSDG")]
            Sysdg
        };

        /// <value>
        /// The role of the user that will be connecting to the pluggable database.
        /// </value>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }
        
    }
}
