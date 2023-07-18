/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// A volume represents a directory with data that is accessible across multiple containers in a
    /// container instance.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateContainerVolumeDetailsModelConverter))]
    public class CreateContainerVolumeDetails 
    {
        
        /// <value>
        /// The name of the volume. This must be unique within a single container instance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        
    }

    public class CreateContainerVolumeDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateContainerVolumeDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateContainerVolumeDetails);
            var discriminator = jsonObject["volumeType"].Value<string>();
            switch (discriminator)
            {
                case "CONFIGFILE":
                    obj = new CreateContainerConfigFileVolumeDetails();
                    break;
                case "EMPTYDIR":
                    obj = new CreateContainerEmptyDirVolumeDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
