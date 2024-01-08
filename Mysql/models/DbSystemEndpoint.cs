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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// A particular functional endpoint for access to a DB System, and the properties that apply to it.
    /// 
    /// </summary>
    public class DbSystemEndpoint 
    {
        
        /// <value>
        /// The network address of the DB System.
        /// </value>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The IP address the DB System is configured to listen on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddress is required.")]
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The port the MySQL instance listens on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The network port where to connect to use this endpoint using the X protocol.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PortX is required.")]
        [JsonProperty(PropertyName = "portX")]
        public System.Nullable<int> PortX { get; set; }
                ///
        ///
        public enum ModesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "READ")]
            Read,
            [EnumMember(Value = "WRITE")]
            Write
        };

        /// <value>
        /// The access modes from the client that this endpoint supports.
        /// </value>
        [JsonProperty(PropertyName = "modes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<ModesEnum> Modes { get; set; }
                ///
        /// <value>
        /// The state of the endpoints, as far as it can seen from the DB System.
        /// There may be some inconsistency with the actual state of the MySQL service.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The state of the endpoints, as far as it can seen from the DB System.
        /// There may be some inconsistency with the actual state of the MySQL service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Additional information about the current endpoint status.
        /// </value>
        [JsonProperty(PropertyName = "statusDetails")]
        public string StatusDetails { get; set; }
                ///
        /// <value>
        /// The type of endpoint that clients and connectors can connect to.
        /// </value>
        ///
        public enum ResourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DBSYSTEM")]
            Dbsystem,
            [EnumMember(Value = "READ_REPLICA")]
            ReadReplica,
            [EnumMember(Value = "LOAD_BALANCER")]
            LoadBalancer
        };

        /// <value>
        /// The type of endpoint that clients and connectors can connect to.
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceTypeEnum> ResourceType { get; set; }
        
        /// <value>
        /// The OCID of the resource that this endpoint is attached to.
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
    }
}
