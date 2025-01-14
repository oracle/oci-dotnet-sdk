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

namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The options for a plan execution.
    /// </summary>
    [JsonConverter(typeof(DrPlanExecutionOptionsModelConverter))]
    public class DrPlanExecutionOptions 
    {
                ///
        /// <value>
        /// The type of the plan execution.
        /// 
        /// </value>
        ///
        public enum PlanExecutionTypeEnum {
            [EnumMember(Value = "SWITCHOVER")]
            Switchover,
            [EnumMember(Value = "SWITCHOVER_PRECHECK")]
            SwitchoverPrecheck,
            [EnumMember(Value = "FAILOVER")]
            Failover,
            [EnumMember(Value = "FAILOVER_PRECHECK")]
            FailoverPrecheck,
            [EnumMember(Value = "START_DRILL_PRECHECK")]
            StartDrillPrecheck,
            [EnumMember(Value = "START_DRILL")]
            StartDrill,
            [EnumMember(Value = "STOP_DRILL_PRECHECK")]
            StopDrillPrecheck,
            [EnumMember(Value = "STOP_DRILL")]
            StopDrill
        };

        
    }

    public class DrPlanExecutionOptionsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DrPlanExecutionOptions);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DrPlanExecutionOptions);
            var discriminator = jsonObject["planExecutionType"].Value<string>();
            switch (discriminator)
            {
                case "STOP_DRILL":
                    obj = new StopDrillExecutionOptions();
                    break;
                case "SWITCHOVER":
                    obj = new SwitchoverExecutionOptions();
                    break;
                case "FAILOVER_PRECHECK":
                    obj = new FailoverPrecheckExecutionOptions();
                    break;
                case "START_DRILL":
                    obj = new StartDrillExecutionOptions();
                    break;
                case "SWITCHOVER_PRECHECK":
                    obj = new SwitchoverPrecheckExecutionOptions();
                    break;
                case "START_DRILL_PRECHECK":
                    obj = new StartDrillPrecheckExecutionOptions();
                    break;
                case "STOP_DRILL_PRECHECK":
                    obj = new StopDrillPrecheckExecutionOptions();
                    break;
                case "FAILOVER":
                    obj = new FailoverExecutionOptions();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DrPlanExecutionOptions! Returning null value.");
            }
            return obj;
        }
    }
}
