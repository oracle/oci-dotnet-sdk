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

namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Optional additional properties for dump transfer in source or target host. Default kind is CURL.
    /// </summary>
    [JsonConverter(typeof(UpdateHostDumpTransferDetailsModelConverter))]
    public class UpdateHostDumpTransferDetails 
    {
        
        /// <value>
        /// Directory path to OCI SSL wallet location on Db server node.
        /// </value>
        [JsonProperty(PropertyName = "walletLocation")]
        public string WalletLocation { get; set; }
                ///
        /// <value>
        /// Type of dump transfer to use during migration in source or target host. Default kind is CURL.
        /// </value>
        ///
        public enum KindEnum {
            [EnumMember(Value = "CURL")]
            Curl,
            [EnumMember(Value = "OCI_CLI")]
            OciCli
        };

        
    }

    public class UpdateHostDumpTransferDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateHostDumpTransferDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateHostDumpTransferDetails);
            var discriminator = jsonObject["kind"].Value<string>();
            switch (discriminator)
            {
                case "CURL":
                    obj = new UpdateCurlTransferDetails();
                    break;
                case "OCI_CLI":
                    obj = new UpdateOciCliDumpTransferDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
