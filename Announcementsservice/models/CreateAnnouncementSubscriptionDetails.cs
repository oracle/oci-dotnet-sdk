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


namespace Oci.AnnouncementsService.Models
{
    /// <summary>
    /// The details for creating a new announcement subscription.
    /// </summary>
    public class CreateAnnouncementSubscriptionDetails 
    {
        
        /// <value>
        /// A user-friendly name for the announcement subscription. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A description of the announcement subscription. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment where you want to create the announcement subscription.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the Notifications service topic that is the target for publishing announcements that match the configured announcement subscription. The caller of the operation needs the ONS_TOPIC_PUBLISH permission for the targeted Notifications service topic. For more information about Notifications permissions, see [Details for Notifications](https://docs.cloud.oracle.com/Content/Identity/policyreference/notificationpolicyreference.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OnsTopicId is required.")]
        [JsonProperty(PropertyName = "onsTopicId")]
        public string OnsTopicId { get; set; }
        
        /// <value>
        /// A list of filter groups for the announcement subscription. A filter group combines one or more filters that the Announcements service applies to announcements for matching purposes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "filterGroups")]
        public System.Collections.Generic.Dictionary<string, FilterGroupDetails> FilterGroups { get; set; }
        
        /// <value>
        /// (For announcement subscriptions with SaaS configured as the platform type or Oracle Fusion Applications as the service, or both, only) The language in which the user prefers to receive emailed announcements. Specify the preference with a value that uses the x-obmcs-human-language format. For example fr-FR.
        /// </value>
        [JsonProperty(PropertyName = "preferredLanguage")]
        public string PreferredLanguage { get; set; }
        
        /// <value>
        /// The time zone in which the user prefers to receive announcements. Specify the preference with a value that uses the IANA Time Zone Database format (x-obmcs-time-zone). For example - America/Los_Angeles
        /// </value>
        [JsonProperty(PropertyName = "preferredTimeZone")]
        public string PreferredTimeZone { get; set; }
        
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
        
    }
}
