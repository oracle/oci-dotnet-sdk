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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Work item to complete a work request.
    /// </summary>
    public class WorkItemSummary 
    {
        
        /// <value>
        /// The unique ID of ths work item.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the work request created this work item.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WorkRequestId is required.")]
        [JsonProperty(PropertyName = "workRequestId")]
        public string WorkRequestId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstallationSite is required.")]
        [JsonProperty(PropertyName = "installationSite")]
        public InstallationSite InstallationSite { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Details is required.")]
        [JsonProperty(PropertyName = "details")]
        public WorkItemDetails Details { get; set; }
        
        /// <value>
        /// The status of the work item.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<WorkItemStatus> Status { get; set; }
        
        /// <value>
        /// Number of times this work item is retried.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RetryCount is required.")]
        [JsonProperty(PropertyName = "retryCount")]
        public System.Nullable<int> RetryCount { get; set; }
        
        /// <value>
        /// The date and time the work item was last updated. (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLastUpdated")]
        public System.Nullable<System.DateTime> TimeLastUpdated { get; set; }
        
    }
}
