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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The details of a ZeroETL pipeline.
    /// 
    /// </summary>
    public class ZeroEtlPipeline : Pipeline
    {
        
        /// <value>
        /// Mapping for source/target schema/tables for the pipeline data replication.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "mappingRules")]
        public System.Collections.Generic.List<MappingRule> MappingRules { get; set; }
        
        [JsonProperty(PropertyName = "processOptions")]
        public ProcessOptions ProcessOptions { get; set; }
        
        /// <value>
        /// When the resource was last updated. This option applies when retrieving a pipeline. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2024-07-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLastRecorded")]
        public System.Nullable<System.DateTime> TimeLastRecorded { get; set; }
        
        [JsonProperty(PropertyName = "recipeType")]
        private readonly string recipeType = "ZERO_ETL";
    }
}
