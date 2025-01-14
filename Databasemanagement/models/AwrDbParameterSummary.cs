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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The summary of the AWR change history data for a single database parameter.
    /// </summary>
    public class AwrDbParameterSummary 
    {
        
        /// <value>
        /// The name of the parameter.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The database instance number.
        /// </value>
        [JsonProperty(PropertyName = "instanceNumber")]
        public System.Nullable<int> InstanceNumber { get; set; }
        
        /// <value>
        /// The parameter value when the period began.
        /// </value>
        [JsonProperty(PropertyName = "beginValue")]
        public string BeginValue { get; set; }
        
        /// <value>
        /// The parameter value when the period ended.
        /// </value>
        [JsonProperty(PropertyName = "endValue")]
        public string EndValue { get; set; }
        
        /// <value>
        /// Indicates whether the parameter value changed within the period.
        /// </value>
        [JsonProperty(PropertyName = "isChanged")]
        public System.Nullable<bool> IsChanged { get; set; }
        
        /// <value>
        /// Indicates whether the parameter has been modified after instance startup:
        ///  - MODIFIED - Parameter has been modified with ALTER SESSION
        ///  - SYSTEM_MOD - Parameter has been modified with ALTER SYSTEM (which causes all the currently logged in sessions\u2019 values to be modified)
        ///  - FALSE - Parameter has not been modified after instance startup
        /// 
        /// </value>
        [JsonProperty(PropertyName = "valueModified")]
        public string ValueModified { get; set; }
        
        /// <value>
        /// Indicates whether the parameter value in the end snapshot is the default.
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
    }
}
