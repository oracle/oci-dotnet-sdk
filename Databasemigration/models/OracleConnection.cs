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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Represents the metadata of an Oracle Database Connection.
    /// </summary>
    public class OracleConnection : Connection
    {
                ///
        /// <value>
        /// The Oracle technology type.
        /// </value>
        ///
        public enum TechnologyTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AMAZON_RDS_ORACLE")]
            AmazonRdsOracle,
            [EnumMember(Value = "OCI_AUTONOMOUS_DATABASE")]
            OciAutonomousDatabase,
            [EnumMember(Value = "ORACLE_DATABASE")]
            OracleDatabase,
            [EnumMember(Value = "ORACLE_EXADATA")]
            OracleExadata
        };

        /// <value>
        /// The Oracle technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// Connect descriptor or Easy Connect Naming method used to connect to a database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
        
        /// <value>
        /// The OCID of the database being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        /// <value>
        /// Name of the host the SSH key is valid for.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sshHost")]
        public string SshHost { get; set; }
        
        /// <value>
        /// Private SSH key string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sshKey")]
        public string SshKey { get; set; }
        
        /// <value>
        /// The username (credential) used when creating or updating this resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sshUser")]
        public string SshUser { get; set; }
        
        /// <value>
        /// Sudo location
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sshSudoLocation")]
        public string SshSudoLocation { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "ORACLE";
    }
}
