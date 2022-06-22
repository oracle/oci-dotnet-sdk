/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Mapped secret used on the firewall policy rules.
    /// </summary>
    [JsonConverter(typeof(MappedSecretModelConverter))]
    public class MappedSecret 
    {
        
                ///
        /// <value>
        /// Type of the secrets mapped based on the policy.
        /// <br/>
        ///  * `SSL_INBOUND_INSPECTION`: For Inbound inspection of SSL traffic.
        ///  * `SSL_FORWARD_PROXY`: For forward proxy certificates for SSL inspection.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "SSL_INBOUND_INSPECTION")]
            SslInboundInspection,
            [EnumMember(Value = "SSL_FORWARD_PROXY")]
            SslForwardProxy
        };

        /// <value>
        /// Type of the secrets mapped based on the policy.
        /// <br/>
        ///  * `SSL_INBOUND_INSPECTION`: For Inbound inspection of SSL traffic.
        ///  * `SSL_FORWARD_PROXY`: For forward proxy certificates for SSL inspection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
    }

    public class MappedSecretModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(MappedSecret);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(MappedSecret);
            var discriminator = jsonObject["source"].Value<string>();
            switch (discriminator)
            {
                case "OCI_VAULT":
                    obj = new VaultMappedSecret();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}