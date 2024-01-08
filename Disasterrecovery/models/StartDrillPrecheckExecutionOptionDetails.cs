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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// Options for start drill precheck execution.
    /// </summary>
    public class StartDrillPrecheckExecutionOptionDetails : DrPlanExecutionOptionDetails
    {
        
        /// <value>
        /// A flag indicating whether warnings should be ignored during the precheck.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "areWarningsIgnored")]
        public System.Nullable<bool> AreWarningsIgnored { get; set; }
        
        [JsonProperty(PropertyName = "planExecutionType")]
        private readonly string planExecutionType = "START_DRILL_PRECHECK";
    }
}
