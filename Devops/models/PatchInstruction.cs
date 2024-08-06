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

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// A single instruction to be included as part of Patch request content.
    /// </summary>
    [JsonConverter(typeof(PatchInstructionModelConverter))]
    public class PatchInstruction 
    {
                ///
        ///
        public enum OperationEnum {
            [EnumMember(Value = "REQUIRE")]
            Require,
            [EnumMember(Value = "PROHIBIT")]
            Prohibit,
            [EnumMember(Value = "REPLACE")]
            Replace,
            [EnumMember(Value = "INSERT")]
            Insert,
            [EnumMember(Value = "REMOVE")]
            Remove,
            [EnumMember(Value = "MOVE")]
            Move,
            [EnumMember(Value = "MERGE")]
            Merge
        };

        
        /// <value>
        /// The set of values to which the operation applies as a [JMESPath expression](https://jmespath.org/specification.html) for evaluation against the context resource.
        /// An operation fails if the selection yields an exception, except as otherwise specified.
        /// Note that comparisons involving non-primitive values (objects or arrays) are not supported and will always evaluate to false.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Selection is required.")]
        [JsonProperty(PropertyName = "selection")]
        public string Selection { get; set; }
        
    }

    public class PatchInstructionModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(PatchInstruction);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(PatchInstruction);
            var discriminator = jsonObject["operation"].Value<string>();
            switch (discriminator)
            {
                case "MOVE":
                    obj = new PatchMoveInstruction();
                    break;
                case "REMOVE":
                    obj = new PatchRemoveInstruction();
                    break;
                case "REPLACE":
                    obj = new PatchReplaceInstruction();
                    break;
                case "INSERT":
                    obj = new PatchInsertInstruction();
                    break;
                case "REQUIRE":
                    obj = new PatchRequireInstruction();
                    break;
                case "MERGE":
                    obj = new PatchMergeInstruction();
                    break;
                case "PROHIBIT":
                    obj = new PatchProhibitInstruction();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
