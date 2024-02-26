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

namespace Oci.SchService.Models
{
    /// <summary>
    /// A service source or service target used to create a connector.
    /// Example connector plugins include the Queue source and the Notifications target.
    /// For more information about flows defined by connectors, see
    /// [Overview of Connector Hub](https://docs.cloud.oracle.com/iaas/Content/connector-hub/overview.htm).
    /// For configuration instructions, see
    /// [Creating a Connector](https://docs.cloud.oracle.com/iaas/Content/connector-hub/create-service-connector.htm).
    /// 
    /// </summary>
    [JsonConverter(typeof(ConnectorPluginModelConverter))]
    public class ConnectorPlugin 
    {
                ///
        /// <value>
        /// The plugin type discriminator.
        /// 
        /// </value>
        ///
        public enum KindEnum {
            [EnumMember(Value = "SOURCE")]
            Source,
            [EnumMember(Value = "TARGET")]
            Target
        };

        
        /// <value>
        /// The service to be called by the connector plugin.
        /// Example: QueueSource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The date and time when this plugin became available.
        /// Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2023-09-09T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The estimated throughput range (LOW, MEDIUM, HIGH).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "estimatedThroughput")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EstimatedThroughput> EstimatedThroughput { get; set; }
        
        /// <value>
        /// The current state of the service connector.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConnectorPluginLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A user-friendly name. It does not have to be unique, and it is changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Gets the specified connector plugin configuration information in OpenAPI specification format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "schema")]
        public string Schema { get; set; }
        
    }

    public class ConnectorPluginModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ConnectorPlugin);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ConnectorPlugin);
            var discriminator = jsonObject["kind"].Value<string>();
            switch (discriminator)
            {
                case "TARGET":
                    obj = new TargetConnectorPlugin();
                    break;
                case "SOURCE":
                    obj = new SourceConnectorPlugin();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ConnectorPlugin! Returning null value.");
            }
            return obj;
        }
    }
}
