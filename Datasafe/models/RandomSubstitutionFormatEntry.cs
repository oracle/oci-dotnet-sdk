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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The Random Substitution masking format uses the specified substitution column 
    /// as the source of masked values. The values in the substitution column are randomly 
    /// ordered before mapping them to the original column values. As a masking operation 
    /// renames tables temporarily, the substitution column must be in a table that has 
    /// no masking column. Also, you may want to ensure that the substitution column has 
    /// sufficient values to uniquely mask the target column.
    /// <br/>
    /// Unlike Deterministic Substitution, Random Substitution doesn't do deterministic 
    /// masking, and thus, doesn't require a seed value. To learn more, check Random 
    /// Substitution in the Data Safe documentation. 
    /// 
    /// </summary>
    public class RandomSubstitutionFormatEntry : FormatEntry
    {
        
        /// <value>
        /// The name of the schema that contains the substitution column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SchemaName is required.")]
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }
        
        /// <value>
        /// The name of the table that contains the substitution column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TableName is required.")]
        [JsonProperty(PropertyName = "tableName")]
        public string TableName { get; set; }
        
        /// <value>
        /// The name of the substitution column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ColumnName is required.")]
        [JsonProperty(PropertyName = "columnName")]
        public string ColumnName { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "RANDOM_SUBSTITUTION";
    }
}
