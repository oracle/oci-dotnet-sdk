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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Results of a job definition listing. Job definitions are resources that describe the scope and type of jobs (eg: harvest, profiling, sampling) that are defined by users in the system.
    /// 
    /// </summary>
    public class JobDefinitionCollection 
    {
        
        /// <value>
        /// Total number of items returned.
        /// </value>
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<int> Count { get; set; }
        
        /// <value>
        /// Collection of job definitions.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<JobDefinitionSummary> Items { get; set; }
        
    }
}
