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

namespace Oci.BdsService.Models
{
    /// <summary>
    /// Detailed configurations for defining the behavior when installing os patches. If not provided, nodes will be patched and rebooted AD/FD by AD/FD for regular patches or will be patched with down time if the patch is an emergent patch.
    /// </summary>
    [JsonConverter(typeof(PatchingConfigsModelConverter))]
    public class PatchingConfigs 
    {
                ///
        /// <value>
        /// Type of strategy used for detailed patching configuration
        /// </value>
        ///
        public enum PatchingConfigStrategyEnum {
            [EnumMember(Value = "DOWNTIME_BASED")]
            DowntimeBased,
            [EnumMember(Value = "BATCHING_BASED")]
            BatchingBased,
            [EnumMember(Value = "DOMAIN_BASED")]
            DomainBased
        };

        
    }

    public class PatchingConfigsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(PatchingConfigs);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(PatchingConfigs);
            var discriminator = jsonObject["patchingConfigStrategy"].Value<string>();
            switch (discriminator)
            {
                case "BATCHING_BASED":
                    obj = new BatchingBasedPatchingConfigs();
                    break;
                case "DOWNTIME_BASED":
                    obj = new DowntimeBasedPatchingConfigs();
                    break;
                case "DOMAIN_BASED":
                    obj = new DomainBasedPatchingConfigs();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
