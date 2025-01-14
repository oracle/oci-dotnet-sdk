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

namespace Oci.VnmonitoringService.Models
{
    
    [JsonConverter(typeof(DrgAttachmentNetworkDetailsModelConverter))]
    public class DrgAttachmentNetworkDetails 
    {
                ///
        ///
        public enum TypeEnum {
            [EnumMember(Value = "VCN")]
            Vcn,
            [EnumMember(Value = "IPSEC_TUNNEL")]
            IpsecTunnel,
            [EnumMember(Value = "VIRTUAL_CIRCUIT")]
            VirtualCircuit,
            [EnumMember(Value = "REMOTE_PEERING_CONNECTION")]
            RemotePeeringConnection
        };

        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the network attached to the DRG.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
    }

    public class DrgAttachmentNetworkDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DrgAttachmentNetworkDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DrgAttachmentNetworkDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "VCN":
                    obj = new VcnDrgAttachmentNetworkDetails();
                    break;
                case "LOOPBACK":
                    obj = new LoopBackDrgAttachmentNetworkDetails();
                    break;
                case "IPSEC_TUNNEL":
                    obj = new IpsecTunnelDrgAttachmentNetworkDetails();
                    break;
                case "VIRTUAL_CIRCUIT":
                    obj = new VirtualCircuitDrgAttachmentNetworkDetails();
                    break;
                case "REMOTE_PEERING_CONNECTION":
                    obj = new RemotePeeringConnectionDrgAttachmentNetworkDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
