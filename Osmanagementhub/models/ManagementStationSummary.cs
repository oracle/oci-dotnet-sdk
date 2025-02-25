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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides summary information for a management station.
    /// </summary>
    public class ManagementStationSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the management station.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the instance that is acting as the management station.
        /// </value>
        [JsonProperty(PropertyName = "managedInstanceId")]
        public string ManagedInstanceId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains the management station.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the registration profile used for the management station.
        /// </value>
        [JsonProperty(PropertyName = "profileId")]
        public string ProfileId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the scheduled job for the mirror sync.
        /// </value>
        [JsonProperty(PropertyName = "scheduledJobId")]
        public string ScheduledJobId { get; set; }
        
        /// <value>
        /// The date and time of the next scheduled mirror sync (in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) format).
        /// </value>
        [JsonProperty(PropertyName = "timeNextExecution")]
        public System.Nullable<System.DateTime> TimeNextExecution { get; set; }
        
        /// <value>
        /// User-friendly name for the management station.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// User-specified description of the management station.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Hostname of the management station.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hostname is required.")]
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// Current state of the mirror sync for the management station.
        /// </value>
        [JsonProperty(PropertyName = "overallState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OverallState> OverallState { get; set; }
        
        /// <value>
        /// Overall health status of the managment station.
        /// </value>
        [JsonProperty(PropertyName = "healthState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<HealthState> HealthState { get; set; }
        
        /// <value>
        /// A decimal number representing the progress of the current mirror sync.
        /// </value>
        [JsonProperty(PropertyName = "overallPercentage")]
        public System.Nullable<int> OverallPercentage { get; set; }
        
        /// <value>
        /// A decimal number representing the amount of mirror capacity used by the sync.
        /// </value>
        [JsonProperty(PropertyName = "mirrorCapacity")]
        public System.Nullable<int> MirrorCapacity { get; set; }
        
        /// <value>
        /// The current state of the management station.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ManagementStation.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The location of the instance that is acting as the management station.
        /// </value>
        [JsonProperty(PropertyName = "location")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ManagedInstanceLocation> Location { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
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
}
