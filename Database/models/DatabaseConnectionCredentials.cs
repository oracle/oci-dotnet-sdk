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

namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Credentials used to connect to the database. Currently only the `DETAILS` type is supported for creating MACS connector crendentials.
    /// 
    /// </summary>
    [JsonConverter(typeof(DatabaseConnectionCredentialsModelConverter))]
    public class DatabaseConnectionCredentials 
    {
                ///
        /// <value>
        /// The type of credential used to connect to the database.
        /// </value>
        ///
        public enum CredentialTypeEnum {
            [EnumMember(Value = "NAME_REFERENCE")]
            NameReference,
            [EnumMember(Value = "DETAILS")]
            Details,
            [EnumMember(Value = "SSL_DETAILS")]
            SslDetails
        };

        
    }

    public class DatabaseConnectionCredentialsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DatabaseConnectionCredentials);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DatabaseConnectionCredentials);
            var discriminator = jsonObject["credentialType"].Value<string>();
            switch (discriminator)
            {
                case "SSL_DETAILS":
                    obj = new DatabaseSslConnectionCredentials();
                    break;
                case "NAME_REFERENCE":
                    obj = new DatabaseConnectionCredentialsByName();
                    break;
                case "DETAILS":
                    obj = new DatabaseConnectionCredentialsByDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DatabaseConnectionCredentials! Returning null value.");
            }
            return obj;
        }
    }
}
