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

namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// Type of container health check which could be either HTTP, TCP, or Command.
    /// </summary>
    [JsonConverter(typeof(ContainerHealthCheckModelConverter))]
    public class ContainerHealthCheck 
    {
        
        /// <value>
        /// Health check name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        
        /// <value>
        /// The initial delay in seconds before start checking container health status.
        /// </value>
        [JsonProperty(PropertyName = "initialDelayInSeconds")]
        public System.Nullable<int> InitialDelayInSeconds { get; set; }
        
        /// <value>
        /// Number of seconds between two consecutive runs for checking container health.
        /// </value>
        [JsonProperty(PropertyName = "intervalInSeconds")]
        public System.Nullable<int> IntervalInSeconds { get; set; }
        
        /// <value>
        /// Number of consecutive failures at which we consider the check failed.
        /// </value>
        [JsonProperty(PropertyName = "failureThreshold")]
        public System.Nullable<int> FailureThreshold { get; set; }
        
        /// <value>
        /// Number of consecutive successes at which we consider the check succeeded again after it was in failure state.
        /// </value>
        [JsonProperty(PropertyName = "successThreshold")]
        public System.Nullable<int> SuccessThreshold { get; set; }
        
        /// <value>
        /// Length of waiting time in seconds before marking health check failed.
        /// </value>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public System.Nullable<int> TimeoutInSeconds { get; set; }
                ///
        /// <value>
        /// Status of container
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "HEALTHY")]
            Healthy,
            [EnumMember(Value = "UNHEALTHY")]
            Unhealthy,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// Status of container
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// A message describing the current status in more details.
        /// </value>
        [JsonProperty(PropertyName = "statusDetails")]
        public string StatusDetails { get; set; }
        
        /// <value>
        /// The action will be triggered when the container health check fails. There are two types of action: KILL or NONE. The default
        /// action is KILL. If failure action is KILL, the container will be subject to the container restart policy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "failureAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ContainerHealthCheckFailureAction> FailureAction { get; set; }
        
    }

    public class ContainerHealthCheckModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ContainerHealthCheck);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ContainerHealthCheck);
            var discriminator = jsonObject["healthCheckType"].Value<string>();
            switch (discriminator)
            {
                case "TCP":
                    obj = new ContainerTcpHealthCheck();
                    break;
                case "HTTP":
                    obj = new ContainerHttpHealthCheck();
                    break;
                case "COMMAND":
                    obj = new ContainerCommandHealthCheck();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ContainerHealthCheck! Returning null value.");
            }
            return obj;
        }
    }
}
