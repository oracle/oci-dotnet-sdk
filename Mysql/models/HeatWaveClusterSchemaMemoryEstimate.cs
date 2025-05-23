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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Schema with estimated memory footprints for each MySQL user table
    /// of the schema when loaded to HeatWave cluster memory.
    /// 
    /// </summary>
    public class HeatWaveClusterSchemaMemoryEstimate 
    {
        
        /// <value>
        /// The name of the schema.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SchemaName is required.")]
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }
        
        /// <value>
        /// Estimated memory footprints for MySQL user tables of the schema
        /// when loaded to HeatWave cluster memory.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PerTableEstimates is required.")]
        [JsonProperty(PropertyName = "perTableEstimates")]
        public System.Collections.Generic.List<HeatWaveClusterTableMemoryEstimate> PerTableEstimates { get; set; }
        
    }
}
