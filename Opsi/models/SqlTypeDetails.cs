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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// SQL details
    /// </summary>
    public class SqlTypeDetails : RelatedObjectTypeDetails
    {
        
        /// <value>
        /// SQL identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlId is required.")]
        [JsonProperty(PropertyName = "sqlId")]
        public string SqlId { get; set; }
        
        /// <value>
        /// First 3800 characters of the SQL text
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlText is required.")]
        [JsonProperty(PropertyName = "sqlText")]
        public string SqlText { get; set; }
        
        /// <value>
        /// SQL identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsSqlTextTruncated is required.")]
        [JsonProperty(PropertyName = "isSqlTextTruncated")]
        public System.Nullable<bool> IsSqlTextTruncated { get; set; }
        
        /// <value>
        /// SQL command name (such as SELECT, INSERT)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlCommand is required.")]
        [JsonProperty(PropertyName = "sqlCommand")]
        public string SqlCommand { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SQL";
    }
}
