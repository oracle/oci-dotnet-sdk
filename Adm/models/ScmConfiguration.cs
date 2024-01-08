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
using Newtonsoft.Json.Linq;

namespace Oci.AdmService.Models
{
    /// <summary>
    /// A configuration for the Source Code Management tool/platform used by a remediation recipe.
    /// </summary>
    [JsonConverter(typeof(ScmConfigurationModelConverter))]
    public class ScmConfiguration 
    {
                ///
        /// <value>
        /// The type of Source Code Management.
        /// </value>
        ///
        public enum ScmTypeEnum {
            [EnumMember(Value = "OCI_CODE_REPOSITORY")]
            OciCodeRepository,
            [EnumMember(Value = "EXTERNAL_SCM")]
            ExternalScm
        };

        
        /// <value>
        /// The branch used by ADM to patch vulnerabilities.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Branch is required.")]
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }
        
        /// <value>
        /// The location of the build file relative to the root of the repository. Only Maven build files (POM) are currently supported.
        /// If this property is not specified, ADM will use the build file located at the root of the repository.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "buildFileLocation")]
        public string BuildFileLocation { get; set; }
        
        /// <value>
        /// If true, the Pull Request (PR) will be merged after the verify stage completes successfully    
        /// If false, the PR with the proposed changes must be reviewed and manually merged.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAutomergeEnabled is required.")]
        [JsonProperty(PropertyName = "isAutomergeEnabled")]
        public System.Nullable<bool> IsAutomergeEnabled { get; set; }
        
    }

    public class ScmConfigurationModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ScmConfiguration);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ScmConfiguration);
            var discriminator = jsonObject["scmType"].Value<string>();
            switch (discriminator)
            {
                case "OCI_CODE_REPOSITORY":
                    obj = new OciCodeRepositoryConfiguration();
                    break;
                case "EXTERNAL_SCM":
                    obj = new ExternalScmConfiguration();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ScmConfiguration! Returning null value.");
            }
            return obj;
        }
    }
}
