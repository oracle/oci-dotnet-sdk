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

namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// A attachment for the listing revision. User can provide an external URL/upload a file
    /// </summary>
    [JsonConverter(typeof(ListingRevisionAttachmentModelConverter))]
    public class ListingRevisionAttachment 
    {
        
        /// <value>
        /// Unique OCID identifier for the listing revision attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The unique identifier for the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The unique identifier of the listing revision that the specified attachment belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListingRevisionId is required.")]
        [JsonProperty(PropertyName = "listingRevisionId")]
        public string ListingRevisionId { get; set; }
        
        /// <value>
        /// Name of the listing revision attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the listing revision attachment.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
                ///
        /// <value>
        /// Possible values for the publisher listing revision attachments. The attachment type informs the type of attachment for the listing revision.
        /// 
        /// </value>
        ///
        public enum AttachmentTypeEnum {
            [EnumMember(Value = "RELATED_DOCUMENT")]
            RelatedDocument,
            [EnumMember(Value = "SCREENSHOT")]
            Screenshot,
            [EnumMember(Value = "VIDEO")]
            Video,
            [EnumMember(Value = "REVIEW_SUPPORT_DOCUMENT")]
            ReviewSupportDocument,
            [EnumMember(Value = "CUSTOMER_SUCCESS")]
            CustomerSuccess,
            [EnumMember(Value = "SUPPORTED_SERVICES")]
            SupportedServices
        };

                ///
        /// <value>
        /// The current state of the attachment.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current state of the attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The time the attachment was created. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the attachment was updated. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }

    public class ListingRevisionAttachmentModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ListingRevisionAttachment);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ListingRevisionAttachment);
            var discriminator = jsonObject["attachmentType"].Value<string>();
            switch (discriminator)
            {
                case "RELATED_DOCUMENT":
                    obj = new RelatedDocumentAttachment();
                    break;
                case "SCREENSHOT":
                    obj = new ScreenShotAttachment();
                    break;
                case "REVIEW_SUPPORT_DOCUMENT":
                    obj = new ReviewSupportDocumentAttachment();
                    break;
                case "SUPPORTED_SERVICES":
                    obj = new SupportedServiceAttachment();
                    break;
                case "VIDEO":
                    obj = new VideoAttachment();
                    break;
                case "CUSTOMER_SUCCESS":
                    obj = new CustomerSuccessAttachment();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ListingRevisionAttachment! Returning null value.");
            }
            return obj;
        }
    }
}
