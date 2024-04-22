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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Details about the scheduled resources for which query needs to be run.
    /// </summary>
    public class ScheduledQueryScopeDetail 
    {
        
        /// <value>
        /// region on which scheduled query needs to be run
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// List of OCIDs on scheduled query needs to run
        /// </value>
        [JsonProperty(PropertyName = "resourceIds")]
        public System.Collections.Generic.List<string> ResourceIds { get; set; }
        
        /// <value>
        /// Type of resource
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
    }
}
