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

namespace Oci.ServicecatalogService.Models
{
    /// <summary>
    /// A base object for all types of private application packages.
    /// </summary>
    [JsonConverter(typeof(PrivateApplicationPackageModelConverter))]
    public class PrivateApplicationPackage 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the private application package.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the private application where the package is hosted.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrivateApplicationId is required.")]
        [JsonProperty(PropertyName = "privateApplicationId")]
        public string PrivateApplicationId { get; set; }
        
        /// <value>
        /// The display name of the package.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The package version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        
        /// <value>
        /// The date and time the private application package was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// <br/>
        /// Example: 2021-05-27T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }

    public class PrivateApplicationPackageModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(PrivateApplicationPackage);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(PrivateApplicationPackage);
            var discriminator = jsonObject["packageType"].Value<string>();
            switch (discriminator)
            {
                case "STACK":
                    obj = new PrivateApplicationStackPackage();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under PrivateApplicationPackage! Returning null value.");
            }
            return obj;
        }
    }
}
