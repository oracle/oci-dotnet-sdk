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

namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// Target of the access policy. This can either be the source or the destination of the traffic.
    /// </summary>
    [JsonConverter(typeof(AccessPolicyTargetDetailsModelConverter))]
    public class AccessPolicyTargetDetails 
    {
                ///
        /// <value>
        /// Traffic type of the target.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "ALL_VIRTUAL_SERVICES")]
            AllVirtualServices,
            [EnumMember(Value = "VIRTUAL_SERVICE")]
            VirtualService,
            [EnumMember(Value = "EXTERNAL_SERVICE")]
            ExternalService,
            [EnumMember(Value = "INGRESS_GATEWAY")]
            IngressGateway
        };

        
    }

    public class AccessPolicyTargetDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AccessPolicyTargetDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AccessPolicyTargetDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "EXTERNAL_SERVICE":
                    obj = new ExternalServiceAccessPolicyTargetDetails();
                    break;
                case "VIRTUAL_SERVICE":
                    obj = new VirtualServiceAccessPolicyTargetDetails();
                    break;
                case "ALL_VIRTUAL_SERVICES":
                    obj = new AllVirtualServicesAccessPolicyTargetDetails();
                    break;
                case "INGRESS_GATEWAY":
                    obj = new IngressGatewayAccessPolicyTargetDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
