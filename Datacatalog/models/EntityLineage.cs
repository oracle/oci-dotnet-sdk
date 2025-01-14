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
    /// Lineage for a data entity.
    /// </summary>
    public class EntityLineage 
    {
        
        /// <value>
        /// Object level at which the lineage is returned.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Level is required.")]
        [JsonProperty(PropertyName = "level")]
        public System.Nullable<int> Level { get; set; }
        
        /// <value>
        /// Direction of the lineage returned.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Direction is required.")]
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LineageDirection> Direction { get; set; }
        
        /// <value>
        /// Set of objects that are involved in the lineage.
        /// </value>
        [JsonProperty(PropertyName = "objects")]
        public System.Collections.Generic.List<LineageObject> Objects { get; set; }
        
        /// <value>
        /// Set of relationships between the objects in the 'objects' set.
        /// </value>
        [JsonProperty(PropertyName = "relationships")]
        public System.Collections.Generic.List<LineageRelationship> Relationships { get; set; }
        
        /// <value>
        /// A map of maps that contains additional information in explanation of the lineage returned. The map keys are
        /// categories of information and the values are maps of annotation names to their corresponding values.
        /// Every annotation is contained inside a category.
        /// Example: {&quot;annotations&quot;: { &quot;category&quot;: { &quot;key&quot;: &quot;value&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "annotations")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Annotations { get; set; }
        
    }
}
