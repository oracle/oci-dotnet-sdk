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

namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Details of DVP Stack.
    /// </summary>
    [JsonConverter(typeof(DvpStackDetailsModelConverter))]
    public class DvpStackDetails 
    {
                ///
        /// <value>
        /// Type of stack.
        /// </value>
        ///
        public enum DvpStackTypeEnum {
            [EnumMember(Value = "ORACLE_RM_STACK")]
            OracleRmStack
        };

        
        /// <value>
        /// Version of DVP.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DvpVersion is required.")]
        [JsonProperty(PropertyName = "dvpVersion")]
        public string DvpVersion { get; set; }
        
    }

    public class DvpStackDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DvpStackDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DvpStackDetails);
            var discriminator = jsonObject["dvpStackType"].Value<string>();
            switch (discriminator)
            {
                case "ORACLE_RM_STACK":
                    obj = new OracleRMStack();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}