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


namespace Oci.DistributeddatabaseService.Models
{
    /// <summary>
    /// Details required for creation of the Globally distributed autonomous database.
    /// </summary>
    public class CreateDistributedAutonomousDatabaseDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Globally distributed autonomous database compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the Globally distributed autonomous database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Oracle Database version for the shards and catalog used in Globally distributed autonomous database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseVersion is required.")]
        [JsonProperty(PropertyName = "databaseVersion")]
        public string DatabaseVersion { get; set; }
        
        /// <value>
        /// Unique name prefix for the Globally distributed autonomous databases. Only alpha-numeric values are allowed. First character
        /// has to be a letter followed by any combination of letter and number.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Prefix is required.")]
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
        /// <value>
        /// The collection of [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the private endpoint associated with Globally distributed autonomous database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrivateEndpointIds is required.")]
        [JsonProperty(PropertyName = "privateEndpointIds")]
        public System.Collections.Generic.List<string> PrivateEndpointIds { get; set; }
                ///
        /// <value>
        /// Sharding Methods for the Globally distributed autonomous database.
        /// </value>
        ///
        public enum ShardingMethodEnum {
            [EnumMember(Value = "USER")]
            User,
            [EnumMember(Value = "SYSTEM")]
            System
        };

        /// <value>
        /// Sharding Methods for the Globally distributed autonomous database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShardingMethod is required.")]
        [JsonProperty(PropertyName = "shardingMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ShardingMethodEnum> ShardingMethod { get; set; }
                ///
        /// <value>
        /// Possible workload types.
        /// </value>
        ///
        public enum DbWorkloadEnum {
            [EnumMember(Value = "OLTP")]
            Oltp,
            [EnumMember(Value = "DW")]
            Dw
        };

        /// <value>
        /// Possible workload types.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbWorkload is required.")]
        [JsonProperty(PropertyName = "dbWorkload")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbWorkloadEnum> DbWorkload { get; set; }
        
        /// <value>
        /// The character set for the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CharacterSet is required.")]
        [JsonProperty(PropertyName = "characterSet")]
        public string CharacterSet { get; set; }
        
        /// <value>
        /// The national character set for the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NcharacterSet is required.")]
        [JsonProperty(PropertyName = "ncharacterSet")]
        public string NcharacterSet { get; set; }
        
        /// <value>
        /// The default number of unique chunks in a shardspace. The value of chunks must be
        /// greater than 2 times the size of the largest shardgroup in any shardspace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "chunks")]
        public System.Nullable<int> Chunks { get; set; }
        
        /// <value>
        /// The listener port number for the Globally distributed autonomous database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListenerPort is required.")]
        [JsonProperty(PropertyName = "listenerPort")]
        public System.Nullable<int> ListenerPort { get; set; }
        
        /// <value>
        /// The TLS listener port number for Globally distributed autonomous database.
        /// </value>
        [JsonProperty(PropertyName = "listenerPortTls")]
        public System.Nullable<int> ListenerPortTls { get; set; }
        
        /// <value>
        /// Ons local port number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OnsPortLocal is required.")]
        [JsonProperty(PropertyName = "onsPortLocal")]
        public System.Nullable<int> OnsPortLocal { get; set; }
        
        /// <value>
        /// Ons remote port number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OnsPortRemote is required.")]
        [JsonProperty(PropertyName = "onsPortRemote")]
        public System.Nullable<int> OnsPortRemote { get; set; }
                ///
        /// <value>
        /// The Replication method for Globally distributed autonomous database. Use RAFT for Raft replication, and DG for
        /// DataGuard. If replicationMethod is not provided, it defaults to DG.
        /// 
        /// </value>
        ///
        public enum ReplicationMethodEnum {
            [EnumMember(Value = "RAFT")]
            Raft,
            [EnumMember(Value = "DG")]
            Dg
        };

        /// <value>
        /// The Replication method for Globally distributed autonomous database. Use RAFT for Raft replication, and DG for
        /// DataGuard. If replicationMethod is not provided, it defaults to DG.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "replicationMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ReplicationMethodEnum> ReplicationMethod { get; set; }
        
        /// <value>
        /// The Replication factor for RAFT replication based Globally distributed autonomous database. Currently supported values are 3, 5 and 7.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "replicationFactor")]
        public System.Nullable<int> ReplicationFactor { get; set; }
        
        /// <value>
        /// For RAFT replication based Globally distributed autonomous database, the value should be atleast twice the number of shards.
        /// </value>
        [JsonProperty(PropertyName = "replicationUnit")]
        public System.Nullable<int> ReplicationUnit { get; set; }
                ///
        /// <value>
        /// The distributed autonomous database deployment type.
        /// 
        /// </value>
        ///
        public enum DbDeploymentTypeEnum {
            [EnumMember(Value = "ADB_D")]
            AdbD
        };

        /// <value>
        /// The distributed autonomous database deployment type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbDeploymentType is required.")]
        [JsonProperty(PropertyName = "dbDeploymentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbDeploymentTypeEnum> DbDeploymentType { get; set; }
        
        /// <value>
        /// Collection of shards for the Globally distributed autonomous database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShardDetails is required.")]
        [JsonProperty(PropertyName = "shardDetails")]
        public System.Collections.Generic.List<CreateDistributedAutonomousDatabaseShardDetails> ShardDetails { get; set; }
        
        /// <value>
        /// Collection of catalog for the Globally distributed autonomous database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogDetails is required.")]
        [JsonProperty(PropertyName = "catalogDetails")]
        public System.Collections.Generic.List<CreateDistributedAutonomousDatabaseCatalogDetails> CatalogDetails { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
