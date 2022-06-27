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

namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the traffic protocol parameters for the traffic in a `PathAnalysisResult`.
    /// </summary>
    [JsonConverter(typeof(TrafficProtocolParametersModelConverter))]
    public class TrafficProtocolParameters 
    {
                ///
        /// <value>
        /// Type of the `TrafficProtocolParameters` object.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "TCP")]
            Tcp,
            [EnumMember(Value = "UDP")]
            Udp,
            [EnumMember(Value = "ICMP")]
            Icmp
        };

        
    }

    public class TrafficProtocolParametersModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TrafficProtocolParameters);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TrafficProtocolParameters);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "ICMP":
                    obj = new IcmpTrafficProtocolParameters();
                    break;
                case "UDP":
                    obj = new UdpTrafficProtocolParameters();
                    break;
                case "TCP":
                    obj = new TcpTrafficProtocolParameters();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
