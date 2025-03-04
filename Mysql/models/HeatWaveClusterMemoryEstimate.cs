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
    /// HeatWave cluster memory estimate
    /// that can be used to determine a suitable HeatWave cluster size. For each MySQL user table the estimated memory
    /// footprint when the table is loaded to the HeatWave cluster memory is returned.
    /// 
    /// </summary>
    public class HeatWaveClusterMemoryEstimate 
    {
        
        /// <value>
        /// The OCID of the DB System the HeatWave cluster memory estimate is associated with.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbSystemId is required.")]
        [JsonProperty(PropertyName = "dbSystemId")]
        public string DbSystemId { get; set; }
        
        /// <value>
        /// Current status of the Work Request generating the HeatWave cluster memory estimate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<HeatWaveClusterMemoryEstimateStatus> Status { get; set; }
        
        /// <value>
        /// The date and time that the Work Request to generate the HeatWave cluster memory estimate was issued, as described by [RFC 3339](https://tools.ietf.org/rfc/rfc333).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time that the HeatWave cluster memory estimate was generated, as described by [RFC 3339](https://tools.ietf.org/rfc/rfc333).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Collection of schemas with estimated memory footprints for MySQL user tables of each schema
        /// when loaded to HeatWave cluster memory.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TableSchemas is required.")]
        [JsonProperty(PropertyName = "tableSchemas")]
        public System.Collections.Generic.List<HeatWaveClusterSchemaMemoryEstimate> TableSchemas { get; set; }
        
    }
}
