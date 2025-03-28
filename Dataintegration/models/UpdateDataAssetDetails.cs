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

namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Properties used in data asset update operations.
    /// </summary>
    [JsonConverter(typeof(UpdateDataAssetDetailsModelConverter))]
    public class UpdateDataAssetDetails 
    {
                ///
        /// <value>
        /// The type of the data asset.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "ORACLE_DATA_ASSET")]
            OracleDataAsset,
            [EnumMember(Value = "ORACLE_OBJECT_STORAGE_DATA_ASSET")]
            OracleObjectStorageDataAsset,
            [EnumMember(Value = "ORACLE_ATP_DATA_ASSET")]
            OracleAtpDataAsset,
            [EnumMember(Value = "ORACLE_ADWC_DATA_ASSET")]
            OracleAdwcDataAsset,
            [EnumMember(Value = "MYSQL_DATA_ASSET")]
            MysqlDataAsset,
            [EnumMember(Value = "GENERIC_JDBC_DATA_ASSET")]
            GenericJdbcDataAsset,
            [EnumMember(Value = "FUSION_APP_DATA_ASSET")]
            FusionAppDataAsset,
            [EnumMember(Value = "AMAZON_S3_DATA_ASSET")]
            AmazonS3DataAsset,
            [EnumMember(Value = "LAKE_DATA_ASSET")]
            LakeDataAsset,
            [EnumMember(Value = "ORACLE_PEOPLESOFT_DATA_ASSET")]
            OraclePeoplesoftDataAsset,
            [EnumMember(Value = "ORACLE_SIEBEL_DATA_ASSET")]
            OracleSiebelDataAsset,
            [EnumMember(Value = "ORACLE_EBS_DATA_ASSET")]
            OracleEbsDataAsset,
            [EnumMember(Value = "HDFS_DATA_ASSET")]
            HdfsDataAsset,
            [EnumMember(Value = "MYSQL_HEATWAVE_DATA_ASSET")]
            MysqlHeatwaveDataAsset,
            [EnumMember(Value = "REST_DATA_ASSET")]
            RestDataAsset
        };

        
        /// <value>
        /// Generated key that can be used in API calls to identify data asset.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The user-defined description of the data asset.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectVersion is required.")]
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The external key for the object.
        /// </value>
        [JsonProperty(PropertyName = "externalKey")]
        public string ExternalKey { get; set; }
        
        /// <value>
        /// Additional properties for the data asset.
        /// </value>
        [JsonProperty(PropertyName = "assetProperties")]
        public System.Collections.Generic.Dictionary<string, string> AssetProperties { get; set; }
        
        [JsonProperty(PropertyName = "registryMetadata")]
        public RegistryMetadata RegistryMetadata { get; set; }
        
    }

    public class UpdateDataAssetDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateDataAssetDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateDataAssetDetails);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "REST_DATA_ASSET":
                    obj = new UpdateDataAssetFromRest();
                    break;
                case "MYSQL_HEATWAVE_DATA_ASSET":
                    obj = new UpdateDataAssetFromMySqlHeatWave();
                    break;
                case "ORACLE_EBS_DATA_ASSET":
                    obj = new UpdateDataAssetFromOracleEbs();
                    break;
                case "ORACLE_ADWC_DATA_ASSET":
                    obj = new UpdateDataAssetFromAdwc();
                    break;
                case "HDFS_DATA_ASSET":
                    obj = new UpdateDataAssetFromHdfs();
                    break;
                case "ORACLE_PEOPLESOFT_DATA_ASSET":
                    obj = new UpdateDataAssetFromOraclePeopleSoft();
                    break;
                case "ORACLE_OBJECT_STORAGE_DATA_ASSET":
                    obj = new UpdateDataAssetFromObjectStorage();
                    break;
                case "AMAZON_S3_DATA_ASSET":
                    obj = new UpdateDataAssetFromAmazonS3();
                    break;
                case "MYSQL_DATA_ASSET":
                    obj = new UpdateDataAssetFromMySQL();
                    break;
                case "ORACLE_SIEBEL_DATA_ASSET":
                    obj = new UpdateDataAssetFromOracleSiebel();
                    break;
                case "LAKE_DATA_ASSET":
                    obj = new UpdateDataAssetFromLake();
                    break;
                case "ORACLE_ATP_DATA_ASSET":
                    obj = new UpdateDataAssetFromAtp();
                    break;
                case "GENERIC_JDBC_DATA_ASSET":
                    obj = new UpdateDataAssetFromJdbc();
                    break;
                case "FUSION_APP_DATA_ASSET":
                    obj = new UpdateDataAssetFromFusionApp();
                    break;
                case "ORACLE_DATA_ASSET":
                    obj = new UpdateDataAssetFromOracle();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
