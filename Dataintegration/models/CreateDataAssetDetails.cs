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
    [JsonConverter(typeof(CreateDataAssetDetailsModelConverter))]
    public class CreateDataAssetDetails 
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
        /// Currently not used on data asset creation. Reserved for future.
        /// </value>
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
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// User-defined description of the data asset.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
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

    public class CreateDataAssetDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateDataAssetDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateDataAssetDetails);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "HDFS_DATA_ASSET":
                    obj = new CreateDataAssetFromHdfs();
                    break;
                case "LAKE_DATA_ASSET":
                    obj = new CreateDataAssetFromLake();
                    break;
                case "MYSQL_HEATWAVE_DATA_ASSET":
                    obj = new CreateDataAssetFromMySqlHeatWave();
                    break;
                case "AMAZON_S3_DATA_ASSET":
                    obj = new CreateDataAssetFromAmazonS3();
                    break;
                case "REST_DATA_ASSET":
                    obj = new CreateDataAssetFromRest();
                    break;
                case "ORACLE_SIEBEL_DATA_ASSET":
                    obj = new CreateDataAssetFromOracleSiebel();
                    break;
                case "GENERIC_JDBC_DATA_ASSET":
                    obj = new CreateDataAssetFromJdbc();
                    break;
                case "MYSQL_DATA_ASSET":
                    obj = new CreateDataAssetFromMySQL();
                    break;
                case "ORACLE_DATA_ASSET":
                    obj = new CreateDataAssetFromOracle();
                    break;
                case "ORACLE_ADWC_DATA_ASSET":
                    obj = new CreateDataAssetFromAdwc();
                    break;
                case "ORACLE_EBS_DATA_ASSET":
                    obj = new CreateDataAssetFromOracleEbs();
                    break;
                case "ORACLE_PEOPLESOFT_DATA_ASSET":
                    obj = new CreateDataAssetFromOraclePeopleSoft();
                    break;
                case "FUSION_APP_DATA_ASSET":
                    obj = new CreateDataAssetFromFusionApp();
                    break;
                case "ORACLE_ATP_DATA_ASSET":
                    obj = new CreateDataAssetFromAtp();
                    break;
                case "ORACLE_OBJECT_STORAGE_DATA_ASSET":
                    obj = new CreateDataAssetFromObjectStorage();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
