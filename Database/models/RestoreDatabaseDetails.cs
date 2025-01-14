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


namespace Oci.DatabaseService.Models
{
    
    public class RestoreDatabaseDetails 
    {
        
        /// <value>
        /// Restores using the backup with the System Change Number (SCN) specified.
        /// This field is applicable for both use cases - Restoring Container Database or Restoring specific Pluggable Database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseSCN")]
        public string DatabaseSCN { get; set; }
        
        /// <value>
        /// Restores to the timestamp specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// Restores to the last known good state with the least possible data loss.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "latest")]
        public System.Nullable<bool> Latest { get; set; }
        
        /// <value>
        /// Restores only the Pluggable Database (if specified) using the inputs provided in request.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "pluggableDatabaseName")]
        public string PluggableDatabaseName { get; set; }
        
    }
}
