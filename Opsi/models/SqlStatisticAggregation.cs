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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// SQL Statistics
    /// </summary>
    public class SqlStatisticAggregation 
    {
        
        /// <value>
        /// Unique SQL_ID for a SQL Statement.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlIdentifier is required.")]
        [JsonProperty(PropertyName = "sqlIdentifier")]
        public string SqlIdentifier { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseDetails is required.")]
        [JsonProperty(PropertyName = "databaseDetails")]
        public DatabaseDetails DatabaseDetails { get; set; }
        
        /// <value>
        /// SQL belongs to one or more categories based on the insights.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Category is required.")]
        [JsonProperty(PropertyName = "category")]
        public System.Collections.Generic.List<string> Category { get; set; }
        
        [JsonProperty(PropertyName = "statistics")]
        public SqlStatistics Statistics { get; set; }
        
    }
}
