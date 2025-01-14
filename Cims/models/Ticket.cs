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
    /// Details about the ticket created.
    /// </summary>
    public class Ticket 
    {
        
        /// <value>
        /// Unique identifier for the ticket.
        /// </value>
        [JsonProperty(PropertyName = "ticketNumber")]
        public string TicketNumber { get; set; }
                ///
        /// <value>
        /// The severity assigned to the ticket.
        /// </value>
        ///
        public enum SeverityEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HIGHEST")]
            Highest,
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "MEDIUM")]
            Medium,
            [EnumMember(Value = "LOW")]
            Low
        };

        /// <value>
        /// The severity assigned to the ticket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Severity is required.")]
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SeverityEnum> Severity { get; set; }
        
        /// <value>
        /// The list of resources associated with the ticket.
        /// </value>
        [JsonProperty(PropertyName = "resourceList")]
        public System.Collections.Generic.List<Resource> ResourceList { get; set; }
        
        /// <value>
        /// The title of the ticket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Title is required.")]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        
        /// <value>
        /// The description of the issue addressed in the ticket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The time when the ticket was created, in seconds since epoch time.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<int> TimeCreated { get; set; }
        
        /// <value>
        /// The time when the ticket was updated, in seconds since epoch time.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<int> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the ticket.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Additional information about the current `lifecycleState`.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleDetails> LifecycleDetails { get; set; }
        
    }
}
