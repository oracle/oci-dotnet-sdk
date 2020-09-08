/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Upload is a container that can be used to optionally put all the relevant and related on-demand upload based log files.
    /// 
    /// </summary>
    public class Upload 
    {
        
        /// <value>
        /// Unique internal identifier to refer to the upload container
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Reference is required.")]
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        /// <value>
        /// The name of the upload container
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The time when this upload container is created. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The latest time when this upload container is modified. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }

        /// <value>
        /// This time represents the earliest time of the log entry in this container. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeEarliestLogEntry")]
        public System.Nullable<System.DateTime> TimeEarliestLogEntry { get; set; }

        /// <value>
        /// This time represents the latest time of the log entry in this container. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeLatestLogEntry")]
        public System.Nullable<System.DateTime> TimeLatestLogEntry { get; set; }

        /// <value>
        /// Warnings summary.
        /// </value>
        [JsonProperty(PropertyName = "warningsCount")]
        public System.Nullable<int> WarningsCount { get; set; }
    }
}
