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


namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details about the ActivityItem object.
    /// </summary>
    public class ActivityItem : Item
    {
        
        /// <value>
        /// Comments added with the activity on the support ticket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Comments is required.")]
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }
        
        /// <value>
        /// The time when the activity was created, in seconds since epoch time.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<int> TimeCreated { get; set; }
        
        /// <value>
        /// The time when the activity was updated, in seconds since epoch time.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<int> TimeUpdated { get; set; }
                ///
        /// <value>
        /// The type of activity occuring on the support ticket.
        /// </value>
        ///
        public enum ActivityTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NOTES")]
            Notes,
            [EnumMember(Value = "PROBLEM_DESCRIPTION")]
            ProblemDescription,
            [EnumMember(Value = "UPDATE")]
            Update,
            [EnumMember(Value = "CLOSE")]
            Close,
            [EnumMember(Value = "REOPEN")]
            Reopen
        };

        /// <value>
        /// The type of activity occuring on the support ticket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActivityType is required.")]
        [JsonProperty(PropertyName = "activityType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActivityTypeEnum> ActivityType { get; set; }
                ///
        ///
        public enum ActivityAuthorEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CUSTOMER")]
            Customer,
            [EnumMember(Value = "ORACLE")]
            Oracle
        };

        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActivityAuthor is required.")]
        [JsonProperty(PropertyName = "activityAuthor")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActivityAuthorEnum> ActivityAuthor { get; set; }
                ///
        ///
        public enum ItemTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ATTACHMENTS")]
            Attachments,
            [EnumMember(Value = "COMMENTS")]
            Comments
        };

        [JsonProperty(PropertyName = "itemType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ItemTypeEnum> ItemType { get; set; }
                ///
        /// <value>
        /// Who updates the activity on the support ticket.
        /// </value>
        ///
        public enum ItemStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROCESSING")]
            Processing,
            [EnumMember(Value = "ATTACHED")]
            Attached,
            [EnumMember(Value = "REMOVED")]
            Removed,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Who updates the activity on the support ticket.
        /// </value>
        [JsonProperty(PropertyName = "itemStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ItemStatusEnum> ItemStatus { get; set; }
        
        /// <value>
        /// attachmentID for the ItemType Attachments only for Alloy realm.
        /// </value>
        [JsonProperty(PropertyName = "attachmentID")]
        public string AttachmentID { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "activity";
    }
}
