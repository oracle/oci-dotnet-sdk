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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Query Properties applicable to SQL type of collection method
    /// </summary>
    public class SqlQueryProperties : MetricExtensionQueryProperties
    {
        
        /// <value>
        /// Type of SQL data collection method i.e. either a Statement or SQL Script File
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlType is required.")]
        [JsonProperty(PropertyName = "sqlType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlQueryTypes> SqlType { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlDetails is required.")]
        [JsonProperty(PropertyName = "sqlDetails")]
        public SqlDetails SqlDetails { get; set; }
        
        /// <value>
        /// List of values and position of PL/SQL procedure IN parameters
        /// </value>
        [JsonProperty(PropertyName = "inParamDetails")]
        public System.Collections.Generic.List<SqlInParamDetails> InParamDetails { get; set; }
        
        [JsonProperty(PropertyName = "outParamDetails")]
        public SqlOutParamDetails OutParamDetails { get; set; }
        
        [JsonProperty(PropertyName = "collectionMethod")]
        private readonly string collectionMethod = "SQL";
    }
}
