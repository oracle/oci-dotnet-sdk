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

namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides summary information for a software package.
    /// </summary>
    [JsonConverter(typeof(PackageSummaryModelConverter))]
    public class PackageSummary 
    {
        
        /// <value>
        /// Package name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Unique identifier for the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Type of the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Version of the installed package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The architecture for which this package was built.
        /// </value>
        [JsonProperty(PropertyName = "architecture")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ArchType> Architecture { get; set; }
        
        /// <value>
        /// List of software sources that provide the software package.
        /// </value>
        [JsonProperty(PropertyName = "softwareSources")]
        public System.Collections.Generic.List<SoftwareSourceDetails> SoftwareSources { get; set; }
                ///
        /// <value>
        /// Status of the software package.
        /// </value>
        ///
        public enum PackageClassificationEnum {
            [EnumMember(Value = "INSTALLED")]
            Installed,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UPDATABLE")]
            Updatable
        };

        
    }

    public class PackageSummaryModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(PackageSummary);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(PackageSummary);
            var discriminator = jsonObject["packageClassification"].Value<string>();
            switch (discriminator)
            {
                case "AVAILABLE":
                    obj = new AvailablePackageSummary();
                    break;
                case "INSTALLED":
                    obj = new InstalledPackageSummary();
                    break;
                case "UPDATABLE":
                    obj = new UpdatablePackageSummary();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under PackageSummary! Returning null value.");
            }
            return obj;
        }
    }
}
