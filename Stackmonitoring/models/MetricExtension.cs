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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Detailed information of the Metric Extension resource
    /// </summary>
    public class MetricExtension 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of Metric Extension resource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Metric Extension resource name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Metric Extension resource display name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the metric extension.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Resource type to which Metric Extension applies
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Tenant Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenantId is required.")]
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }
        
        /// <value>
        /// Collection Method  Metric Extension applies
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CollectionMethod is required.")]
        [JsonProperty(PropertyName = "collectionMethod")]
        public string CollectionMethod { get; set; }
        
        /// <value>
        /// The current status of the metric extension i.e. whether it is Draft or Published
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MetricExtensionLifeCycleDetails> Status { get; set; }
        
        /// <value>
        /// The current lifecycle state of the metric extension
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MetricExtensionLifeCycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Created by user
        /// </value>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// Last updated by user
        /// </value>
        [JsonProperty(PropertyName = "lastUpdatedBy")]
        public string LastUpdatedBy { get; set; }
        
        /// <value>
        /// Metric Extension creation time. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Metric Extension update time. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Schedule of metric extension should use RFC 5545 format -> recur-rule-part = \"FREQ\";\"INTERVAL\" where FREQ rule part identifies the type of recurrence rule. Valid values are \"MINUTELY\",\"HOURLY\",\"DAILY\" to specify repeating events based on an interval of a minute, an hour and a day or more. Example- FREQ=DAILY;INTERVAL=1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CollectionRecurrences is required.")]
        [JsonProperty(PropertyName = "collectionRecurrences")]
        public string CollectionRecurrences { get; set; }
        
        /// <value>
        /// List of metrics which are part of this metric extension
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricList is required.")]
        [JsonProperty(PropertyName = "metricList")]
        public System.Collections.Generic.List<Metric> MetricList { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "QueryProperties is required.")]
        [JsonProperty(PropertyName = "queryProperties")]
        public MetricExtensionQueryProperties QueryProperties { get; set; }
        
        /// <value>
        /// List of resource details objects having resourceIds on which this metric extension is enabled.
        /// </value>
        [JsonProperty(PropertyName = "enabledOnResources")]
        public System.Collections.Generic.List<EnabledResourceDetails> EnabledOnResources { get; set; }
        
        /// <value>
        /// Count of resources on which this metric extension is enabled.
        /// </value>
        [JsonProperty(PropertyName = "enabledOnResourcesCount")]
        public System.Nullable<int> EnabledOnResourcesCount { get; set; }
        
        /// <value>
        /// The URI path that the user can do a GET on to access the metric extension metadata
        /// </value>
        [JsonProperty(PropertyName = "resourceUri")]
        public string ResourceUri { get; set; }
        
    }
}
