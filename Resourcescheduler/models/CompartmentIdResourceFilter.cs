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


namespace Oci.ResourceschedulerService.Models
{
    /// <summary>
    /// This is a resource filter for filtering resource based on compartment OCID.
    /// </summary>
    public class CompartmentIdResourceFilter : ResourceFilter
    {
        
        /// <value>
        /// This is the compartment used for filtering.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// This sets whether to include child compartments.
        /// </value>
        [JsonProperty(PropertyName = "shouldIncludeChildCompartments")]
        public System.Nullable<bool> ShouldIncludeChildCompartments { get; set; }
        
        [JsonProperty(PropertyName = "attribute")]
        private readonly string attribute = "COMPARTMENT_ID";
    }
}
