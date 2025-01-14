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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summarizes change history for specific database parameter
    /// </summary>
    public class AddmDbParameterAggregation 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Database insight.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Name of  parameter
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Number of database instance
        /// </value>
        [JsonProperty(PropertyName = "instNum")]
        public System.Nullable<int> InstNum { get; set; }
        
        /// <value>
        /// Parameter default value
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }
        
        /// <value>
        /// Parameter value when time period began
        /// </value>
        [JsonProperty(PropertyName = "beginValue")]
        public string BeginValue { get; set; }
        
        /// <value>
        /// Parameter value when time period ended
        /// </value>
        [JsonProperty(PropertyName = "endValue")]
        public string EndValue { get; set; }
        
        /// <value>
        /// Indicates whether the parameter's value changed during the selected time range (TRUE) or
        /// did not change during the selected time range (FALSE)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsChanged is required.")]
        [JsonProperty(PropertyName = "isChanged")]
        public System.Nullable<bool> IsChanged { get; set; }
        
        /// <value>
        /// Indicates whether the parameter's end value was set to the default value (TRUE) or was
        /// specified in the parameter file (FALSE)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
        /// <value>
        /// Indicates whether the parameter has been modified after instance starup
        /// MODIFIED - Parameter has been modified with ALTER SESSION
        /// SYSTEM_MOD - Parameter has been modified with ALTER SYSTEM
        /// FALSE - Parameter has not been modified after instance starup
        /// 
        /// </value>
        [JsonProperty(PropertyName = "valueModified")]
        public string ValueModified { get; set; }
        
        /// <value>
        /// Indicates whether the parameter is a high impact parameter (TRUE) or not (FALSE)          
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHighImpact")]
        public System.Nullable<bool> IsHighImpact { get; set; }
        
    }
}
