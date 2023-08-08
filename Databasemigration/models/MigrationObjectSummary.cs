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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Database objects to include or exclude from migration
    /// 
    /// </summary>
    public class MigrationObjectSummary 
    {
        
        /// <value>
        /// Owner of the object (regular expression is allowed)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Owner is required.")]
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }
        
        /// <value>
        /// Name of the object (regular expression is allowed)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectName is required.")]
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
        /// <value>
        /// Type of object to exclude.
        /// If not specified, matching owners and object names of type TABLE would be excluded.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Object status.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ObjectStatus> ObjectStatus { get; set; }
        
        /// <value>
        /// Whether an excluded table should be omitted from replication. Only valid for database objects that have are of type TABLE and object status EXCLUDE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isOmitExcludedTableFromReplication")]
        public System.Nullable<bool> IsOmitExcludedTableFromReplication { get; set; }
        
    }
}
