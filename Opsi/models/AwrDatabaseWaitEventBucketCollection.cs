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
    /// The percentage distribution of waits in the AWR wait event buckets.
    /// </summary>
    public class AwrDatabaseWaitEventBucketCollection : AwrQueryResult
    {
        
        /// <value>
        /// The total waits of the database.
        /// </value>
        [JsonProperty(PropertyName = "totalWaits")]
        public System.Nullable<long> TotalWaits { get; set; }
        
        /// <value>
        /// A list of AWR wait event buckets.
        /// </value>
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<AwrDatabaseWaitEventBucketSummary> Items { get; set; }
        
        [JsonProperty(PropertyName = "awrResultType")]
        private readonly string awrResultType = "AWRDB_EVENT_HISTOGRAM_SET";
    }
}
