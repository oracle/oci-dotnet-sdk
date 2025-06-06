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
    /// The property search criteria for listing monitored resources.
    /// </summary>
    public class SearchMonitoredResourcesDetails 
    {
        
        /// <value>
        /// Compartment Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Multiple compartment identifiers [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentIds")]
        public System.Collections.Generic.List<string> CompartmentIds { get; set; }
        
        /// <value>
        /// Multiple lifecycle states filter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleStates")]
        public System.Collections.Generic.List<ResourceLifecycleState> LifecycleStates { get; set; }
        
        /// <value>
        /// Source type filter.
        /// </value>
        [JsonProperty(PropertyName = "sourceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SourceType> SourceType { get; set; }
        
        /// <value>
        /// Resource category filter.
        /// </value>
        [JsonProperty(PropertyName = "resourceCategory")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResourceCategory> ResourceCategory { get; set; }
        
        /// <value>
        /// A filter to return resources that match exact resource name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A filter to return resources that match resource name pattern given. The match is not case sensitive.
        /// </value>
        [JsonProperty(PropertyName = "nameContains")]
        public string NameContains { get; set; }
        
        /// <value>
        /// A filter to return resources that match resource type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// A filter to return resources with host name match.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// External resource is any OCI resource identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)
        /// which is not a Stack Monitoring service resource.
        /// Currently supports only following resource types - Container database, non-container database, 
        /// pluggable database and OCI compute instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }
        
        /// <value>
        /// A filter to return resources with host name pattern.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostNameContains")]
        public string HostNameContains { get; set; }
        
        /// <value>
        /// A filter to return resources with matching management agent id.
        /// </value>
        [JsonProperty(PropertyName = "managementAgentId")]
        public string ManagementAgentId { get; set; }
        
        /// <value>
        /// A filter to return resources with matching lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResourceLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// License edition of the monitored resource.
        /// </value>
        [JsonProperty(PropertyName = "license")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseType> License { get; set; }
        
        /// <value>
        /// Search for resources that were created within a specific date range,
        /// using this parameter to specify the earliest creation date for the
        /// returned list (inclusive). Specifying this parameter without the
        /// corresponding `timeCreatedLessThan` parameter will retrieve resources created from the
        /// given `timeCreatedGreaterThanOrEqualTo` to the current time, in \"YYYY-MM-ddThh:mmZ\" format with a
        /// Z offset, as defined by [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Search for resources that were created within a specific date range,
        /// using this parameter to specify the latest creation date for the returned
        /// list (exclusive). Specifying this parameter without the corresponding
        /// `timeCreatedGreaterThanOrEqualTo` parameter will retrieve all resources created before the
        /// specified end date, in \"YYYY-MM-ddThh:mmZ\" format with a Z offset, as
        /// defined by [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreatedLessThan")]
        public System.Nullable<System.DateTime> TimeCreatedLessThan { get; set; }
        
        /// <value>
        /// Search for resources that were updated within a specific date range,
        /// using this parameter to specify the earliest update date for the
        /// returned list (inclusive). Specifying this parameter without the
        /// corresponding `timeUpdatedLessThan` parameter will retrieve resources updated from the
        /// given `timeUpdatedGreaterThanOrEqualTo` to the current time, in \"YYYY-MM-ddThh:mmZ\" format with a
        /// Z offset, as defined by [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeUpdatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeUpdatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Search for resources that were updated within a specific date range,
        /// using this parameter to specify the latest creation date for the returned
        /// list (exclusive). Specifying this parameter without the corresponding
        /// `timeUpdatedGreaterThanOrEqualTo` parameter will retrieve all resources updated before the
        /// specified end date, in \"YYYY-MM-ddThh:mmZ\" format with a Z offset, as
        /// defined by [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeUpdatedLessThan")]
        public System.Nullable<System.DateTime> TimeUpdatedLessThan { get; set; }
        
        /// <value>
        /// Time zone in the form of tz database canonical zone ID. Specifies the preference with
        /// a value that uses the IANA Time Zone Database format (x-obmcs-time-zone).
        /// For example - America/Los_Angeles
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceTimeZone")]
        public string ResourceTimeZone { get; set; }
        
        /// <value>
        /// The sort order to use, either 'ASC' or 'DESC'.
        /// </value>
        [JsonProperty(PropertyName = "sortOrder")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortOrder> SortOrder { get; set; }
                ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided.
        /// Default order for timeCreated is descending. Default order for resources is ascending.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIME_CREATED")]
            TimeCreated,
            [EnumMember(Value = "RESOURCE_NAME")]
            ResourceName
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided.
        /// Default order for timeCreated is descending. Default order for resources is ascending.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sortBy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Criteria based on resource property.
        /// </value>
        [JsonProperty(PropertyName = "propertyEquals")]
        public System.Collections.Generic.Dictionary<string, string> PropertyEquals { get; set; }
        
    }
}
