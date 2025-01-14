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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Parameters to specify to resume a Migration Job.
    /// 
    /// </summary>
    public class ResumeJobDetails 
    {
        
        /// <value>
        /// Name of a migration phase. The Job will wait after executing this
        /// phase until Resume Job endpoint is called again.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "waitAfter")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OdmsJobPhases> WaitAfter { get; set; }
        
    }
}
