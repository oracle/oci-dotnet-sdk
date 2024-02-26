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

namespace Oci.CoreService.Models
{
    /// <summary>
    /// The details of the volume to attach.
    /// </summary>
    [JsonConverter(typeof(LaunchAttachVolumeDetailsModelConverter))]
    public class LaunchAttachVolumeDetails 
    {
        
        /// <value>
        /// The device name. To retrieve a list of devices for a given instance, see {@link #listInstanceDevices(ListInstanceDevicesRequest) listInstanceDevices}.
        /// </value>
        [JsonProperty(PropertyName = "device")]
        public string Device { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Whether the attachment was created in read-only mode.
        /// </value>
        [JsonProperty(PropertyName = "isReadOnly")]
        public System.Nullable<bool> IsReadOnly { get; set; }
        
        /// <value>
        /// Whether the attachment should be created in shareable mode. If an attachment
        /// is created in shareable mode, then other instances can attach the same volume, provided
        /// that they also create their attachments in shareable mode. Only certain volume types can
        /// be attached in shareable mode. Defaults to false if not specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isShareable")]
        public System.Nullable<bool> IsShareable { get; set; }
        
        
        /// <value>
        /// The OCID of the volume. If CreateVolumeDetails is specified, this field must be omitted from the request.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "volumeId")]
        public string VolumeId { get; set; }
        
        [JsonProperty(PropertyName = "launchCreateVolumeDetails")]
        public LaunchCreateVolumeDetails LaunchCreateVolumeDetails { get; set; }
        
    }

    public class LaunchAttachVolumeDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(LaunchAttachVolumeDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(LaunchAttachVolumeDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "iscsi":
                    obj = new LaunchAttachIScsiVolumeDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
