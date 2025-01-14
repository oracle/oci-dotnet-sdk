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


namespace Oci.GloballydistributeddatabaseService.Models
{
    /// <summary>
    /// Request details for creation of ATP-Dedicated based sharded database.
    /// </summary>
    public class CreateDedicatedShardedDatabase : CreateShardedDatabaseDetails
    {
        
        /// <value>
        /// The Replication method for sharded database.
        /// </value>
        [JsonProperty(PropertyName = "replicationMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DedicatedShardedDatabase.ReplicationMethodEnum> ReplicationMethod { get; set; }
        
        /// <value>
        /// The Replication factor for RAFT replication based sharded database. Currently supported values are 3, 5 and 7.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "replicationFactor")]
        public System.Nullable<int> ReplicationFactor { get; set; }
        
        /// <value>
        /// For RAFT replication based sharded database, the value should be atleast twice the number of shards.
        /// </value>
        [JsonProperty(PropertyName = "replicationUnit")]
        public System.Nullable<int> ReplicationUnit { get; set; }
        
        /// <value>
        /// The certificate common name used in all cloudAutonomousVmClusters for the sharded database topology. Eg. Production.
        /// All the clusters used in one sharded database topology shall have same CABundle setup. Valid characterset for
        /// clusterCertificateCommonName include uppercase or lowercase letters, numbers, hyphens, underscores, and period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clusterCertificateCommonName")]
        public string ClusterCertificateCommonName { get; set; }
        
        /// <value>
        /// The default number of unique chunks in a shardspace. The value of chunks must be
        /// greater than 2 times the size of the largest shardgroup in any shardspace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "chunks")]
        public System.Nullable<int> Chunks { get; set; }
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
                ///
        /// <value>
        /// Sharding Method.
        /// </value>
        ///
        public enum ShardingMethodEnum {
            [EnumMember(Value = "USER")]
            User,
            [EnumMember(Value = "SYSTEM")]
            System
        };

        /// <value>
        /// Sharding Method.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShardingMethod is required.")]
        [JsonProperty(PropertyName = "shardingMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ShardingMethodEnum> ShardingMethod { get; set; }
        
        /// <value>
        /// Oracle Database version of the Autonomous Container Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbVersion is required.")]
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// The character set for the new shard database being created. Use database api ListAutonomousDatabaseCharacterSets to
        /// get the list of allowed character set for autonomous dedicated database. See documentation:
        /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/AutonomousDatabaseCharacterSets/ListAutonomousDatabaseCharacterSets
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CharacterSet is required.")]
        [JsonProperty(PropertyName = "characterSet")]
        public string CharacterSet { get; set; }
        
        /// <value>
        /// The national character set for the new shard database being created. Use database api ListAutonomousDatabaseCharacterSets to
        /// get the list of allowed national character set for autonomous dedicated database. See documentation:
        /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/AutonomousDatabaseCharacterSets/ListAutonomousDatabaseCharacterSets
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NcharacterSet is required.")]
        [JsonProperty(PropertyName = "ncharacterSet")]
        public string NcharacterSet { get; set; }
        
        /// <value>
        /// The listener port number for sharded database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListenerPort is required.")]
        [JsonProperty(PropertyName = "listenerPort")]
        public System.Nullable<int> ListenerPort { get; set; }
        
        /// <value>
        /// The TLS listener port number for sharded database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListenerPortTls is required.")]
        [JsonProperty(PropertyName = "listenerPortTls")]
        public System.Nullable<int> ListenerPortTls { get; set; }
        
        /// <value>
        /// Ons port local for sharded database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OnsPortLocal is required.")]
        [JsonProperty(PropertyName = "onsPortLocal")]
        public System.Nullable<int> OnsPortLocal { get; set; }
        
        /// <value>
        /// Ons remote port for sharded database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OnsPortRemote is required.")]
        [JsonProperty(PropertyName = "onsPortRemote")]
        public System.Nullable<int> OnsPortRemote { get; set; }
        
        /// <value>
        /// Unique name prefix for the sharded databases. Only alpha-numeric values are allowed. First character
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
        /// Collection of ATP-Dedicated shards that needs to be created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShardDetails is required.")]
        [JsonProperty(PropertyName = "shardDetails")]
        public System.Collections.Generic.List<CreateDedicatedShardDetail> ShardDetails { get; set; }
        
        /// <value>
        /// Collection of ATP-Dedicated catalogs that needs to be created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogDetails is required.")]
        [JsonProperty(PropertyName = "catalogDetails")]
        public System.Collections.Generic.List<CreateDedicatedCatalogDetail> CatalogDetails { get; set; }
        
        [JsonProperty(PropertyName = "dbDeploymentType")]
        private readonly string dbDeploymentType = "DEDICATED";
    }
}
