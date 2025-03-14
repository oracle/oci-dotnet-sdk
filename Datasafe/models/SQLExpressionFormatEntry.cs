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
    /// The SQL Expression masking format uses a SQL expression to generate values
    /// that are used to replace the original data values. SQL expressions with 
    /// dbms_lob and other user-defined functions can be used to mask columns of 
    /// Large Object data type (LOB). To learn more, check SQL Expression in the 
    /// Data Safe documentation. 
    /// 
    /// </summary>
    public class SQLExpressionFormatEntry : FormatEntry
    {
        
        /// <value>
        /// The SQL expression to be used to generate the masked values. It can 
        /// consist of one or more values, operators, and SQL functions that 
        /// evaluate to a value. It can also contain substitution columns from 
        /// the same table. Specify the substitution columns within percent (%) 
        /// symbols. 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlExpression is required.")]
        [JsonProperty(PropertyName = "sqlExpression")]
        public string SqlExpression { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SQL_EXPRESSION";
    }
}
