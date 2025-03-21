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

namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Decryption Profile used on the firewall policy rules.
    /// </summary>
    [JsonConverter(typeof(DecryptionProfileModelConverter))]
    public class DecryptionProfile 
    {
        
        
        /// <value>
        /// Unique Name of the decryption profile.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// OCID of the Network Firewall Policy this decryption profile belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParentResourceId is required.")]
        [JsonProperty(PropertyName = "parentResourceId")]
        public string ParentResourceId { get; set; }
        
    }

    public class DecryptionProfileModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DecryptionProfile);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DecryptionProfile);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "SSL_INBOUND_INSPECTION":
                    obj = new SslInboundInspectionProfile();
                    break;
                case "SSL_FORWARD_PROXY":
                    obj = new SslForwardProxyProfile();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DecryptionProfile! Returning null value.");
            }
            return obj;
        }
    }
}
