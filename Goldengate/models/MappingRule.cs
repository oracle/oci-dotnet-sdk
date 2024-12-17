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
    /// Mapping rule for source and target schemas for the pipeline data replication.
    /// For Example: &quot;{mappingType: INCLUDE, source: HR.*, target: HR.*}&quot; for rule &quot;Include HR.*&quot; which will include all the tables under HR schema.
    /// </summary>
    public class MappingRule 
    {
        
        /// <value>
        /// Defines the exclude/include rules of source and target schemas and tables when replicating from source to target. This option applies when creating and updating a pipeline.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MappingType is required.")]
        [JsonProperty(PropertyName = "mappingType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MappingType> MappingType { get; set; }
        
        /// <value>
        /// The source schema/table combination for replication to target.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
        
        /// <value>
        /// The target schema/table combination for replication from the source.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }
        
    }
}
