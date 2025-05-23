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

namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The trigger of the schedule can be UNIX cron or iCal expression or simple interval
    /// </summary>
    [JsonConverter(typeof(ScheduleTriggerModelConverter))]
    public class ScheduleTrigger 
    {
                ///
        /// <value>
        /// The schedule trigger type
        /// </value>
        ///
        public enum TriggerTypeEnum {
            [EnumMember(Value = "CRON")]
            Cron,
            [EnumMember(Value = "INTERVAL")]
            Interval,
            [EnumMember(Value = "ICAL")]
            Ical
        };

        
        /// <value>
        /// The schedule starting date time, if null, System set the time when schedule is created.
        /// Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// The schedule end date time, if null, the schedule will never expire.
        /// Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
    }

    public class ScheduleTriggerModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ScheduleTrigger);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ScheduleTrigger);
            var discriminator = jsonObject["triggerType"].Value<string>();
            switch (discriminator)
            {
                case "ICAL":
                    obj = new ScheduleICalTrigger();
                    break;
                case "INTERVAL":
                    obj = new ScheduleIntervalTrigger();
                    break;
                case "CRON":
                    obj = new ScheduleCronTrigger();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ScheduleTrigger! Returning null value.");
            }
            return obj;
        }
    }
}
