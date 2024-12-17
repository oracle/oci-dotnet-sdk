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

namespace Oci.GenerativeaiagentService.Models
{
    /// <summary>
    /// The details of configured security configuration on OpenSearch.
    /// 
    /// </summary>
    [JsonConverter(typeof(SecretDetailModelConverter))]
    public class SecretDetail 
    {
                ///
        /// <value>
        /// The type of OpenID.
        /// The allowed values are:
        /// - `IDCS_SECRET`: The OpenID configuration used is OpenSearch is IDCS.
        /// - `BASIC_AUTH_SECRET`: Basic authentication use for OpenSearch
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "IDCS_SECRET")]
            IdcsSecret,
            [EnumMember(Value = "BASIC_AUTH_SECRET")]
            BasicAuthSecret
        };

        
    }

    public class SecretDetailModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SecretDetail);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SecretDetail);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "IDCS_SECRET":
                    obj = new IdcsSecret();
                    break;
                case "BASIC_AUTH_SECRET":
                    obj = new BasicAuthSecret();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under SecretDetail! Returning null value.");
            }
            return obj;
        }
    }
}
