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

namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Scheduling related details for the Exadata Fleet Update Action.
    /// The specified time should not conflict with existing Exadata Infrastructure maintenance windows.
    /// 'NONE' type scheduleDetails for UpdateAction would execute the Exadata Fleet Update Action as soon as possible.
    /// 
    /// </summary>
    [JsonConverter(typeof(UpdateScheduleDetailsModelConverter))]
    public class UpdateScheduleDetails 
    {
                ///
        /// <value>
        /// Type of scheduling strategy to use for Fleet Patching Update Action execution.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "START_TIME")]
            StartTime,
            [EnumMember(Value = "NONE")]
            None
        };

        
    }

    public class UpdateScheduleDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateScheduleDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateScheduleDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "NONE":
                    obj = new NoneScheduleDetails();
                    break;
                case "START_TIME":
                    obj = new UpdateStartTimeScheduleDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
