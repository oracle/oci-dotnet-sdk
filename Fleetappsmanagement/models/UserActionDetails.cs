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

namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// User action details.
    /// This can be performed on a failed/paused task or action group.
    /// 
    /// </summary>
    [JsonConverter(typeof(UserActionDetailsModelConverter))]
    public class UserActionDetails 
    {
                ///
        /// <value>
        /// User action based On.
        /// 
        /// </value>
        ///
        public enum LevelEnum {
            [EnumMember(Value = "ACTION_GROUP")]
            ActionGroup,
            [EnumMember(Value = "STEP_NAME")]
            StepName
        };

                ///
        /// <value>
        /// Action to be Performed.
        /// 
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "RETRY")]
            Retry,
            [EnumMember(Value = "RESUME")]
            Resume
        };

        /// <value>
        /// Action to be Performed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
    }

    public class UserActionDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UserActionDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UserActionDetails);
            var discriminator = jsonObject["level"].Value<string>();
            switch (discriminator)
            {
                case "STEP_NAME":
                    obj = new StepBasedUserActionDetails();
                    break;
                case "ACTION_GROUP":
                    obj = new ActionGroupBasedUserActionDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}