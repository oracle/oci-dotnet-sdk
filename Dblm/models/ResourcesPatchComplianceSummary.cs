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


namespace Oci.DblmService.Models
{
    /// <summary>
    /// Summary of resources and their patch compliance.
    /// </summary>
    public class ResourcesPatchComplianceSummary 
    {
        
        /// <value>
        /// Total number of resources.
        /// </value>
        [JsonProperty(PropertyName = "totalResourcesCount")]
        public System.Nullable<int> TotalResourcesCount { get; set; }
        
        /// <value>
        /// Total number of resources that are up to date.
        /// </value>
        [JsonProperty(PropertyName = "upToDateResourcesCount")]
        public System.Nullable<int> UpToDateResourcesCount { get; set; }
        
        /// <value>
        /// Total number of  non-compliant resources.
        /// </value>
        [JsonProperty(PropertyName = "nonCompliantResourcesCount")]
        public System.Nullable<int> NonCompliantResourcesCount { get; set; }
        
        /// <value>
        /// Total number of resources that are not subscribed.
        /// </value>
        [JsonProperty(PropertyName = "notSubscribedResourcesCount")]
        public System.Nullable<int> NotSubscribedResourcesCount { get; set; }
        
        /// <value>
        /// Total number of resources that are not registered to DBLM.
        /// </value>
        [JsonProperty(PropertyName = "notDblmRegisteredResourcesCount")]
        public System.Nullable<int> NotDblmRegisteredResourcesCount { get; set; }
        
    }
}
