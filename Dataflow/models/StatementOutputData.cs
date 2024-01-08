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

namespace Oci.DataflowService.Models
{
    /// <summary>
    /// An object representing execution output of a statement.
    /// 
    /// </summary>
    [JsonConverter(typeof(StatementOutputDataModelConverter))]
    public class StatementOutputData 
    {
                ///
        /// <value>
        /// The type of the `StatementOutputData` like `TEXT_PLAIN`, `TEXT_HTML` or `IMAGE_PNG`.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "TEXT_PLAIN")]
            TextPlain,
            [EnumMember(Value = "TEXT_HTML")]
            TextHtml,
            [EnumMember(Value = "IMAGE_PNG")]
            ImagePng
        };

        
    }

    public class StatementOutputDataModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(StatementOutputData);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(StatementOutputData);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "IMAGE_PNG":
                    obj = new ImagePngStatementOutputData();
                    break;
                case "TEXT_HTML":
                    obj = new TextHtmlStatementOutputData();
                    break;
                case "TEXT_PLAIN":
                    obj = new TextPlainStatementOutputData();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under StatementOutputData! Returning null value.");
            }
            return obj;
        }
    }
}
