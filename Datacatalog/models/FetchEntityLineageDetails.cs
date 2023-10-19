/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// The information needed to obtain desired lineage.
    /// </summary>
    public class FetchEntityLineageDetails 
    {
        
        /// <value>
        /// Object level at which the lineage is returned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "level")]
        public System.Nullable<int> Level { get; set; }
        
        /// <value>
        /// Direction of the lineage returned.
        /// </value>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LineageDirection> Direction { get; set; }
        
        /// <value>
        /// Intra-lineages are drill down lineages. This field indicates whether all intra-lineages need to be
        /// expanded inline in the lineage returned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isIntraLineage")]
        public System.Nullable<bool> IsIntraLineage { get; set; }
        
        /// <value>
        /// Unique object key for which intra-lineage needs to be fetched. Only drill-down lineage corresponding
        /// to the object whose object key is passed is returned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "intraLineageObjectKey")]
        public string IntraLineageObjectKey { get; set; }
        
    }
}