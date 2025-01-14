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

namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Types of connection supported by Data Safe.
    /// </summary>
    [JsonConverter(typeof(ConnectionOptionModelConverter))]
    public class ConnectionOption 
    {
                ///
        /// <value>
        /// The connection type used to connect to the database. Allowed values:
        /// - PRIVATE_ENDPOINT - Represents connection through private endpoint in Data Safe.
        /// - ONPREM_CONNECTOR - Represents connection through on-premises connector in Data Safe.
        /// 
        /// </value>
        ///
        public enum ConnectionTypeEnum {
            [EnumMember(Value = "PRIVATE_ENDPOINT")]
            PrivateEndpoint,
            [EnumMember(Value = "ONPREM_CONNECTOR")]
            OnpremConnector
        };

        
    }

    public class ConnectionOptionModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ConnectionOption);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ConnectionOption);
            var discriminator = jsonObject["connectionType"].Value<string>();
            switch (discriminator)
            {
                case "PRIVATE_ENDPOINT":
                    obj = new PrivateEndpoint();
                    break;
                case "ONPREM_CONNECTOR":
                    obj = new OnPremiseConnector();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ConnectionOption! Returning null value.");
            }
            return obj;
        }
    }
}
