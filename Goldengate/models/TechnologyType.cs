/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.GoldengateService.Models
{
  /// <summary>
  /// The technology type.
    /// 
  /// </summary>
  public enum TechnologyType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "GOLDENGATE")]
      Goldengate,
      [EnumMember(Value = "GENERIC")]
      Generic,
      [EnumMember(Value = "OCI_AUTONOMOUS_DATABASE")]
      OciAutonomousDatabase,
      [EnumMember(Value = "OCI_AUTONOMOUS_JSON_DATABASE")]
      OciAutonomousJsonDatabase,
      [EnumMember(Value = "OCI_CACHE_WITH_REDIS")]
      OciCacheWithRedis,
      [EnumMember(Value = "OCI_MYSQL")]
      OciMysql,
      [EnumMember(Value = "OCI_OBJECT_STORAGE")]
      OciObjectStorage,
      [EnumMember(Value = "OCI_POSTGRESQL")]
      OciPostgresql,
      [EnumMember(Value = "OCI_STREAMING")]
      OciStreaming,
      [EnumMember(Value = "ORACLE_DATABASE")]
      OracleDatabase,
      [EnumMember(Value = "ORACLE_EXADATA")]
      OracleExadata,
      [EnumMember(Value = "ORACLE_EXADATA_DATABASE_AT_AZURE")]
      OracleExadataDatabaseAtAzure,
      [EnumMember(Value = "ORACLE_NOSQL")]
      OracleNosql,
      [EnumMember(Value = "ORACLE_WEBLOGIC_JMS")]
      OracleWeblogicJms,
      [EnumMember(Value = "AMAZON_RDS_ORACLE")]
      AmazonRdsOracle,
      [EnumMember(Value = "AMAZON_RDS_SQLSERVER")]
      AmazonRdsSqlserver,
      [EnumMember(Value = "AMAZON_S3")]
      AmazonS3,
      [EnumMember(Value = "AMAZON_AURORA_MYSQL")]
      AmazonAuroraMysql,
      [EnumMember(Value = "AMAZON_AURORA_POSTGRESQL")]
      AmazonAuroraPostgresql,
      [EnumMember(Value = "AMAZON_KINESIS")]
      AmazonKinesis,
      [EnumMember(Value = "AMAZON_REDSHIFT")]
      AmazonRedshift,
      [EnumMember(Value = "AMAZON_RDS_MARIADB")]
      AmazonRdsMariadb,
      [EnumMember(Value = "AMAZON_RDS_MYSQL")]
      AmazonRdsMysql,
      [EnumMember(Value = "AMAZON_RDS_POSTGRESQL")]
      AmazonRdsPostgresql,
      [EnumMember(Value = "APACHE_KAFKA")]
      ApacheKafka,
      [EnumMember(Value = "AZURE_COSMOS_DB_FOR_MONGODB")]
      AzureCosmosDbForMongodb,
      [EnumMember(Value = "AZURE_COSMOS_DB_FOR_POSTGRESQL")]
      AzureCosmosDbForPostgresql,
      [EnumMember(Value = "AZURE_DATA_LAKE_STORAGE")]
      AzureDataLakeStorage,
      [EnumMember(Value = "AZURE_EVENT_HUBS")]
      AzureEventHubs,
      [EnumMember(Value = "AZURE_MYSQL")]
      AzureMysql,
      [EnumMember(Value = "AZURE_POSTGRESQL")]
      AzurePostgresql,
      [EnumMember(Value = "AZURE_SQLSERVER_MANAGED_INSTANCE")]
      AzureSqlserverManagedInstance,
      [EnumMember(Value = "AZURE_SQLSERVER_NON_MANAGED_INSTANCE")]
      AzureSqlserverNonManagedInstance,
      [EnumMember(Value = "AZURE_SYNAPSE_ANALYTICS")]
      AzureSynapseAnalytics,
      [EnumMember(Value = "CONFLUENT_KAFKA")]
      ConfluentKafka,
      [EnumMember(Value = "CONFLUENT_SCHEMA_REGISTRY")]
      ConfluentSchemaRegistry,
      [EnumMember(Value = "DB2_ZOS")]
      Db2Zos,
      [EnumMember(Value = "ELASTICSEARCH")]
      Elasticsearch,
      [EnumMember(Value = "GOOGLE_BIGQUERY")]
      GoogleBigquery,
      [EnumMember(Value = "GOOGLE_CLOUD_STORAGE")]
      GoogleCloudStorage,
      [EnumMember(Value = "GOOGLE_CLOUD_SQL_MYSQL")]
      GoogleCloudSqlMysql,
      [EnumMember(Value = "GOOGLE_CLOUD_SQL_POSTGRESQL")]
      GoogleCloudSqlPostgresql,
      [EnumMember(Value = "GOOGLE_CLOUD_SQL_SQLSERVER")]
      GoogleCloudSqlSqlserver,
      [EnumMember(Value = "HDFS")]
      Hdfs,
      [EnumMember(Value = "MARIADB")]
      Mariadb,
      [EnumMember(Value = "MICROSOFT_SQLSERVER")]
      MicrosoftSqlserver,
      [EnumMember(Value = "MONGODB")]
      Mongodb,
      [EnumMember(Value = "MYSQL_SERVER")]
      MysqlServer,
      [EnumMember(Value = "MYSQL_HEATWAVE_ON_AZURE")]
      MysqlHeatwaveOnAzure,
      [EnumMember(Value = "MYSQL_HEATWAVE_ON_AWS")]
      MysqlHeatwaveOnAws,
      [EnumMember(Value = "POSTGRESQL_SERVER")]
      PostgresqlServer,
      [EnumMember(Value = "REDIS")]
      Redis,
      [EnumMember(Value = "SINGLESTOREDB")]
      Singlestoredb,
      [EnumMember(Value = "SINGLESTOREDB_CLOUD")]
      SinglestoredbCloud,
      [EnumMember(Value = "SNOWFLAKE")]
      Snowflake
  }
}
