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

namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// The action to be performed if the ingest time rule condition(s) are satisfied.
    /// </summary>
    [JsonConverter(typeof(IngestTimeRuleActionModelConverter))]
    public class IngestTimeRuleAction 
    {
                ///
        /// <value>
        /// Discriminator.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "METRIC_EXTRACTION")]
            MetricExtraction
        };

        
    }

    public class IngestTimeRuleActionModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(IngestTimeRuleAction);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(IngestTimeRuleAction);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "METRIC_EXTRACTION":
                    obj = new IngestTimeRuleMetricExtractionAction();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under IngestTimeRuleAction! Returning null value.");
            }
            return obj;
        }
    }
}
