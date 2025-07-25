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

namespace Oci.AutoscalingService.Models
{
    
    [JsonConverter(typeof(MetricBaseModelConverter))]
    public class MetricBase 
    {
        
        /// <value>
        /// The period of time that the condition defined in the alarm must persist before the alarm state
        /// changes from \"OK\" to \"FIRING\" or vice versa. For example, a value of 5 minutes means that the
        /// alarm must persist in breaching the condition for five minutes before the alarm updates its
        /// state to \"FIRING\"; likewise, the alarm must persist in not breaching the condition for five
        /// minutes before the alarm updates its state to \"OK.\"
        /// <br/>
        /// The duration is specified as a string in ISO 8601 format (`PT10M` for ten minutes or `PT1H`
        /// for one hour). Minimum: PT3M. Maximum: PT1H. Default: PT3M.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "pendingDuration")]
        public string PendingDuration { get; set; }
                ///
        /// <value>
        /// Source of the metric data for creating the alarm used to trigger autoscaling actions.
        /// <br/>
        /// The following values are supported:
        /// <br/>
        /// * `COMPUTE_AGENT`: CPU or memory metrics emitted by the Compute Instance Monitoring plugin.
        /// <br/>
        /// * `CUSTOM_QUERY`: A custom Monitoring Query Language (MQL) expression.
        /// 
        /// </value>
        ///
        public enum MetricSourceEnum {
            [EnumMember(Value = "COMPUTE_AGENT")]
            ComputeAgent,
            [EnumMember(Value = "CUSTOM_QUERY")]
            CustomQuery
        };

        
    }

    public class MetricBaseModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(MetricBase);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(MetricBase);
            var discriminator = jsonObject["metricSource"].Value<string>();
            switch (discriminator)
            {
                case "CUSTOM_QUERY":
                    obj = new CustomMetric();
                    break;
                case "COMPUTE_AGENT":
                    obj = new Metric();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under MetricBase! Returning null value.");
            }
            return obj;
        }
    }
}
