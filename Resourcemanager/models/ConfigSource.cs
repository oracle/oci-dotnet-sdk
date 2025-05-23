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

namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Information about the Terraform configuration.
    /// 
    /// </summary>
    [JsonConverter(typeof(ConfigSourceModelConverter))]
    public class ConfigSource 
    {
                ///
        /// <value>
        /// The type of configuration source to use for the Terraform configuration.
        /// 
        /// </value>
        ///
        public enum ConfigSourceTypeEnum {
            [EnumMember(Value = "BITBUCKET_CLOUD_CONFIG_SOURCE")]
            BitbucketCloudConfigSource,
            [EnumMember(Value = "BITBUCKET_SERVER_CONFIG_SOURCE")]
            BitbucketServerConfigSource,
            [EnumMember(Value = "COMPARTMENT_CONFIG_SOURCE")]
            CompartmentConfigSource,
            [EnumMember(Value = "DEVOPS_CONFIG_SOURCE")]
            DevopsConfigSource,
            [EnumMember(Value = "GIT_CONFIG_SOURCE")]
            GitConfigSource,
            [EnumMember(Value = "OBJECT_STORAGE_CONFIG_SOURCE")]
            ObjectStorageConfigSource,
            [EnumMember(Value = "ZIP_UPLOAD")]
            ZipUpload
        };

        
        /// <value>
        /// File path to the directory to use for running Terraform.
        /// If not specified, the root directory is used.
        /// Required when using a zip Terraform configuration (`configSourceType` value of `ZIP_UPLOAD`) that contains folders.
        /// Ignored for the `configSourceType` value of `COMPARTMENT_CONFIG_SOURCE`.
        /// For more information about required and recommended file structure, see
        /// [File Structure (Terraform Configurations for Resource Manager)](https://docs.cloud.oracle.com/iaas/Content/ResourceManager/Concepts/terraformconfigresourcemanager.htm#filestructure).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "workingDirectory")]
        public string WorkingDirectory { get; set; }
        
    }

    public class ConfigSourceModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ConfigSource);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ConfigSource);
            var discriminator = jsonObject["configSourceType"].Value<string>();
            switch (discriminator)
            {
                case "GIT_CONFIG_SOURCE":
                    obj = new GitConfigSource();
                    break;
                case "DEVOPS_CONFIG_SOURCE":
                    obj = new DevOpsConfigSource();
                    break;
                case "OBJECT_STORAGE_CONFIG_SOURCE":
                    obj = new ObjectStorageConfigSource();
                    break;
                case "BITBUCKET_SERVER_CONFIG_SOURCE":
                    obj = new BitbucketServerConfigSource();
                    break;
                case "BITBUCKET_CLOUD_CONFIG_SOURCE":
                    obj = new BitbucketCloudConfigSource();
                    break;
                case "COMPARTMENT_CONFIG_SOURCE":
                    obj = new CompartmentConfigSource();
                    break;
                case "ZIP_UPLOAD":
                    obj = new ZipUploadConfigSource();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ConfigSource! Returning null value.");
            }
            return obj;
        }
    }
}
