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
    /// A message about an impactful operational event.
    /// 
    /// </summary>
    public class Announcement : BaseAnnouncement
    {
        
        /// <value>
        /// A detailed explanation of the event, expressed by using Markdown language. Avoid entering
        /// confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Additional information about the event, expressed by using Markdown language and included in the
        /// details view of an announcement. Additional information might include remediation steps or
        /// answers to frequently asked questions. Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "additionalInformation")]
        public string AdditionalInformation { get; set; }
        
        /// <value>
        /// The list of resources, if any, affected by the event described in the announcement.
        /// </value>
        [JsonProperty(PropertyName = "affectedResources")]
        public System.Collections.Generic.List<AffectedResource> AffectedResources { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "Announcement";
    }
}
