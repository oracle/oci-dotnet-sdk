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

namespace Oci.PsqlService.Models
{
    /// <summary>
    /// Details for the database system password.
    /// Password can be passed as `VaultSecretPasswordDetails` or `PlainTextPasswordDetails`.
    /// 
    /// </summary>
    [JsonConverter(typeof(PasswordDetailsModelConverter))]
    public class PasswordDetails 
    {
                ///
        /// <value>
        /// The password type.
        /// </value>
        ///
        public enum PasswordTypeEnum {
            [EnumMember(Value = "PLAIN_TEXT")]
            PlainText,
            [EnumMember(Value = "VAULT_SECRET")]
            VaultSecret
        };

        
    }

    public class PasswordDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(PasswordDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(PasswordDetails);
            var discriminator = jsonObject["passwordType"].Value<string>();
            switch (discriminator)
            {
                case "PLAIN_TEXT":
                    obj = new PlainTextPasswordDetails();
                    break;
                case "VAULT_SECRET":
                    obj = new VaultSecretPasswordDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
