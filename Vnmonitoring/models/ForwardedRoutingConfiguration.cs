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

namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the type of the resource that forwarded traffic.
    /// </summary>
    [JsonConverter(typeof(ForwardedRoutingConfigurationModelConverter))]
    public class ForwardedRoutingConfiguration 
    {
                ///
        /// <value>
        /// Type of the forwarded routing configuration.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "VCN")]
            Vcn,
            [EnumMember(Value = "DRG")]
            Drg
        };

        
    }

    public class ForwardedRoutingConfigurationModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ForwardedRoutingConfiguration);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ForwardedRoutingConfiguration);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "VCN":
                    obj = new VcnRoutingConfiguration();
                    break;
                case "DRG":
                    obj = new DrgRoutingConfiguration();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ForwardedRoutingConfiguration! Returning null value.");
            }
            return obj;
        }
    }
}
