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

namespace Oci.OdaService.Models
{
    /// <summary>
    /// Properties of a Channel.
    /// </summary>
    [JsonConverter(typeof(ChannelModelConverter))]
    public class Channel 
    {
        
        /// <value>
        /// Unique immutable identifier that was assigned when the Channel was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The Channel's name. The name can contain only letters, numbers, periods, and underscores. The name must begin with a letter.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A short description of the Channel.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The category of the Channel.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Category is required.")]
        [JsonProperty(PropertyName = "category")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ChannelCategory> Category { get; set; }
        
        
        /// <value>
        /// The number of milliseconds before a session expires.
        /// </value>
        [JsonProperty(PropertyName = "sessionExpiryDurationInMilliseconds")]
        public System.Nullable<long> SessionExpiryDurationInMilliseconds { get; set; }
        
        /// <value>
        /// The Channel's current state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// When the resource was created. A date-time string as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// When the resource was last updated. A date-time string as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }

    public class ChannelModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(Channel);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(Channel);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "APPEVENT":
                    obj = new AppEventChannel();
                    break;
                case "FACEBOOK":
                    obj = new FacebookChannel();
                    break;
                case "WEB":
                    obj = new WebChannel();
                    break;
                case "MSTEAMS":
                    obj = new MSTeamsChannel();
                    break;
                case "TWILIO":
                    obj = new TwilioChannel();
                    break;
                case "OSVC":
                    obj = new OsvcChannel();
                    break;
                case "ANDROID":
                    obj = new AndroidChannel();
                    break;
                case "OSS":
                    obj = new OSSChannel();
                    break;
                case "WEBHOOK":
                    obj = new WebhookChannel();
                    break;
                case "APPLICATION":
                    obj = new ApplicationChannel();
                    break;
                case "SLACK":
                    obj = new SlackChannel();
                    break;
                case "CORTANA":
                    obj = new CortanaChannel();
                    break;
                case "SERVICECLOUD":
                    obj = new ServiceCloudChannel();
                    break;
                case "IOS":
                    obj = new IosChannel();
                    break;
                case "TEST":
                    obj = new TestChannel();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under Channel! Returning null value.");
            }
            return obj;
        }
    }
}
