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

namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Specifies how the replication channel handles replicated transactions without an identifier, enabling replication
    /// from a source that does not use transaction-id-based replication to a replica that does.
    /// 
    /// </summary>
    [JsonConverter(typeof(AnonymousTransactionsHandlingModelConverter))]
    public class AnonymousTransactionsHandling 
    {
                ///
        /// <value>
        /// Specifies how the replication channel handles anonymous transactions.
        /// </value>
        ///
        public enum PolicyEnum {
            [EnumMember(Value = "ERROR_ON_ANONYMOUS")]
            ErrorOnAnonymous,
            [EnumMember(Value = "ASSIGN_TARGET_UUID")]
            AssignTargetUuid,
            [EnumMember(Value = "ASSIGN_MANUAL_UUID")]
            AssignManualUuid
        };

        
    }

    public class AnonymousTransactionsHandlingModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AnonymousTransactionsHandling);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AnonymousTransactionsHandling);
            var discriminator = jsonObject["policy"].Value<string>();
            switch (discriminator)
            {
                case "ERROR_ON_ANONYMOUS":
                    obj = new ErrorOnAnonymousHandling();
                    break;
                case "ASSIGN_MANUAL_UUID":
                    obj = new AssignManualUuidHandling();
                    break;
                case "ASSIGN_TARGET_UUID":
                    obj = new AssignTargetUuidHandling();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under AnonymousTransactionsHandling! Returning null value.");
            }
            return obj;
        }
    }
}
