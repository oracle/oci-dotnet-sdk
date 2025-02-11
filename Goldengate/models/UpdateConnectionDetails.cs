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
using Newtonsoft.Json.Linq;

namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The information to update a Connection.
    /// 
    /// </summary>
    [JsonConverter(typeof(UpdateConnectionDetailsModelConverter))]
    public class UpdateConnectionDetails 
    {
        
        
        /// <value>
        /// An object's Display Name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Metadata about this specific object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. Exists
        /// for cross-compatibility only.
        /// <br/>
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Tags defined for this resource. Each key is predefined and scoped to a namespace.
        /// <br/>
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Refers to the customer's vault OCID. 
        /// If provided, it references a vault where GoldenGate can manage secrets. Customers must add policies to permit GoldenGate
        /// to manage secrets contained within this vault.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// Refers to the customer's master key OCID. 
        /// If provided, it references a key to manage secrets. Customers must add policies to permit GoldenGate to use this key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// An array of Network Security Group OCIDs used to define network access for either Deployments or Connections.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the target subnet of the dedicated connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// Controls the network traffic direction to the target:
        /// SHARED_SERVICE_ENDPOINT: Traffic flows through the Goldengate Service's network to public hosts. Cannot be used for private targets. 
        /// SHARED_DEPLOYMENT_ENDPOINT: Network traffic flows from the assigned deployment's private endpoint through the deployment's subnet.
        /// DEDICATED_ENDPOINT: A dedicated private endpoint is created in the target VCN subnet for the connection. The subnetId is required when DEDICATED_ENDPOINT networking is selected.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routingMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoutingMethod> RoutingMethod { get; set; }
        
        /// <value>
        /// Indicates that sensitive attributes are provided via Secrets.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "doesUseSecretIds")]
        public System.Nullable<bool> DoesUseSecretIds { get; set; }
        
    }

    public class UpdateConnectionDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateConnectionDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateConnectionDetails);
            var discriminator = jsonObject["connectionType"].Value<string>();
            switch (discriminator)
            {
                case "ELASTICSEARCH":
                    obj = new UpdateElasticsearchConnectionDetails();
                    break;
                case "GOOGLE_BIGQUERY":
                    obj = new UpdateGoogleBigQueryConnectionDetails();
                    break;
                case "ORACLE":
                    obj = new UpdateOracleConnectionDetails();
                    break;
                case "AMAZON_REDSHIFT":
                    obj = new UpdateAmazonRedshiftConnectionDetails();
                    break;
                case "OCI_OBJECT_STORAGE":
                    obj = new UpdateOciObjectStorageConnectionDetails();
                    break;
                case "REDIS":
                    obj = new UpdateRedisConnectionDetails();
                    break;
                case "MONGODB":
                    obj = new UpdateMongoDbConnectionDetails();
                    break;
                case "GOOGLE_CLOUD_STORAGE":
                    obj = new UpdateGoogleCloudStorageConnectionDetails();
                    break;
                case "MICROSOFT_FABRIC":
                    obj = new UpdateMicrosoftFabricConnectionDetails();
                    break;
                case "POSTGRESQL":
                    obj = new UpdatePostgresqlConnectionDetails();
                    break;
                case "MICROSOFT_SQLSERVER":
                    obj = new UpdateMicrosoftSqlserverConnectionDetails();
                    break;
                case "SNOWFLAKE":
                    obj = new UpdateSnowflakeConnectionDetails();
                    break;
                case "HDFS":
                    obj = new UpdateHdfsConnectionDetails();
                    break;
                case "DATABRICKS":
                    obj = new UpdateDatabricksConnectionDetails();
                    break;
                case "KAFKA":
                    obj = new UpdateKafkaConnectionDetails();
                    break;
                case "AZURE_DATA_LAKE_STORAGE":
                    obj = new UpdateAzureDataLakeStorageConnectionDetails();
                    break;
                case "AMAZON_KINESIS":
                    obj = new UpdateAmazonKinesisConnectionDetails();
                    break;
                case "JAVA_MESSAGE_SERVICE":
                    obj = new UpdateJavaMessageServiceConnectionDetails();
                    break;
                case "GOLDENGATE":
                    obj = new UpdateGoldenGateConnectionDetails();
                    break;
                case "GOOGLE_PUBSUB":
                    obj = new UpdateGooglePubSubConnectionDetails();
                    break;
                case "ORACLE_NOSQL":
                    obj = new UpdateOracleNosqlConnectionDetails();
                    break;
                case "KAFKA_SCHEMA_REGISTRY":
                    obj = new UpdateKafkaSchemaRegistryConnectionDetails();
                    break;
                case "AMAZON_S3":
                    obj = new UpdateAmazonS3ConnectionDetails();
                    break;
                case "MYSQL":
                    obj = new UpdateMysqlConnectionDetails();
                    break;
                case "DB2":
                    obj = new UpdateDb2ConnectionDetails();
                    break;
                case "GENERIC":
                    obj = new UpdateGenericConnectionDetails();
                    break;
                case "AZURE_SYNAPSE_ANALYTICS":
                    obj = new UpdateAzureSynapseConnectionDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
