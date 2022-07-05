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

namespace Oci.WafService.Models
{
    /// <summary>
    /// An object that represents action and its options.
    /// The action can be terminating, if it stops further execution of rules and modules.
    /// And non-terminating, if it does not interrupt execution flow.
    /// 
    /// </summary>
    [JsonConverter(typeof(ActionModelConverter))]
    public class Action 
    {
                ///
        /// <value>
        /// * **CHECK** is a non-terminating action that does not stop the execution of rules in current module,
        ///   just emits a log message documenting result of rule execution.
        /// <br/>
        /// * **ALLOW** is a non-terminating action which upon matching rule skips all remaining rules in the current module.
        /// <br/>
        /// * **RETURN_HTTP_RESPONSE** is a terminating action which is executed immediately, returns a defined HTTP response.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "CHECK")]
            Check,
            [EnumMember(Value = "ALLOW")]
            Allow,
            [EnumMember(Value = "RETURN_HTTP_RESPONSE")]
            ReturnHttpResponse
        };

        
        /// <value>
        /// Action name. Can be used to reference the action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }

    public class ActionModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(Action);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(Action);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "RETURN_HTTP_RESPONSE":
                    obj = new ReturnHttpResponseAction();
                    break;
                case "ALLOW":
                    obj = new AllowAction();
                    break;
                case "CHECK":
                    obj = new CheckAction();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under Action! Returning null value.");
            }
            return obj;
        }
    }
}
