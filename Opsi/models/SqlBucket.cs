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
    /// Sql bucket type object.
    /// </summary>
    public class SqlBucket 
    {
        
        /// <value>
        /// Version
        /// Example: 1
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public System.Nullable<float> Version { get; set; }
        
        /// <value>
        /// Ops Insights internal representation of the database type.
        /// </value>
        [JsonProperty(PropertyName = "databaseType")]
        public string DatabaseType { get; set; }
        
        /// <value>
        /// Collection timestamp
        /// Example: &quot;2020-03-31T00:00:00.000Z&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCollected is required.")]
        [JsonProperty(PropertyName = "timeCollected")]
        public System.Nullable<System.DateTime> TimeCollected { get; set; }
        
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
        
        /// <value>
        /// Plan hash value for the SQL Execution Plan
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanHash is required.")]
        [JsonProperty(PropertyName = "planHash")]
        public System.Nullable<long> PlanHash { get; set; }
        
        /// <value>
        /// SQL Bucket ID, examples <= 3 secs, 3-10 secs, 10-60 secs, 1-5 min, > 5 min
        /// Example: &quot;<= 3 secs&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketId is required.")]
        [JsonProperty(PropertyName = "bucketId")]
        public string BucketId { get; set; }
        
        /// <value>
        /// Total number of executions
        /// Example: 60
        /// </value>
        [JsonProperty(PropertyName = "executionsCount")]
        public System.Nullable<int> ExecutionsCount { get; set; }
        
        /// <value>
        /// Total CPU time
        /// Example: 1046
        /// </value>
        [JsonProperty(PropertyName = "cpuTimeInSec")]
        public System.Nullable<float> CpuTimeInSec { get; set; }
        
        /// <value>
        /// Total IO time
        /// Example: 5810
        /// </value>
        [JsonProperty(PropertyName = "ioTimeInSec")]
        public System.Nullable<float> IoTimeInSec { get; set; }
        
        /// <value>
        /// Total other wait time
        /// Example: 24061
        /// </value>
        [JsonProperty(PropertyName = "otherWaitTimeInSec")]
        public System.Nullable<float> OtherWaitTimeInSec { get; set; }
        
        /// <value>
        /// Total time
        /// Example: 30917
        /// </value>
        [JsonProperty(PropertyName = "totalTimeInSec")]
        public System.Nullable<float> TotalTimeInSec { get; set; }
        
    }
}
