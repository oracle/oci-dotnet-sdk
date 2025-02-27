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
    /// <summary>
    /// An execution schedule for an autoscaling policy.
    /// 
    /// </summary>
    [JsonConverter(typeof(ExecutionScheduleModelConverter))]
    public class ExecutionSchedule 
    {
        
                ///
        /// <value>
        /// The time zone for the execution schedule.
        /// </value>
        ///
        public enum TimezoneEnum {
            [EnumMember(Value = "UTC")]
            Utc
        };

        /// <value>
        /// The time zone for the execution schedule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timezone is required.")]
        [JsonProperty(PropertyName = "timezone")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TimezoneEnum> Timezone { get; set; }
        
    }

    public class ExecutionScheduleModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ExecutionSchedule);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ExecutionSchedule);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "cron":
                    obj = new CronExecutionSchedule();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ExecutionSchedule! Returning null value.");
            }
            return obj;
        }
    }
}
