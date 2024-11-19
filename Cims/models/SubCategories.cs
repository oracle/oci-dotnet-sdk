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


namespace Oci.CimsService.Models
{
    /// <summary>
    /// List of subcategories under a service.
    /// </summary>
    public class SubCategories 
    {
        
        /// <value>
        /// Subcategory list.
        /// </value>
        [JsonProperty(PropertyName = "serviceCategory")]
        public System.Collections.Generic.Dictionary<string, string> ServiceCategory { get; set; }
        
        /// <value>
        /// Schema of a subcategory.
        /// </value>
        [JsonProperty(PropertyName = "schema")]
        public string Schema { get; set; }
        
        /// <value>
        /// Flag to identify if subComponent is present
        /// </value>
        [JsonProperty(PropertyName = "hasSubCategory")]
        public string HasSubCategory { get; set; }
        
        /// <value>
        /// The sub component list for MOS Taxonomy.
        /// </value>
        [JsonProperty(PropertyName = "subCategories")]
        public System.Collections.Generic.List<SubComponents> SubCategoriesProp { get; set; }
        
    }
}
