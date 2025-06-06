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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Specifies the properties for updating maintenance due date.
    /// 
    /// </summary>
    public class UpdateInstanceMaintenanceEventDetails 
    {
        
        /// <value>
        /// The beginning of the time window when Maintenance is scheduled to begin. The Maintenance will not begin before
        /// this time.
        /// <br/>
        /// The timeWindowEnd is automatically calculated based on the maintenanceReason and the instanceAction.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeWindowStart")]
        public System.Nullable<System.DateTime> TimeWindowStart { get; set; }
        
        /// <value>
        /// One of the alternativeResolutionActions that was provided in the InstanceMaintenanceEvent.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "alternativeResolutionAction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InstanceMaintenanceAlternativeResolutionActions> AlternativeResolutionAction { get; set; }
        
        /// <value>
        /// This field is only applicable when setting the alternativeResolutionAction.
        /// <br/>
        /// For Instances that have local storage, this must be set to true to verify that the local storage
        /// will be deleted during the migration. For instances without, this parameter has no effect.
        /// <br/>
        /// In cases where the local storage will be lost, this parameter must be set or the request will fail.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "canDeleteLocalStorage")]
        public System.Nullable<bool> CanDeleteLocalStorage { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
    }
}
