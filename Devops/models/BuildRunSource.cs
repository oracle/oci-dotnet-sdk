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

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// The source from which the build run is triggered.
    /// </summary>
    [JsonConverter(typeof(BuildRunSourceModelConverter))]
    public class BuildRunSource 
    {
                ///
        /// <value>
        /// The source from which the build run is triggered.
        /// </value>
        ///
        public enum SourceTypeEnum {
            [EnumMember(Value = "MANUAL")]
            Manual,
            [EnumMember(Value = "GITHUB")]
            Github,
            [EnumMember(Value = "GITLAB")]
            Gitlab,
            [EnumMember(Value = "GITLAB_SERVER")]
            GitlabServer,
            [EnumMember(Value = "BITBUCKET_CLOUD")]
            BitbucketCloud,
            [EnumMember(Value = "BITBUCKET_SERVER")]
            BitbucketServer,
            [EnumMember(Value = "DEVOPS_CODE_REPOSITORY")]
            DevopsCodeRepository,
            [EnumMember(Value = "VBS")]
            Vbs
        };

        
    }

    public class BuildRunSourceModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(BuildRunSource);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(BuildRunSource);
            var discriminator = jsonObject["sourceType"].Value<string>();
            switch (discriminator)
            {
                case "GITLAB_SERVER":
                    obj = new GitlabServerBuildRunSource();
                    break;
                case "BITBUCKET_SERVER":
                    obj = new BitbucketServerBuildRunSource();
                    break;
                case "GITHUB":
                    obj = new GithubBuildRunSource();
                    break;
                case "DEVOPS_CODE_REPOSITORY":
                    obj = new DevopsCodeRepositoryBuildRunSource();
                    break;
                case "VBS":
                    obj = new VbsBuildRunSource();
                    break;
                case "MANUAL":
                    obj = new ManualBuildRunSource();
                    break;
                case "BITBUCKET_CLOUD":
                    obj = new BitbucketCloudBuildRunSource();
                    break;
                case "GITLAB":
                    obj = new GitlabBuildRunSource();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under BuildRunSource! Returning null value.");
            }
            return obj;
        }
    }
}
