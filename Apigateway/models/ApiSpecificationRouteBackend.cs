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

namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// The backend to forward requests to.
    /// 
    /// </summary>
    [JsonConverter(typeof(ApiSpecificationRouteBackendModelConverter))]
    public class ApiSpecificationRouteBackend 
    {
                ///
        /// <value>
        /// Type of the API backend.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "ORACLE_FUNCTIONS_BACKEND")]
            OracleFunctionsBackend,
            [EnumMember(Value = "HTTP_BACKEND")]
            HttpBackend,
            [EnumMember(Value = "STOCK_RESPONSE_BACKEND")]
            StockResponseBackend,
            [EnumMember(Value = "DYNAMIC_ROUTING_BACKEND")]
            DynamicRoutingBackend,
            [EnumMember(Value = "OAUTH2_LOGOUT_BACKEND")]
            Oauth2LogoutBackend
        };

        
    }

    public class ApiSpecificationRouteBackendModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ApiSpecificationRouteBackend);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ApiSpecificationRouteBackend);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "OAUTH2_LOGOUT_BACKEND":
                    obj = new OAuth2LogoutBackend();
                    break;
                case "HTTP_BACKEND":
                    obj = new HTTPBackend();
                    break;
                case "ORACLE_FUNCTIONS_BACKEND":
                    obj = new OracleFunctionBackend();
                    break;
                case "STOCK_RESPONSE_BACKEND":
                    obj = new StockResponseBackend();
                    break;
                case "DYNAMIC_ROUTING_BACKEND":
                    obj = new DynamicRoutingBackend();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ApiSpecificationRouteBackend! Returning null value.");
            }
            return obj;
        }
    }
}
