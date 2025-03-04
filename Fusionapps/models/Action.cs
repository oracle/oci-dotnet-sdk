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

namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// Action details
    /// </summary>
    [JsonConverter(typeof(ActionModelConverter))]
    public class Action 
    {
        
        /// <value>
        /// Unique identifier of the object that represents the action
        /// </value>
        [JsonProperty(PropertyName = "referenceKey")]
        public string ReferenceKey { get; set; }
                ///
        /// <value>
        /// Type of action
        /// </value>
        ///
        public enum ActionTypeEnum {
            [EnumMember(Value = "QUARTERLY_UPGRADE")]
            QuarterlyUpgrade,
            [EnumMember(Value = "PATCH")]
            Patch,
            [EnumMember(Value = "VERTEX")]
            Vertex
        };

                ///
        /// <value>
        /// A string that describes whether the change is applied hot or cold
        /// </value>
        ///
        public enum StateEnum {
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// A string that describes whether the change is applied hot or cold
        /// </value>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StateEnum> State { get; set; }
        
        /// <value>
        /// A string that describes the details of the action. It does not have to be unique, and you can change it. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
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
            var discriminator = jsonObject["actionType"].Value<string>();
            switch (discriminator)
            {
                case "PATCH":
                    obj = new PatchAction();
                    break;
                case "QUARTERLY_UPGRADE":
                    obj = new UpgradeAction();
                    break;
                case "VERTEX":
                    obj = new VertexAction();
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
