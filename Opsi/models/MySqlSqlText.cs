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
    /// MySql SQL Text type object.
    /// </summary>
    public class MySqlSqlText 
    {
        
        /// <value>
        /// Name of Database Schema.
        /// Example: &quot;performance_schema&quot;
        /// </value>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }
        
        /// <value>
        /// digest
        /// Example: &quot;323k3k99ua09a90adf&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Digest is required.")]
        [JsonProperty(PropertyName = "digest")]
        public string Digest { get; set; }
        
        /// <value>
        /// Collection timestamp.
        /// Example: &quot;2020-05-06T00:00:00.000Z&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCollected is required.")]
        [JsonProperty(PropertyName = "timeCollected")]
        public System.Nullable<System.DateTime> TimeCollected { get; set; }
        
        /// <value>
        /// SQL event name
        /// Example: &quot;SELECT&quot;
        /// </value>
        [JsonProperty(PropertyName = "commandType")]
        public string CommandType { get; set; }
        
        /// <value>
        /// The normalized statement string.
        /// Example: &quot;SELECT username,profile,default_tablespace,temporary_tablespace FROM dba_users&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DigestText is required.")]
        [JsonProperty(PropertyName = "digestText")]
        public string DigestText { get; set; }
        
    }
}
