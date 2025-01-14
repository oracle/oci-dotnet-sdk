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
    /// If authentication has been performed, validate whether the request scope (if any) applies to this route.
    /// If no RouteAuthorizationPolicy is defined for a route, a policy with a type of AUTHENTICATION_ONLY is applied.
    /// 
    /// </summary>
    [JsonConverter(typeof(RouteAuthorizationPolicyModelConverter))]
    public class RouteAuthorizationPolicy 
    {
                ///
        /// <value>
        /// Indicates how authorization should be applied. For a type of ANY_OF, an \"allowedScope\"
        /// property must also be specified. Otherwise, only a type is required. For a type of ANONYMOUS, an
        /// authenticated API must have the \"isAnonymousAccessAllowed\" property set to \"true\" in the authentication
        /// policy.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "ANONYMOUS")]
            Anonymous,
            [EnumMember(Value = "ANY_OF")]
            AnyOf,
            [EnumMember(Value = "AUTHENTICATION_ONLY")]
            AuthenticationOnly
        };

        
    }

    public class RouteAuthorizationPolicyModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(RouteAuthorizationPolicy);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(RouteAuthorizationPolicy);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "ANY_OF":
                    obj = new AnyOfRouteAuthorizationPolicy();
                    break;
                case "ANONYMOUS":
                    obj = new AnonymousRouteAuthorizationPolicy();
                    break;
                case "AUTHENTICATION_ONLY":
                    obj = new AuthenticationOnlyRouteAuthorizationPolicy();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under RouteAuthorizationPolicy! Returning null value.");
            }
            return obj;
        }
    }
}
