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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Core properties of a Mysql Channel source.
    /// </summary>
    public class ChannelSourceMysql : ChannelSource
    {
        
        /// <value>
        /// The network address of the MySQL instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hostname is required.")]
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The port the source MySQL instance listens on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The name of the replication user on the source MySQL instance.
        /// The username has a maximum length of 96 characters. For more information,
        /// please see the [MySQL documentation](https://dev.mysql.com/doc/refman/8.0/en/change-master-to.html)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
                ///
        /// <value>
        /// The SSL mode of the Channel.
        /// </value>
        ///
        public enum SslModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "VERIFY_IDENTITY")]
            VerifyIdentity,
            [EnumMember(Value = "VERIFY_CA")]
            VerifyCa,
            [EnumMember(Value = "REQUIRED")]
            Required,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// The SSL mode of the Channel.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SslMode is required.")]
        [JsonProperty(PropertyName = "sslMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SslModeEnum> SslMode { get; set; }
        
        [JsonProperty(PropertyName = "sslCaCertificate")]
        public CaCertificate SslCaCertificate { get; set; }
        
        [JsonProperty(PropertyName = "anonymousTransactionsHandling")]
        public AnonymousTransactionsHandling AnonymousTransactionsHandling { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "MYSQL";
    }
}
