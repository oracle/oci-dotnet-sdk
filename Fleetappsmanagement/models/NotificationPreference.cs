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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Notification information to get notified when the fleet status changes.
    /// </summary>
    public class NotificationPreference 
    {
        
        /// <value>
        /// Topic Id where the notifications will be directed.
        /// A topic is a communication channel for sending messages on chosen events to subscriptions.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TopicId is required.")]
        [JsonProperty(PropertyName = "topicId")]
        public string TopicId { get; set; }
        
        /// <value>
        /// Compartment ID the topic belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "preferences")]
        public Preferences Preferences { get; set; }
        
    }
}
